using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.Validation;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace HERP.Document.BusinessObjects;


[DefaultClassOptions]
[NavigationItem("Document")]
[ImageName("SpellingWord")]
public class SpellingWord : HerpAuditedObject, IHerpBusinessValidatable
{
    public SpellingWord()
    {
        Code = $"SPELL-{Guid.NewGuid():N}";
        Name = "Spelling";
    }

    [MaxLength(512)]
    public virtual string? PhoneticText { get; set; }

    public virtual IList<LanguageSpelling> LanguageSpellings { get; set; } = new ObservableCollection<LanguageSpelling>();

    public void Validate()
    {
        DocumentValidationMessages.EnsureText("SpellingWord", PhoneticText);
    }
}


