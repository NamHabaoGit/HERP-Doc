using HERP.Document.BusinessObjects;
﻿

namespace HERP.Document.Contracts;

public interface ITermExtractionGateway
{
    Task<IReadOnlyList<string>> ExtractTermsAsync(Video video, CancellationToken cancellationToken = default);
}

