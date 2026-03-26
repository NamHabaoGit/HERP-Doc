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


[ImageName("DataServiceParameter")]
public class DataServiceParameter : HerpAuditedObject, IHerpBusinessValidatable
{
    public DataServiceParameter()
    {
        Code = $"PARAM-{Guid.NewGuid():N}";
        Name = "Parameter";
    }

    public virtual Guid? DataServiceId { get; set; }

    [ForeignKey(nameof(DataServiceId))]
    public virtual DataService? DataService { get; set; }

    public virtual DataServiceParameterType Type { get; set; } = DataServiceParameterType.Parameter;

    public virtual DataServiceParameterOption ParameterOption { get; set; } = DataServiceParameterOption.Json;

    [MaxLength(512)]
    public virtual string? Value { get; set; }

    public virtual int? Order { get; set; }

    public virtual bool IsSecret { get; set; }

    public virtual bool InActive { get; set; }

    public void Validate()
    {
        const string entityName = "DataServiceParameter";
        DocumentValidationMessages.EnsureCodeAndName(entityName, Code, Name);
        DocumentValidationMessages.EnsureDataService(entityName, DataServiceId);
    }
}


