using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.BusinessObjects;
using HERP.Document.Validation;
using HERP.MasterData.BusinessObjects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;


[ImageName("ParagraphStyle")]
public class ParagraphStyle : HerpCompanyScopedAuditedObject, IHerpBusinessValidatable
{
    public ParagraphStyle()
    {
        Code = $"STYLE-{Guid.NewGuid():N}";
        Name = "Paragraph Style";
    }

    [ForeignKey(nameof(CompanyId))]
    public virtual Company? Company { get; set; }

    [ForeignKey(nameof(BranchId))]
    public virtual Branch? Branch { get; set; }

    public virtual Guid? VideoId { get; set; }

    [ForeignKey(nameof(VideoId))]
    public virtual Video? Video { get; set; }

    [MaxLength(64)]
    public virtual string? FontFamily { get; set; }

    public virtual decimal? FontSize { get; set; }

    [MaxLength(32)]
    public virtual string? FontWeight { get; set; }

    [MaxLength(32)]
    public virtual string? TextAlignment { get; set; }

    public void Validate()
    {
        const string entityName = "ParagraphStyle";
        DocumentValidationMessages.EnsureCompany(entityName, CompanyId);
        DocumentValidationMessages.EnsureVideo(entityName, VideoId);
        DocumentValidationMessages.EnsureCodeAndName(entityName, Code, Name);
    }
}


