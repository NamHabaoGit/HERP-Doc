using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.BusinessObjects;
using HERP.Document.BusinessObjects;
using HERP.Document.BusinessObjects;
using HERP.Document.Validation;
using HERP.MasterData.BusinessObjects;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;

[DefaultClassOptions]
[ImageName("ElementBatch")]
public class ElementBatch : HerpDocumentObject, IHerpBusinessValidatable
{
    public ElementBatch()
    {
        Code = $"BATCH-{Guid.NewGuid():N}";
        Name = "Element Batch";
    }

    [ForeignKey(nameof(CompanyId))]
    public virtual Company? Company { get; set; }

    [ForeignKey(nameof(BranchId))]
    public virtual Branch? Branch { get; set; }

    public virtual Guid? VideoId { get; set; }

    [ForeignKey(nameof(VideoId))]
    public virtual Video? Video { get; set; }

    public virtual Guid? TargetLanguageId { get; set; }

    [ForeignKey(nameof(TargetLanguageId))]
    public virtual Language? TargetLanguage { get; set; }

    public virtual IList<Element> Elements { get; set; } = new ObservableCollection<Element>();
    public virtual IList<BatchTranslate> Translations { get; set; } = new ObservableCollection<BatchTranslate>();

    public void Validate()
    {
        const string entityName = "ElementBatch";
        DocumentValidationMessages.EnsureCompany(entityName, CompanyId);
        DocumentValidationMessages.EnsureVideo(entityName, VideoId);
        DocumentValidationMessages.EnsureTargetLanguage(entityName, TargetLanguageId);
        DocumentValidationMessages.EnsureCodeAndName(entityName, Code, Name);
        DocumentValidationMessages.EnsureDifferentLanguage(entityName, Video?.SourceLanguageId, TargetLanguageId);
    }
}