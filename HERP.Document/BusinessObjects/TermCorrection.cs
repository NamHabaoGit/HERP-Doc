using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.Validation;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;


[ImageName("TermCorrection")]
public class TermCorrection : HerpAuditedObject, IHerpBusinessValidatable
{
    public TermCorrection()
    {
        Code = $"TERMCORR-{Guid.NewGuid():N}";
        Name = "Term Correction";
    }

    public virtual Guid? TermId { get; set; }

    [ForeignKey(nameof(TermId))]
    public virtual Term? Term { get; set; }

    [MaxLength(512)]
    public virtual string? ReplacementText { get; set; }

    public virtual bool IsApplied { get; set; }

    public virtual IList<TermLocationCorrection> LocationCorrections { get; set; } = new ObservableCollection<TermLocationCorrection>();
    public virtual IList<CorrectionOption> Options { get; set; } = new ObservableCollection<CorrectionOption>();

    public void Validate()
    {
        DocumentValidationMessages.EnsureText("TermCorrection", ReplacementText);
    }
}


