using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;


[ImageName("TermLocationCorrection")]
public class TermLocationCorrection : HerpAuditedObject, IHerpBusinessValidatable
{
    public TermLocationCorrection()
    {
        Code = $"LOC-CORR-{Guid.NewGuid():N}";
        Name = "Term Location Correction";
    }

    public virtual Guid? TermLocationId { get; set; }

    [ForeignKey(nameof(TermLocationId))]
    public virtual TermLocation? TermLocation { get; set; }

    public virtual Guid? TermCorrectionId { get; set; }

    [ForeignKey(nameof(TermCorrectionId))]
    public virtual TermCorrection? TermCorrection { get; set; }

    [MaxLength(512)]
    public virtual string? ReplacementText { get; set; }

    public virtual bool IsApplied { get; set; }

    public void Validate()
    {
        DocumentValidationMessages.EnsureText("TermLocationCorrection", ReplacementText);
    }
}


