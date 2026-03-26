



using HERP.Document.BusinessObjects;
using HERP.Document.Contracts;

namespace HERP.Document.Services.Translation;

public class BatchTranslationService
{
    private readonly ITranslationGateway translationGateway;
    private readonly PromptGenerationService promptGenerationService;

    public BatchTranslationService(ITranslationGateway? translationGateway = null, PromptGenerationService? promptGenerationService = null)
    {
        this.translationGateway = translationGateway ?? new DefaultTranslationGateway();
        this.promptGenerationService = promptGenerationService ?? new PromptGenerationService();
    }

    public ElementBatch CreateBatch(Video video, Language targetLanguage, IEnumerable<Element> audios)
    {
        ArgumentNullException.ThrowIfNull(video);
        ArgumentNullException.ThrowIfNull(targetLanguage);

        var batch = new ElementBatch
        {
            CompanyId = video.CompanyId,
            BranchId = video.BranchId,
            Video = video,
            VideoId = video.ID,
            TargetLanguage = targetLanguage,
            TargetLanguageId = targetLanguage.ID,
            DocumentNo = $"BATCH-{DateTime.UtcNow:yyyyMMddHHmmss}",
            Name = $"Batch {targetLanguage.Name}",
            Code = $"BATCH-{Guid.NewGuid():N}"
        };

        foreach (var audio in audios.OrderBy(audio => audio.Sequence))
        {
            batch.Elements.Add(audio);
        }

        video.Batches.Add(batch);
        return batch;
    }

    public async Task<BatchTranslate> PrepareTranslationAsync(ElementBatch batch, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(batch);

        var prompt = promptGenerationService.BuildBatchPrompt(batch, batch.Elements);
        var results = await translationGateway.TranslateAsync(prompt, batch.TargetLanguage!, cancellationToken);

        var translation = new BatchTranslate
        {
            CompanyId = batch.CompanyId,
            BranchId = batch.BranchId,
            ElementBatch = batch,
            ElementBatchId = batch.ID,
            TargetLanguage = batch.TargetLanguage,
            TargetLanguageId = batch.TargetLanguageId,
            PromptPayload = prompt,
            ResultPayload = string.Join(Environment.NewLine, results),
            Name = $"Translation {batch.TargetLanguage?.Name}",
            Code = $"BATCHTRANS-{Guid.NewGuid():N}"
        };

        batch.Translations.Add(translation);
        return translation;
    }

    public void ApplyTranslation(BatchTranslate translation)
    {
        ArgumentNullException.ThrowIfNull(translation);

        if (translation.ElementBatch is null || string.IsNullOrWhiteSpace(translation.ResultPayload))
        {
            return;
        }

        var lines = translation.ResultPayload.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        foreach (var pair in translation.ElementBatch.Elements.OrderBy(audio => audio.Sequence).Zip(lines, (audio, line) => (audio, line)))
        {
            pair.audio.TranslatedText = pair.line;
        }

        translation.AppliedOnUtc = DateTime.UtcNow;
    }

    private sealed class DefaultTranslationGateway : ITranslationGateway
    {
        public Task<IReadOnlyList<string>> TranslateAsync(string prompt, Language targetLanguage, CancellationToken cancellationToken = default)
        {
            IReadOnlyList<string> results = prompt
                .Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                .Where(line => line.StartsWith("[", StringComparison.Ordinal))
                .Select(line => $"[{targetLanguage.Code}] {line[(line.IndexOf(']') + 1)..].Trim()}")
                .ToArray();

            return Task.FromResult(results);
        }
    }
}

