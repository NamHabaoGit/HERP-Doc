using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.BusinessObjects;
using HERP.Document.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;


[ImageName("TermLocation")]
public class TermLocation : HerpAuditedObject, IHerpBusinessValidatable
{
    public TermLocation()
    {
        Code = $"TERMLOC-{Guid.NewGuid():N}";
        Name = "Term Location";
    }

    public virtual Guid? TermId { get; set; }

    [ForeignKey(nameof(TermId))]
    public virtual Term? Term { get; set; }

    public virtual Guid? ElementId { get; set; }

    [ForeignKey(nameof(ElementId))]
    public virtual Element? Element { get; set; }

    public virtual int StartIndex { get; set; }

    public virtual int Length { get; set; }

    public void Validate()
    {
        const string entityName = "TermLocation";
        DocumentValidationMessages.EnsureStartIndex(entityName, StartIndex);
        DocumentValidationMessages.EnsureLength(entityName, Length);
    }
}


