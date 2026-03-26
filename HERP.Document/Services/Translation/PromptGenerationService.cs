

using HERP.Document.BusinessObjects;
using System.Text;

namespace HERP.Document.Services.Translation;

public class PromptGenerationService
{
    public string BuildBatchPrompt(ElementBatch batch, IEnumerable<Element> audios)
    {
        ArgumentNullException.ThrowIfNull(batch);
        ArgumentNullException.ThrowIfNull(audios);

        var builder = new StringBuilder();
        builder.AppendLine($"Translate the following content to {batch.TargetLanguage?.Name ?? "the target language"}.");

        foreach (var audio in audios.OrderBy(audio => audio.Sequence))
        {
            builder.AppendLine($"[{audio.Sequence}] {audio.SourceText}");
        }

        return builder.ToString().Trim();
    }
}

