


using HERP.Document.BusinessObjects;
using HERP.Document.Contracts;

namespace HERP.Document.Services.Import;

public class DocumentImportService
{
    private readonly IDocumentImportParser parser;

    public DocumentImportService(IDocumentImportParser? parser = null)
    {
        this.parser = parser ?? new DefaultDocumentImportParser();
    }

    public async Task<IReadOnlyList<Element>> ImportAsync(Video video, BookMark bookMark, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(video);
        ArgumentNullException.ThrowIfNull(bookMark);

        var blocks = await parser.ParseAsync(bookMark, cancellationToken);
        var audios = new List<Element>();
        var sequence = video.Elements.Count;

        foreach (var block in blocks.Where(block => !string.IsNullOrWhiteSpace(block)))
        {
            sequence++;
            var audio = new Element
            {
                CompanyId = video.CompanyId,
                BranchId = video.BranchId,
                Video = video,
                VideoId = video.ID,
                Language = video.SourceLanguage,
                LanguageId = video.SourceLanguageId,
                Sequence = sequence,
                SourceText = block.Trim(),
                Name = $"Element {sequence}",
                Code = $"ELEMENT-{Guid.NewGuid():N}"
            };

            video.Elements.Add(audio);
            audios.Add(audio);
        }

        bookMark.IsImported = true;
        bookMark.ImportedOnUtc = DateTime.UtcNow;
        return audios;
    }

    private sealed class DefaultDocumentImportParser : IDocumentImportParser
    {
        public Task<IReadOnlyList<string>> ParseAsync(BookMark bookMark, CancellationToken cancellationToken = default)
        {
            var source = string.IsNullOrWhiteSpace(bookMark.FilePath) ? bookMark.SourceUrl : bookMark.FilePath;
            IReadOnlyList<string> blocks = string.IsNullOrWhiteSpace(source)
                ? Array.Empty<string>()
                : source.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            return Task.FromResult(blocks);
        }
    }
}

