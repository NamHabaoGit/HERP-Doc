using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.Validation;

namespace HERP.Document.BusinessObjects;


[ImageName("SoftwareServiceType")]
public class SoftwareServiceType : HerpAuditedObject, IHerpBusinessValidatable
{
    public SoftwareServiceType()
    {
        Code = $"SVCTYPE-{Guid.NewGuid():N}";
        Name = "Service Type";
    }

    public void Validate()
    {
        DocumentValidationMessages.EnsureCodeAndName("SoftwareServiceType", Code, Name);
    }
}


