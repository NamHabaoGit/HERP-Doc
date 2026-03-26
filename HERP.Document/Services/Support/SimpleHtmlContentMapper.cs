
using HERP.Document.BusinessObjects;
using HERP.Document.Contracts;
using System.Text;

namespace HERP.Document.Services.Support;

internal sealed class SimpleHtmlContentMapper : IHtmlContentMapper
{
    public IReadOnlyList<string> ExtractBlocks(string html)
    {
        return html.Split(new[] { "</p>", "<br/>", "<br>" }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
    }

    public string BuildHtml(Video video)
    {
        var builder = new StringBuilder();
        builder.AppendLine($"<article data-document-no=\"{video.DocumentNo}\">");

        foreach (var paragraph in video.Paragraphs.OrderBy(paragraph => paragraph.Sequence))
        {
            builder.Append("  <p>");
            builder.Append(string.Join(' ', paragraph.Elements.OrderBy(audio => audio.Sequence).Select(audio => audio.TranslatedText ?? audio.SourceText)));
            builder.AppendLine("</p>");
        }

        if (video.Paragraphs.Count == 0)
        {
            foreach (var audio in video.Elements.OrderBy(audio => audio.Sequence))
            {
                builder.AppendLine($"  <p>{audio.TranslatedText ?? audio.SourceText}</p>");
            }
        }

        builder.Append("</article>");
        return builder.ToString();
    }
}

