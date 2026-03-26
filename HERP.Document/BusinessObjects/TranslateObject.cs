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


[ImageName("TranslateObject")]
public class TranslateObject : HerpCompanyScopedAuditedObject, IHerpBusinessValidatable
{
    public TranslateObject()
    {
        Code = $"TR-OBJ-{Guid.NewGuid():N}";
        Name = "Translate Object";
    }

    [ForeignKey(nameof(CompanyId))]
    public virtual Company? Company { get; set; }

    [ForeignKey(nameof(BranchId))]
    public virtual Branch? Branch { get; set; }

    public virtual Guid? VideoId { get; set; }

    [ForeignKey(nameof(VideoId))]
    public virtual Video? Video { get; set; }

    public virtual ExternalObjectType ExternalObjectType { get; set; }

    [MaxLength(256)]
    public virtual string? ExternalObjectId { get; set; }

    [MaxLength(256)]
    public virtual string? SourceFieldName { get; set; }

    [MaxLength(256)]
    public virtual string? TargetFieldName { get; set; }

    [MaxLength(8000)]
    public virtual string? SourceHtml { get; set; }

    [MaxLength(8000)]
    public virtual string? ExportedHtml { get; set; }

    public void Validate()
    {
        const string entityName = "TranslateObject";
        DocumentValidationMessages.EnsureCompany(entityName, CompanyId);
        DocumentValidationMessages.EnsureVideo(entityName, VideoId);
        DocumentValidationMessages.EnsureExternalObjectId(entityName, ExternalObjectId);
        DocumentValidationMessages.EnsureSource(entityName, SourceHtml);
    }
}


