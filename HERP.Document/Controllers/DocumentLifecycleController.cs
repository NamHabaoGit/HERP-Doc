using DevExpress.ExpressApp;
using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

using HERP.Document.Services.Workflow;

namespace HERP.Document.Controllers;

public class DocumentLifecycleController : ObjectViewController<ObjectView, Video>
{
    public DocumentLifecycleController()
    {
        var submitAction = new SimpleAction(this, "DocumentSubmitForReview", PredefinedCategory.RecordEdit)
        {
            Caption = "Submit"
        };
        submitAction.Execute += (_, _) =>
        {
            if (View?.CurrentObject is not Video video)
            {
                return;
            }

            new DocumentWorkflowService().SubmitForReview(video);
            ObjectSpace.SetModified(video);
        };

        var publishAction = new SimpleAction(this, "DocumentPublish", PredefinedCategory.RecordEdit)
        {
            Caption = "Publish"
        };
        publishAction.Execute += (_, _) =>
        {
            if (View?.CurrentObject is not Video video)
            {
                return;
            }

            new DocumentWorkflowService().Publish(video);
            ObjectSpace.SetModified(video);
        };
    }
}

