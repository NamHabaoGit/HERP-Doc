using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.BusinessObjects;
using HERP.Document.BusinessObjects;
using HERP.Document.Validation;
using HERP.MasterData.BusinessObjects;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;


[ImageName("Term")]
public class Term : HerpCompanyScopedAuditedObject, IHerpBusinessValidatable
{
    public Term()
    {
        Code = $"TERM-{Guid.NewGuid():N}";
        Name = "Term";
    }

    [ForeignKey(nameof(CompanyId))]
    public virtual Company? Company { get; set; }

    [ForeignKey(nameof(BranchId))]
    public virtual Branch? Branch { get; set; }

    public virtual Guid? VideoId { get; set; }

    [ForeignKey(nameof(VideoId))]
    public virtual Video? Video { get; set; }

    public virtual Guid? LanguageId { get; set; }

    [ForeignKey(nameof(LanguageId))]
    public virtual Language? Language { get; set; }

    [MaxLength(512)]
    public virtual string? SourceTerm { get; set; }

    [MaxLength(512)]
    public virtual string? TranslatedTerm { get; set; }

    public virtual IList<TermLocation> Locations { get; set; } = new ObservableCollection<TermLocation>();
    public virtual IList<TermCorrection> Corrections { get; set; } = new ObservableCollection<TermCorrection>();

    public void Validate()
    {
        const string entityName = "Term";
        DocumentValidationMessages.EnsureCompany(entityName, CompanyId);
        DocumentValidationMessages.EnsureVideo(entityName, VideoId);
        DocumentValidationMessages.EnsureLanguage(entityName, LanguageId);
        DocumentValidationMessages.EnsureTerm(entityName, SourceTerm);
    }
}


