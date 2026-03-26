


using HERP.Document.BusinessObjects;
using HERP.Document.Contracts;

namespace HERP.Document.Services.Terminology;

public class TerminologyExtractionService
{
    private readonly ITermExtractionGateway gateway;

    public TerminologyExtractionService(ITermExtractionGateway? gateway = null)
    {
        this.gateway = gateway ?? new DefaultTermExtractionGateway();
    }

    public async Task<IReadOnlyList<Term>> ExtractAsync(Video video, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(video);

        var candidates = await gateway.ExtractTermsAsync(video, cancellationToken);
        var terms = new List<Term>();

        foreach (var candidate in candidates.Distinct(StringComparer.OrdinalIgnoreCase))
        {
            var term = new Term
            {
                CompanyId = video.CompanyId,
                BranchId = video.BranchId,
                Video = video,
                VideoId = video.ID,
                Language = video.SourceLanguage,
                LanguageId = video.SourceLanguageId,
                SourceTerm = candidate,
                Name = candidate,
                Code = $"TERM-{Guid.NewGuid():N}"
            };

            foreach (var audio in video.Elements.Where(audio => audio.SourceText?.Contains(candidate, StringComparison.OrdinalIgnoreCase) == true))
            {
                term.Locations.Add(new TermLocation
                {
                    Term = term,
                    TermId = term.ID,
                    Element = audio,
                    ElementId = audio.ID,
                    StartIndex = audio.SourceText!.IndexOf(candidate, StringComparison.OrdinalIgnoreCase),
                    Length = candidate.Length,
                    Code = $"TERMLOC-{Guid.NewGuid():N}",
                    Name = $"{candidate} in {audio.Name}"
                });
            }

            video.Terms.Add(term);
            terms.Add(term);
        }

        return terms;
    }

    private sealed class DefaultTermExtractionGateway : ITermExtractionGateway
    {
        public Task<IReadOnlyList<string>> ExtractTermsAsync(Video video, CancellationToken cancellationToken = default)
        {
            var terms = video.Elements
                .Select(audio => audio.SourceText)
                .Where(text => !string.IsNullOrWhiteSpace(text))
                .SelectMany(text => text!.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
                .Where(word => word.Length >= 4)
                .Take(50)
                .ToArray();

            return Task.FromResult<IReadOnlyList<string>>(terms);
        }
    }
}

