using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using HERP.Document.BusinessObjects;
using HERP.Document.DatabaseUpdate;
using DocumentDictionary = HERP.Document.BusinessObjects.Dictionary;

namespace HERP.Document;

public sealed class HERPDocumentModule : ModuleBase
{
    public HERPDocumentModule()
    {
        RequiredModuleTypes.Add(typeof(HERP.Base.BaseModule));
        RequiredModuleTypes.Add(typeof(HERP.MasterData.MasterDataModule));

        AdditionalExportedTypes.Add(typeof(Folder));
        AdditionalExportedTypes.Add(typeof(Video));
        AdditionalExportedTypes.Add(typeof(BookMark));
        AdditionalExportedTypes.Add(typeof(ObjectRelation));
        AdditionalExportedTypes.Add(typeof(Element));
        AdditionalExportedTypes.Add(typeof(Paragraph));
        AdditionalExportedTypes.Add(typeof(ParagraphStyle));
        AdditionalExportedTypes.Add(typeof(Media));
        AdditionalExportedTypes.Add(typeof(Term));
        AdditionalExportedTypes.Add(typeof(TermLocation));
        AdditionalExportedTypes.Add(typeof(TermCorrection));
        AdditionalExportedTypes.Add(typeof(TermLocationCorrection));
        AdditionalExportedTypes.Add(typeof(CorrectionOption));
        AdditionalExportedTypes.Add(typeof(DocumentDictionary));
        AdditionalExportedTypes.Add(typeof(DictionaryWord));
        AdditionalExportedTypes.Add(typeof(TranslateWord));
        AdditionalExportedTypes.Add(typeof(SpellingWord));
        AdditionalExportedTypes.Add(typeof(LanguageSpelling));
        AdditionalExportedTypes.Add(typeof(Word));
        AdditionalExportedTypes.Add(typeof(WordNoSign));
        AdditionalExportedTypes.Add(typeof(ElementTranslate));
        AdditionalExportedTypes.Add(typeof(ElementBatch));
        AdditionalExportedTypes.Add(typeof(BatchTranslate));
        AdditionalExportedTypes.Add(typeof(Language));
        AdditionalExportedTypes.Add(typeof(Voice));
        AdditionalExportedTypes.Add(typeof(DataService));
        AdditionalExportedTypes.Add(typeof(DataServiceParameter));
        AdditionalExportedTypes.Add(typeof(SoftwareServiceType));
        AdditionalExportedTypes.Add(typeof(TranslateObject));
        AdditionalExportedTypes.Add(typeof(ExceptionWord));
        AdditionalExportedTypes.Add(typeof(GoogleKey));
        AdditionalExportedTypes.Add(typeof(DataServiceLog));
    }

    public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB)
    {
        return [new DocumentUpdater(objectSpace, versionFromDB)];
    }
}
