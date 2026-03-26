using DevExpress.ExpressApp;
using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

using HERP.Document.Services.Integration;

namespace HERP.Document.Controllers;

public class DataServiceController : ObjectViewController<ObjectView, DataService>
{
    public DataServiceController()
    {
        var pingAction = new SimpleAction(this, "DocumentExecuteDataService", PredefinedCategory.RecordEdit)
        {
            Caption = "Execute Service"
        };
        pingAction.Execute += async (_, _) =>
        {
            if (View?.CurrentObject is not DataService dataService)
            {
                return;
            }

            await new ExternalDataServiceExecutor().ExecuteAsync(dataService, "document-module-smoke-test");
            ObjectSpace.SetModified(dataService);
        };
    }
}

