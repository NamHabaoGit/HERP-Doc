using DevExpress.ExpressApp;
using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

using HERP.Document.Services.Workflow;

namespace HERP.Document.Controllers;

public class FolderController : ObjectViewController<ObjectView, Folder>
{
    public FolderController()
    {
        var folderService = new FolderService();

        var rebuildAction = new SimpleAction(this, "DocumentFolderRebuildPath", PredefinedCategory.RecordEdit)
        {
            Caption = "Rebuild Path"
        };
        rebuildAction.Execute += (_, _) =>
        {
            if (View?.CurrentObject is not Folder folder)
            {
                return;
            }

            folderService.RebuildPath(folder);
            ObjectSpace.SetModified(folder);
        };

        var rebuildTreeAction = new SimpleAction(this, "DocumentFolderRebuildPathTree", PredefinedCategory.RecordEdit)
        {
            Caption = "Rebuild Path Tree"
        };
        rebuildTreeAction.Execute += (_, _) =>
        {
            if (View?.CurrentObject is not Folder folder)
            {
                return;
            }

            folderService.RebuildPathTree(folder);
            ObjectSpace.SetModified(folder);

            foreach (var child in folder.Children)
            {
                ObjectSpace.SetModified(child);
            }
        };
    }
}
