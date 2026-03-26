using DevExpress.ExpressApp;
using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

using HERP.Document.Services.Terminology;

namespace HERP.Document.Controllers;

public class TermCorrectionController : ObjectViewController<ObjectView, TermCorrection>
{
    public TermCorrectionController()
    {
        var applyAction = new SimpleAction(this, "DocumentApplyTermCorrection", PredefinedCategory.RecordEdit)
        {
            Caption = "Apply Correction"
        };
        applyAction.Execute += (_, _) =>
        {
            if (View?.CurrentObject is not TermCorrection correction)
            {
                return;
            }

            new TerminologyCorrectionService().ApplyTermCorrection(correction);
            ObjectSpace.SetModified(correction);
        };
    }
}

