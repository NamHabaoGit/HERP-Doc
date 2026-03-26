using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.Validation;
using System.ComponentModel.DataAnnotations;

namespace HERP.Document.BusinessObjects;

[DefaultClassOptions]
[NavigationItem("Document")]
[ImageName("GoogleKey")]
public class GoogleKey : HerpAuditedObject, IHerpBusinessValidatable
{
    public GoogleKey()
    {
        Code = $"GKEY-{Guid.NewGuid():N}";
        Name = "Google Key";
    }

    [MaxLength(4000)]
    public virtual string? KeyJson { get; set; }

    public void Validate()
    {
        DocumentValidationMessages.EnsureCodeAndName("GoogleKey", Code, Name);
    }
}
