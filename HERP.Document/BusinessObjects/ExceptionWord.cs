using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;

[DefaultClassOptions]
[NavigationItem("Document")]
[ImageName("ExceptionWord")]
public class ExceptionWord : HerpAuditedObject, IHerpBusinessValidatable
{
    public ExceptionWord()
    {
        Code = $"EXW-{Guid.NewGuid():N}";
        Name = "Exception Word";
    }

    public virtual Guid? LanguageId { get; set; }

    [ForeignKey(nameof(LanguageId))]
    public virtual Language? Language { get; set; }

    [MaxLength(512)]
    public virtual string? Meaning { get; set; }

    public void Validate()
    {
        const string entityName = "ExceptionWord";
        DocumentValidationMessages.EnsureCodeAndName(entityName, Code, Name);
        DocumentValidationMessages.EnsureLanguage(entityName, LanguageId);
    }
}
