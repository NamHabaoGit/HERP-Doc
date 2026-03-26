using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.BusinessObjects;
using HERP.Document.BusinessObjects;
using HERP.Document.Validation;
using HERP.MasterData.BusinessObjects;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;


[ImageName("Paragraph")]
public class Paragraph : HerpCompanyScopedAuditedObject, IHerpBusinessValidatable
{
    public Paragraph()
    {
        Code = $"PARA-{Guid.NewGuid():N}";
        Name = "Paragraph";
    }

    [ForeignKey(nameof(CompanyId))]
    public virtual Company? Company { get; set; }

    [ForeignKey(nameof(BranchId))]
    public virtual Branch? Branch { get; set; }

    public virtual Guid? VideoId { get; set; }

    [ForeignKey(nameof(VideoId))]
    public virtual Video? Video { get; set; }

    public virtual Guid? ParagraphStyleId { get; set; }

    [ForeignKey(nameof(ParagraphStyleId))]
    public virtual ParagraphStyle? ParagraphStyle { get; set; }

    public virtual int Sequence { get; set; }

    public virtual IList<Element> Elements { get; set; } = new ObservableCollection<Element>();
    public virtual IList<Media> MediaItems { get; set; } = new ObservableCollection<Media>();

    public void Validate()
    {
        const string entityName = "Paragraph";
        DocumentValidationMessages.EnsureCompany(entityName, CompanyId);
        DocumentValidationMessages.EnsureVideo(entityName, VideoId);
        DocumentValidationMessages.EnsureCodeAndName(entityName, Code, Name);
        DocumentValidationMessages.EnsureSequence(entityName, Sequence);
    }
}


