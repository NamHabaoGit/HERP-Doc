
using HERP.Document.BusinessObjects;
using HERP.Document.Contracts;
using HERP.Document.Services.Support;

namespace HERP.Document.Services.Export;

public class LayoutExportService
{
    private readonly IHtmlContentMapper htmlContentMapper;

    public LayoutExportService(IHtmlContentMapper? htmlContentMapper = null)
    {
        this.htmlContentMapper = htmlContentMapper ?? new SimpleHtmlContentMapper();
    }

    public string Export(Video video)
    {
        ArgumentNullException.ThrowIfNull(video);
        return htmlContentMapper.BuildHtml(video);
    }
}

