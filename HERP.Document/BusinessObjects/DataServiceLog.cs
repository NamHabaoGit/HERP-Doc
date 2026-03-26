using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;

[ImageName("DataServiceLog")]
public class DataServiceLog : HerpAuditedObject, IHerpBusinessValidatable
{
    public DataServiceLog()
    {
        Code = $"LOG-{Guid.NewGuid():N}";
        Name = "Log";
    }

    public virtual Guid? DataServiceId { get; set; }

    [ForeignKey(nameof(DataServiceId))]
    public virtual DataService? DataService { get; set; }

    public virtual int? Quantity { get; set; }

    [MaxLength(1024)]
    public virtual string? Note { get; set; }

    public virtual DateTime? CreatedDate { get; set; }

    public void Validate()
    {
        DocumentValidationMessages.EnsureDataService("DataServiceLog", DataServiceId);
    }
}
