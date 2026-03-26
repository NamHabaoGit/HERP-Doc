using HERP.Document.BusinessObjects;
using DocumentDictionary = HERP.Document.BusinessObjects.Dictionary;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;


namespace HERP.Document.DatabaseUpdate;

public class DocumentUpdater : ModuleUpdater
{
    public DocumentUpdater(IObjectSpace objectSpace, Version currentDBVersion)
        : base(objectSpace, currentDBVersion) { }

    public override void UpdateDatabaseAfterUpdateSchema()
    {
        base.UpdateDatabaseAfterUpdateSchema();

        SeedSoftwareServiceTypes();
        SeedLanguages();
        SeedDictionaries();

        ObjectSpace.CommitChanges();
    }

    private void SeedSoftwareServiceTypes()
    {
        CreateSoftwareServiceType("SVCTYPE-TRANS",  "Translation");
        CreateSoftwareServiceType("SVCTYPE-TTS",    "Text to Speech");
        CreateSoftwareServiceType("SVCTYPE-STT",    "Speech to Text");
        CreateSoftwareServiceType("SVCTYPE-VO",     "Voice Over");
        CreateSoftwareServiceType("SVCTYPE-TERM",   "Term Extraction");
    }

    private void SeedLanguages()
    {
        CreateLanguage("LANG-EN",    "English",               "en",    "English");
        CreateLanguage("LANG-VI",    "Vietnamese",            "vi",    "Tiếng Việt");
        CreateLanguage("LANG-ZH",    "Chinese (Simplified)",  "zh-CN", "中文（简体）");
        CreateLanguage("LANG-ZH-TW", "Chinese (Traditional)", "zh-TW", "中文（繁體）");
        CreateLanguage("LANG-JA",    "Japanese",              "ja",    "日本語");
        CreateLanguage("LANG-KO",    "Korean",                "ko",    "한국어");
        CreateLanguage("LANG-FR",    "French",                "fr",    "Français");
        CreateLanguage("LANG-DE",    "German",                "de",    "Deutsch");
        CreateLanguage("LANG-ES",    "Spanish",               "es",    "Español");
        CreateLanguage("LANG-PT",    "Portuguese",            "pt",    "Português");
    }

    private void SeedDictionaries()
    {
        CreateDictionary("DICT-GENERAL", "General", "Từ điển chung");
        CreateDictionary("DICT-TECH",    "Technical", "Thuật ngữ kỹ thuật");
        CreateDictionary("DICT-BRAND",   "Brand Names", "Tên thương hiệu & nhãn hiệu");
    }

    private DocumentDictionary CreateDictionary(string code, string name, string? description = null)
    {
        var existing = ObjectSpace.FirstOrDefault<DocumentDictionary>(x => x.Code == code);
        if (existing != null) return existing;

        var entity = ObjectSpace.CreateObject<DocumentDictionary>();
        entity.Code = code;
        entity.Name = name;
        entity.Description = description;
        return entity;
    }

    private SoftwareServiceType CreateSoftwareServiceType(string code, string name)
    {
        var existing = ObjectSpace.FirstOrDefault<SoftwareServiceType>(x => x.Code == code);
        if (existing != null) return existing;

        var entity = ObjectSpace.CreateObject<SoftwareServiceType>();
        entity.Code = code;
        entity.Name = name;
        return entity;
    }

    private Language CreateLanguage(string code, string name, string isoCode, string nativeName)
    {
        var existing = ObjectSpace.FirstOrDefault<Language>(x => x.Code == code);
        if (existing != null) return existing;

        var entity = ObjectSpace.CreateObject<Language>();
        entity.Code = code;
        entity.Name = name;
        entity.IsoCode = isoCode;
        entity.NativeName = nativeName;
        return entity;
    }
}
