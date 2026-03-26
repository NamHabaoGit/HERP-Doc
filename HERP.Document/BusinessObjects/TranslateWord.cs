using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.BusinessObjects;
using HERP.Document.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;


[ImageName("TranslateWord")]
public class TranslateWord : HerpAuditedObject, IHerpBusinessValidatable
{
    public TranslateWord()
    {
        Code = $"TRANSWORD-{Guid.NewGuid():N}";
        Name = "Translate Word";
    }

    public virtual Guid? DictionaryWordId { get; set; }

    [ForeignKey(nameof(DictionaryWordId))]
    public virtual DictionaryWord? DictionaryWord { get; set; }

    public virtual Guid? LanguageId { get; set; }

    [ForeignKey(nameof(LanguageId))]
    public virtual Language? Language { get; set; }

    [MaxLength(512)]
    public virtual string? Value { get; set; }

    public void Validate()
    {
        DocumentValidationMessages.EnsureLanguage("TranslateWord", LanguageId);
        DocumentValidationMessages.EnsureText("TranslateWord", Value);
    }
}


