using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.BusinessObjects;
using HERP.Document.BusinessObjects;
using HERP.Document.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;


[ImageName("ElementTranslate")]
public class ElementTranslate : HerpAuditedObject, IHerpBusinessValidatable
{
    public ElementTranslate()
    {
        Code = $"ELTRANS-{Guid.NewGuid():N}";
        Name = "Element Translate";
    }

    public virtual Guid? ElementId { get; set; }

    [ForeignKey(nameof(ElementId))]
    public virtual Element? Element { get; set; }

    public virtual Guid? LanguageId { get; set; }

    [ForeignKey(nameof(LanguageId))]
    public virtual Language? Language { get; set; }

    [MaxLength(4000)]
    public virtual string? Value { get; set; }

    public virtual bool IsApproved { get; set; }

    public void Validate()
    {
        DocumentValidationMessages.EnsureLanguage("ElementTranslate", LanguageId);
        DocumentValidationMessages.EnsureText("ElementTranslate", Value);
    }
}


