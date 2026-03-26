


using HERP.Document.BusinessObjects;
using HERP.Document.Contracts;
using HERP.Document.Services.Support;

namespace HERP.Document.Services.Integration;

public class TranslateObjectService
{
    private readonly IHtmlContentMapper htmlContentMapper;

    public TranslateObjectService(IHtmlContentMapper? htmlContentMapper = null)
    {
        this.htmlContentMapper = htmlContentMapper ?? new SimpleHtmlContentMapper();
    }

    public IReadOnlyList<Element> ImportHtml(TranslateObject translateObject, Video video)
    {
        ArgumentNullException.ThrowIfNull(translateObject);
        ArgumentNullException.ThrowIfNull(video);

        var blocks = htmlContentMapper.ExtractBlocks(translateObject.SourceHtml ?? string.Empty);
        var audios = new List<Element>();
        var sequence = video.Elements.Count;

        foreach (var block in blocks)
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
                SourceText = block,
                Name = $"Element {sequence}",
                Code = $"ELEMENT-{Guid.NewGuid():N}"
            };

            video.Elements.Add(audio);
            audios.Add(audio);
        }

        return audios;
    }

    public string ExportHtml(TranslateObject translateObject, Video video)
    {
        ArgumentNullException.ThrowIfNull(translateObject);
        ArgumentNullException.ThrowIfNull(video);

        var html = htmlContentMapper.BuildHtml(video);
        translateObject.ExportedHtml = html;
        return html;
    }
}

