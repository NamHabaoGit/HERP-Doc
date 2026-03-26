using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.BusinessObjects;
using HERP.Document.Enums;
using HERP.Document.Validation;
using HERP.MasterData.BusinessObjects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;


[ImageName("ObjectRelation")]
public class ObjectRelation : HerpCompanyScopedAuditedObject, IHerpBusinessValidatable
{
    public ObjectRelation()
    {
        Code = $"REL-{Guid.NewGuid():N}";
        Name = "Document Relation";
    }

    [ForeignKey(nameof(CompanyId))]
    public virtual Company? Company { get; set; }

    [ForeignKey(nameof(BranchId))]
    public virtual Branch? Branch { get; set; }

    public virtual Guid? FolderId { get; set; }

    [ForeignKey(nameof(FolderId))]
    public virtual Folder? Folder { get; set; }

    public virtual Guid? VideoId { get; set; }

    [ForeignKey(nameof(VideoId))]
    public virtual Video? Video { get; set; }

    public virtual ExternalObjectType ExternalObjectType { get; set; }

    [MaxLength(256)]
    public virtual string? ExternalObjectId { get; set; }

    [MaxLength(256)]
    public virtual string? ExternalEntityName { get; set; }

    public void Validate()
    {
        const string entityName = "ObjectRelation";
        DocumentValidationMessages.EnsureCompany(entityName, CompanyId);
        DocumentValidationMessages.EnsureCodeAndName(entityName, Code, Name);
        DocumentValidationMessages.EnsureExternalObjectId(entityName, ExternalObjectId);
    }
}


