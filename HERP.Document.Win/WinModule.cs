using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.Persistent.BaseImpl.EF;
using System.ComponentModel;

namespace HERP.Document.Win;

[ToolboxItemFilter("Xaf.Platform.Win")]
public sealed class HERPDocumentWinModule : ModuleBase
{
    public HERPDocumentWinModule()
    {
        RequiredModuleTypes.Add(typeof(HERP.Document.HERPDocumentModule));
    }

    private void Application_CreateCustomUserModelDifferenceStore(object sender, CreateCustomModelDifferenceStoreEventArgs e)
    {
        e.Store = new ModelDifferenceDbStore((XafApplication)sender, typeof(ModelDifference), false, "Win");
        e.Handled = true;
    }

    public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB)
    {
        return ModuleUpdater.EmptyModuleUpdaters;
    }

    public override void Setup(XafApplication application)
    {
        base.Setup(application);
        application.CreateCustomUserModelDifferenceStore += Application_CreateCustomUserModelDifferenceStore;
    }
}

