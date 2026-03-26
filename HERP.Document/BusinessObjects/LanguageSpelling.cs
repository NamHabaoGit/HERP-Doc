using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.BusinessObjects;
using HERP.Document.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;


[ImageName("LanguageSpelling")]
public class LanguageSpelling : HerpAuditedObject, IHerpBusinessValidatable
{
    public LanguageSpelling()
    {
        Code = $"LANGSPELL-{Guid.NewGuid():N}";
        Name = "Language Spelling";
    }

    public virtual Guid? LanguageId { get; set; }

    [ForeignKey(nameof(LanguageId))]
    public virtual Language? Language { get; set; }

    public virtual Guid? SpellingWordId { get; set; }

    [ForeignKey(nameof(SpellingWordId))]
    public virtual SpellingWord? SpellingWord { get; set; }

    public void Validate()
    {
        DocumentValidationMessages.EnsureLanguage("LanguageSpelling", LanguageId);
    }
}


