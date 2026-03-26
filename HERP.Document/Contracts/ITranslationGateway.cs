using HERP.Document.BusinessObjects;
﻿

namespace HERP.Document.Contracts;

public interface ITranslationGateway
{
    Task<IReadOnlyList<string>> TranslateAsync(string prompt, Language targetLanguage, CancellationToken cancellationToken = default);
}

