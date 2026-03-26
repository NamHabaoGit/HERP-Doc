using DevExpress.ExpressApp;
using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

using HERP.Document.Services.Workflow;

namespace HERP.Document.Controllers;

public class ElementEditingController : ObjectViewController<ObjectView, Element>
{
    public ElementEditingController()
    {
        var normalizeAction = new SimpleAction(this, "DocumentNormalizeElement", PredefinedCategory.RecordEdit)
        {
            Caption = "Normalize Text"
        };
        normalizeAction.Execute += (_, _) =>
        {
            foreach (Element audio in View.SelectedObjects)
            {
                new ElementEditingService().Normalize(audio);
                ObjectSpace.SetModified(audio);
            }
        };
    }
}

