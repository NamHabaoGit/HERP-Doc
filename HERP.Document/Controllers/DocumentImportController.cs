using DevExpress.ExpressApp;
using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

using HERP.Document.Services.Import;

namespace HERP.Document.Controllers;

public class DocumentImportController : ObjectViewController<ObjectView, BookMark>
{
    public DocumentImportController()
    {
        var queueAction = new SimpleAction(this, "DocumentBookmarkQueueImport", PredefinedCategory.RecordEdit)
        {
            Caption = "Queue Import"
        };
        queueAction.Execute += (_, _) =>
        {
            if (View?.CurrentObject is not BookMark bookMark)
            {
                return;
            }

            new BookmarkImportService().MarkAsQueued(bookMark);
            ObjectSpace.SetModified(bookMark);
        };
    }
}

