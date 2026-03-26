

using HERP.Document.BusinessObjects;
using HERP.Document.Validation;
using System.Linq;

namespace HERP.Document.Services.Workflow;

public class ElementEditingService
{
    public Element Split(Element source, int splitIndex)
    {
        ArgumentNullException.ThrowIfNull(source);
        DocumentValidationMessages.EnsureStartIndex("Element", splitIndex);
        DocumentValidationMessages.EnsureText("Element", source.SourceText);

        if (splitIndex >= source.SourceText!.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(splitIndex));
        }

        var tail = source.SourceText[splitIndex..].Trim();
        source.SourceText = source.SourceText[..splitIndex].Trim();

        return new Element
        {
            CompanyId = source.CompanyId,
            BranchId = source.BranchId,
            Video = source.Video,
            VideoId = source.VideoId,
            Paragraph = source.Paragraph,
            ParagraphId = source.ParagraphId,
            Language = source.Language,
            LanguageId = source.LanguageId,
            Sequence = source.Sequence + 1,
            SourceText = tail,
            Name = $"{source.Name} (Part 2)",
            Code = $"ELEMENT-{Guid.NewGuid():N}"
        };
    }

    public void Normalize(Element audio)
    {
        ArgumentNullException.ThrowIfNull(audio);
        audio.SourceText = NormalizeText(audio.SourceText);
        audio.TranslatedText = NormalizeText(audio.TranslatedText);
    }

    public void Resequence(Video video)
    {
        ArgumentNullException.ThrowIfNull(video);

        var orderedElements = video.Elements
            .OrderBy(element => element.StartTime ?? TimeSpan.MaxValue)
            .ThenBy(element => element.Sequence)
            .ThenBy(element => element.Name)
            .ToList();

        for (var index = 0; index < orderedElements.Count; index++)
        {
            orderedElements[index].Sequence = index + 1;
        }
    }

    private static string? NormalizeText(string? value)
    {
        return string.IsNullOrWhiteSpace(value)
            ? value
            : string.Join(' ', value.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries));
    }
}
