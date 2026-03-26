using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.Enums;
using HERP.Document.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;


[DefaultClassOptions]
[NavigationItem("Document")]
[ImageName("Voice")]
public class Voice : HerpAuditedObject, IHerpBusinessValidatable
{
    public Voice()
    {
        Code = $"VOICE-{Guid.NewGuid():N}";
        Name = "Voice";
    }

    public virtual Guid? LanguageId { get; set; }

    [ForeignKey(nameof(LanguageId))]
    public virtual Language? Language { get; set; }

    public virtual Guid? DataServiceId { get; set; }

    [ForeignKey(nameof(DataServiceId))]
    public virtual DataService? DataService { get; set; }

    [MaxLength(128)]
    public virtual string? ProviderVoiceCode { get; set; }

    public virtual Gender Gender { get; set; } = Gender.Other;

    public virtual decimal VowelSpeed { get; set; } = 1.0m;

    [MaxLength(512)]
    public virtual string? Note { get; set; }

    public void Validate()
    {
        const string entityName = "Voice";
        DocumentValidationMessages.EnsureCodeAndName(entityName, Code, Name);
        DocumentValidationMessages.EnsureLanguage(entityName, LanguageId);
    }
}


