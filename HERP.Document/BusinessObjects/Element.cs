using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.BusinessObjects;
using HERP.Document.BusinessObjects;
using HERP.Document.BusinessObjects;
using HERP.Document.BusinessObjects;
using HERP.Document.Enums;
using HERP.Document.Validation;
using HERP.MasterData.BusinessObjects;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;

[DefaultClassOptions]
[ImageName("Element")]
public class Element : HerpCompanyScopedAuditedObject, IHerpBusinessValidatable
{
    public Element()
    {
        Code = $"ELEMENT-{Guid.NewGuid():N}";
        Name = "Element";
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

    public virtual Guid? LanguageId { get; set; }

    [ForeignKey(nameof(LanguageId))]
    public virtual Language? Language { get; set; }

    public virtual Guid? VoiceId { get; set; }

    [ForeignKey(nameof(VoiceId))]
    public virtual Voice? Voice { get; set; }

    public virtual int Sequence { get; set; }

    public virtual TimeSpan? StartTime { get; set; }

    public virtual TimeSpan? EndTime { get; set; }

    [MaxLength(4000)]
    public virtual string? SourceText { get; set; }

    [MaxLength(4000)]
    public virtual string? TranslatedText { get; set; }

    [MaxLength(1024)]
    public virtual string? Notes { get; set; }

    public virtual bool IsProcessed { get; set; }

    public virtual decimal? VoiceSpeed { get; set; }

    [MaxLength(4000)]
    public virtual string? Spelling { get; set; }

    [MaxLength(2048)]
    public virtual string? AudioLink { get; set; }

    public virtual decimal? AudioDuration { get; set; }

    public virtual IList<ElementTranslate> Translations { get; set; } = new ObservableCollection<ElementTranslate>();

    [NotMapped]
    public virtual TimeSpan? Duration => StartTime.HasValue && EndTime.HasValue ? EndTime.Value - StartTime.Value : null;

    [NotMapped]
    public virtual bool HasTranslation => !string.IsNullOrWhiteSpace(TranslatedText);

    [NotMapped]
    [Browsable(false)]
    public virtual string DisplayText => string.IsNullOrWhiteSpace(TranslatedText) ? SourceText ?? string.Empty : TranslatedText!;

    public void Validate()
    {
        const string entityName = "Element";
        DocumentValidationMessages.EnsureCompany(entityName, CompanyId);
        DocumentValidationMessages.EnsureVideo(entityName, VideoId);
        DocumentValidationMessages.EnsureSequence(entityName, Sequence);
        DocumentValidationMessages.EnsureText(entityName, SourceText);
        DocumentValidationMessages.EnsureTimeRange(entityName, StartTime, EndTime);
    }
}
