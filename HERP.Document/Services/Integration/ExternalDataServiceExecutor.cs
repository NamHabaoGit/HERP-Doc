
using HERP.Document.BusinessObjects;
using HERP.Document.Contracts;

namespace HERP.Document.Services.Integration;

public class ExternalDataServiceExecutor
{
    private readonly IDataServiceExecutor executor;

    public ExternalDataServiceExecutor(IDataServiceExecutor? executor = null)
    {
        this.executor = executor ?? new DefaultDataServiceExecutor();
    }

    public Task<string?> ExecuteAsync(DataService dataService, string payload, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(dataService);
        return executor.ExecuteAsync(dataService, payload, cancellationToken);
    }

    private sealed class DefaultDataServiceExecutor : IDataServiceExecutor
    {
        public Task<string?> ExecuteAsync(DataService dataService, string payload, CancellationToken cancellationToken = default)
        {
            var parameterSummary = string.Join(';', dataService.Parameters.Select(parameter => $"{parameter.Code}={parameter.Value}"));
            return Task.FromResult<string?>($"endpoint={dataService.Endpoint};payload={payload};params={parameterSummary}");
        }
    }
}

