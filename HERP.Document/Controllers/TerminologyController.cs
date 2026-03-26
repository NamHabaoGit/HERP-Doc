using DevExpress.ExpressApp;
using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

using HERP.Document.Services.Terminology;

namespace HERP.Document.Controllers;

public class TerminologyController : ObjectViewController<ObjectView, Video>
{
    public TerminologyController()
    {
        var extractAction = new SimpleAction(this, "DocumentExtractTerms", PredefinedCategory.RecordEdit)
        {
            Caption = "Extract Terms"
        };
        extractAction.Execute += async (_, _) =>
        {
            if (View?.CurrentObject is not Video video)
            {
                return;
            }

            await new TerminologyExtractionService().ExtractAsync(video);
            ObjectSpace.SetModified(video);
        };
    }
}

