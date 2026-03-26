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


[ImageName("Media")]
public class Media : HerpCompanyScopedAuditedObject, IHerpBusinessValidatable
{
    public Media()
    {
        Code = $"MEDIA-{Guid.NewGuid():N}";
        Name = "Media";
    }

    [ForeignKey(nameof(CompanyId))]
    public virtual Company? Company { get; set; }

    [ForeignKey(nameof(BranchId))]
    public virtual Branch? Branch { get; set; }

    public virtual Guid? VideoId { get; set; }

    [ForeignKey(nameof(VideoId))]
    public virtual Video? Video { get; set; }

    public virtual Guid? ParagraphId { get; set; }

    [ForeignKey(nameof(ParagraphId))]
    public virtual Paragraph? Paragraph { get; set; }

    public virtual int Sequence { get; set; }

    [MaxLength(2048)]
    public virtual string? SourceUrl { get; set; }

    [MaxLength(256)]
    public virtual string? MediaType { get; set; }

    public void Validate()
    {
        const string entityName = "Media";
        DocumentValidationMessages.EnsureCompany(entityName, CompanyId);
        DocumentValidationMessages.EnsureVideo(entityName, VideoId);
        DocumentValidationMessages.EnsureCodeAndName(entityName, Code, Name);
        DocumentValidationMessages.EnsureSequence(entityName, Sequence);
    }
}


