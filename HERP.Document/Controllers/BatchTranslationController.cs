using DevExpress.ExpressApp;
using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

using HERP.Document.Services.Translation;

namespace HERP.Document.Controllers;

public class BatchTranslationController : ObjectViewController<ObjectView, ElementBatch>
{
    public BatchTranslationController()
    {
        var prepareAction = new SimpleAction(this, "DocumentPrepareBatchTranslation", PredefinedCategory.RecordEdit)
        {
            Caption = "Prepare Batch"
        };
        prepareAction.Execute += async (_, _) =>
        {
            if (View?.CurrentObject is not ElementBatch batch)
            {
                return;
            }

            var translation = await new BatchTranslationService().PrepareTranslationAsync(batch);
            ObjectSpace.SetModified(batch);
            ObjectSpace.SetModified(translation);
        };
    }
}

