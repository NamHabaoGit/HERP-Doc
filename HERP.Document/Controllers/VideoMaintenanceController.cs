using DevExpress.ExpressApp;
using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

using HERP.Document.Services.Workflow;

namespace HERP.Document.Controllers;

public class VideoMaintenanceController : ObjectViewController<ObjectView, Video>
{
    public VideoMaintenanceController()
    {
        var editingService = new ElementEditingService();

        var resequenceAction = new SimpleAction(this, "DocumentResequenceElements", PredefinedCategory.RecordEdit)
        {
            Caption = "Resequence Elements"
        };
        resequenceAction.Execute += (_, _) =>
        {
            if (View?.CurrentObject is not Video video)
            {
                return;
            }

            editingService.Resequence(video);
            ObjectSpace.SetModified(video);

            foreach (var element in video.Elements)
            {
                ObjectSpace.SetModified(element);
            }
        };
    }
}
