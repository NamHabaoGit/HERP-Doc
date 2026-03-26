using HERP.Document.BusinessObjects;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using HERP.Base.BusinessObjects;
using HERP.Base.Contracts;
using HERP.Document.Validation;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace HERP.Document.BusinessObjects;


[ImageName("DictionaryWord")]
public class DictionaryWord : HerpAuditedObject, IHerpBusinessValidatable
{
    public DictionaryWord()
    {
        Code = $"DICTWORD-{Guid.NewGuid():N}";
        Name = "Dictionary Word";
    }

    public virtual Guid? DictionaryId { get; set; }

    [ForeignKey(nameof(DictionaryId))]
    public virtual Dictionary? Dictionary { get; set; }

    public virtual Guid? WordId { get; set; }

    [ForeignKey(nameof(WordId))]
    public virtual Word? Word { get; set; }

    public virtual IList<TranslateWord> Translations { get; set; } = new ObservableCollection<TranslateWord>();

    public void Validate()
    {
        DocumentValidationMessages.EnsureText("DictionaryWord", Name);
    }
}


