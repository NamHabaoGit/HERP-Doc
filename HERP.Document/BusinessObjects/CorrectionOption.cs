using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;


[ImageName("CorrectionOption")]
public class CorrectionOption : HerpAuditedObject, IHerpBusinessValidatable
{
    public CorrectionOption()
    {
        Code = $"OPTION-{Guid.NewGuid():N}";
        Name = "Correction Option";
    }

    public virtual Guid? TermCorrectionId { get; set; }

    [ForeignKey(nameof(TermCorrectionId))]
    public virtual TermCorrection? TermCorrection { get; set; }

    [MaxLength(512)]
    public virtual string? ProposedValue { get; set; }

    public virtual decimal Score { get; set; }

    public void Validate()
    {
        DocumentValidationMessages.EnsureText("CorrectionOption", ProposedValue);
    }
}


