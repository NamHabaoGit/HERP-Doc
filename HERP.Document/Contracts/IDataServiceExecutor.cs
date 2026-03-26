using HERP.Document.BusinessObjects;
﻿

namespace HERP.Document.Contracts;

public interface IDataServiceExecutor
{
    Task<string?> ExecuteAsync(DataService dataService, string payload, CancellationToken cancellationToken = default);
}

