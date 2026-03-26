using HERP.Document.BusinessObjects;
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
[ImageName("WordNoSign")]
public class WordNoSign : HerpAuditedObject, IHerpBusinessValidatable
{
    public WordNoSign()
    {
        Code = $"WORDNS-{Guid.NewGuid():N}";
        Name = "Word No Sign";
    }

    public virtual Guid? WordId { get; set; }

    [ForeignKey(nameof(WordId))]
    public virtual Word? Word { get; set; }

    [MaxLength(512)]
    public virtual string? Value { get; set; }

    public void Validate()
    {
        DocumentValidationMessages.EnsureText("WordNoSign", Value);
    }
}


