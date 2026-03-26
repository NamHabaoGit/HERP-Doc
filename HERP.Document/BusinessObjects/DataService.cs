using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.Enums;
using HERP.Document.Validation;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;

[DefaultClassOptions]
[ImageName("DataService")]
[NavigationItem("Document")]
public class DataService : HerpAuditedObject, IHerpBusinessValidatable
{
    public DataService()
    {
        Code = $"SERVICE-{Guid.NewGuid():N}";
        Name = "Data Service";
    }

    public virtual Guid? SoftwareServiceTypeId { get; set; }

    [ForeignKey(nameof(SoftwareServiceTypeId))]
    public virtual SoftwareServiceType? SoftwareServiceType { get; set; }

    [MaxLength(2048)]
    public virtual string? Endpoint { get; set; }

    public virtual ApiMethodType ApiMethodType { get; set; } = ApiMethodType.Post;

    [MaxLength(1024)]
    public virtual string? APIKey { get; set; }

    [MaxLength(256)]
    public virtual string? ServiceCode { get; set; }

    public virtual int? MaxConcurrency { get; set; }

    public virtual bool IsEnabled { get; set; } = true;

    public virtual IList<DataServiceParameter> Parameters { get; set; } = new ObservableCollection<DataServiceParameter>();
    public virtual IList<Voice> Voices { get; set; } = new ObservableCollection<Voice>();
    public virtual IList<DataServiceLog> Logs { get; set; } = new ObservableCollection<DataServiceLog>();

    public void Validate()
    {
        const string entityName = "DataService";
        DocumentValidationMessages.EnsureCodeAndName(entityName, Code, Name);
        DocumentValidationMessages.EnsureEndpoint(entityName, Endpoint);
        DocumentValidationMessages.EnsureUniqueParameterCodes(entityName, Parameters);
    }
}