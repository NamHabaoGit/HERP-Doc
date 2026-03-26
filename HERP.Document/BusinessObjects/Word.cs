using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.BusinessObjects;
using HERP.Document.Validation;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;


[DefaultClassOptions]
[NavigationItem("Document")]
[ImageName("Word")]
public class Word : HerpAuditedObject, IHerpBusinessValidatable
{
    public Word()
    {
        Code = $"WORD-{Guid.NewGuid():N}";
        Name = "Word";
    }

    public virtual Guid? LanguageId { get; set; }

    [ForeignKey(nameof(LanguageId))]
    public virtual Language? Language { get; set; }

    [MaxLength(512)]
    public virtual string? NormalizedValue { get; set; }

    public virtual IList<WordNoSign> NoSignVariants { get; set; } = new ObservableCollection<WordNoSign>();

    public void Validate()
    {
        DocumentValidationMessages.EnsureLanguage("Word", LanguageId);
        DocumentValidationMessages.EnsureText("Word", NormalizedValue);
    }
}


