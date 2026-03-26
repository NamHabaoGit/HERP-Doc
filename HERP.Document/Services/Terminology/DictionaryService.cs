using HERP.Document.BusinessObjects;
﻿

using DocumentDictionary = HERP.Document.BusinessObjects.Dictionary;

namespace HERP.Document.Services.Terminology;

public class DictionaryService
{
    public void SyncFromTerms(DocumentDictionary dictionary, IEnumerable<Term> terms)
    {
        ArgumentNullException.ThrowIfNull(dictionary);
        ArgumentNullException.ThrowIfNull(terms);

        foreach (var term in terms.Where(term => !string.IsNullOrWhiteSpace(term.SourceTerm)))
        {
            if (dictionary.Words.Any(existing => string.Equals(existing.Name, term.SourceTerm, StringComparison.OrdinalIgnoreCase)))
            {
                continue;
            }

            var word = new Word
            {
                Name = term.SourceTerm!,
                Code = $"WORD-{Guid.NewGuid():N}",
                Language = term.Language,
                LanguageId = term.LanguageId,
                NormalizedValue = term.SourceTerm
            };

            dictionary.Words.Add(new DictionaryWord
            {
                Dictionary = dictionary,
                DictionaryId = dictionary.ID,
                Word = word,
                WordId = word.ID,
                Name = term.SourceTerm!,
                Code = $"DICTWORD-{Guid.NewGuid():N}"
            });
        }
    }
}

