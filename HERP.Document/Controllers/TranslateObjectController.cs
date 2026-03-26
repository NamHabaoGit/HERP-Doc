using DevExpress.ExpressApp;
using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

using HERP.Document.Services.Integration;

namespace HERP.Document.Controllers;

public class TranslateObjectController : ObjectViewController<ObjectView, TranslateObject>
{
    public TranslateObjectController()
    {
        var exportAction = new SimpleAction(this, "DocumentExportHtml", PredefinedCategory.RecordEdit)
        {
            Caption = "Export Html"
        };
        exportAction.Execute += (_, _) =>
        {
            if (View?.CurrentObject is not TranslateObject translateObject || translateObject.Video is null)
            {
                return;
            }

            new TranslateObjectService().ExportHtml(translateObject, translateObject.Video);
            ObjectSpace.SetModified(translateObject);
        };
    }
}

