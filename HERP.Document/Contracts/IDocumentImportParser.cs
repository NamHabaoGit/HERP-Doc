using HERP.Document.BusinessObjects;
﻿

namespace HERP.Document.Contracts;

public interface IDocumentImportParser
{
    Task<IReadOnlyList<string>> ParseAsync(BookMark bookMark, CancellationToken cancellationToken = default);
}

