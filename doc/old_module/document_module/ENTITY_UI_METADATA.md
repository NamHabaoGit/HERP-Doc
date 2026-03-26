# ENTITY_UI_METADATA

Ph?m vi: to?n b? entity trong `ENTOSDocument.Module/BusinessObjects` c?a h? th?ng c?. D? li?u ???c tr?ch xu?t t? attribute, method lifecycle v? c?c method `GetDefault*`/`SetDefault*` hi?n c? trong m? ngu?n.

# Entity: ApplicationUserLoginInfo

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|

## Default Logic

Kh?ng t?m th?y default logic r? r?ng trong constructor, lifecycle method ho?c attribute.

## UI Layout

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| _None_ | ApplicationUserLoginInfo | Kh?ng t?m th?y method `GetDefault*`, `SetDefault*`, `AfterConstruction`, `OnLoaded`, `OnSaving` ho?c constructor c? logic ??ng ch? ?. |

---

# Entity: Audio

Caption entity: `Thành phần`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Start | TimeSpan? | Bắt đầu | Yes | GetDefaultStart: Start<br>SetDefaultStart: result | true | true |   | 1 |
| End | TimeSpan? | Kết thúc | No | GetDefaultEnd: End<br>SetDefaultEnd: result | true | true |   | 1 |
| Voice | Module.BusinessObjects.Voice | Giọng | No | GetDefaultVoice: Voice<br>SetDefaultVoice: result | false | true |   | 1 |
| VoiceSpeed | decimal? | Tốc độ | No | GetDefaultVoiceSpeed: VoiceSpeed<br>SetDefaultVoiceSpeed: result | false | true |   | 1 |
| Content | string | Nội dung | No | GetDefaultContent: Content<br>SetDefaultContent: result | true | true |   | 1 |
| Subtitle | string | Dịch | No | GetDefaultSubtitle: Subtitle<br>SetDefaultSubtitle: result | true | true |   | 1 |
| Spelling | string | Phiên âm | No | GetDefaultSpelling: Spelling<br>SetDefaultSpelling: result | false | true |   | 1 |
| ElementTranslateList | XPCollection <Module.BusinessObjects.ElementTranslate> | Dịch ngữ | No |  | false | true |  |  |
| TermLocationList | XPCollection <Module.BusinessObjects.TermLocation> | Thuật vị | No |  | false | true |  |  |
| MediaList | XPCollection <Module.BusinessObjects.Media> | Đoạn video | No |  | false | true |  |  |
| Video | Module.BusinessObjects.Video | Video | No | GetDefaultVideo: Video<br>SetDefaultVideo: result | false | false |  |  |
| ParagraphStyle | Module.BusinessObjects.ParagraphStyle | Kiểu cách | No | GetDefaultParagraphStyle: ParagraphStyle<br>SetDefaultParagraphStyle: result | false | false |  |  |
| Update | DateTime | Cập nhật | No | SetDefaultUpdate: GetDefaultUpdate()<br>GetDefaultUpdate: System.DateTime.Now | false | false |  |  |
| URL | string | URL | No | GetDefaultURL: URL<br>SetDefaultURL: result | false | false |  |  |
| FileData | DevExpress.Persistent.BaseImpl.FileData | Âm thanh | No | GetDefaultFileData: FileData<br>SetDefaultFileData: result | false | false |  |  |
| AudioLink | string | Tệp âm | No | GetDefaultAudioLink: AudioLink<br>SetDefaultAudioLink: result | false | false |  |  |
| AudioDuration | decimal? | Thời lượng âm | No | SetDefaultAudioDuration: result<br>GetDefaultAudioDuration: Computed in GetDefaultAudioDuration | false | false |  |  |
| AudioRate | decimal? | Suất âm | No | GetDefaultAudioRate: AudioRate<br>SetDefaultAudioRate: result | false | false |  |  |
| Duration | decimal? | Thời lượng | No | GetDefaultDuration: Duration<br>SetDefaultDuration: result | false | false |  |  |
| SilenceGap | decimal? | Lặng | No | GetDefaultSilenceGap: SilenceGap<br>SetDefaultSilenceGap: result | false | false |  |  |
| Quantity | decimal? | Số lượng | No | SetDefaultQuantity: result<br>GetDefaultQuantity: Computed in GetDefaultQuantity | false | false |  |  |
| TextRate | decimal? | Tỉ suất | No | GetDefaultTextRate: TextRate<br>SetDefaultTextRate: result | false | false |  |  |
| SubtitleTime | DateTime? | Cập nhật dịch | No | GetDefaultSubtitleTime: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)<br>SetDefaultSubtitleTime: GetDefaultSubtitleTime() | false | false |  |  |
| SpellingTime | DateTime? | Cập nhật phiên âm | No | SetDefaultSpellingTime: GetDefaultSpellingTime()<br>GetDefaultSpellingTime: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null) | false | false |  |  |
| AudioTime | DateTime? | Cập nhật âm thanh | No | GetDefaultAudioTime: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)<br>SetDefaultAudioTime: GetDefaultAudioTime() | false | false |  |  |
| Splitted | bool | Tách | No | GetDefaultSplitted: Splitted<br>SetDefaultSplitted: result | false | false |  |  |
| Note | string | Ghi chú | No | GetDefaultNote: Note<br>SetDefaultNote: result | false | false |  |  |
| Delete | bool | Xóa | No | GetDefaultDelete: Delete<br>SetDefaultDelete: result | false | false |  |  |
| NextElement | Module.BusinessObjects.Audio | Sau | No | SetDefaultNextElement: result<br>GetDefaultNextElement: Video.GetAudioListWithSort(BookMark, true, TranslateObject).FirstOrDefault(x => x.Start > Start) | false | false |  |  |
| PreviousElement | Module.BusinessObjects.Audio | Trước | No | SetDefaultPreviousElement: result<br>GetDefaultPreviousElement: Video.GetAudioListWithSort(BookMark, false, TranslateObject).FirstOrDefault(x => x.Start < Start) | false | false |  |  |
| Status | Status | Trạng thái | No | GetDefaultStatus: Status<br>SetDefaultStatus: result | false | false |  |  |
| UpperElement | Module.BusinessObjects.Audio | Cấp trên | No | GetDefaultUpperElement: UpperElement<br>SetDefaultUpperElement: result | false | false |  |  |
| TextNode | bool | Nốt | No | GetDefaultTextNode: TextNode<br>SetDefaultTextNode: result | false | false |  |  |
| NotAdjacent | bool | Không kề sau | No | GetDefaultNotAdjacent: NotAdjacent<br>SetDefaultNotAdjacent: result | false | false |  |  |
| LinePageContent | string | Dòng trang ND | No | GetDefaultLinePageContent: LinePageContent<br>SetDefaultLinePageContent: result | false | false |  |  |
| LinePageTranslate | string | Dòng trang Dịch | No | GetDefaultLinePageTranslate: LinePageTranslate<br>SetDefaultLinePageTranslate: result | false | false |  |  |
| ParentTag | string | Thẻ cha | No | GetDefaultParentTag: ParentTag<br>SetDefaultParentTag: result | false | false |  |  |
| CaseType | CaseType | Kiểu chữ | No | SetDefaultCaseType: result<br>GetDefaultCaseType: CaseType.UpperCaseAll | false | false |  |  |
| BookMark | Module.BusinessObjects.BookMark | Liên kết | No | GetDefaultBookMark: BookMark<br>SetDefaultBookMark: result | false | false |  |  |
| TranslateObject | Module.BusinessObjects.TranslateObject | Đối tượng dịch | No | GetDefaultTranslateObject: TranslateObject<br>SetDefaultTranslateObject: result | false | false |  |  |
| Flag | bool | Cờ | No | GetDefaultFlag: Flag<br>SetDefaultFlag: result | false | false |  |  |
| Flag2 | bool | Cờ 2 | No | GetDefaultFlag2: Flag2<br>SetDefaultFlag2: result | false | false |  |  |
| Note2 | string | Ghi chú 2 | No | GetDefaultNote2: Note2<br>SetDefaultNote2: result | false | false |  |  |
| Speaker | string | Người nói | No | GetDefaultSpeaker: Speaker<br>SetDefaultSpeaker: result | false | false |  |  |
| ElementBatch | Module.BusinessObjects.ElementBatch | Lô | No | GetDefaultElementBatch: ElementBatch<br>SetDefaultElementBatch: result | false | false |  |  |
| LanguageTranslate | string | Dịch ngữ | No | GetDefaultLanguageTranslate: LanguageTranslate<br>SetDefaultLanguageTranslate: result | false | false |  |  |
| Order | int? | Thứ tự | No |  | false | false |  |  |
| Paragraph | Module.BusinessObjects.Paragraph | Đoạn văn bản | No | GetDefaultParagraph: Paragraph<br>SetDefaultParagraph: result | false | false |  |  |

## Default Logic

Field: Start  
Default: Start  
Source: `GetDefaultStart()`  
Logic: { return Start; }

Field: Start  
Default: result  
Source: `SetDefaultStart()`  
Logic: { //if (Start is null){ // var result = GetDefaultStart(view); // if (result != null && result != Start){ // Start = result; // } //} }

Field: End  
Default: End  
Source: `GetDefaultEnd()`  
Logic: { return End; }

Field: End  
Default: result  
Source: `SetDefaultEnd()`  
Logic: { //if (End is null){ // var result = GetDefaultEnd(view); // if (result != null && result != End){ // End = result; // } //} }

Field: Voice  
Default: Voice  
Source: `GetDefaultVoice()`  
Logic: { return Voice; }

Field: Voice  
Default: result  
Source: `SetDefaultVoice()`  
Logic: { //if (Voice is null){ // var result = GetDefaultVoice(view); // if (result != null && result != Voice){ // Voice = result; // } //} }

Field: VoiceSpeed  
Default: VoiceSpeed  
Source: `GetDefaultVoiceSpeed()`  
Logic: { return VoiceSpeed; }

Field: VoiceSpeed  
Default: result  
Source: `SetDefaultVoiceSpeed()`  
Logic: { //if (VoiceSpeed is null){ // var result = GetDefaultVoiceSpeed(view); // if (result != null && result != VoiceSpeed){ // VoiceSpeed = result; // } //} }

Field: Content  
Default: Content  
Source: `GetDefaultContent()`  
Logic: { return Content; }

Field: Content  
Default: result  
Source: `SetDefaultContent()`  
Logic: { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} }

Field: Subtitle  
Default: Subtitle  
Source: `GetDefaultSubtitle()`  
Logic: { return Subtitle; }

Field: Subtitle  
Default: result  
Source: `SetDefaultSubtitle()`  
Logic: { //if (Subtitle is null){ // var result = GetDefaultSubtitle(view); // if (result != null && result != Subtitle){ // Subtitle = result; // } //} }

Field: Spelling  
Default: Spelling  
Source: `GetDefaultSpelling()`  
Logic: { return Spelling; }

Field: Spelling  
Default: result  
Source: `SetDefaultSpelling()`  
Logic: { //if (Spelling is null){ // var result = GetDefaultSpelling(view); // if (result != null && result != Spelling){ // Spelling = result; // } //} }

Field: Video  
Default: Video  
Source: `GetDefaultVideo()`  
Logic: { return Video; }

Field: Video  
Default: result  
Source: `SetDefaultVideo()`  
Logic: { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} }

Field: ParagraphStyle  
Default: ParagraphStyle  
Source: `GetDefaultParagraphStyle()`  
Logic: { return ParagraphStyle; }

Field: ParagraphStyle  
Default: result  
Source: `SetDefaultParagraphStyle()`  
Logic: { //if (ParagraphStyle is null){ // var result = GetDefaultParagraphStyle(view); // if (result != null && result != ParagraphStyle){ // ParagraphStyle = result; // } //} }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 0048 Oid: 0a234f7c-ee1c-4410-9580-c374870c55ef if (!IsDeleted) Update = GetDefaultUpdate(); }

Field: Update  
Default: System.DateTime.Now  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 0136 Oid: 5a2a5740-6f37-4cc5-ac23-b2ada42c08fc return System.DateTime.Now; }

Field: URL  
Default: URL  
Source: `GetDefaultURL()`  
Logic: { return URL; }

Field: URL  
Default: result  
Source: `SetDefaultURL()`  
Logic: { //if (URL is null){ // var result = GetDefaultURL(view); // if (result != null && result != URL){ // URL = result; // } //} }

Field: FileData  
Default: FileData  
Source: `GetDefaultFileData()`  
Logic: { return FileData; }

Field: FileData  
Default: result  
Source: `SetDefaultFileData()`  
Logic: { //if (FileData is null){ // var result = GetDefaultFileData(view); // if (result != null && result != FileData){ // FileData = result; // } //} }

Field: AudioLink  
Default: AudioLink  
Source: `GetDefaultAudioLink()`  
Logic: { return AudioLink; }

Field: AudioLink  
Default: result  
Source: `SetDefaultAudioLink()`  
Logic: { //if (AudioLink is null){ // var result = GetDefaultAudioLink(view); // if (result != null && result != AudioLink){ // AudioLink = result; // } //} }

Field: AudioDuration  
Default: result  
Source: `SetDefaultAudioDuration()`  
Logic: { //if (AudioDuration is null){ // var result = GetDefaultAudioDuration(view); // if (result != null && result != AudioDuration){ // AudioDuration = result; // } //} }

Field: AudioDuration  
Default: Computed in GetDefaultAudioDuration  
Source: `GetDefaultAudioDuration()`  
Logic: { //Code: 0574 Oid: 42d3b1de-3ad8-457f-82f2-a3b131623217 if (FileData != null && FileData.Content != null) { string audioFolder = System.IO.Directory.GetCurrentDirectory() + "\\Audio"; if (!System.IO.Directory.Exists(audioFolder)) System.IO.Directory.CreateDir...

Field: AudioRate  
Default: AudioRate  
Source: `GetDefaultAudioRate()`  
Logic: { return AudioRate; }

Field: AudioRate  
Default: result  
Source: `SetDefaultAudioRate()`  
Logic: { //if (AudioRate is null){ // var result = GetDefaultAudioRate(view); // if (result != null && result != AudioRate){ // AudioRate = result; // } //} }

Field: Duration  
Default: Duration  
Source: `GetDefaultDuration()`  
Logic: { return Duration; }

Field: Duration  
Default: result  
Source: `SetDefaultDuration()`  
Logic: { //if (Duration is null){ // var result = GetDefaultDuration(view); // if (result != null && result != Duration){ // Duration = result; // } //} }

Field: SilenceGap  
Default: SilenceGap  
Source: `GetDefaultSilenceGap()`  
Logic: { return SilenceGap; }

Field: SilenceGap  
Default: result  
Source: `SetDefaultSilenceGap()`  
Logic: { //if (SilenceGap is null){ // var result = GetDefaultSilenceGap(view); // if (result != null && result != SilenceGap){ // SilenceGap = result; // } //} }

Field: Quantity  
Default: result  
Source: `SetDefaultQuantity()`  
Logic: { //if (Quantity is null){ // var result = GetDefaultQuantity(view); // if (result != null && result != Quantity){ // Quantity = result; // } //} }

Field: Quantity  
Default: Computed in GetDefaultQuantity  
Source: `GetDefaultQuantity()`  
Logic: { //Code: 0560 Oid: 1be69bb7-9333-44a4-8b5a-c46836eda9ac //End == null là trường hợp không phải phụ đề if (!string.IsNullOrEmpty(Content) && End != null) { string languageCode = (Video != null && Video.LanguageOrigin != null) ? Video.LanguageOrigin.Code : null...

Field: TextRate  
Default: TextRate  
Source: `GetDefaultTextRate()`  
Logic: { return TextRate; }

Field: TextRate  
Default: result  
Source: `SetDefaultTextRate()`  
Logic: { //if (TextRate is null){ // var result = GetDefaultTextRate(view); // if (result != null && result != TextRate){ // TextRate = result; // } //} }

Field: SubtitleTime  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultSubtitleTime()`  
Logic: { //Code: 0529 Oid: 4738915c-a526-444c-9743-cebfd1712d35 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: SubtitleTime  
Default: GetDefaultSubtitleTime()  
Source: `SetDefaultSubtitleTime()`  
Logic: { //Code: 0532 Oid: 78ed577d-8863-4a5a-b9eb-11643408bc70 SubtitleTime= GetDefaultSubtitleTime(); }

Field: SpellingTime  
Default: GetDefaultSpellingTime()  
Source: `SetDefaultSpellingTime()`  
Logic: { //Code: 0533 Oid: 01fc71e7-b842-4f9e-b2eb-8f65a3ff4859 SpellingTime= GetDefaultSpellingTime(); }

Field: SpellingTime  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultSpellingTime()`  
Logic: { //Code: 0530 Oid: 6c10ba4b-4d0b-493e-88fc-a04bf3d6edee return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: AudioTime  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultAudioTime()`  
Logic: { //Code: 0531 Oid: ddf39b7a-6632-4789-8373-103fb94480ff return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: AudioTime  
Default: GetDefaultAudioTime()  
Source: `SetDefaultAudioTime()`  
Logic: { //Code: 0534 Oid: e7982100-4397-44c0-a3f5-f09c226c15b2 AudioTime= GetDefaultAudioTime(); }

Field: Splitted  
Default: Splitted  
Source: `GetDefaultSplitted()`  
Logic: { return Splitted; }

Field: Splitted  
Default: result  
Source: `SetDefaultSplitted()`  
Logic: { //if (Splitted is null){ // var result = GetDefaultSplitted(view); // if (result != null && result != Splitted){ // Splitted = result; // } //} }

Field: Note  
Default: Note  
Source: `GetDefaultNote()`  
Logic: { return Note; }

Field: Note  
Default: result  
Source: `SetDefaultNote()`  
Logic: { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} }

Field: Delete  
Default: Delete  
Source: `GetDefaultDelete()`  
Logic: { return Delete; }

Field: Delete  
Default: result  
Source: `SetDefaultDelete()`  
Logic: { //if (Delete is null){ // var result = GetDefaultDelete(view); // if (result != null && result != Delete){ // Delete = result; // } //} }

Field: NextElement  
Default: result  
Source: `SetDefaultNextElement()`  
Logic: { //if (NextElement is null){ // var result = GetDefaultNextElement(view); // if (result != null && result != NextElement){ // NextElement = result; // } //} }

Field: NextElement  
Default: Video.GetAudioListWithSort(BookMark, true, TranslateObject).FirstOrDefault(x => x.Start > Start)  
Source: `GetDefaultNextElement()`  
Logic: { //Code: 1524 Oid: c43970ab-9112-4cd4-bb75-c01278e2461c if (Video != null && Start != null) { return Video.GetAudioListWithSort(BookMark, true, TranslateObject).FirstOrDefault(x => x.Start > Start); } return null; }

Field: PreviousElement  
Default: result  
Source: `SetDefaultPreviousElement()`  
Logic: { //if (PreviousElement is null){ // var result = GetDefaultPreviousElement(view); // if (result != null && result != PreviousElement){ // PreviousElement = result; // } //} }

Field: PreviousElement  
Default: Video.GetAudioListWithSort(BookMark, false, TranslateObject).FirstOrDefault(x => x.Start < Start)  
Source: `GetDefaultPreviousElement()`  
Logic: { //Code: 1525 Oid: 342d3aac-e07f-4173-afb8-03746dee9dd4 if(Video != null && Start != null) { return Video.GetAudioListWithSort(BookMark, false, TranslateObject).FirstOrDefault(x => x.Start < Start); } return null; }

Field: Status  
Default: Status  
Source: `GetDefaultStatus()`  
Logic: { return Status; }

Field: Status  
Default: result  
Source: `SetDefaultStatus()`  
Logic: { //if (Status is null){ // var result = GetDefaultStatus(view); // if (result != null && result != Status){ // Status = result; // } //} }

Field: UpperElement  
Default: UpperElement  
Source: `GetDefaultUpperElement()`  
Logic: { return UpperElement; }

Field: UpperElement  
Default: result  
Source: `SetDefaultUpperElement()`  
Logic: { //if (UpperElement is null){ // var result = GetDefaultUpperElement(view); // if (result != null && result != UpperElement){ // UpperElement = result; // } //} }

Field: TextNode  
Default: TextNode  
Source: `GetDefaultTextNode()`  
Logic: { return TextNode; }

Field: TextNode  
Default: result  
Source: `SetDefaultTextNode()`  
Logic: { //if (TextNode is null){ // var result = GetDefaultTextNode(view); // if (result != null && result != TextNode){ // TextNode = result; // } //} }

Field: NotAdjacent  
Default: NotAdjacent  
Source: `GetDefaultNotAdjacent()`  
Logic: { return NotAdjacent; }

Field: NotAdjacent  
Default: result  
Source: `SetDefaultNotAdjacent()`  
Logic: { //if (NotAdjacent is null){ // var result = GetDefaultNotAdjacent(view); // if (result != null && result != NotAdjacent){ // NotAdjacent = result; // } //} }

Field: LinePageContent  
Default: LinePageContent  
Source: `GetDefaultLinePageContent()`  
Logic: { return LinePageContent; }

Field: LinePageContent  
Default: result  
Source: `SetDefaultLinePageContent()`  
Logic: { //if (LinePageContent is null){ // var result = GetDefaultLinePageContent(view); // if (result != null && result != LinePageContent){ // LinePageContent = result; // } //} }

Field: LinePageTranslate  
Default: LinePageTranslate  
Source: `GetDefaultLinePageTranslate()`  
Logic: { return LinePageTranslate; }

Field: LinePageTranslate  
Default: result  
Source: `SetDefaultLinePageTranslate()`  
Logic: { //if (LinePageTranslate is null){ // var result = GetDefaultLinePageTranslate(view); // if (result != null && result != LinePageTranslate){ // LinePageTranslate = result; // } //} }

Field: ParentTag  
Default: ParentTag  
Source: `GetDefaultParentTag()`  
Logic: { return ParentTag; }

Field: ParentTag  
Default: result  
Source: `SetDefaultParentTag()`  
Logic: { //if (ParentTag is null){ // var result = GetDefaultParentTag(view); // if (result != null && result != ParentTag){ // ParentTag = result; // } //} }

Field: CaseType  
Default: result  
Source: `SetDefaultCaseType()`  
Logic: { //if (CaseType is null){ // var result = GetDefaultCaseType(view); // if (result != null && result != CaseType){ // CaseType = result; // } //} }

Field: CaseType  
Default: CaseType.UpperCaseAll  
Source: `GetDefaultCaseType()`  
Logic: { //Code: 1074 Oid: c82486d0-382f-4e6f-9da5-3433c915eb56 if (!string.IsNullOrEmpty(Content) && Video != null) { if (Module.Helpers.TextHelper.CheckUpperCaseAll(Content)) return CaseType.UpperCaseAll; if(Module.Services.AudioService.ElementFlagUpperCase(Video, ...

Field: BookMark  
Default: BookMark  
Source: `GetDefaultBookMark()`  
Logic: { return BookMark; }

Field: BookMark  
Default: result  
Source: `SetDefaultBookMark()`  
Logic: { //if (BookMark is null){ // var result = GetDefaultBookMark(view); // if (result != null && result != BookMark){ // BookMark = result; // } //} }

Field: TranslateObject  
Default: TranslateObject  
Source: `GetDefaultTranslateObject()`  
Logic: { return TranslateObject; }

Field: TranslateObject  
Default: result  
Source: `SetDefaultTranslateObject()`  
Logic: { //if (TranslateObject is null){ // var result = GetDefaultTranslateObject(view); // if (result != null && result != TranslateObject){ // TranslateObject = result; // } //} }

Field: Flag  
Default: Flag  
Source: `GetDefaultFlag()`  
Logic: { return Flag; }

Field: Flag  
Default: result  
Source: `SetDefaultFlag()`  
Logic: { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} }

Field: Flag2  
Default: Flag2  
Source: `GetDefaultFlag2()`  
Logic: { return Flag2; }

Field: Flag2  
Default: result  
Source: `SetDefaultFlag2()`  
Logic: { //if (Flag2 is null){ // var result = GetDefaultFlag2(view); // if (result != null && result != Flag2){ // Flag2 = result; // } //} }

Field: Note2  
Default: Note2  
Source: `GetDefaultNote2()`  
Logic: { return Note2; }

Field: Note2  
Default: result  
Source: `SetDefaultNote2()`  
Logic: { //if (Note2 is null){ // var result = GetDefaultNote2(view); // if (result != null && result != Note2){ // Note2 = result; // } //} }

Field: Speaker  
Default: Speaker  
Source: `GetDefaultSpeaker()`  
Logic: { return Speaker; }

Field: Speaker  
Default: result  
Source: `SetDefaultSpeaker()`  
Logic: { //if (Speaker is null){ // var result = GetDefaultSpeaker(view); // if (result != null && result != Speaker){ // Speaker = result; // } //} }

Field: ElementBatch  
Default: ElementBatch  
Source: `GetDefaultElementBatch()`  
Logic: { return ElementBatch; }

Field: ElementBatch  
Default: result  
Source: `SetDefaultElementBatch()`  
Logic: { //if (ElementBatch is null){ // var result = GetDefaultElementBatch(view); // if (result != null && result != ElementBatch){ // ElementBatch = result; // } //} }

Field: LanguageTranslate  
Default: LanguageTranslate  
Source: `GetDefaultLanguageTranslate()`  
Logic: { return LanguageTranslate; }

Field: LanguageTranslate  
Default: result  
Source: `SetDefaultLanguageTranslate()`  
Logic: { //if (LanguageTranslate is null){ // var result = GetDefaultLanguageTranslate(view); // if (result != null && result != LanguageTranslate){ // LanguageTranslate = result; // } //} }

Field: Paragraph  
Default: Paragraph  
Source: `GetDefaultParagraph()`  
Logic: { return Paragraph; }

Field: Paragraph  
Default: result  
Source: `SetDefaultParagraph()`  
Logic: { //if (Paragraph is null){ // var result = GetDefaultParagraph(view); // if (result != null && result != Paragraph){ // Paragraph = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 0378ImportCode base.AfterConstruction(); SetDefaultUpdate(); VoiceSpeed = 1; #endregion 0378ImportCode //SetDefaultStart(View view = null); //SetDefaultEnd(View view = null); //SetDefaultVoice(View view = null); //SetDefaultVoic...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 0475ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0475ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- AudioDuration [Detail=false]
- AudioLink [Detail=false]
- AudioRate [Detail=false]
- AudioTime [Detail=false]
- BookMark [Detail=false]
- CaseType [Detail=false]
- Delete [Detail=false]
- Duration [Detail=false]
- ElementBatch [Detail=false]
- ElementTranslateList [Detail=true]
- FileData [Detail=false]
- Flag [Detail=false]
- Flag2 [Detail=false]
- LanguageTranslate [Detail=false]
- LinePageContent [Detail=false]
- LinePageTranslate [Detail=false]
- MediaList [Detail=true]
- NextElement [Detail=false]
- NotAdjacent [Detail=false]
- Note [Detail=false]
- Note2 [Detail=false]
- Order [Detail=false]
- Paragraph [Detail=false]
- ParagraphStyle [Detail=false]
- ParentTag [Detail=false]
- PreviousElement [Detail=false]
- Quantity [Detail=false]
- SilenceGap [Detail=false]
- Speaker [Detail=false]
- SpellingTime [Detail=false]
- Splitted [Detail=false]
- Status [Detail=false]
- SubtitleTime [Detail=false]
- TermLocationList [Detail=true]
- TextNode [Detail=false]
- TextRate [Detail=false]
- TranslateObject [Detail=false]
- URL [Detail=false]
- Update [Detail=false]
- UpperElement [Detail=false]
- Video [Detail=false]

Group: (default)
- Content [Order=1] [Detail=true]
- End [Order=1] [Detail=true]
- Spelling [Order=1] [Detail=true]
- Start [Order=1] [Detail=true]
- Subtitle [Order=1] [Detail=true]
- Voice [Order=1] [Detail=true]
- VoiceSpeed [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | Audio | { Oid = Guid.NewGuid(); #region 0378ImportCode base.AfterConstruction(); SetDefaultUpdate(); VoiceSpeed = 1; #endregion 0378ImportCode //SetDefaultStart(View view = null); //SetDefaultEnd(View view = null); //SetDefaultVoice(View view = null); //SetDefaultVoic... |
| GetDefaultAudioDuration | Audio | { //Code: 0574 Oid: 42d3b1de-3ad8-457f-82f2-a3b131623217 if (FileData != null && FileData.Content != null) { string audioFolder = System.IO.Directory.GetCurrentDirectory() + "\\Audio"; if (!System.IO.Directory.Exists(audioFolder)) System.IO.Directory.CreateDir... |
| GetDefaultAudioLink | Audio | { return AudioLink; } |
| GetDefaultAudioRate | Audio | { return AudioRate; } |
| GetDefaultAudioTime | Audio | { //Code: 0531 Oid: ddf39b7a-6632-4789-8373-103fb94480ff return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultBookMark | Audio | { return BookMark; } |
| GetDefaultCaseType | Audio | { //Code: 1074 Oid: c82486d0-382f-4e6f-9da5-3433c915eb56 if (!string.IsNullOrEmpty(Content) && Video != null) { if (Module.Helpers.TextHelper.CheckUpperCaseAll(Content)) return CaseType.UpperCaseAll; if(Module.Services.AudioService.ElementFlagUpperCase(Video, ... |
| GetDefaultContent | Audio | { return Content; } |
| GetDefaultDelete | Audio | { return Delete; } |
| GetDefaultDuration | Audio | { return Duration; } |
| GetDefaultElementBatch | Audio | { return ElementBatch; } |
| GetDefaultEnd | Audio | { return End; } |
| GetDefaultFileData | Audio | { return FileData; } |
| GetDefaultFlag | Audio | { return Flag; } |
| GetDefaultFlag2 | Audio | { return Flag2; } |
| GetDefaultLanguageTranslate | Audio | { return LanguageTranslate; } |
| GetDefaultLinePageContent | Audio | { return LinePageContent; } |
| GetDefaultLinePageTranslate | Audio | { return LinePageTranslate; } |
| GetDefaultNextElement | Audio | { //Code: 1524 Oid: c43970ab-9112-4cd4-bb75-c01278e2461c if (Video != null && Start != null) { return Video.GetAudioListWithSort(BookMark, true, TranslateObject).FirstOrDefault(x => x.Start > Start); } return null; } |
| GetDefaultNotAdjacent | Audio | { return NotAdjacent; } |
| GetDefaultNote | Audio | { return Note; } |
| GetDefaultNote2 | Audio | { return Note2; } |
| GetDefaultParagraph | Audio | { return Paragraph; } |
| GetDefaultParagraphStyle | Audio | { return ParagraphStyle; } |
| GetDefaultParentTag | Audio | { return ParentTag; } |
| GetDefaultPreviousElement | Audio | { //Code: 1525 Oid: 342d3aac-e07f-4173-afb8-03746dee9dd4 if(Video != null && Start != null) { return Video.GetAudioListWithSort(BookMark, false, TranslateObject).FirstOrDefault(x => x.Start < Start); } return null; } |
| GetDefaultQuantity | Audio | { //Code: 0560 Oid: 1be69bb7-9333-44a4-8b5a-c46836eda9ac //End == null là trường hợp không phải phụ đề if (!string.IsNullOrEmpty(Content) && End != null) { string languageCode = (Video != null && Video.LanguageOrigin != null) ? Video.LanguageOrigin.Code : null... |
| GetDefaultSilenceGap | Audio | { return SilenceGap; } |
| GetDefaultSpeaker | Audio | { return Speaker; } |
| GetDefaultSpelling | Audio | { return Spelling; } |
| GetDefaultSpellingTime | Audio | { //Code: 0530 Oid: 6c10ba4b-4d0b-493e-88fc-a04bf3d6edee return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultSplitted | Audio | { return Splitted; } |
| GetDefaultStart | Audio | { return Start; } |
| GetDefaultStatus | Audio | { return Status; } |
| GetDefaultSubtitle | Audio | { return Subtitle; } |
| GetDefaultSubtitleTime | Audio | { //Code: 0529 Oid: 4738915c-a526-444c-9743-cebfd1712d35 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultTextNode | Audio | { return TextNode; } |
| GetDefaultTextRate | Audio | { return TextRate; } |
| GetDefaultTranslateObject | Audio | { return TranslateObject; } |
| GetDefaultURL | Audio | { return URL; } |
| GetDefaultUpdate | Audio | { //Code: 0136 Oid: 5a2a5740-6f37-4cc5-ac23-b2ada42c08fc return System.DateTime.Now; } |
| GetDefaultUpperElement | Audio | { return UpperElement; } |
| GetDefaultVideo | Audio | { return Video; } |
| GetDefaultVoice | Audio | { return Voice; } |
| GetDefaultVoiceSpeed | Audio | { return VoiceSpeed; } |
| OnLoaded | Audio | { base.OnLoaded(); } |
| OnSaving | Audio | { #region 0475ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0475ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ... |
| SetDefaultAudioDuration | Audio | { //if (AudioDuration is null){ // var result = GetDefaultAudioDuration(view); // if (result != null && result != AudioDuration){ // AudioDuration = result; // } //} } |
| SetDefaultAudioLink | Audio | { //if (AudioLink is null){ // var result = GetDefaultAudioLink(view); // if (result != null && result != AudioLink){ // AudioLink = result; // } //} } |
| SetDefaultAudioRate | Audio | { //if (AudioRate is null){ // var result = GetDefaultAudioRate(view); // if (result != null && result != AudioRate){ // AudioRate = result; // } //} } |
| SetDefaultAudioTime | Audio | { //Code: 0534 Oid: e7982100-4397-44c0-a3f5-f09c226c15b2 AudioTime= GetDefaultAudioTime(); } |
| SetDefaultBookMark | Audio | { //if (BookMark is null){ // var result = GetDefaultBookMark(view); // if (result != null && result != BookMark){ // BookMark = result; // } //} } |
| SetDefaultCaseType | Audio | { //if (CaseType is null){ // var result = GetDefaultCaseType(view); // if (result != null && result != CaseType){ // CaseType = result; // } //} } |
| SetDefaultContent | Audio | { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} } |
| SetDefaultDelete | Audio | { //if (Delete is null){ // var result = GetDefaultDelete(view); // if (result != null && result != Delete){ // Delete = result; // } //} } |
| SetDefaultDuration | Audio | { //if (Duration is null){ // var result = GetDefaultDuration(view); // if (result != null && result != Duration){ // Duration = result; // } //} } |
| SetDefaultElementBatch | Audio | { //if (ElementBatch is null){ // var result = GetDefaultElementBatch(view); // if (result != null && result != ElementBatch){ // ElementBatch = result; // } //} } |
| SetDefaultEnd | Audio | { //if (End is null){ // var result = GetDefaultEnd(view); // if (result != null && result != End){ // End = result; // } //} } |
| SetDefaultFileData | Audio | { //if (FileData is null){ // var result = GetDefaultFileData(view); // if (result != null && result != FileData){ // FileData = result; // } //} } |
| SetDefaultFlag | Audio | { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} } |
| SetDefaultFlag2 | Audio | { //if (Flag2 is null){ // var result = GetDefaultFlag2(view); // if (result != null && result != Flag2){ // Flag2 = result; // } //} } |
| SetDefaultLanguageTranslate | Audio | { //if (LanguageTranslate is null){ // var result = GetDefaultLanguageTranslate(view); // if (result != null && result != LanguageTranslate){ // LanguageTranslate = result; // } //} } |
| SetDefaultLinePageContent | Audio | { //if (LinePageContent is null){ // var result = GetDefaultLinePageContent(view); // if (result != null && result != LinePageContent){ // LinePageContent = result; // } //} } |
| SetDefaultLinePageTranslate | Audio | { //if (LinePageTranslate is null){ // var result = GetDefaultLinePageTranslate(view); // if (result != null && result != LinePageTranslate){ // LinePageTranslate = result; // } //} } |
| SetDefaultNextElement | Audio | { //if (NextElement is null){ // var result = GetDefaultNextElement(view); // if (result != null && result != NextElement){ // NextElement = result; // } //} } |
| SetDefaultNotAdjacent | Audio | { //if (NotAdjacent is null){ // var result = GetDefaultNotAdjacent(view); // if (result != null && result != NotAdjacent){ // NotAdjacent = result; // } //} } |
| SetDefaultNote | Audio | { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} } |
| SetDefaultNote2 | Audio | { //if (Note2 is null){ // var result = GetDefaultNote2(view); // if (result != null && result != Note2){ // Note2 = result; // } //} } |
| SetDefaultParagraph | Audio | { //if (Paragraph is null){ // var result = GetDefaultParagraph(view); // if (result != null && result != Paragraph){ // Paragraph = result; // } //} } |
| SetDefaultParagraphStyle | Audio | { //if (ParagraphStyle is null){ // var result = GetDefaultParagraphStyle(view); // if (result != null && result != ParagraphStyle){ // ParagraphStyle = result; // } //} } |
| SetDefaultParentTag | Audio | { //if (ParentTag is null){ // var result = GetDefaultParentTag(view); // if (result != null && result != ParentTag){ // ParentTag = result; // } //} } |
| SetDefaultPreviousElement | Audio | { //if (PreviousElement is null){ // var result = GetDefaultPreviousElement(view); // if (result != null && result != PreviousElement){ // PreviousElement = result; // } //} } |
| SetDefaultQuantity | Audio | { //if (Quantity is null){ // var result = GetDefaultQuantity(view); // if (result != null && result != Quantity){ // Quantity = result; // } //} } |
| SetDefaultSilenceGap | Audio | { //if (SilenceGap is null){ // var result = GetDefaultSilenceGap(view); // if (result != null && result != SilenceGap){ // SilenceGap = result; // } //} } |
| SetDefaultSpeaker | Audio | { //if (Speaker is null){ // var result = GetDefaultSpeaker(view); // if (result != null && result != Speaker){ // Speaker = result; // } //} } |
| SetDefaultSpelling | Audio | { //if (Spelling is null){ // var result = GetDefaultSpelling(view); // if (result != null && result != Spelling){ // Spelling = result; // } //} } |
| SetDefaultSpellingTime | Audio | { //Code: 0533 Oid: 01fc71e7-b842-4f9e-b2eb-8f65a3ff4859 SpellingTime= GetDefaultSpellingTime(); } |
| SetDefaultSplitted | Audio | { //if (Splitted is null){ // var result = GetDefaultSplitted(view); // if (result != null && result != Splitted){ // Splitted = result; // } //} } |
| SetDefaultStart | Audio | { //if (Start is null){ // var result = GetDefaultStart(view); // if (result != null && result != Start){ // Start = result; // } //} } |
| SetDefaultStatus | Audio | { //if (Status is null){ // var result = GetDefaultStatus(view); // if (result != null && result != Status){ // Status = result; // } //} } |
| SetDefaultSubtitle | Audio | { //if (Subtitle is null){ // var result = GetDefaultSubtitle(view); // if (result != null && result != Subtitle){ // Subtitle = result; // } //} } |
| SetDefaultSubtitleTime | Audio | { //Code: 0532 Oid: 78ed577d-8863-4a5a-b9eb-11643408bc70 SubtitleTime= GetDefaultSubtitleTime(); } |
| SetDefaultTextNode | Audio | { //if (TextNode is null){ // var result = GetDefaultTextNode(view); // if (result != null && result != TextNode){ // TextNode = result; // } //} } |
| SetDefaultTextRate | Audio | { //if (TextRate is null){ // var result = GetDefaultTextRate(view); // if (result != null && result != TextRate){ // TextRate = result; // } //} } |
| SetDefaultTranslateObject | Audio | { //if (TranslateObject is null){ // var result = GetDefaultTranslateObject(view); // if (result != null && result != TranslateObject){ // TranslateObject = result; // } //} } |
| SetDefaultURL | Audio | { //if (URL is null){ // var result = GetDefaultURL(view); // if (result != null && result != URL){ // URL = result; // } //} } |
| SetDefaultUpdate | Audio | { //Code: 0048 Oid: 0a234f7c-ee1c-4410-9580-c374870c55ef if (!IsDeleted) Update = GetDefaultUpdate(); } |
| SetDefaultUpperElement | Audio | { //if (UpperElement is null){ // var result = GetDefaultUpperElement(view); // if (result != null && result != UpperElement){ // UpperElement = result; // } //} } |
| SetDefaultVideo | Audio | { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} } |
| SetDefaultVoice | Audio | { //if (Voice is null){ // var result = GetDefaultVoice(view); // if (result != null && result != Voice){ // Voice = result; // } //} } |
| SetDefaultVoiceSpeed | Audio | { //if (VoiceSpeed is null){ // var result = GetDefaultVoiceSpeed(view); // if (result != null && result != VoiceSpeed){ // VoiceSpeed = result; // } //} } |

---

# Entity: BatchTranslate

Caption entity: `Dịch lô`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Language | Module.BusinessObjects.Language | Ngữ dịch | No | GetDefaultLanguage: Language<br>SetDefaultLanguage: result | true | true |   | 1 |
| LineQuantity | int? | Dòng xuôi | No | GetDefaultLineQuantity: LineQuantity<br>SetDefaultLineQuantity: result | false | true |   | 1 |
| Content | string | Dịch xuôi | No | GetDefaultContent: Content<br>SetDefaultContent: result | true | true |   | 1 |
| OriginLanguage | Module.BusinessObjects.Language | Ngữ gốc | No | GetDefaultOriginLanguage: OriginLanguage<br>SetDefaultOriginLanguage: result | false | true |   | 1 |
| TranslateLineQuantity | int? | Dòng ngược | No | GetDefaultTranslateLineQuantity: TranslateLineQuantity<br>SetDefaultTranslateLineQuantity: result | false | true |   | 1 |
| Translate | string | Dịch ngược | No | GetDefaultTranslate: Translate<br>SetDefaultTranslate: result | false | true |   | 1 |
| Translate2 | string | Dịch Google | No | GetDefaultTranslate2: Translate2<br>SetDefaultTranslate2: result | false | true |   | 1 |
| ElementBatch | Module.BusinessObjects.ElementBatch | Lô thành phần | No | GetDefaultElementBatch: ElementBatch<br>SetDefaultElementBatch: result | false | false |  |  |
| Translate2LineQuantity | int? | Dòng Google | No | GetDefaultTranslate2LineQuantity: Translate2LineQuantity<br>SetDefaultTranslate2LineQuantity: result | false | false |  |  |
| Display | bool |  | No |  |  |  |  |  |

## Default Logic

Field: Language  
Default: Language  
Source: `GetDefaultLanguage()`  
Logic: { return Language; }

Field: Language  
Default: result  
Source: `SetDefaultLanguage()`  
Logic: { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} }

Field: LineQuantity  
Default: LineQuantity  
Source: `GetDefaultLineQuantity()`  
Logic: { return LineQuantity; }

Field: LineQuantity  
Default: result  
Source: `SetDefaultLineQuantity()`  
Logic: { //if (LineQuantity is null){ // var result = GetDefaultLineQuantity(view); // if (result != null && result != LineQuantity){ // LineQuantity = result; // } //} }

Field: Content  
Default: Content  
Source: `GetDefaultContent()`  
Logic: { return Content; }

Field: Content  
Default: result  
Source: `SetDefaultContent()`  
Logic: { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} }

Field: OriginLanguage  
Default: OriginLanguage  
Source: `GetDefaultOriginLanguage()`  
Logic: { return OriginLanguage; }

Field: OriginLanguage  
Default: result  
Source: `SetDefaultOriginLanguage()`  
Logic: { //if (OriginLanguage is null){ // var result = GetDefaultOriginLanguage(view); // if (result != null && result != OriginLanguage){ // OriginLanguage = result; // } //} }

Field: TranslateLineQuantity  
Default: TranslateLineQuantity  
Source: `GetDefaultTranslateLineQuantity()`  
Logic: { return TranslateLineQuantity; }

Field: TranslateLineQuantity  
Default: result  
Source: `SetDefaultTranslateLineQuantity()`  
Logic: { //if (TranslateLineQuantity is null){ // var result = GetDefaultTranslateLineQuantity(view); // if (result != null && result != TranslateLineQuantity){ // TranslateLineQuantity = result; // } //} }

Field: Translate  
Default: Translate  
Source: `GetDefaultTranslate()`  
Logic: { return Translate; }

Field: Translate  
Default: result  
Source: `SetDefaultTranslate()`  
Logic: { //if (Translate is null){ // var result = GetDefaultTranslate(view); // if (result != null && result != Translate){ // Translate = result; // } //} }

Field: Translate2  
Default: Translate2  
Source: `GetDefaultTranslate2()`  
Logic: { return Translate2; }

Field: Translate2  
Default: result  
Source: `SetDefaultTranslate2()`  
Logic: { //if (Translate2 is null){ // var result = GetDefaultTranslate2(view); // if (result != null && result != Translate2){ // Translate2 = result; // } //} }

Field: ElementBatch  
Default: ElementBatch  
Source: `GetDefaultElementBatch()`  
Logic: { return ElementBatch; }

Field: ElementBatch  
Default: result  
Source: `SetDefaultElementBatch()`  
Logic: { //if (ElementBatch is null){ // var result = GetDefaultElementBatch(view); // if (result != null && result != ElementBatch){ // ElementBatch = result; // } //} }

Field: Translate2LineQuantity  
Default: Translate2LineQuantity  
Source: `GetDefaultTranslate2LineQuantity()`  
Logic: { return Translate2LineQuantity; }

Field: Translate2LineQuantity  
Default: result  
Source: `SetDefaultTranslate2LineQuantity()`  
Logic: { //if (Translate2LineQuantity is null){ // var result = GetDefaultTranslate2LineQuantity(view); // if (result != null && result != Translate2LineQuantity){ // Translate2LineQuantity = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); Display = true; //SetDefaultLanguage(View view = null); //SetDefaultLineQuantity(View view = null); //SetDefaultContent(View view = null); //SetDefaultOriginLanguage(View view = null); //SetDefaultTranslateLine...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- Display
- ElementBatch [Detail=false]
- Translate2LineQuantity [Detail=false]

Group: (default)
- Content [Order=1] [Detail=true]
- Language [Order=1] [Detail=true]
- LineQuantity [Order=1] [Detail=true]
- OriginLanguage [Order=1] [Detail=true]
- Translate [Order=1] [Detail=true]
- Translate2 [Order=1] [Detail=true]
- TranslateLineQuantity [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | BatchTranslate | { Oid = Guid.NewGuid(); base.AfterConstruction(); Display = true; //SetDefaultLanguage(View view = null); //SetDefaultLineQuantity(View view = null); //SetDefaultContent(View view = null); //SetDefaultOriginLanguage(View view = null); //SetDefaultTranslateLine... |
| GetDefaultContent | BatchTranslate | { return Content; } |
| GetDefaultElementBatch | BatchTranslate | { return ElementBatch; } |
| GetDefaultLanguage | BatchTranslate | { return Language; } |
| GetDefaultLineQuantity | BatchTranslate | { return LineQuantity; } |
| GetDefaultOriginLanguage | BatchTranslate | { return OriginLanguage; } |
| GetDefaultTranslate | BatchTranslate | { return Translate; } |
| GetDefaultTranslate2 | BatchTranslate | { return Translate2; } |
| GetDefaultTranslate2LineQuantity | BatchTranslate | { return Translate2LineQuantity; } |
| GetDefaultTranslateLineQuantity | BatchTranslate | { return TranslateLineQuantity; } |
| OnLoaded | BatchTranslate | { base.OnLoaded(); } |
| OnSaving | BatchTranslate | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultContent | BatchTranslate | { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} } |
| SetDefaultElementBatch | BatchTranslate | { //if (ElementBatch is null){ // var result = GetDefaultElementBatch(view); // if (result != null && result != ElementBatch){ // ElementBatch = result; // } //} } |
| SetDefaultLanguage | BatchTranslate | { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} } |
| SetDefaultLineQuantity | BatchTranslate | { //if (LineQuantity is null){ // var result = GetDefaultLineQuantity(view); // if (result != null && result != LineQuantity){ // LineQuantity = result; // } //} } |
| SetDefaultOriginLanguage | BatchTranslate | { //if (OriginLanguage is null){ // var result = GetDefaultOriginLanguage(view); // if (result != null && result != OriginLanguage){ // OriginLanguage = result; // } //} } |
| SetDefaultTranslate | BatchTranslate | { //if (Translate is null){ // var result = GetDefaultTranslate(view); // if (result != null && result != Translate){ // Translate = result; // } //} } |
| SetDefaultTranslate2 | BatchTranslate | { //if (Translate2 is null){ // var result = GetDefaultTranslate2(view); // if (result != null && result != Translate2){ // Translate2 = result; // } //} } |
| SetDefaultTranslate2LineQuantity | BatchTranslate | { //if (Translate2LineQuantity is null){ // var result = GetDefaultTranslate2LineQuantity(view); // if (result != null && result != Translate2LineQuantity){ // Translate2LineQuantity = result; // } //} } |
| SetDefaultTranslateLineQuantity | BatchTranslate | { //if (TranslateLineQuantity is null){ // var result = GetDefaultTranslateLineQuantity(view); // if (result != null && result != TranslateLineQuantity){ // TranslateLineQuantity = result; // } //} } |

---

# Entity: BookMark

Caption entity: `Liên kết`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: fileInfo.Name.Substring(0, fileInfo.Name.Length - fileInfo.Extension.Length)<br>SetDefaultName: GetDefaultName() | true | true |   | 1 |
| URL | string | Địa chỉ | No | GetDefaultURL: URL<br>SetDefaultURL: result | true | true |   | 1 |
| Product | Module.BusinessObjects.Product | Sản phẩm | No | GetDefaultProduct: Product<br>SetDefaultProduct: result | false | false |  |  |
| Image | byte[] | Ảnh | No | SetDefaultImage: result | false | true |   | 1 |
| Note | string | Ghi chú | No | GetDefaultNote: Note<br>SetDefaultNote: result | false | true |   | 1 |
| CreatedDate | DateTime? | Ngày | No | GetDefaultCreatedDate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)<br>SetDefaultCreatedDate: = null) CreatedDate = GetDefaultCreatedDate() | false | false |  |  |
| Update | DateTime? | Cập nhật | No | GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)<br>SetDefaultUpdate: GetDefaultUpdate() | false | false |  |  |
| Updater | Module.BusinessObjects.Member | Người cập nhật | No | SetDefaultUpdater: GetDefaultUpdater()<br>GetDefaultUpdater: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session) | false | false |  |  |
| Order | int? | Thứ tự | No | SetDefaultOrder: GetDefaultOrder()<br>GetDefaultOrder: Computed in GetDefaultOrder | false | false |  |  |
| Video | Module.BusinessObjects.Video | Tư liệu | No | GetDefaultVideo: Video<br>SetDefaultVideo: result | false | false |  |  |
| Member | Module.BusinessObjects.Member | Quản lý | No | SetDefaultMember: = null) Member = GetDefaultMember()<br>GetDefaultMember: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session) | false | false |  |  |
| Folder | Module.BusinessObjects.Folder | Thư mục | No | GetDefaultFolder: Folder<br>SetDefaultFolder: result | false | false |  |  |
| Quantity | int? | Số lượng | No | GetDefaultQuantity: Quantity<br>SetDefaultQuantity: result | false | false |  |  |
| Post | Module.BusinessObjects.Post | Bài viết | No | GetDefaultPost: Post<br>SetDefaultPost: result | false | false |  |  |
| Flag | bool | Cờ | No | GetDefaultFlag: Flag<br>SetDefaultFlag: result | false | false |  |  |
| LinkType | LinkType | Loại | No | GetDefaultLinkType: LinkType<br>SetDefaultLinkType: result | false | false |  |  |
| SystemType | System.Type | Kiểu hệ thống | No | SetDefaultSystemType: GetDefaultSystemType()<br>GetDefaultSystemType: Folder.SystemType | false | false |  |  |
| ObjectID | System.Guid | Mã đối tượng | No | GetDefaultObjectID: ObjectID<br>SetDefaultObjectID: result | false | false |  |  |
| SoftwareObjectType | SoftwareObjectType | Kiểu đối tượng | No | GetDefaultSoftwareObjectType: SoftwareObjectType<br>SetDefaultSoftwareObjectType: result | false | false |  |  |
| Xpath | string | Xpath | No | GetDefaultXpath: Xpath<br>SetDefaultXpath: result | false | false |  |  |
| Flag2 | bool | Cờ 2 | No | GetDefaultFlag2: Flag2<br>SetDefaultFlag2: result | false | false |  |  |
| ShowOpenHyperLink | bool |  | No |  |  |  |  |  |

## Default Logic

Field: Name  
Default: fileInfo.Name.Substring(0, fileInfo.Name.Length - fileInfo.Extension.Length)  
Source: `GetDefaultName()`  
Logic: { //Code: 1079 Oid: 1b19f5f5-bfea-41c3-8f32-c3feec593bf6 if (!string.IsNullOrEmpty(URL)) { var fileInfo = new System.IO.FileInfo(URL); return fileInfo.Name.Substring(0, fileInfo.Name.Length - fileInfo.Extension.Length); } return null; }

Field: Name  
Default: GetDefaultName()  
Source: `SetDefaultName()`  
Logic: { //Code: 1078 Oid: 3017ce85-be57-411c-b227-9a91b0725809 if(String.IsNullOrEmpty(Name)) Name = GetDefaultName(); }

Field: URL  
Default: URL  
Source: `GetDefaultURL()`  
Logic: { return URL; }

Field: URL  
Default: result  
Source: `SetDefaultURL()`  
Logic: { //if (URL is null){ // var result = GetDefaultURL(view); // if (result != null && result != URL){ // URL = result; // } //} }

Field: Product  
Default: Product  
Source: `GetDefaultProduct()`  
Logic: { return Product; }

Field: Product  
Default: result  
Source: `SetDefaultProduct()`  
Logic: { //if (Product is null){ // var result = GetDefaultProduct(view); // if (result != null && result != Product){ // Product = result; // } //} }

Field: Image  
Default: result  
Source: `SetDefaultImage()`  
Logic: { //if (Image is null){ // var result = GetDefaultImage(view); // if (result != null && result != Image){ // Image = result; // } //} }

Field: Note  
Default: Note  
Source: `GetDefaultNote()`  
Logic: { return Note; }

Field: Note  
Default: result  
Source: `SetDefaultNote()`  
Logic: { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} }

Field: CreatedDate  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultCreatedDate()`  
Logic: { //Code: 1070 Oid: 23c6d2cf-797e-4177-a322-f5cca19538f1 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: CreatedDate  
Default: = null) CreatedDate = GetDefaultCreatedDate()  
Source: `SetDefaultCreatedDate()`  
Logic: { //Code: 1071 Oid: 9526aec8-05e5-4fee-8b73-32434006850f if(CreatedDate == null) CreatedDate = GetDefaultCreatedDate(); }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 3177 Oid: fd2678dd-baa8-4720-84d3-1e3ffc94bd35 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 3175 Oid: 6b75c633-ba17-48b8-a70d-31fb687dc94e if (!IsDeleted) Update = GetDefaultUpdate(); }

Field: Updater  
Default: GetDefaultUpdater()  
Source: `SetDefaultUpdater()`  
Logic: { //Code: 3178 Oid: ec57a5c0-4e85-4bf3-924f-775a09fa8fc0 Updater = GetDefaultUpdater(); }

Field: Updater  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultUpdater()`  
Logic: { //Code: 3179 Oid: b029443f-6b6e-4c7e-8c25-4b31ffc3b421 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: Order  
Default: GetDefaultOrder()  
Source: `SetDefaultOrder()`  
Logic: { //Code: 1082 Oid: 71602fc1-d95f-4d0a-820e-3d7bbd731e22 Order= GetDefaultOrder(); }

Field: Order  
Default: Computed in GetDefaultOrder  
Source: `GetDefaultOrder()`  
Logic: { //Code: 1081 Oid: d479b0ba-9ff3-429b-95d6-177b1d63d574 var type = this.GetType(); var folderMember = type.GetProperty("Folder"); if (folderMember != null) { var parentObjectObject = folderMember.GetValue(this); if (parentObjectObject != null) { //var fileLis...

Field: Video  
Default: Video  
Source: `GetDefaultVideo()`  
Logic: { return Video; }

Field: Video  
Default: result  
Source: `SetDefaultVideo()`  
Logic: { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} }

Field: Member  
Default: = null) Member = GetDefaultMember()  
Source: `SetDefaultMember()`  
Logic: { //Code: 2599 Oid: 0da8e180-11a0-45b6-8657-e188abd75351 if(Member == null) Member = GetDefaultMember(); }

Field: Member  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultMember()`  
Logic: { //Code: 2600 Oid: c91479f4-d949-484c-9115-1109eebe6a63 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: Folder  
Default: Folder  
Source: `GetDefaultFolder()`  
Logic: { return Folder; }

Field: Folder  
Default: result  
Source: `SetDefaultFolder()`  
Logic: { //if (Folder is null){ // var result = GetDefaultFolder(view); // if (result != null && result != Folder){ // Folder = result; // } //} }

Field: Quantity  
Default: Quantity  
Source: `GetDefaultQuantity()`  
Logic: { return Quantity; }

Field: Quantity  
Default: result  
Source: `SetDefaultQuantity()`  
Logic: { //if (Quantity is null){ // var result = GetDefaultQuantity(view); // if (result != null && result != Quantity){ // Quantity = result; // } //} }

Field: Post  
Default: Post  
Source: `GetDefaultPost()`  
Logic: { return Post; }

Field: Post  
Default: result  
Source: `SetDefaultPost()`  
Logic: { //if (Post is null){ // var result = GetDefaultPost(view); // if (result != null && result != Post){ // Post = result; // } //} }

Field: Flag  
Default: Flag  
Source: `GetDefaultFlag()`  
Logic: { return Flag; }

Field: Flag  
Default: result  
Source: `SetDefaultFlag()`  
Logic: { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} }

Field: LinkType  
Default: LinkType  
Source: `GetDefaultLinkType()`  
Logic: { return LinkType; }

Field: LinkType  
Default: result  
Source: `SetDefaultLinkType()`  
Logic: { //if (LinkType is null){ // var result = GetDefaultLinkType(view); // if (result != null && result != LinkType){ // LinkType = result; // } //} }

Field: SystemType  
Default: GetDefaultSystemType()  
Source: `SetDefaultSystemType()`  
Logic: { //Code: 3436 Oid: 033aca3c-874e-4ecf-93a2-1c350d71526b SystemType= GetDefaultSystemType(); }

Field: SystemType  
Default: Folder.SystemType  
Source: `GetDefaultSystemType()`  
Logic: { //Code: 1338 Oid: f1907a69-9f77-4591-9d04-debea4e84fda if(Folder != null && Folder.SystemType != null) return Folder.SystemType; return null; }

Field: ObjectID  
Default: ObjectID  
Source: `GetDefaultObjectID()`  
Logic: { return ObjectID; }

Field: ObjectID  
Default: result  
Source: `SetDefaultObjectID()`  
Logic: { //if (ObjectID is null){ // var result = GetDefaultObjectID(view); // if (result != null && result != ObjectID){ // ObjectID = result; // } //} }

Field: SoftwareObjectType  
Default: SoftwareObjectType  
Source: `GetDefaultSoftwareObjectType()`  
Logic: { return SoftwareObjectType; }

Field: SoftwareObjectType  
Default: result  
Source: `SetDefaultSoftwareObjectType()`  
Logic: { //if (SoftwareObjectType is null){ // var result = GetDefaultSoftwareObjectType(view); // if (result != null && result != SoftwareObjectType){ // SoftwareObjectType = result; // } //} }

Field: Xpath  
Default: Xpath  
Source: `GetDefaultXpath()`  
Logic: { return Xpath; }

Field: Xpath  
Default: result  
Source: `SetDefaultXpath()`  
Logic: { //if (Xpath is null){ // var result = GetDefaultXpath(view); // if (result != null && result != Xpath){ // Xpath = result; // } //} }

Field: Flag2  
Default: Flag2  
Source: `GetDefaultFlag2()`  
Logic: { return Flag2; }

Field: Flag2  
Default: result  
Source: `SetDefaultFlag2()`  
Logic: { //if (Flag2 is null){ // var result = GetDefaultFlag2(view); // if (result != null && result != Flag2){ // Flag2 = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 1072ImportCode base.AfterConstruction(); SetDefaultCreatedDate(); SetDefaultMember(); #endregion 1072ImportCode //SetDefaultName(View view = null); //SetDefaultURL(View view = null); //SetDefaultImage(View view = null); //SetDef...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 3176ImportCode base.OnSaving(); SetDefaultUpdate(); SetDefaultUpdater(); #endregion 3176ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- CreatedDate [Detail=false]
- Flag [Detail=false]
- Flag2 [Detail=false]
- Folder [Detail=false]
- LinkType [Detail=false]
- Member [Detail=false]
- ObjectID [Detail=false]
- Order [Detail=false]
- Post [Detail=false]
- Product [Detail=false]
- Quantity [Detail=false]
- ShowOpenHyperLink
- SoftwareObjectType [Detail=false]
- SystemType [Detail=false]
- Update [Detail=false]
- Updater [Detail=false]
- Video [Detail=false]
- Xpath [Detail=false]

Group: (default)
- Image [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- Note [Order=1] [Detail=true]
- URL [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | BookMark | { Oid = Guid.NewGuid(); #region 1072ImportCode base.AfterConstruction(); SetDefaultCreatedDate(); SetDefaultMember(); #endregion 1072ImportCode //SetDefaultName(View view = null); //SetDefaultURL(View view = null); //SetDefaultImage(View view = null); //SetDef... |
| GetDefaultCreatedDate | BookMark | { //Code: 1070 Oid: 23c6d2cf-797e-4177-a322-f5cca19538f1 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultFlag | BookMark | { return Flag; } |
| GetDefaultFlag2 | BookMark | { return Flag2; } |
| GetDefaultFolder | BookMark | { return Folder; } |
| GetDefaultLinkType | BookMark | { return LinkType; } |
| GetDefaultMember | BookMark | { //Code: 2600 Oid: c91479f4-d949-484c-9115-1109eebe6a63 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| GetDefaultName | BookMark | { //Code: 1079 Oid: 1b19f5f5-bfea-41c3-8f32-c3feec593bf6 if (!string.IsNullOrEmpty(URL)) { var fileInfo = new System.IO.FileInfo(URL); return fileInfo.Name.Substring(0, fileInfo.Name.Length - fileInfo.Extension.Length); } return null; } |
| GetDefaultNote | BookMark | { return Note; } |
| GetDefaultObjectID | BookMark | { return ObjectID; } |
| GetDefaultOrder | BookMark | { //Code: 1081 Oid: d479b0ba-9ff3-429b-95d6-177b1d63d574 var type = this.GetType(); var folderMember = type.GetProperty("Folder"); if (folderMember != null) { var parentObjectObject = folderMember.GetValue(this); if (parentObjectObject != null) { //var fileLis... |
| GetDefaultPost | BookMark | { return Post; } |
| GetDefaultProduct | BookMark | { return Product; } |
| GetDefaultQuantity | BookMark | { return Quantity; } |
| GetDefaultSoftwareObjectType | BookMark | { return SoftwareObjectType; } |
| GetDefaultSystemType | BookMark | { //Code: 1338 Oid: f1907a69-9f77-4591-9d04-debea4e84fda if(Folder != null && Folder.SystemType != null) return Folder.SystemType; return null; } |
| GetDefaultURL | BookMark | { return URL; } |
| GetDefaultUpdate | BookMark | { //Code: 3177 Oid: fd2678dd-baa8-4720-84d3-1e3ffc94bd35 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultUpdater | BookMark | { //Code: 3179 Oid: b029443f-6b6e-4c7e-8c25-4b31ffc3b421 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| GetDefaultVideo | BookMark | { return Video; } |
| GetDefaultXpath | BookMark | { return Xpath; } |
| OnLoaded | BookMark | { base.OnLoaded(); } |
| OnSaving | BookMark | { #region 3176ImportCode base.OnSaving(); SetDefaultUpdate(); SetDefaultUpdater(); #endregion 3176ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&... |
| SetDefaultCreatedDate | BookMark | { //Code: 1071 Oid: 9526aec8-05e5-4fee-8b73-32434006850f if(CreatedDate == null) CreatedDate = GetDefaultCreatedDate(); } |
| SetDefaultFlag | BookMark | { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} } |
| SetDefaultFlag2 | BookMark | { //if (Flag2 is null){ // var result = GetDefaultFlag2(view); // if (result != null && result != Flag2){ // Flag2 = result; // } //} } |
| SetDefaultFolder | BookMark | { //if (Folder is null){ // var result = GetDefaultFolder(view); // if (result != null && result != Folder){ // Folder = result; // } //} } |
| SetDefaultImage | BookMark | { //if (Image is null){ // var result = GetDefaultImage(view); // if (result != null && result != Image){ // Image = result; // } //} } |
| SetDefaultLinkType | BookMark | { //if (LinkType is null){ // var result = GetDefaultLinkType(view); // if (result != null && result != LinkType){ // LinkType = result; // } //} } |
| SetDefaultMember | BookMark | { //Code: 2599 Oid: 0da8e180-11a0-45b6-8657-e188abd75351 if(Member == null) Member = GetDefaultMember(); } |
| SetDefaultName | BookMark | { //Code: 1078 Oid: 3017ce85-be57-411c-b227-9a91b0725809 if(String.IsNullOrEmpty(Name)) Name = GetDefaultName(); } |
| SetDefaultNote | BookMark | { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} } |
| SetDefaultObjectID | BookMark | { //if (ObjectID is null){ // var result = GetDefaultObjectID(view); // if (result != null && result != ObjectID){ // ObjectID = result; // } //} } |
| SetDefaultOrder | BookMark | { //Code: 1082 Oid: 71602fc1-d95f-4d0a-820e-3d7bbd731e22 Order= GetDefaultOrder(); } |
| SetDefaultPost | BookMark | { //if (Post is null){ // var result = GetDefaultPost(view); // if (result != null && result != Post){ // Post = result; // } //} } |
| SetDefaultProduct | BookMark | { //if (Product is null){ // var result = GetDefaultProduct(view); // if (result != null && result != Product){ // Product = result; // } //} } |
| SetDefaultQuantity | BookMark | { //if (Quantity is null){ // var result = GetDefaultQuantity(view); // if (result != null && result != Quantity){ // Quantity = result; // } //} } |
| SetDefaultSoftwareObjectType | BookMark | { //if (SoftwareObjectType is null){ // var result = GetDefaultSoftwareObjectType(view); // if (result != null && result != SoftwareObjectType){ // SoftwareObjectType = result; // } //} } |
| SetDefaultSystemType | BookMark | { //Code: 3436 Oid: 033aca3c-874e-4ecf-93a2-1c350d71526b SystemType= GetDefaultSystemType(); } |
| SetDefaultURL | BookMark | { //if (URL is null){ // var result = GetDefaultURL(view); // if (result != null && result != URL){ // URL = result; // } //} } |
| SetDefaultUpdate | BookMark | { //Code: 3175 Oid: 6b75c633-ba17-48b8-a70d-31fb687dc94e if (!IsDeleted) Update = GetDefaultUpdate(); } |
| SetDefaultUpdater | BookMark | { //Code: 3178 Oid: ec57a5c0-4e85-4bf3-924f-775a09fa8fc0 Updater = GetDefaultUpdater(); } |
| SetDefaultVideo | BookMark | { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} } |
| SetDefaultXpath | BookMark | { //if (Xpath is null){ // var result = GetDefaultXpath(view); // if (result != null && result != Xpath){ // Xpath = result; // } //} } |

---

# Entity: Concept

Caption entity: `Khái niệm`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Translate | string | Dịch | No | GetDefaultTranslate: Translate<br>SetDefaultTranslate: result | true | true |   | 1 |
| ConceptType | ConceptType | Loại | No | GetDefaultConceptType: ConceptType<br>SetDefaultConceptType: result | false | true |   | 1 |
| GradeSubject | Module.BusinessObjects.GradeSubject | Môn | No | GetDefaultGradeSubject: GradeSubject<br>SetDefaultGradeSubject: result | true | true |   | 1 |
| Photo | byte[] | Ảnh | No | SetDefaultPhoto: result | true | true |   | 1 |
| Language | Module.BusinessObjects.Language | Ngữ gốc | No | GetDefaultLanguage: Language<br>SetDefaultLanguage: result | false | true |   | 1 |
| LanguageTranslate | Module.BusinessObjects.Language | Ngữ dịch | No | GetDefaultLanguageTranslate: LanguageTranslate<br>SetDefaultLanguageTranslate: result | false | true |   | 1 |
| Note | string | Ghi chú | No | GetDefaultNote: Note<br>SetDefaultNote: result | false | true |  |  |
| NoteTranslate | string | Dịch | No | GetDefaultNoteTranslate: NoteTranslate<br>SetDefaultNoteTranslate: result | false | true |  |  |
| Update | DateTime | Cập nhật | No | GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)<br>SetDefaultUpdate: GetDefaultUpdate() | false | false |  |  |
| Creator | Module.BusinessObjects.Member | Người tạo | No | SetDefaultCreator: = null) Creator = GetDefaultCreator()<br>GetDefaultCreator: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session) | false | false |  |  |
| Audio | DevExpress.Persistent.BaseImpl.FileData | Âm thanh | No | GetDefaultAudio: Audio<br>SetDefaultAudio: result | false | false |  |  |
| AudioTranslate | DevExpress.Persistent.BaseImpl.FileData | Âm thanh dịch | No | GetDefaultAudioTranslate: AudioTranslate<br>SetDefaultAudioTranslate: result | false | false |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Translate  
Default: Translate  
Source: `GetDefaultTranslate()`  
Logic: { return Translate; }

Field: Translate  
Default: result  
Source: `SetDefaultTranslate()`  
Logic: { //if (Translate is null){ // var result = GetDefaultTranslate(view); // if (result != null && result != Translate){ // Translate = result; // } //} }

Field: ConceptType  
Default: ConceptType  
Source: `GetDefaultConceptType()`  
Logic: { return ConceptType; }

Field: ConceptType  
Default: result  
Source: `SetDefaultConceptType()`  
Logic: { //if (ConceptType is null){ // var result = GetDefaultConceptType(view); // if (result != null && result != ConceptType){ // ConceptType = result; // } //} }

Field: GradeSubject  
Default: GradeSubject  
Source: `GetDefaultGradeSubject()`  
Logic: { return GradeSubject; }

Field: GradeSubject  
Default: result  
Source: `SetDefaultGradeSubject()`  
Logic: { //if (GradeSubject is null){ // var result = GetDefaultGradeSubject(view); // if (result != null && result != GradeSubject){ // GradeSubject = result; // } //} }

Field: Photo  
Default: result  
Source: `SetDefaultPhoto()`  
Logic: { //if (Photo is null){ // var result = GetDefaultPhoto(view); // if (result != null && result != Photo){ // Photo = result; // } //} }

Field: Language  
Default: Language  
Source: `GetDefaultLanguage()`  
Logic: { return Language; }

Field: Language  
Default: result  
Source: `SetDefaultLanguage()`  
Logic: { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} }

Field: LanguageTranslate  
Default: LanguageTranslate  
Source: `GetDefaultLanguageTranslate()`  
Logic: { return LanguageTranslate; }

Field: LanguageTranslate  
Default: result  
Source: `SetDefaultLanguageTranslate()`  
Logic: { //if (LanguageTranslate is null){ // var result = GetDefaultLanguageTranslate(view); // if (result != null && result != LanguageTranslate){ // LanguageTranslate = result; // } //} }

Field: Note  
Default: Note  
Source: `GetDefaultNote()`  
Logic: { return Note; }

Field: Note  
Default: result  
Source: `SetDefaultNote()`  
Logic: { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} }

Field: NoteTranslate  
Default: NoteTranslate  
Source: `GetDefaultNoteTranslate()`  
Logic: { return NoteTranslate; }

Field: NoteTranslate  
Default: result  
Source: `SetDefaultNoteTranslate()`  
Logic: { //if (NoteTranslate is null){ // var result = GetDefaultNoteTranslate(view); // if (result != null && result != NoteTranslate){ // NoteTranslate = result; // } //} }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 0014 Oid: eb06992d-0dad-47ab-ab42-1780dc92e7a7 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 0066 Oid: d4483b68-99eb-48ff-8355-21bb2f725c65 Update = GetDefaultUpdate(); }

Field: Creator  
Default: = null) Creator = GetDefaultCreator()  
Source: `SetDefaultCreator()`  
Logic: { //Code: 0891 Oid: ed99aa4b-800b-42de-8734-4fff9603e3f5 if(Creator == null) Creator = GetDefaultCreator(); }

Field: Creator  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultCreator()`  
Logic: { //Code: 0892 Oid: 6f345df0-c821-4e1f-bc56-d4604cdbfad9 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: Audio  
Default: Audio  
Source: `GetDefaultAudio()`  
Logic: { return Audio; }

Field: Audio  
Default: result  
Source: `SetDefaultAudio()`  
Logic: { //if (Audio is null){ // var result = GetDefaultAudio(view); // if (result != null && result != Audio){ // Audio = result; // } //} }

Field: AudioTranslate  
Default: AudioTranslate  
Source: `GetDefaultAudioTranslate()`  
Logic: { return AudioTranslate; }

Field: AudioTranslate  
Default: result  
Source: `SetDefaultAudioTranslate()`  
Logic: { //if (AudioTranslate is null){ // var result = GetDefaultAudioTranslate(view); // if (result != null && result != AudioTranslate){ // AudioTranslate = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 0374ImportCode base.AfterConstruction(); SetDefaultUpdate(); SetDefaultCreator(); #endregion 0374ImportCode //SetDefaultName(View view = null); //SetDefaultTranslate(View view = null); //SetDefaultConceptType(View view = null); ...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 0479ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0479ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- Audio [Detail=false]
- AudioTranslate [Detail=false]
- Creator [Detail=false]
- Note [Detail=true]
- NoteTranslate [Detail=true]
- Update [Detail=false]

Group: (default)
- ConceptType [Order=1] [Detail=true]
- GradeSubject [Order=1] [Detail=true]
- Language [Order=1] [Detail=true]
- LanguageTranslate [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- Photo [Order=1] [Detail=true]
- Translate [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | Concept | { Oid = Guid.NewGuid(); #region 0374ImportCode base.AfterConstruction(); SetDefaultUpdate(); SetDefaultCreator(); #endregion 0374ImportCode //SetDefaultName(View view = null); //SetDefaultTranslate(View view = null); //SetDefaultConceptType(View view = null); ... |
| GetDefaultAudio | Concept | { return Audio; } |
| GetDefaultAudioTranslate | Concept | { return AudioTranslate; } |
| GetDefaultConceptType | Concept | { return ConceptType; } |
| GetDefaultCreator | Concept | { //Code: 0892 Oid: 6f345df0-c821-4e1f-bc56-d4604cdbfad9 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| GetDefaultGradeSubject | Concept | { return GradeSubject; } |
| GetDefaultLanguage | Concept | { return Language; } |
| GetDefaultLanguageTranslate | Concept | { return LanguageTranslate; } |
| GetDefaultName | Concept | { return Name; } |
| GetDefaultNote | Concept | { return Note; } |
| GetDefaultNoteTranslate | Concept | { return NoteTranslate; } |
| GetDefaultTranslate | Concept | { return Translate; } |
| GetDefaultUpdate | Concept | { //Code: 0014 Oid: eb06992d-0dad-47ab-ab42-1780dc92e7a7 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| OnLoaded | Concept | { base.OnLoaded(); } |
| OnSaving | Concept | { #region 0479ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0479ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ... |
| SetDefaultAudio | Concept | { //if (Audio is null){ // var result = GetDefaultAudio(view); // if (result != null && result != Audio){ // Audio = result; // } //} } |
| SetDefaultAudioTranslate | Concept | { //if (AudioTranslate is null){ // var result = GetDefaultAudioTranslate(view); // if (result != null && result != AudioTranslate){ // AudioTranslate = result; // } //} } |
| SetDefaultConceptType | Concept | { //if (ConceptType is null){ // var result = GetDefaultConceptType(view); // if (result != null && result != ConceptType){ // ConceptType = result; // } //} } |
| SetDefaultCreator | Concept | { //Code: 0891 Oid: ed99aa4b-800b-42de-8734-4fff9603e3f5 if(Creator == null) Creator = GetDefaultCreator(); } |
| SetDefaultGradeSubject | Concept | { //if (GradeSubject is null){ // var result = GetDefaultGradeSubject(view); // if (result != null && result != GradeSubject){ // GradeSubject = result; // } //} } |
| SetDefaultLanguage | Concept | { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} } |
| SetDefaultLanguageTranslate | Concept | { //if (LanguageTranslate is null){ // var result = GetDefaultLanguageTranslate(view); // if (result != null && result != LanguageTranslate){ // LanguageTranslate = result; // } //} } |
| SetDefaultName | Concept | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultNote | Concept | { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} } |
| SetDefaultNoteTranslate | Concept | { //if (NoteTranslate is null){ // var result = GetDefaultNoteTranslate(view); // if (result != null && result != NoteTranslate){ // NoteTranslate = result; // } //} } |
| SetDefaultPhoto | Concept | { //if (Photo is null){ // var result = GetDefaultPhoto(view); // if (result != null && result != Photo){ // Photo = result; // } //} } |
| SetDefaultTranslate | Concept | { //if (Translate is null){ // var result = GetDefaultTranslate(view); // if (result != null && result != Translate){ // Translate = result; // } //} } |
| SetDefaultUpdate | Concept | { //Code: 0066 Oid: d4483b68-99eb-48ff-8355-21bb2f725c65 Update = GetDefaultUpdate(); } |

---

# Entity: CorrectionOption

Caption entity: `Tùy chọn sửa`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| TermLocationCorrection | Module.BusinessObjects.TermLocationCorrection | Sửa thuật ngữ | No | GetDefaultTermLocationCorrection: TermLocationCorrection<br>SetDefaultTermLocationCorrection: result | false | true |   | 1 |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: TermLocationCorrection  
Default: TermLocationCorrection  
Source: `GetDefaultTermLocationCorrection()`  
Logic: { return TermLocationCorrection; }

Field: TermLocationCorrection  
Default: result  
Source: `SetDefaultTermLocationCorrection()`  
Logic: { //if (TermLocationCorrection is null){ // var result = GetDefaultTermLocationCorrection(view); // if (result != null && result != TermLocationCorrection){ // TermLocationCorrection = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultTermLocationCorrection(View view = null); }

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete

Group: (default)
- Name [Order=1] [Detail=true]
- TermLocationCorrection [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | CorrectionOption | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultTermLocationCorrection(View view = null); } |
| GetDefaultName | CorrectionOption | { return Name; } |
| GetDefaultTermLocationCorrection | CorrectionOption | { return TermLocationCorrection; } |
| OnLoaded | CorrectionOption | { base.OnLoaded(); } |
| OnSaving | CorrectionOption | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultName | CorrectionOption | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultTermLocationCorrection | CorrectionOption | { //if (TermLocationCorrection is null){ // var result = GetDefaultTermLocationCorrection(view); // if (result != null && result != TermLocationCorrection){ // TermLocationCorrection = result; // } //} } |

---

# Entity: DataService

Caption entity: `Dịch vụ dữ liệu`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Code | string | Mã | Yes | SetDefaultCode: GetDefaultCode()<br>GetDefaultCode: Computed in GetDefaultCode | true | true |   | 1 |
| Name | string | Tên | Yes | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Address | string | Địa chỉ | No | GetDefaultAddress: Address<br>SetDefaultAddress: result | true | true |   | 1 |
| ServiceCode | string | Mã thực hiện | No | GetDefaultServiceCode: ServiceCode<br>SetDefaultServiceCode: result | false | true |   | 1 |
| DataServiceType | DataServiceType | Loại | No | GetDefaultDataServiceType: DataServiceType<br>SetDefaultDataServiceType: result | false | true |   | 1 |
| ApiMethodType | ApiMethodType | Loại phương thức | No | GetDefaultApiMethodType: ApiMethodType<br>SetDefaultApiMethodType: result | false | true |   | 1 |
| APIKey | string | Khóa API | No | GetDefaultAPIKey: APIKey<br>SetDefaultAPIKey: result | false | true |   | 1 |
| PreviousDataService | Module.BusinessObjects.DataService | Dịch vụ trước | No | GetDefaultPreviousDataService: PreviousDataService<br>SetDefaultPreviousDataService: result | false | true |   | 1 |
| MaxConcurrency | int? | Số luồng đồng thời | No | GetDefaultMaxConcurrency: MaxConcurrency<br>SetDefaultMaxConcurrency: result | false | true |   | 1 |
| Pause | bool | Tạm dừng | No | GetDefaultPause: Pause<br>SetDefaultPause: result | false | true |   | 1 |
| IsDefault | bool | Mặc định | No | GetDefaultIsDefault: IsDefault<br>SetDefaultIsDefault: result | false | true |   | 1 |
| DataServiceParameterList | XPCollection <Module.BusinessObjects.DataServiceParameter> | Tham số | No |  | false | true |  |  |
| VoiceList | XPCollection <Module.BusinessObjects.Voice> | Giọng đọc | No |  | false | true |  |  |
| SoftwareServiceType | Module.BusinessObjects.SoftwareServiceType | Loại dịch vụ | No | GetDefaultSoftwareServiceType: SoftwareServiceType<br>SetDefaultSoftwareServiceType: result | false | false |  |  |
| ServiceCodeDataSource | System.Collections.Generic.IList<string> |  | No |  |  |  |  |  |

## Default Logic

Field: Code  
Default: GetDefaultCode()  
Source: `SetDefaultCode()`  
Logic: { //Code: 1501 Oid: 583b843c-3905-484a-8cc1-6266f728b710 if(String.IsNullOrEmpty(Code)) Code = GetDefaultCode(); }

Field: Code  
Default: Computed in GetDefaultCode  
Source: `GetDefaultCode()`  
Logic: { //Code: 1500 Oid: 0830ac8b-1572-483d-aeb5-ee02c6ee6beb var keyCodeObject = Module.Helpers.ParameterHelper.GetSettingParameter(Session, "CodeObject"); //Trường hợp chỉ lấy mã trên đối tượng này Type currentType = this.GetType(); //Trường hợp lấy mã từ đối tượ...

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Address  
Default: Address  
Source: `GetDefaultAddress()`  
Logic: { return Address; }

Field: Address  
Default: result  
Source: `SetDefaultAddress()`  
Logic: { //if (Address is null){ // var result = GetDefaultAddress(view); // if (result != null && result != Address){ // Address = result; // } //} }

Field: ServiceCode  
Default: ServiceCode  
Source: `GetDefaultServiceCode()`  
Logic: { return ServiceCode; }

Field: ServiceCode  
Default: result  
Source: `SetDefaultServiceCode()`  
Logic: { //if (ServiceCode is null){ // var result = GetDefaultServiceCode(view); // if (result != null && result != ServiceCode){ // ServiceCode = result; // } //} }

Field: DataServiceType  
Default: DataServiceType  
Source: `GetDefaultDataServiceType()`  
Logic: { return DataServiceType; }

Field: DataServiceType  
Default: result  
Source: `SetDefaultDataServiceType()`  
Logic: { //if (DataServiceType is null){ // var result = GetDefaultDataServiceType(view); // if (result != null && result != DataServiceType){ // DataServiceType = result; // } //} }

Field: ApiMethodType  
Default: ApiMethodType  
Source: `GetDefaultApiMethodType()`  
Logic: { return ApiMethodType; }

Field: ApiMethodType  
Default: result  
Source: `SetDefaultApiMethodType()`  
Logic: { //if (ApiMethodType is null){ // var result = GetDefaultApiMethodType(view); // if (result != null && result != ApiMethodType){ // ApiMethodType = result; // } //} }

Field: APIKey  
Default: APIKey  
Source: `GetDefaultAPIKey()`  
Logic: { return APIKey; }

Field: APIKey  
Default: result  
Source: `SetDefaultAPIKey()`  
Logic: { //if (APIKey is null){ // var result = GetDefaultAPIKey(view); // if (result != null && result != APIKey){ // APIKey = result; // } //} }

Field: PreviousDataService  
Default: PreviousDataService  
Source: `GetDefaultPreviousDataService()`  
Logic: { return PreviousDataService; }

Field: PreviousDataService  
Default: result  
Source: `SetDefaultPreviousDataService()`  
Logic: { //if (PreviousDataService is null){ // var result = GetDefaultPreviousDataService(view); // if (result != null && result != PreviousDataService){ // PreviousDataService = result; // } //} }

Field: MaxConcurrency  
Default: MaxConcurrency  
Source: `GetDefaultMaxConcurrency()`  
Logic: { return MaxConcurrency; }

Field: MaxConcurrency  
Default: result  
Source: `SetDefaultMaxConcurrency()`  
Logic: { //if (MaxConcurrency is null){ // var result = GetDefaultMaxConcurrency(view); // if (result != null && result != MaxConcurrency){ // MaxConcurrency = result; // } //} }

Field: Pause  
Default: Pause  
Source: `GetDefaultPause()`  
Logic: { return Pause; }

Field: Pause  
Default: result  
Source: `SetDefaultPause()`  
Logic: { //if (Pause is null){ // var result = GetDefaultPause(view); // if (result != null && result != Pause){ // Pause = result; // } //} }

Field: IsDefault  
Default: IsDefault  
Source: `GetDefaultIsDefault()`  
Logic: { return IsDefault; }

Field: IsDefault  
Default: result  
Source: `SetDefaultIsDefault()`  
Logic: { //if (IsDefault is null){ // var result = GetDefaultIsDefault(view); // if (result != null && result != IsDefault){ // IsDefault = result; // } //} }

Field: SoftwareServiceType  
Default: SoftwareServiceType  
Source: `GetDefaultSoftwareServiceType()`  
Logic: { return SoftwareServiceType; }

Field: SoftwareServiceType  
Default: result  
Source: `SetDefaultSoftwareServiceType()`  
Logic: { //if (SoftwareServiceType is null){ // var result = GetDefaultSoftwareServiceType(view); // if (result != null && result != SoftwareServiceType){ // SoftwareServiceType = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 1502ImportCode base.AfterConstruction(); SetDefaultCode(); #endregion 1502ImportCode //SetDefaultCode(View view = null); //SetDefaultName(View view = null); //SetDefaultAddress(View view = null); //SetDefaultServiceCode(View vie...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- DataServiceParameterList [Detail=true]
- ServiceCodeDataSource
- SoftwareServiceType [Detail=false]
- VoiceList [Detail=true]

Group: (default)
- APIKey [Order=1] [Detail=true]
- Address [Order=1] [Detail=true]
- ApiMethodType [Order=1] [Detail=true]
- Code [Order=1] [Detail=true]
- DataServiceType [Order=1] [Detail=true]
- IsDefault [Order=1] [Detail=true]
- MaxConcurrency [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- Pause [Order=1] [Detail=true]
- PreviousDataService [Order=1] [Detail=true]
- ServiceCode [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | DataService | { Oid = Guid.NewGuid(); #region 1502ImportCode base.AfterConstruction(); SetDefaultCode(); #endregion 1502ImportCode //SetDefaultCode(View view = null); //SetDefaultName(View view = null); //SetDefaultAddress(View view = null); //SetDefaultServiceCode(View vie... |
| GetDefaultAPIKey | DataService | { return APIKey; } |
| GetDefaultAddress | DataService | { return Address; } |
| GetDefaultApiMethodType | DataService | { return ApiMethodType; } |
| GetDefaultCode | DataService | { //Code: 1500 Oid: 0830ac8b-1572-483d-aeb5-ee02c6ee6beb var keyCodeObject = Module.Helpers.ParameterHelper.GetSettingParameter(Session, "CodeObject"); //Trường hợp chỉ lấy mã trên đối tượng này Type currentType = this.GetType(); //Trường hợp lấy mã từ đối tượ... |
| GetDefaultDataServiceType | DataService | { return DataServiceType; } |
| GetDefaultIsDefault | DataService | { return IsDefault; } |
| GetDefaultMaxConcurrency | DataService | { return MaxConcurrency; } |
| GetDefaultName | DataService | { return Name; } |
| GetDefaultPause | DataService | { return Pause; } |
| GetDefaultPreviousDataService | DataService | { return PreviousDataService; } |
| GetDefaultServiceCode | DataService | { return ServiceCode; } |
| GetDefaultSoftwareServiceType | DataService | { return SoftwareServiceType; } |
| OnLoaded | DataService | { base.OnLoaded(); } |
| OnSaving | DataService | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultAPIKey | DataService | { //if (APIKey is null){ // var result = GetDefaultAPIKey(view); // if (result != null && result != APIKey){ // APIKey = result; // } //} } |
| SetDefaultAddress | DataService | { //if (Address is null){ // var result = GetDefaultAddress(view); // if (result != null && result != Address){ // Address = result; // } //} } |
| SetDefaultApiMethodType | DataService | { //if (ApiMethodType is null){ // var result = GetDefaultApiMethodType(view); // if (result != null && result != ApiMethodType){ // ApiMethodType = result; // } //} } |
| SetDefaultCode | DataService | { //Code: 1501 Oid: 583b843c-3905-484a-8cc1-6266f728b710 if(String.IsNullOrEmpty(Code)) Code = GetDefaultCode(); } |
| SetDefaultDataServiceType | DataService | { //if (DataServiceType is null){ // var result = GetDefaultDataServiceType(view); // if (result != null && result != DataServiceType){ // DataServiceType = result; // } //} } |
| SetDefaultIsDefault | DataService | { //if (IsDefault is null){ // var result = GetDefaultIsDefault(view); // if (result != null && result != IsDefault){ // IsDefault = result; // } //} } |
| SetDefaultMaxConcurrency | DataService | { //if (MaxConcurrency is null){ // var result = GetDefaultMaxConcurrency(view); // if (result != null && result != MaxConcurrency){ // MaxConcurrency = result; // } //} } |
| SetDefaultName | DataService | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultPause | DataService | { //if (Pause is null){ // var result = GetDefaultPause(view); // if (result != null && result != Pause){ // Pause = result; // } //} } |
| SetDefaultPreviousDataService | DataService | { //if (PreviousDataService is null){ // var result = GetDefaultPreviousDataService(view); // if (result != null && result != PreviousDataService){ // PreviousDataService = result; // } //} } |
| SetDefaultServiceCode | DataService | { //if (ServiceCode is null){ // var result = GetDefaultServiceCode(view); // if (result != null && result != ServiceCode){ // ServiceCode = result; // } //} } |
| SetDefaultSoftwareServiceType | DataService | { //if (SoftwareServiceType is null){ // var result = GetDefaultSoftwareServiceType(view); // if (result != null && result != SoftwareServiceType){ // SoftwareServiceType = result; // } //} } |

---

# Entity: DataServiceLog

Caption entity: `Nhật ký Dịch vụ Dữ liệu`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| DataService | Module.BusinessObjects.DataService | Dịch vụ Dữ liệu | No | GetDefaultDataService: DataService<br>SetDefaultDataService: result | true | true |   | 1 |
| Quantity | int? | Số lượng | No | GetDefaultQuantity: Quantity<br>SetDefaultQuantity: result | true | true |   | 1 |
| Note | string | Ghi chú | No | GetDefaultNote: Note<br>SetDefaultNote: result | true | true |   | 1 |
| Creator | Module.BusinessObjects.Member | Người dùng | No | GetDefaultCreator: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)<br>SetDefaultCreator: = null) Creator = GetDefaultCreator() | true | false |  |  |
| CreatedDate | DateTime? | Thời gian | No | GetDefaultCreatedDate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)<br>SetDefaultCreatedDate: = null) CreatedDate = GetDefaultCreatedDate() | true | false |  |  |

## Default Logic

Field: DataService  
Default: DataService  
Source: `GetDefaultDataService()`  
Logic: { return DataService; }

Field: DataService  
Default: result  
Source: `SetDefaultDataService()`  
Logic: { //if (DataService is null){ // var result = GetDefaultDataService(view); // if (result != null && result != DataService){ // DataService = result; // } //} }

Field: Quantity  
Default: Quantity  
Source: `GetDefaultQuantity()`  
Logic: { return Quantity; }

Field: Quantity  
Default: result  
Source: `SetDefaultQuantity()`  
Logic: { //if (Quantity is null){ // var result = GetDefaultQuantity(view); // if (result != null && result != Quantity){ // Quantity = result; // } //} }

Field: Note  
Default: Note  
Source: `GetDefaultNote()`  
Logic: { return Note; }

Field: Note  
Default: result  
Source: `SetDefaultNote()`  
Logic: { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} }

Field: Creator  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultCreator()`  
Logic: { //Code: 1407 Oid: bda59c06-1de1-4331-97b2-37895d353809 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: Creator  
Default: = null) Creator = GetDefaultCreator()  
Source: `SetDefaultCreator()`  
Logic: { //Code: 1406 Oid: 5d91c09b-c0c0-4fc6-9f3b-a81f47c15b57 if(Creator == null) Creator = GetDefaultCreator(); }

Field: CreatedDate  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultCreatedDate()`  
Logic: { //Code: 1403 Oid: e31b25a8-228b-49a9-be15-b9c796485967 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: CreatedDate  
Default: = null) CreatedDate = GetDefaultCreatedDate()  
Source: `SetDefaultCreatedDate()`  
Logic: { //Code: 1404 Oid: 745c4525-6bd0-4cae-89cb-089852619ac7 if(CreatedDate == null) CreatedDate = GetDefaultCreatedDate(); }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 1405ImportCode base.AfterConstruction(); SetDefaultCreatedDate(); SetDefaultCreator(); #endregion 1405ImportCode //SetDefaultDataService(View view = null); //SetDefaultQuantity(View view = null); //SetDefaultNote(View view = nul...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- CreatedDate [Detail=false]
- Creator [Detail=false]

Group: (default)
- DataService [Order=1] [Detail=true]
- Note [Order=1] [Detail=true]
- Quantity [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | DataServiceLog | { Oid = Guid.NewGuid(); #region 1405ImportCode base.AfterConstruction(); SetDefaultCreatedDate(); SetDefaultCreator(); #endregion 1405ImportCode //SetDefaultDataService(View view = null); //SetDefaultQuantity(View view = null); //SetDefaultNote(View view = nul... |
| GetDefaultCreatedDate | DataServiceLog | { //Code: 1403 Oid: e31b25a8-228b-49a9-be15-b9c796485967 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultCreator | DataServiceLog | { //Code: 1407 Oid: bda59c06-1de1-4331-97b2-37895d353809 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| GetDefaultDataService | DataServiceLog | { return DataService; } |
| GetDefaultNote | DataServiceLog | { return Note; } |
| GetDefaultQuantity | DataServiceLog | { return Quantity; } |
| OnLoaded | DataServiceLog | { base.OnLoaded(); } |
| OnSaving | DataServiceLog | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultCreatedDate | DataServiceLog | { //Code: 1404 Oid: 745c4525-6bd0-4cae-89cb-089852619ac7 if(CreatedDate == null) CreatedDate = GetDefaultCreatedDate(); } |
| SetDefaultCreator | DataServiceLog | { //Code: 1406 Oid: 5d91c09b-c0c0-4fc6-9f3b-a81f47c15b57 if(Creator == null) Creator = GetDefaultCreator(); } |
| SetDefaultDataService | DataServiceLog | { //if (DataService is null){ // var result = GetDefaultDataService(view); // if (result != null && result != DataService){ // DataService = result; // } //} } |
| SetDefaultNote | DataServiceLog | { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} } |
| SetDefaultQuantity | DataServiceLog | { //if (Quantity is null){ // var result = GetDefaultQuantity(view); // if (result != null && result != Quantity){ // Quantity = result; // } //} } |

---

# Entity: DataServiceParameter

Caption entity: `Tham số Dịch vụ Dữ liệu`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Type | DataServiceParameterType | Loại | No | GetDefaultType: Type<br>SetDefaultType: result | false | true |   | 1 |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | false | true |   | 1 |
| Value | string | Giá trị | No | GetDefaultValue: Value<br>SetDefaultValue: result | true | true |   | 1 |
| Note | string | Ghi chú | No | GetDefaultNote: Note<br>SetDefaultNote: result | true | true |   | 1 |
| DataServiceParameterOption | DataServiceParameterOption | Kiểu tham số | No | GetDefaultDataServiceParameterOption: DataServiceParameterOption<br>SetDefaultDataServiceParameterOption: result | true | true |   | 1 |
| Order | int? | Thứ tự | No | GetDefaultOrder: Computed in GetDefaultOrder<br>SetDefaultOrder: GetDefaultOrder() | false | true |   | 1 |
| InActive | bool | Ngừng | No | GetDefaultInActive: InActive<br>SetDefaultInActive: result | false | true |   | 1 |
| DataService | Module.BusinessObjects.DataService | Dịch vụ Dữ liệu | No | GetDefaultDataService: DataService<br>SetDefaultDataService: result | false | false |  |  |

## Default Logic

Field: Type  
Default: Type  
Source: `GetDefaultType()`  
Logic: { return Type; }

Field: Type  
Default: result  
Source: `SetDefaultType()`  
Logic: { //if (Type is null){ // var result = GetDefaultType(view); // if (result != null && result != Type){ // Type = result; // } //} }

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Value  
Default: Value  
Source: `GetDefaultValue()`  
Logic: { return Value; }

Field: Value  
Default: result  
Source: `SetDefaultValue()`  
Logic: { //if (Value is null){ // var result = GetDefaultValue(view); // if (result != null && result != Value){ // Value = result; // } //} }

Field: Note  
Default: Note  
Source: `GetDefaultNote()`  
Logic: { return Note; }

Field: Note  
Default: result  
Source: `SetDefaultNote()`  
Logic: { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} }

Field: DataServiceParameterOption  
Default: DataServiceParameterOption  
Source: `GetDefaultDataServiceParameterOption()`  
Logic: { return DataServiceParameterOption; }

Field: DataServiceParameterOption  
Default: result  
Source: `SetDefaultDataServiceParameterOption()`  
Logic: { //if (DataServiceParameterOption is null){ // var result = GetDefaultDataServiceParameterOption(view); // if (result != null && result != DataServiceParameterOption){ // DataServiceParameterOption = result; // } //} }

Field: Order  
Default: Computed in GetDefaultOrder  
Source: `GetDefaultOrder()`  
Logic: { //Code: 2625 Oid: 9b1b1f3d-6d16-4bde-a267-6842a15e8b1e if (DataService != null && DataService.DataServiceParameterList != null) { var lasted = DataService.DataServiceParameterList.Where(m => m.Order != null).OrderByDescending(m => m.Order).FirstOrDefault(); ...

Field: Order  
Default: GetDefaultOrder()  
Source: `SetDefaultOrder()`  
Logic: { //Code: 2626 Oid: 2a567331-42ae-4ce8-92ef-d7560b9a2775 Order= GetDefaultOrder(); }

Field: InActive  
Default: InActive  
Source: `GetDefaultInActive()`  
Logic: { return InActive; }

Field: InActive  
Default: result  
Source: `SetDefaultInActive()`  
Logic: { //if (InActive is null){ // var result = GetDefaultInActive(view); // if (result != null && result != InActive){ // InActive = result; // } //} }

Field: DataService  
Default: DataService  
Source: `GetDefaultDataService()`  
Logic: { return DataService; }

Field: DataService  
Default: result  
Source: `SetDefaultDataService()`  
Logic: { //if (DataService is null){ // var result = GetDefaultDataService(view); // if (result != null && result != DataService){ // DataService = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultType(View view = null); //SetDefaultName(View view = null); //SetDefaultValue(View view = null); //SetDefaultNote(View view = null); //SetDefaultDataServiceParameterOption(View view = null); //SetDe...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- DataService [Detail=false]

Group: (default)
- DataServiceParameterOption [Order=1] [Detail=true]
- InActive [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- Note [Order=1] [Detail=true]
- Order [Order=1] [Detail=true]
- Type [Order=1] [Detail=true]
- Value [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | DataServiceParameter | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultType(View view = null); //SetDefaultName(View view = null); //SetDefaultValue(View view = null); //SetDefaultNote(View view = null); //SetDefaultDataServiceParameterOption(View view = null); //SetDe... |
| GetDefaultDataService | DataServiceParameter | { return DataService; } |
| GetDefaultDataServiceParameterOption | DataServiceParameter | { return DataServiceParameterOption; } |
| GetDefaultInActive | DataServiceParameter | { return InActive; } |
| GetDefaultName | DataServiceParameter | { return Name; } |
| GetDefaultNote | DataServiceParameter | { return Note; } |
| GetDefaultOrder | DataServiceParameter | { //Code: 2625 Oid: 9b1b1f3d-6d16-4bde-a267-6842a15e8b1e if (DataService != null && DataService.DataServiceParameterList != null) { var lasted = DataService.DataServiceParameterList.Where(m => m.Order != null).OrderByDescending(m => m.Order).FirstOrDefault(); ... |
| GetDefaultType | DataServiceParameter | { return Type; } |
| GetDefaultValue | DataServiceParameter | { return Value; } |
| OnLoaded | DataServiceParameter | { base.OnLoaded(); } |
| OnSaving | DataServiceParameter | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultDataService | DataServiceParameter | { //if (DataService is null){ // var result = GetDefaultDataService(view); // if (result != null && result != DataService){ // DataService = result; // } //} } |
| SetDefaultDataServiceParameterOption | DataServiceParameter | { //if (DataServiceParameterOption is null){ // var result = GetDefaultDataServiceParameterOption(view); // if (result != null && result != DataServiceParameterOption){ // DataServiceParameterOption = result; // } //} } |
| SetDefaultInActive | DataServiceParameter | { //if (InActive is null){ // var result = GetDefaultInActive(view); // if (result != null && result != InActive){ // InActive = result; // } //} } |
| SetDefaultName | DataServiceParameter | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultNote | DataServiceParameter | { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} } |
| SetDefaultOrder | DataServiceParameter | { //Code: 2626 Oid: 2a567331-42ae-4ce8-92ef-d7560b9a2775 Order= GetDefaultOrder(); } |
| SetDefaultType | DataServiceParameter | { //if (Type is null){ // var result = GetDefaultType(view); // if (result != null && result != Type){ // Type = result; // } //} } |
| SetDefaultValue | DataServiceParameter | { //if (Value is null){ // var result = GetDefaultValue(view); // if (result != null && result != Value){ // Value = result; // } //} } |

---

# Entity: Dictionary

Caption entity: `Từ điển`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Member | Module.BusinessObjects.Member | Quản lý | No | GetDefaultMember: Member<br>SetDefaultMember: result | false | true |   | 1 |
| Symbol | byte[] | Biểu tượng | No | SetDefaultSymbol: result | true | true |   | 1 |
| DictionaryWordList | XPCollection <Module.BusinessObjects.DictionaryWord> | Từ ngữ | No |  | false | true |  |  |
| Update | DateTime | Cập nhật | No | GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)<br>SetDefaultUpdate: GetDefaultUpdate() | false | false |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Member  
Default: Member  
Source: `GetDefaultMember()`  
Logic: { return Member; }

Field: Member  
Default: result  
Source: `SetDefaultMember()`  
Logic: { //if (Member is null){ // var result = GetDefaultMember(view); // if (result != null && result != Member){ // Member = result; // } //} }

Field: Symbol  
Default: result  
Source: `SetDefaultSymbol()`  
Logic: { //if (Symbol is null){ // var result = GetDefaultSymbol(view); // if (result != null && result != Symbol){ // Symbol = result; // } //} }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 0094 Oid: 437bfd68-bdd4-42bb-a123-d0b593e72987 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 0117 Oid: b3689790-e5a0-447a-808f-c9dc5f19e48f Update = GetDefaultUpdate(); }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 0366ImportCode base.AfterConstruction(); SetDefaultUpdate(); #endregion 0366ImportCode //SetDefaultName(View view = null); //SetDefaultMember(View view = null); //SetDefaultSymbol(View view = null); //SetDefaultUpdate(View view ...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 0518ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0518ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- DictionaryWordList [Detail=true]
- Update [Detail=false]

Group: (default)
- Member [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- Symbol [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | Dictionary | { Oid = Guid.NewGuid(); #region 0366ImportCode base.AfterConstruction(); SetDefaultUpdate(); #endregion 0366ImportCode //SetDefaultName(View view = null); //SetDefaultMember(View view = null); //SetDefaultSymbol(View view = null); //SetDefaultUpdate(View view ... |
| GetDefaultMember | Dictionary | { return Member; } |
| GetDefaultName | Dictionary | { return Name; } |
| GetDefaultUpdate | Dictionary | { //Code: 0094 Oid: 437bfd68-bdd4-42bb-a123-d0b593e72987 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| OnLoaded | Dictionary | { base.OnLoaded(); } |
| OnSaving | Dictionary | { #region 0518ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0518ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ... |
| SetDefaultMember | Dictionary | { //if (Member is null){ // var result = GetDefaultMember(view); // if (result != null && result != Member){ // Member = result; // } //} } |
| SetDefaultName | Dictionary | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultSymbol | Dictionary | { //if (Symbol is null){ // var result = GetDefaultSymbol(view); // if (result != null && result != Symbol){ // Symbol = result; // } //} } |
| SetDefaultUpdate | Dictionary | { //Code: 0117 Oid: b3689790-e5a0-447a-808f-c9dc5f19e48f Update = GetDefaultUpdate(); } |

---

# Entity: DictionaryWord

Caption entity: `Từ ngữ`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Translate | string | Dịch | No | GetDefaultTranslate: Translate<br>SetDefaultTranslate: result | true | true |   | 1 |
| Sentence | string | Ngữ cảnh | No | GetDefaultSentence: Sentence<br>SetDefaultSentence: result | false | true |   | 1 |
| LanguageOrigin | Module.BusinessObjects.Language | Ngữ gốc | No | GetDefaultLanguageOrigin: LanguageOrigin<br>SetDefaultLanguageOrigin: result | true | true |   | 1 |
| LanguageTranslate | Module.BusinessObjects.Language | Ngữ dịch | No | GetDefaultLanguageTranslate: LanguageTranslate<br>SetDefaultLanguageTranslate: result | true | true |   | 1 |
| WordType | WordType | Loại | No | GetDefaultWordType: WordType<br>SetDefaultWordType: result | false | true |   | 1 |
| TranslateWordList | XPCollection <Module.BusinessObjects.TranslateWord> | Dịch ngữ | No |  | false | true |  |  |
| Dictionary | Module.BusinessObjects.Dictionary | Từ điển | No | GetDefaultDictionary: Dictionary<br>SetDefaultDictionary: result | false | false |  |  |
| Creator | Module.BusinessObjects.Member | Người tạo | No | SetDefaultCreator: = null) Creator = GetDefaultCreator()<br>GetDefaultCreator: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session) | false | false |  |  |
| Update | DateTime | Cập nhật | No | GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)<br>SetDefaultUpdate: GetDefaultUpdate() | true | false |  |  |
| NoSignWord | string | Không dấu | No | GetDefaultNoSignWord: NoSignWord<br>SetDefaultNoSignWord: result | false | false |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Translate  
Default: Translate  
Source: `GetDefaultTranslate()`  
Logic: { return Translate; }

Field: Translate  
Default: result  
Source: `SetDefaultTranslate()`  
Logic: { //if (Translate is null){ // var result = GetDefaultTranslate(view); // if (result != null && result != Translate){ // Translate = result; // } //} }

Field: Sentence  
Default: Sentence  
Source: `GetDefaultSentence()`  
Logic: { return Sentence; }

Field: Sentence  
Default: result  
Source: `SetDefaultSentence()`  
Logic: { //if (Sentence is null){ // var result = GetDefaultSentence(view); // if (result != null && result != Sentence){ // Sentence = result; // } //} }

Field: LanguageOrigin  
Default: LanguageOrigin  
Source: `GetDefaultLanguageOrigin()`  
Logic: { return LanguageOrigin; }

Field: LanguageOrigin  
Default: result  
Source: `SetDefaultLanguageOrigin()`  
Logic: { //if (LanguageOrigin is null){ // var result = GetDefaultLanguageOrigin(view); // if (result != null && result != LanguageOrigin){ // LanguageOrigin = result; // } //} }

Field: LanguageTranslate  
Default: LanguageTranslate  
Source: `GetDefaultLanguageTranslate()`  
Logic: { return LanguageTranslate; }

Field: LanguageTranslate  
Default: result  
Source: `SetDefaultLanguageTranslate()`  
Logic: { //if (LanguageTranslate is null){ // var result = GetDefaultLanguageTranslate(view); // if (result != null && result != LanguageTranslate){ // LanguageTranslate = result; // } //} }

Field: WordType  
Default: WordType  
Source: `GetDefaultWordType()`  
Logic: { return WordType; }

Field: WordType  
Default: result  
Source: `SetDefaultWordType()`  
Logic: { //if (WordType is null){ // var result = GetDefaultWordType(view); // if (result != null && result != WordType){ // WordType = result; // } //} }

Field: Dictionary  
Default: Dictionary  
Source: `GetDefaultDictionary()`  
Logic: { return Dictionary; }

Field: Dictionary  
Default: result  
Source: `SetDefaultDictionary()`  
Logic: { //if (Dictionary is null){ // var result = GetDefaultDictionary(view); // if (result != null && result != Dictionary){ // Dictionary = result; // } //} }

Field: Creator  
Default: = null) Creator = GetDefaultCreator()  
Source: `SetDefaultCreator()`  
Logic: { //Code: 0580 Oid: 9507e261-3654-426f-bea8-1326ebbaf825 if(Creator == null) Creator = GetDefaultCreator(); }

Field: Creator  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultCreator()`  
Logic: { //Code: 0582 Oid: 74dc958f-022f-491c-909c-3d87457735a1 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 0546 Oid: 03e7f65c-c327-45cd-acbb-0a4fa1333023 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 0544 Oid: 5791ab39-beff-4847-8e66-2ff0497649b8 Update = GetDefaultUpdate(); }

Field: NoSignWord  
Default: NoSignWord  
Source: `GetDefaultNoSignWord()`  
Logic: { return NoSignWord; }

Field: NoSignWord  
Default: result  
Source: `SetDefaultNoSignWord()`  
Logic: { //if (NoSignWord is null){ // var result = GetDefaultNoSignWord(view); // if (result != null && result != NoSignWord){ // NoSignWord = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 0581ImportCode base.AfterConstruction(); SetDefaultCreator(); #endregion 0581ImportCode //SetDefaultName(View view = null); //SetDefaultTranslate(View view = null); //SetDefaultSentence(View view = null); //SetDefaultLanguageOri...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 0545ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0545ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- Creator [Detail=false]
- Dictionary [Detail=false]
- NoSignWord [Detail=false]
- TranslateWordList [Detail=true]
- Update [Detail=false]

Group: (default)
- LanguageOrigin [Order=1] [Detail=true]
- LanguageTranslate [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- Sentence [Order=1] [Detail=true]
- Translate [Order=1] [Detail=true]
- WordType [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | DictionaryWord | { Oid = Guid.NewGuid(); #region 0581ImportCode base.AfterConstruction(); SetDefaultCreator(); #endregion 0581ImportCode //SetDefaultName(View view = null); //SetDefaultTranslate(View view = null); //SetDefaultSentence(View view = null); //SetDefaultLanguageOri... |
| GetDefaultCreator | DictionaryWord | { //Code: 0582 Oid: 74dc958f-022f-491c-909c-3d87457735a1 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| GetDefaultDictionary | DictionaryWord | { return Dictionary; } |
| GetDefaultLanguageOrigin | DictionaryWord | { return LanguageOrigin; } |
| GetDefaultLanguageTranslate | DictionaryWord | { return LanguageTranslate; } |
| GetDefaultName | DictionaryWord | { return Name; } |
| GetDefaultNoSignWord | DictionaryWord | { return NoSignWord; } |
| GetDefaultSentence | DictionaryWord | { return Sentence; } |
| GetDefaultTranslate | DictionaryWord | { return Translate; } |
| GetDefaultUpdate | DictionaryWord | { //Code: 0546 Oid: 03e7f65c-c327-45cd-acbb-0a4fa1333023 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultWordType | DictionaryWord | { return WordType; } |
| OnLoaded | DictionaryWord | { base.OnLoaded(); } |
| OnSaving | DictionaryWord | { #region 0545ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0545ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ... |
| SetDefaultCreator | DictionaryWord | { //Code: 0580 Oid: 9507e261-3654-426f-bea8-1326ebbaf825 if(Creator == null) Creator = GetDefaultCreator(); } |
| SetDefaultDictionary | DictionaryWord | { //if (Dictionary is null){ // var result = GetDefaultDictionary(view); // if (result != null && result != Dictionary){ // Dictionary = result; // } //} } |
| SetDefaultLanguageOrigin | DictionaryWord | { //if (LanguageOrigin is null){ // var result = GetDefaultLanguageOrigin(view); // if (result != null && result != LanguageOrigin){ // LanguageOrigin = result; // } //} } |
| SetDefaultLanguageTranslate | DictionaryWord | { //if (LanguageTranslate is null){ // var result = GetDefaultLanguageTranslate(view); // if (result != null && result != LanguageTranslate){ // LanguageTranslate = result; // } //} } |
| SetDefaultName | DictionaryWord | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultNoSignWord | DictionaryWord | { //if (NoSignWord is null){ // var result = GetDefaultNoSignWord(view); // if (result != null && result != NoSignWord){ // NoSignWord = result; // } //} } |
| SetDefaultSentence | DictionaryWord | { //if (Sentence is null){ // var result = GetDefaultSentence(view); // if (result != null && result != Sentence){ // Sentence = result; // } //} } |
| SetDefaultTranslate | DictionaryWord | { //if (Translate is null){ // var result = GetDefaultTranslate(view); // if (result != null && result != Translate){ // Translate = result; // } //} } |
| SetDefaultUpdate | DictionaryWord | { //Code: 0544 Oid: 5791ab39-beff-4847-8e66-2ff0497649b8 Update = GetDefaultUpdate(); } |
| SetDefaultWordType | DictionaryWord | { //if (WordType is null){ // var result = GetDefaultWordType(view); // if (result != null && result != WordType){ // WordType = result; // } //} } |

---

# Entity: ElementBatch

Caption entity: `Lô thành phần`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Start | TimeSpan? | Bắt đầu | No | GetDefaultStart: Start<br>SetDefaultStart: result | true | true |   | 1 |
| End | TimeSpan? | Kết thúc | No | GetDefaultEnd: End<br>SetDefaultEnd: result | true | true |   | 1 |
| BatchTranslateList | XPCollection <Module.BusinessObjects.BatchTranslate> | Dịch lô | No |  | false | true |  |  |
| AudioList | XPCollection <Module.BusinessObjects.Audio> | Thành phần | No |  | false | true |  |  |
| Content | string | Nội dung | No | GetDefaultContent: Content<br>SetDefaultContent: result | true | true |  |  |
| Video | Module.BusinessObjects.Video | Tư liệu | No | GetDefaultVideo: Video<br>SetDefaultVideo: result | false | false |  |  |
| Quantity | decimal? | Số lượng | No | GetDefaultQuantity: Quantity<br>SetDefaultQuantity: result | true | false |  |  |

## Default Logic

Field: Start  
Default: Start  
Source: `GetDefaultStart()`  
Logic: { return Start; }

Field: Start  
Default: result  
Source: `SetDefaultStart()`  
Logic: { //if (Start is null){ // var result = GetDefaultStart(view); // if (result != null && result != Start){ // Start = result; // } //} }

Field: End  
Default: End  
Source: `GetDefaultEnd()`  
Logic: { return End; }

Field: End  
Default: result  
Source: `SetDefaultEnd()`  
Logic: { //if (End is null){ // var result = GetDefaultEnd(view); // if (result != null && result != End){ // End = result; // } //} }

Field: Content  
Default: Content  
Source: `GetDefaultContent()`  
Logic: { return Content; }

Field: Content  
Default: result  
Source: `SetDefaultContent()`  
Logic: { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} }

Field: Video  
Default: Video  
Source: `GetDefaultVideo()`  
Logic: { return Video; }

Field: Video  
Default: result  
Source: `SetDefaultVideo()`  
Logic: { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} }

Field: Quantity  
Default: Quantity  
Source: `GetDefaultQuantity()`  
Logic: { return Quantity; }

Field: Quantity  
Default: result  
Source: `SetDefaultQuantity()`  
Logic: { //if (Quantity is null){ // var result = GetDefaultQuantity(view); // if (result != null && result != Quantity){ // Quantity = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultStart(View view = null); //SetDefaultEnd(View view = null); //SetDefaultVideo(View view = null); //SetDefaultQuantity(View view = null); }

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- AudioList [Detail=true]
- BatchTranslateList [Detail=true]
- Content [Detail=true]
- Quantity [Detail=false]
- Video [Detail=false]

Group: (default)
- End [Order=1] [Detail=true]
- Start [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | ElementBatch | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultStart(View view = null); //SetDefaultEnd(View view = null); //SetDefaultVideo(View view = null); //SetDefaultQuantity(View view = null); } |
| GetDefaultContent | ElementBatch | { return Content; } |
| GetDefaultEnd | ElementBatch | { return End; } |
| GetDefaultQuantity | ElementBatch | { return Quantity; } |
| GetDefaultStart | ElementBatch | { return Start; } |
| GetDefaultVideo | ElementBatch | { return Video; } |
| OnLoaded | ElementBatch | { base.OnLoaded(); } |
| OnSaving | ElementBatch | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultContent | ElementBatch | { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} } |
| SetDefaultEnd | ElementBatch | { //if (End is null){ // var result = GetDefaultEnd(view); // if (result != null && result != End){ // End = result; // } //} } |
| SetDefaultQuantity | ElementBatch | { //if (Quantity is null){ // var result = GetDefaultQuantity(view); // if (result != null && result != Quantity){ // Quantity = result; // } //} } |
| SetDefaultStart | ElementBatch | { //if (Start is null){ // var result = GetDefaultStart(view); // if (result != null && result != Start){ // Start = result; // } //} } |
| SetDefaultVideo | ElementBatch | { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} } |

---

# Entity: ElementTranslate

Caption entity: `Dịch ngữ`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Start | TimeSpan? | Bắt đầu | No | GetDefaultStart: Start<br>SetDefaultStart: result | true | true |   | 1 |
| End | TimeSpan? | Kết thúc | No | GetDefaultEnd: End<br>SetDefaultEnd: result | true | true |   | 1 |
| Voice | Module.BusinessObjects.Voice | Giọng đọc | No | GetDefaultVoice: Voice<br>SetDefaultVoice: result | true | true |   | 1 |
| Content | string | Nội dung | No | GetDefaultContent: Content<br>SetDefaultContent: result | true | true |   | 1 |
| VoiceSpeed | decimal? | Tốc độ | No | GetDefaultVoiceSpeed: VoiceSpeed<br>SetDefaultVoiceSpeed: result | true | true |   | 1 |
| AudioLink | string | Tệp âm | No | GetDefaultAudioLink: AudioLink<br>SetDefaultAudioLink: result | true | true |   | 1 |
| AudioDuration | decimal? | Thời lượng âm | No | GetDefaultAudioDuration: AudioDuration<br>SetDefaultAudioDuration: result | true | true |   | 1 |
| Spelling | string | Phiên âm | No | GetDefaultSpelling: Spelling<br>SetDefaultSpelling: result | false | true |   | 1 |
| Audio | Module.BusinessObjects.Audio | Thành phần | No | GetDefaultAudio: Audio<br>SetDefaultAudio: result | false | false |  |  |
| AudioRate | decimal? | Suất âm | No | GetDefaultAudioRate: AudioRate<br>SetDefaultAudioRate: result | true | false |  |  |
| Language | Module.BusinessObjects.Language | Ngôn ngữ | No | GetDefaultLanguage: Language<br>SetDefaultLanguage: result | false | false |  |  |
| Update | DateTime? | Cập nhật | No | SetDefaultUpdate: GetDefaultUpdate()<br>GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null) | false | false |  |  |

## Default Logic

Field: Start  
Default: Start  
Source: `GetDefaultStart()`  
Logic: { return Start; }

Field: Start  
Default: result  
Source: `SetDefaultStart()`  
Logic: { //if (Start is null){ // var result = GetDefaultStart(view); // if (result != null && result != Start){ // Start = result; // } //} }

Field: End  
Default: End  
Source: `GetDefaultEnd()`  
Logic: { return End; }

Field: End  
Default: result  
Source: `SetDefaultEnd()`  
Logic: { //if (End is null){ // var result = GetDefaultEnd(view); // if (result != null && result != End){ // End = result; // } //} }

Field: Voice  
Default: Voice  
Source: `GetDefaultVoice()`  
Logic: { return Voice; }

Field: Voice  
Default: result  
Source: `SetDefaultVoice()`  
Logic: { //if (Voice is null){ // var result = GetDefaultVoice(view); // if (result != null && result != Voice){ // Voice = result; // } //} }

Field: Content  
Default: Content  
Source: `GetDefaultContent()`  
Logic: { return Content; }

Field: Content  
Default: result  
Source: `SetDefaultContent()`  
Logic: { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} }

Field: VoiceSpeed  
Default: VoiceSpeed  
Source: `GetDefaultVoiceSpeed()`  
Logic: { return VoiceSpeed; }

Field: VoiceSpeed  
Default: result  
Source: `SetDefaultVoiceSpeed()`  
Logic: { //if (VoiceSpeed is null){ // var result = GetDefaultVoiceSpeed(view); // if (result != null && result != VoiceSpeed){ // VoiceSpeed = result; // } //} }

Field: AudioLink  
Default: AudioLink  
Source: `GetDefaultAudioLink()`  
Logic: { return AudioLink; }

Field: AudioLink  
Default: result  
Source: `SetDefaultAudioLink()`  
Logic: { //if (AudioLink is null){ // var result = GetDefaultAudioLink(view); // if (result != null && result != AudioLink){ // AudioLink = result; // } //} }

Field: AudioDuration  
Default: AudioDuration  
Source: `GetDefaultAudioDuration()`  
Logic: { return AudioDuration; }

Field: AudioDuration  
Default: result  
Source: `SetDefaultAudioDuration()`  
Logic: { //if (AudioDuration is null){ // var result = GetDefaultAudioDuration(view); // if (result != null && result != AudioDuration){ // AudioDuration = result; // } //} }

Field: Spelling  
Default: Spelling  
Source: `GetDefaultSpelling()`  
Logic: { return Spelling; }

Field: Spelling  
Default: result  
Source: `SetDefaultSpelling()`  
Logic: { //if (Spelling is null){ // var result = GetDefaultSpelling(view); // if (result != null && result != Spelling){ // Spelling = result; // } //} }

Field: Audio  
Default: Audio  
Source: `GetDefaultAudio()`  
Logic: { return Audio; }

Field: Audio  
Default: result  
Source: `SetDefaultAudio()`  
Logic: { //if (Audio is null){ // var result = GetDefaultAudio(view); // if (result != null && result != Audio){ // Audio = result; // } //} }

Field: AudioRate  
Default: AudioRate  
Source: `GetDefaultAudioRate()`  
Logic: { return AudioRate; }

Field: AudioRate  
Default: result  
Source: `SetDefaultAudioRate()`  
Logic: { //if (AudioRate is null){ // var result = GetDefaultAudioRate(view); // if (result != null && result != AudioRate){ // AudioRate = result; // } //} }

Field: Language  
Default: Language  
Source: `GetDefaultLanguage()`  
Logic: { return Language; }

Field: Language  
Default: result  
Source: `SetDefaultLanguage()`  
Logic: { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 3334 Oid: d417fa8d-4efe-4fd0-8ed3-7729c40bea94 if (!IsDeleted) Update = GetDefaultUpdate(); }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 3336 Oid: 4f8d5b62-7900-43ca-a569-cc288f68ba8e return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 3337ImportCode base.AfterConstruction(); VoiceSpeed = 1; #endregion 3337ImportCode //SetDefaultStart(View view = null); //SetDefaultEnd(View view = null); //SetDefaultVoice(View view = null); //SetDefaultContent(View view = null...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 3335ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 3335ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- Audio [Detail=false]
- AudioRate [Detail=false]
- Language [Detail=false]
- Update [Detail=false]

Group: (default)
- AudioDuration [Order=1] [Detail=true]
- AudioLink [Order=1] [Detail=true]
- Content [Order=1] [Detail=true]
- End [Order=1] [Detail=true]
- Spelling [Order=1] [Detail=true]
- Start [Order=1] [Detail=true]
- Voice [Order=1] [Detail=true]
- VoiceSpeed [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | ElementTranslate | { Oid = Guid.NewGuid(); #region 3337ImportCode base.AfterConstruction(); VoiceSpeed = 1; #endregion 3337ImportCode //SetDefaultStart(View view = null); //SetDefaultEnd(View view = null); //SetDefaultVoice(View view = null); //SetDefaultContent(View view = null... |
| GetDefaultAudio | ElementTranslate | { return Audio; } |
| GetDefaultAudioDuration | ElementTranslate | { return AudioDuration; } |
| GetDefaultAudioLink | ElementTranslate | { return AudioLink; } |
| GetDefaultAudioRate | ElementTranslate | { return AudioRate; } |
| GetDefaultContent | ElementTranslate | { return Content; } |
| GetDefaultEnd | ElementTranslate | { return End; } |
| GetDefaultLanguage | ElementTranslate | { return Language; } |
| GetDefaultSpelling | ElementTranslate | { return Spelling; } |
| GetDefaultStart | ElementTranslate | { return Start; } |
| GetDefaultUpdate | ElementTranslate | { //Code: 3336 Oid: 4f8d5b62-7900-43ca-a569-cc288f68ba8e return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultVoice | ElementTranslate | { return Voice; } |
| GetDefaultVoiceSpeed | ElementTranslate | { return VoiceSpeed; } |
| OnLoaded | ElementTranslate | { base.OnLoaded(); } |
| OnSaving | ElementTranslate | { #region 3335ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 3335ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ... |
| SetDefaultAudio | ElementTranslate | { //if (Audio is null){ // var result = GetDefaultAudio(view); // if (result != null && result != Audio){ // Audio = result; // } //} } |
| SetDefaultAudioDuration | ElementTranslate | { //if (AudioDuration is null){ // var result = GetDefaultAudioDuration(view); // if (result != null && result != AudioDuration){ // AudioDuration = result; // } //} } |
| SetDefaultAudioLink | ElementTranslate | { //if (AudioLink is null){ // var result = GetDefaultAudioLink(view); // if (result != null && result != AudioLink){ // AudioLink = result; // } //} } |
| SetDefaultAudioRate | ElementTranslate | { //if (AudioRate is null){ // var result = GetDefaultAudioRate(view); // if (result != null && result != AudioRate){ // AudioRate = result; // } //} } |
| SetDefaultContent | ElementTranslate | { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} } |
| SetDefaultEnd | ElementTranslate | { //if (End is null){ // var result = GetDefaultEnd(view); // if (result != null && result != End){ // End = result; // } //} } |
| SetDefaultLanguage | ElementTranslate | { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} } |
| SetDefaultSpelling | ElementTranslate | { //if (Spelling is null){ // var result = GetDefaultSpelling(view); // if (result != null && result != Spelling){ // Spelling = result; // } //} } |
| SetDefaultStart | ElementTranslate | { //if (Start is null){ // var result = GetDefaultStart(view); // if (result != null && result != Start){ // Start = result; // } //} } |
| SetDefaultUpdate | ElementTranslate | { //Code: 3334 Oid: d417fa8d-4efe-4fd0-8ed3-7729c40bea94 if (!IsDeleted) Update = GetDefaultUpdate(); } |
| SetDefaultVoice | ElementTranslate | { //if (Voice is null){ // var result = GetDefaultVoice(view); // if (result != null && result != Voice){ // Voice = result; // } //} } |
| SetDefaultVoiceSpeed | ElementTranslate | { //if (VoiceSpeed is null){ // var result = GetDefaultVoiceSpeed(view); // if (result != null && result != VoiceSpeed){ // VoiceSpeed = result; // } //} } |

---

# Entity: ExceptionWord

Caption entity: `Phi thuật`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Meaning | string | Nghĩa | No | GetDefaultMeaning: Meaning<br>SetDefaultMeaning: result | true | true |   | 1 |
| WordType | WordType | Loại | No | GetDefaultWordType: WordType<br>SetDefaultWordType: result | true | true |   | 1 |
| Language | Module.BusinessObjects.Language | Ngôn ngữ | No | GetDefaultLanguage: Language<br>SetDefaultLanguage: result | true | true |   | 1 |
| Update | DateTime | Cập nhật | No | GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)<br>SetDefaultUpdate: GetDefaultUpdate() | true | false |  |  |
| Creator | Module.BusinessObjects.Member | Người tạo | No | GetDefaultCreator: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)<br>SetDefaultCreator: = null) Creator = GetDefaultCreator() | true | false |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Meaning  
Default: Meaning  
Source: `GetDefaultMeaning()`  
Logic: { return Meaning; }

Field: Meaning  
Default: result  
Source: `SetDefaultMeaning()`  
Logic: { //if (Meaning is null){ // var result = GetDefaultMeaning(view); // if (result != null && result != Meaning){ // Meaning = result; // } //} }

Field: WordType  
Default: WordType  
Source: `GetDefaultWordType()`  
Logic: { return WordType; }

Field: WordType  
Default: result  
Source: `SetDefaultWordType()`  
Logic: { //if (WordType is null){ // var result = GetDefaultWordType(view); // if (result != null && result != WordType){ // WordType = result; // } //} }

Field: Language  
Default: Language  
Source: `GetDefaultLanguage()`  
Logic: { return Language; }

Field: Language  
Default: result  
Source: `SetDefaultLanguage()`  
Logic: { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 0568 Oid: 555893c0-b8ff-43b0-8449-e1ab0a341bb1 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 0566 Oid: ccd3e08c-e9d7-4e57-a246-4ea22d8ac64a Update = GetDefaultUpdate(); }

Field: Creator  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultCreator()`  
Logic: { //Code: 0565 Oid: eac8602d-e669-4255-b6fc-29233d38f427 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: Creator  
Default: = null) Creator = GetDefaultCreator()  
Source: `SetDefaultCreator()`  
Logic: { //Code: 0563 Oid: ec7e153a-d0c1-4346-945e-4458c3f9c63e if(Creator == null) Creator = GetDefaultCreator(); }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 0564ImportCode base.AfterConstruction(); SetDefaultCreator(); #endregion 0564ImportCode //SetDefaultName(View view = null); //SetDefaultMeaning(View view = null); //SetDefaultWordType(View view = null); //SetDefaultLanguage(View...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 0567ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0567ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- Creator [Detail=false]
- Update [Detail=false]

Group: (default)
- Language [Order=1] [Detail=true]
- Meaning [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- WordType [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | ExceptionWord | { Oid = Guid.NewGuid(); #region 0564ImportCode base.AfterConstruction(); SetDefaultCreator(); #endregion 0564ImportCode //SetDefaultName(View view = null); //SetDefaultMeaning(View view = null); //SetDefaultWordType(View view = null); //SetDefaultLanguage(View... |
| GetDefaultCreator | ExceptionWord | { //Code: 0565 Oid: eac8602d-e669-4255-b6fc-29233d38f427 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| GetDefaultLanguage | ExceptionWord | { return Language; } |
| GetDefaultMeaning | ExceptionWord | { return Meaning; } |
| GetDefaultName | ExceptionWord | { return Name; } |
| GetDefaultUpdate | ExceptionWord | { //Code: 0568 Oid: 555893c0-b8ff-43b0-8449-e1ab0a341bb1 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultWordType | ExceptionWord | { return WordType; } |
| OnLoaded | ExceptionWord | { base.OnLoaded(); } |
| OnSaving | ExceptionWord | { #region 0567ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0567ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ... |
| SetDefaultCreator | ExceptionWord | { //Code: 0563 Oid: ec7e153a-d0c1-4346-945e-4458c3f9c63e if(Creator == null) Creator = GetDefaultCreator(); } |
| SetDefaultLanguage | ExceptionWord | { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} } |
| SetDefaultMeaning | ExceptionWord | { //if (Meaning is null){ // var result = GetDefaultMeaning(view); // if (result != null && result != Meaning){ // Meaning = result; // } //} } |
| SetDefaultName | ExceptionWord | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultUpdate | ExceptionWord | { //Code: 0566 Oid: ccd3e08c-e9d7-4e57-a246-4ea22d8ac64a Update = GetDefaultUpdate(); } |
| SetDefaultWordType | ExceptionWord | { //if (WordType is null){ // var result = GetDefaultWordType(view); // if (result != null && result != WordType){ // WordType = result; // } //} } |

---

# Entity: Folder

Caption entity: `Thư mục`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| FolderType | SoftwareObjectType | Loại | No | GetDefaultFolderType: FolderType<br>SetDefaultFolderType: result | true | true |   | 1 |
| UpperFolder | Module.BusinessObjects.Folder | Cấp trên | No | GetDefaultUpperFolder: UpperFolder<br>SetDefaultUpperFolder: result | false | true |   | 1 |
| Order | int? | Thứ tự | No | GetDefaultOrder: Computed in GetDefaultOrder<br>SetDefaultOrder: GetDefaultOrder() | false | true |   | 1 |
| URL | string | Đường dẫn | No | GetDefaultURL: URL<br>SetDefaultURL: result | false | true |   | 1 |
| Image | byte[] | Biểu tượng | No | SetDefaultImage: result | false | true |   | 1 |
| Member | Module.BusinessObjects.Member | Quản lý | No | SetDefaultMember: = null) Member = GetDefaultMember()<br>GetDefaultMember: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session) | true | true |   | 1 |
| ProductList | XPCollection<Module.BusinessObjects.Product> | Sản phẩm n-n | No |  | false | false |  |  |
| GroupProductList | XPCollection<Module.BusinessObjects.Product> | Sản phẩm | No |  | false | true |  |  |
| PermissionPolicyRole | DevExpress.Persistent.BaseImpl.PermissionPolicy.PermissionPolicyRole | Nhóm | No | GetDefaultPermissionPolicyRole: PermissionPolicyRole<br>SetDefaultPermissionPolicyRole: result | true | true |   | 1 |
| Open | bool? | Công khai | No | GetDefaultOpen: Open<br>SetDefaultOpen: result | true | true |   | 1 |
| PostList | XPCollection <Module.BusinessObjects.Post> | Bài viết | No |  | false | true |  |  |
| Content | string | Nội dung | No | GetDefaultContent: Content<br>SetDefaultContent: result | false | true |  |  |
| LowerFolder | XPCollection <Module.BusinessObjects.Folder> | Cấp dưới | No |  | false | true |  |  |
| VideoList | XPCollection <Module.BusinessObjects.Video> | Tư liệu | No |  | false | true |  |  |
| BookMarkList | XPCollection <Module.BusinessObjects.BookMark> | Liên kết | No |  | false | true |  |  |
| ObjectRelationList | XPCollection <Module.BusinessObjects.ObjectRelation> | Quan hệ | No |  | false | true |  |  |
| Parent | DevExpress.Persistent.Base.General.ITreeNode | Parent | No | GetDefaultParent: Parent<br>SetDefaultParent: result | false | false |  |  |
| Update | DateTime? | Cập nhật | No | GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)<br>SetDefaultUpdate: GetDefaultUpdate() | false | false |  |  |
| CreatedDate | DateTime? | Ngày | No | GetDefaultCreatedDate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)<br>SetDefaultCreatedDate: = null) CreatedDate = GetDefaultCreatedDate() | false | false |  |  |
| Children | System.ComponentModel.IBindingList | Children | No | GetDefaultChildren: Children<br>SetDefaultChildren: result | false | false |  |  |
| Quantity | decimal? | Số lượng | No | SetDefaultQuantity: quantity<br>GetDefaultQuantity: Computed in GetDefaultQuantity | false | false |  |  |
| Code | string | Mã | No | GetDefaultCode: Computed in GetDefaultCode<br>SetDefaultCode: result | false | false |  |  |
| SystemType | System.Type | Kiểu hệ thống | No | GetDefaultSystemType: SystemType<br>SetDefaultSystemType: result | false | false |  |  |
| Close | bool | Riêng tư | No | GetDefaultClose: Close<br>SetDefaultClose: result | false | false |  |  |
| InActive | bool | Ngừng | No | GetDefaultInActive: InActive<br>SetDefaultInActive: result | false | false |  |  |
| MemberFolder | Module.BusinessObjects.Folder | Tập thể | No |  | false | false |  |  |
| Flag | bool | Cờ | No | GetDefaultFlag: Flag<br>SetDefaultFlag: result | false | false |  |  |
| Flag2 | bool | Cờ 2 | No | GetDefaultFlag2: Flag2<br>SetDefaultFlag2: result | false | false |  |  |
| Display | bool |  | No |  |  |  |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: FolderType  
Default: FolderType  
Source: `GetDefaultFolderType()`  
Logic: { return FolderType; }

Field: FolderType  
Default: result  
Source: `SetDefaultFolderType()`  
Logic: { //if (FolderType is null){ // var result = GetDefaultFolderType(view); // if (result != null && result != FolderType){ // FolderType = result; // } //} }

Field: UpperFolder  
Default: UpperFolder  
Source: `GetDefaultUpperFolder()`  
Logic: { return UpperFolder; }

Field: UpperFolder  
Default: result  
Source: `SetDefaultUpperFolder()`  
Logic: { //if (UpperFolder is null){ // var result = GetDefaultUpperFolder(view); // if (result != null && result != UpperFolder){ // UpperFolder = result; // } //} }

Field: Order  
Default: Computed in GetDefaultOrder  
Source: `GetDefaultOrder()`  
Logic: { //Code: 0322 Oid: 2de6efe7-4f4f-444b-9eb4-4158bbe4701d if (UpperFolder != null && UpperFolder.LowerFolder != null) { var lasted = UpperFolder.LowerFolder.Where(m => m.Order != null).OrderByDescending(m => m.Order).FirstOrDefault(); if (lasted != null) return...

Field: Order  
Default: GetDefaultOrder()  
Source: `SetDefaultOrder()`  
Logic: { //Code: 0323 Oid: 47c6a978-a138-4035-9595-683e536c290b Order= GetDefaultOrder(); }

Field: URL  
Default: URL  
Source: `GetDefaultURL()`  
Logic: { return URL; }

Field: URL  
Default: result  
Source: `SetDefaultURL()`  
Logic: { //if (URL is null){ // var result = GetDefaultURL(view); // if (result != null && result != URL){ // URL = result; // } //} }

Field: Image  
Default: result  
Source: `SetDefaultImage()`  
Logic: { //if (Image is null){ // var result = GetDefaultImage(view); // if (result != null && result != Image){ // Image = result; // } //} }

Field: Member  
Default: = null) Member = GetDefaultMember()  
Source: `SetDefaultMember()`  
Logic: { //Code: 1075 Oid: 628eab1d-492e-40d7-be90-00a0bfa3b020 if(Member == null) Member = GetDefaultMember(); }

Field: Member  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultMember()`  
Logic: { //Code: 1077 Oid: ee4fc3a4-3c4a-4b39-b901-eff6ae43e6f7 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: PermissionPolicyRole  
Default: PermissionPolicyRole  
Source: `GetDefaultPermissionPolicyRole()`  
Logic: { return PermissionPolicyRole; }

Field: PermissionPolicyRole  
Default: result  
Source: `SetDefaultPermissionPolicyRole()`  
Logic: { //if (PermissionPolicyRole is null){ // var result = GetDefaultPermissionPolicyRole(view); // if (result != null && result != PermissionPolicyRole){ // PermissionPolicyRole = result; // } //} }

Field: Open  
Default: Open  
Source: `GetDefaultOpen()`  
Logic: { return Open; }

Field: Open  
Default: result  
Source: `SetDefaultOpen()`  
Logic: { //if (Open is null){ // var result = GetDefaultOpen(view); // if (result != null && result != Open){ // Open = result; // } //} }

Field: Content  
Default: Content  
Source: `GetDefaultContent()`  
Logic: { return Content; }

Field: Content  
Default: result  
Source: `SetDefaultContent()`  
Logic: { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} }

Field: Parent  
Default: Parent  
Source: `GetDefaultParent()`  
Logic: { return Parent; }

Field: Parent  
Default: result  
Source: `SetDefaultParent()`  
Logic: { //if (Parent is null){ // var result = GetDefaultParent(view); // if (result != null && result != Parent){ // Parent = result; // } //} }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 1068 Oid: c5bb4fa9-78a1-4c0c-9815-08ef98f12bef return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 1066 Oid: dbf70a98-7000-4b69-83dd-addd66d1f765 Update = GetDefaultUpdate(); }

Field: CreatedDate  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultCreatedDate()`  
Logic: { //Code: 1368 Oid: 4c59f4b9-9e90-438d-8319-eee99215c9d3 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: CreatedDate  
Default: = null) CreatedDate = GetDefaultCreatedDate()  
Source: `SetDefaultCreatedDate()`  
Logic: { //Code: 1369 Oid: 59305813-54c2-4d9b-a3c6-061cec78583c if(CreatedDate == null) CreatedDate = GetDefaultCreatedDate(); }

Field: Children  
Default: Children  
Source: `GetDefaultChildren()`  
Logic: { return Children; }

Field: Children  
Default: result  
Source: `SetDefaultChildren()`  
Logic: { //if (Children is null){ // var result = GetDefaultChildren(view); // if (result != null && result != Children){ // Children = result; // } //} }

Field: Quantity  
Default: quantity  
Source: `SetDefaultQuantity()`  
Logic: { //Code: 1089 Oid: 4bfc8b87-4764-43b6-b834-679ef61cd93e if (BookMarkList.Count > 0) { var quantity = GetDefaultQuantity(); if (Quantity != quantity) Quantity = quantity; } }

Field: Quantity  
Default: Computed in GetDefaultQuantity  
Source: `GetDefaultQuantity()`  
Logic: { //Code: 1088 Oid: 92958384-7030-40b3-991e-06094dc85ed3 //Code: 1336 Oid: 92958384-7030-40b3-991e-06094dc85ed3 decimal total = 0; if (BookMarkList != null) total += BookMarkList.Count; foreach (var childFolder in LowerFolder) { var childFolderQuantity = child...

Field: Code  
Default: Computed in GetDefaultCode  
Source: `GetDefaultCode()`  
Logic: { //Code: 1110 Oid: 5ff83860-eaed-4f09-953e-5e33d2d0ddf7 string result = ""; var sort = new DevExpress.Xpo.SortProperty(nameof(Order), DevExpress.Xpo.DB.SortingDirection.Descending); var criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse("UpperFolder ...

Field: Code  
Default: result  
Source: `SetDefaultCode()`  
Logic: { //Code: 1111 Oid: 54df7743-29af-4bba-a705-1b381e970860 if (string.IsNullOrEmpty(Code)) { var result = GetDefaultCode(); if (result != null && result != Code) { Code = result; } } }

Field: SystemType  
Default: SystemType  
Source: `GetDefaultSystemType()`  
Logic: { return SystemType; }

Field: SystemType  
Default: result  
Source: `SetDefaultSystemType()`  
Logic: { //if (SystemType is null){ // var result = GetDefaultSystemType(view); // if (result != null && result != SystemType){ // SystemType = result; // } //} }

Field: Close  
Default: Close  
Source: `GetDefaultClose()`  
Logic: { return Close; }

Field: Close  
Default: result  
Source: `SetDefaultClose()`  
Logic: { //if (Close is null){ // var result = GetDefaultClose(view); // if (result != null && result != Close){ // Close = result; // } //} }

Field: InActive  
Default: InActive  
Source: `GetDefaultInActive()`  
Logic: { return InActive; }

Field: InActive  
Default: result  
Source: `SetDefaultInActive()`  
Logic: { //if (InActive is null){ // var result = GetDefaultInActive(view); // if (result != null && result != InActive){ // InActive = result; // } //} }

Field: Flag  
Default: Flag  
Source: `GetDefaultFlag()`  
Logic: { return Flag; }

Field: Flag  
Default: result  
Source: `SetDefaultFlag()`  
Logic: { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} }

Field: Flag2  
Default: Flag2  
Source: `GetDefaultFlag2()`  
Logic: { return Flag2; }

Field: Flag2  
Default: result  
Source: `SetDefaultFlag2()`  
Logic: { //if (Flag2 is null){ // var result = GetDefaultFlag2(view); // if (result != null && result != Flag2){ // Flag2 = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 1076ImportCode base.AfterConstruction(); Open = null; SetDefaultMember(); SetDefaultCreatedDate(); #endregion 1076ImportCode Display = true; //SetDefaultName(View view = null); //SetDefaultFolderType(View view = null); //SetDefa...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 1067ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 1067ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- BookMarkList [Detail=true]
- Children [Detail=false]
- Close [Detail=false]
- Code [Detail=false]
- Content [Detail=true]
- CreatedDate [Detail=false]
- Display
- Flag [Detail=false]
- Flag2 [Detail=false]
- GroupProductList [Detail=true]
- InActive [Detail=false]
- LowerFolder [Detail=true]
- MemberFolder [Detail=false]
- ObjectRelationList [Detail=true]
- Parent [Detail=false]
- PostList [Detail=true]
- ProductList [Detail=false]
- Quantity [Detail=false]
- SystemType [Detail=false]
- Update [Detail=false]
- VideoList [Detail=true]

Group: (default)
- FolderType [Order=1] [Detail=true]
- Image [Order=1] [Detail=true]
- Member [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- Open [Order=1] [Detail=true]
- Order [Order=1] [Detail=true]
- PermissionPolicyRole [Order=1] [Detail=true]
- URL [Order=1] [Detail=true]
- UpperFolder [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | Folder | { Oid = Guid.NewGuid(); #region 1076ImportCode base.AfterConstruction(); Open = null; SetDefaultMember(); SetDefaultCreatedDate(); #endregion 1076ImportCode Display = true; //SetDefaultName(View view = null); //SetDefaultFolderType(View view = null); //SetDefa... |
| GetDefaultChildren | Folder | { return Children; } |
| GetDefaultClose | Folder | { return Close; } |
| GetDefaultCode | Folder | { //Code: 1110 Oid: 5ff83860-eaed-4f09-953e-5e33d2d0ddf7 string result = ""; var sort = new DevExpress.Xpo.SortProperty(nameof(Order), DevExpress.Xpo.DB.SortingDirection.Descending); var criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse("UpperFolder ... |
| GetDefaultContent | Folder | { return Content; } |
| GetDefaultCreatedDate | Folder | { //Code: 1368 Oid: 4c59f4b9-9e90-438d-8319-eee99215c9d3 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultFlag | Folder | { return Flag; } |
| GetDefaultFlag2 | Folder | { return Flag2; } |
| GetDefaultFolderType | Folder | { return FolderType; } |
| GetDefaultInActive | Folder | { return InActive; } |
| GetDefaultMember | Folder | { //Code: 1077 Oid: ee4fc3a4-3c4a-4b39-b901-eff6ae43e6f7 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| GetDefaultName | Folder | { return Name; } |
| GetDefaultOpen | Folder | { return Open; } |
| GetDefaultOrder | Folder | { //Code: 0322 Oid: 2de6efe7-4f4f-444b-9eb4-4158bbe4701d if (UpperFolder != null && UpperFolder.LowerFolder != null) { var lasted = UpperFolder.LowerFolder.Where(m => m.Order != null).OrderByDescending(m => m.Order).FirstOrDefault(); if (lasted != null) return... |
| GetDefaultParent | Folder | { return Parent; } |
| GetDefaultPermissionPolicyRole | Folder | { return PermissionPolicyRole; } |
| GetDefaultQuantity | Folder | { //Code: 1088 Oid: 92958384-7030-40b3-991e-06094dc85ed3 //Code: 1336 Oid: 92958384-7030-40b3-991e-06094dc85ed3 decimal total = 0; if (BookMarkList != null) total += BookMarkList.Count; foreach (var childFolder in LowerFolder) { var childFolderQuantity = child... |
| GetDefaultSystemType | Folder | { return SystemType; } |
| GetDefaultURL | Folder | { return URL; } |
| GetDefaultUpdate | Folder | { //Code: 1068 Oid: c5bb4fa9-78a1-4c0c-9815-08ef98f12bef return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultUpperFolder | Folder | { return UpperFolder; } |
| OnLoaded | Folder | { base.OnLoaded(); } |
| OnSaving | Folder | { #region 1067ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 1067ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ... |
| SetDefaultChildren | Folder | { //if (Children is null){ // var result = GetDefaultChildren(view); // if (result != null && result != Children){ // Children = result; // } //} } |
| SetDefaultClose | Folder | { //if (Close is null){ // var result = GetDefaultClose(view); // if (result != null && result != Close){ // Close = result; // } //} } |
| SetDefaultCode | Folder | { //Code: 1111 Oid: 54df7743-29af-4bba-a705-1b381e970860 if (string.IsNullOrEmpty(Code)) { var result = GetDefaultCode(); if (result != null && result != Code) { Code = result; } } } |
| SetDefaultContent | Folder | { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} } |
| SetDefaultCreatedDate | Folder | { //Code: 1369 Oid: 59305813-54c2-4d9b-a3c6-061cec78583c if(CreatedDate == null) CreatedDate = GetDefaultCreatedDate(); } |
| SetDefaultFlag | Folder | { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} } |
| SetDefaultFlag2 | Folder | { //if (Flag2 is null){ // var result = GetDefaultFlag2(view); // if (result != null && result != Flag2){ // Flag2 = result; // } //} } |
| SetDefaultFolderType | Folder | { //if (FolderType is null){ // var result = GetDefaultFolderType(view); // if (result != null && result != FolderType){ // FolderType = result; // } //} } |
| SetDefaultImage | Folder | { //if (Image is null){ // var result = GetDefaultImage(view); // if (result != null && result != Image){ // Image = result; // } //} } |
| SetDefaultInActive | Folder | { //if (InActive is null){ // var result = GetDefaultInActive(view); // if (result != null && result != InActive){ // InActive = result; // } //} } |
| SetDefaultMember | Folder | { //Code: 1075 Oid: 628eab1d-492e-40d7-be90-00a0bfa3b020 if(Member == null) Member = GetDefaultMember(); } |
| SetDefaultName | Folder | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultOpen | Folder | { //if (Open is null){ // var result = GetDefaultOpen(view); // if (result != null && result != Open){ // Open = result; // } //} } |
| SetDefaultOrder | Folder | { //Code: 0323 Oid: 47c6a978-a138-4035-9595-683e536c290b Order= GetDefaultOrder(); } |
| SetDefaultParent | Folder | { //if (Parent is null){ // var result = GetDefaultParent(view); // if (result != null && result != Parent){ // Parent = result; // } //} } |
| SetDefaultPermissionPolicyRole | Folder | { //if (PermissionPolicyRole is null){ // var result = GetDefaultPermissionPolicyRole(view); // if (result != null && result != PermissionPolicyRole){ // PermissionPolicyRole = result; // } //} } |
| SetDefaultQuantity | Folder | { //Code: 1089 Oid: 4bfc8b87-4764-43b6-b834-679ef61cd93e if (BookMarkList.Count > 0) { var quantity = GetDefaultQuantity(); if (Quantity != quantity) Quantity = quantity; } } |
| SetDefaultSystemType | Folder | { //if (SystemType is null){ // var result = GetDefaultSystemType(view); // if (result != null && result != SystemType){ // SystemType = result; // } //} } |
| SetDefaultURL | Folder | { //if (URL is null){ // var result = GetDefaultURL(view); // if (result != null && result != URL){ // URL = result; // } //} } |
| SetDefaultUpdate | Folder | { //Code: 1066 Oid: dbf70a98-7000-4b69-83dd-addd66d1f765 Update = GetDefaultUpdate(); } |
| SetDefaultUpperFolder | Folder | { //if (UpperFolder is null){ // var result = GetDefaultUpperFolder(view); // if (result != null && result != UpperFolder){ // UpperFolder = result; // } //} } |

---

# Entity: GoogleBucket

Caption entity: `Thư mục chia sẻ`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| CloudURL | string | Cloud URL | No | GetDefaultCloudURL: CloudURL<br>SetDefaultCloudURL: result | true | true |   | 1 |
| GsURI | string | Gs URI | No | GetDefaultGsURI: GsURI<br>SetDefaultGsURI: result | true | true |   | 1 |
| Notes | string | Ghi chú | No | GetDefaultNotes: Notes<br>SetDefaultNotes: result | false | true |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: CloudURL  
Default: CloudURL  
Source: `GetDefaultCloudURL()`  
Logic: { return CloudURL; }

Field: CloudURL  
Default: result  
Source: `SetDefaultCloudURL()`  
Logic: { //if (CloudURL is null){ // var result = GetDefaultCloudURL(view); // if (result != null && result != CloudURL){ // CloudURL = result; // } //} }

Field: GsURI  
Default: GsURI  
Source: `GetDefaultGsURI()`  
Logic: { return GsURI; }

Field: GsURI  
Default: result  
Source: `SetDefaultGsURI()`  
Logic: { //if (GsURI is null){ // var result = GetDefaultGsURI(view); // if (result != null && result != GsURI){ // GsURI = result; // } //} }

Field: Notes  
Default: Notes  
Source: `GetDefaultNotes()`  
Logic: { return Notes; }

Field: Notes  
Default: result  
Source: `SetDefaultNotes()`  
Logic: { //if (Notes is null){ // var result = GetDefaultNotes(view); // if (result != null && result != Notes){ // Notes = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultCloudURL(View view = null); //SetDefaultGsURI(View view = null); }

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- Notes [Detail=true]

Group: (default)
- CloudURL [Order=1] [Detail=true]
- GsURI [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | GoogleBucket | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultCloudURL(View view = null); //SetDefaultGsURI(View view = null); } |
| GetDefaultCloudURL | GoogleBucket | { return CloudURL; } |
| GetDefaultGsURI | GoogleBucket | { return GsURI; } |
| GetDefaultName | GoogleBucket | { return Name; } |
| GetDefaultNotes | GoogleBucket | { return Notes; } |
| OnLoaded | GoogleBucket | { base.OnLoaded(); } |
| OnSaving | GoogleBucket | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultCloudURL | GoogleBucket | { //if (CloudURL is null){ // var result = GetDefaultCloudURL(view); // if (result != null && result != CloudURL){ // CloudURL = result; // } //} } |
| SetDefaultGsURI | GoogleBucket | { //if (GsURI is null){ // var result = GetDefaultGsURI(view); // if (result != null && result != GsURI){ // GsURI = result; // } //} } |
| SetDefaultName | GoogleBucket | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultNotes | GoogleBucket | { //if (Notes is null){ // var result = GetDefaultNotes(view); // if (result != null && result != Notes){ // Notes = result; // } //} } |

---

# Entity: GoogleKey

Caption entity: `Google Key`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| FileData | DevExpress.Persistent.BaseImpl.FileData | Tập đính kèm | No | GetDefaultFileData: FileData<br>SetDefaultFileData: result | true | true |   | 1 |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: FileData  
Default: FileData  
Source: `GetDefaultFileData()`  
Logic: { return FileData; }

Field: FileData  
Default: result  
Source: `SetDefaultFileData()`  
Logic: { //if (FileData is null){ // var result = GetDefaultFileData(view); // if (result != null && result != FileData){ // FileData = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultFileData(View view = null); }

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete

Group: (default)
- FileData [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | GoogleKey | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultFileData(View view = null); } |
| GetDefaultFileData | GoogleKey | { return FileData; } |
| GetDefaultName | GoogleKey | { return Name; } |
| OnLoaded | GoogleKey | { base.OnLoaded(); } |
| OnSaving | GoogleKey | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultFileData | GoogleKey | { //if (FileData is null){ // var result = GetDefaultFileData(view); // if (result != null && result != FileData){ // FileData = result; // } //} } |
| SetDefaultName | GoogleKey | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |

---

# Entity: GradeSubject

Caption entity: `Môn`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | Yes | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| English | string | Tiếng Anh | No | GetDefaultEnglish: English<br>SetDefaultEnglish: result | true | true |   | 1 |
| Code | string | Mã | Yes | GetDefaultCode: Code<br>SetDefaultCode: result | true | true |   | 1 |
| Order | int? | Thứ tự | No | GetDefaultOrder: Order<br>SetDefaultOrder: result | false | false |  |  |
| InActive | bool | Ngừng | No | GetDefaultInActive: InActive<br>SetDefaultInActive: result | false | false |  |  |
| Update | DateTime | Cập nhật | No | SetDefaultUpdate: GetDefaultUpdate()<br>GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null) | false | false |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: English  
Default: English  
Source: `GetDefaultEnglish()`  
Logic: { return English; }

Field: English  
Default: result  
Source: `SetDefaultEnglish()`  
Logic: { //if (English is null){ // var result = GetDefaultEnglish(view); // if (result != null && result != English){ // English = result; // } //} }

Field: Code  
Default: Code  
Source: `GetDefaultCode()`  
Logic: { return Code; }

Field: Code  
Default: result  
Source: `SetDefaultCode()`  
Logic: { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} }

Field: Order  
Default: Order  
Source: `GetDefaultOrder()`  
Logic: { return Order; }

Field: Order  
Default: result  
Source: `SetDefaultOrder()`  
Logic: { //if (Order is null){ // var result = GetDefaultOrder(view); // if (result != null && result != Order){ // Order = result; // } //} }

Field: InActive  
Default: InActive  
Source: `GetDefaultInActive()`  
Logic: { return InActive; }

Field: InActive  
Default: result  
Source: `SetDefaultInActive()`  
Logic: { //if (InActive is null){ // var result = GetDefaultInActive(view); // if (result != null && result != InActive){ // InActive = result; // } //} }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 0085 Oid: 42c0fba7-d461-42f3-bc99-4b5424ac5736 Update = GetDefaultUpdate(); }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 0149 Oid: 7312304d-13b3-492f-8350-eacd3e08f96d return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 0363ImportCode base.AfterConstruction(); SetDefaultUpdate(); #endregion 0363ImportCode //SetDefaultName(View view = null); //SetDefaultEnglish(View view = null); //SetDefaultCode(View view = null); //SetDefaultOrder(View view = ...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 0486ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0486ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- InActive [Detail=false]
- Order [Detail=false]
- Update [Detail=false]

Group: (default)
- Code [Order=1] [Detail=true]
- English [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | GradeSubject | { Oid = Guid.NewGuid(); #region 0363ImportCode base.AfterConstruction(); SetDefaultUpdate(); #endregion 0363ImportCode //SetDefaultName(View view = null); //SetDefaultEnglish(View view = null); //SetDefaultCode(View view = null); //SetDefaultOrder(View view = ... |
| GetDefaultCode | GradeSubject | { return Code; } |
| GetDefaultEnglish | GradeSubject | { return English; } |
| GetDefaultInActive | GradeSubject | { return InActive; } |
| GetDefaultName | GradeSubject | { return Name; } |
| GetDefaultOrder | GradeSubject | { return Order; } |
| GetDefaultUpdate | GradeSubject | { //Code: 0149 Oid: 7312304d-13b3-492f-8350-eacd3e08f96d return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| OnLoaded | GradeSubject | { base.OnLoaded(); } |
| OnSaving | GradeSubject | { #region 0486ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0486ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ... |
| SetDefaultCode | GradeSubject | { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} } |
| SetDefaultEnglish | GradeSubject | { //if (English is null){ // var result = GetDefaultEnglish(view); // if (result != null && result != English){ // English = result; // } //} } |
| SetDefaultInActive | GradeSubject | { //if (InActive is null){ // var result = GetDefaultInActive(view); // if (result != null && result != InActive){ // InActive = result; // } //} } |
| SetDefaultName | GradeSubject | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultOrder | GradeSubject | { //if (Order is null){ // var result = GetDefaultOrder(view); // if (result != null && result != Order){ // Order = result; // } //} } |
| SetDefaultUpdate | GradeSubject | { //Code: 0085 Oid: 42c0fba7-d461-42f3-bc99-4b5424ac5736 Update = GetDefaultUpdate(); } |

---

# Entity: Language

Caption entity: `Ngôn ngữ`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | Yes | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| EnglishName | string | Tiếng Anh | No | GetDefaultEnglishName: EnglishName<br>SetDefaultEnglishName: result | true | true |   | 1 |
| OriginName | string | Bản ngữ | No | GetDefaultOriginName: OriginName<br>SetDefaultOriginName: result | true | true |   | 1 |
| Code | string | Mã ISO | No | GetDefaultCode: Code<br>SetDefaultCode: result | true | true |   | 1 |
| LocaleCode | string | Mã vực | No | GetDefaultLocaleCode: LocaleCode<br>SetDefaultLocaleCode: result | true | true |   | 1 |
| Speaker | int? | Số người | No | GetDefaultSpeaker: Speaker<br>SetDefaultSpeaker: result | false | true |   | 1 |
| Character | string | Ký tự | No | GetDefaultCharacter: Character<br>SetDefaultCharacter: result | false | true |   | 1 |
| Vowel | string | Nguyên âm | No | GetDefaultVowel: Vowel<br>SetDefaultVowel: result | false | true |   | 1 |
| RepeatCharacter | string | Ký tự lặp | No | GetDefaultRepeatCharacter: RepeatCharacter<br>SetDefaultRepeatCharacter: result | false | true |   | 1 |
| NotUpCase | string | Từ không hoa | No | GetDefaultNotUpCase: NotUpCase<br>SetDefaultNotUpCase: result | false | true |   | 1 |
| VideoList | XPCollection <Module.BusinessObjects.Video> | Tư liệu | No |  | false | false |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: EnglishName  
Default: EnglishName  
Source: `GetDefaultEnglishName()`  
Logic: { return EnglishName; }

Field: EnglishName  
Default: result  
Source: `SetDefaultEnglishName()`  
Logic: { //if (EnglishName is null){ // var result = GetDefaultEnglishName(view); // if (result != null && result != EnglishName){ // EnglishName = result; // } //} }

Field: OriginName  
Default: OriginName  
Source: `GetDefaultOriginName()`  
Logic: { return OriginName; }

Field: OriginName  
Default: result  
Source: `SetDefaultOriginName()`  
Logic: { //if (OriginName is null){ // var result = GetDefaultOriginName(view); // if (result != null && result != OriginName){ // OriginName = result; // } //} }

Field: Code  
Default: Code  
Source: `GetDefaultCode()`  
Logic: { return Code; }

Field: Code  
Default: result  
Source: `SetDefaultCode()`  
Logic: { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} }

Field: LocaleCode  
Default: LocaleCode  
Source: `GetDefaultLocaleCode()`  
Logic: { return LocaleCode; }

Field: LocaleCode  
Default: result  
Source: `SetDefaultLocaleCode()`  
Logic: { //if (LocaleCode is null){ // var result = GetDefaultLocaleCode(view); // if (result != null && result != LocaleCode){ // LocaleCode = result; // } //} }

Field: Speaker  
Default: Speaker  
Source: `GetDefaultSpeaker()`  
Logic: { return Speaker; }

Field: Speaker  
Default: result  
Source: `SetDefaultSpeaker()`  
Logic: { //if (Speaker is null){ // var result = GetDefaultSpeaker(view); // if (result != null && result != Speaker){ // Speaker = result; // } //} }

Field: Character  
Default: Character  
Source: `GetDefaultCharacter()`  
Logic: { return Character; }

Field: Character  
Default: result  
Source: `SetDefaultCharacter()`  
Logic: { //if (Character is null){ // var result = GetDefaultCharacter(view); // if (result != null && result != Character){ // Character = result; // } //} }

Field: Vowel  
Default: Vowel  
Source: `GetDefaultVowel()`  
Logic: { return Vowel; }

Field: Vowel  
Default: result  
Source: `SetDefaultVowel()`  
Logic: { //if (Vowel is null){ // var result = GetDefaultVowel(view); // if (result != null && result != Vowel){ // Vowel = result; // } //} }

Field: RepeatCharacter  
Default: RepeatCharacter  
Source: `GetDefaultRepeatCharacter()`  
Logic: { return RepeatCharacter; }

Field: RepeatCharacter  
Default: result  
Source: `SetDefaultRepeatCharacter()`  
Logic: { //if (RepeatCharacter is null){ // var result = GetDefaultRepeatCharacter(view); // if (result != null && result != RepeatCharacter){ // RepeatCharacter = result; // } //} }

Field: NotUpCase  
Default: NotUpCase  
Source: `GetDefaultNotUpCase()`  
Logic: { return NotUpCase; }

Field: NotUpCase  
Default: result  
Source: `SetDefaultNotUpCase()`  
Logic: { //if (NotUpCase is null){ // var result = GetDefaultNotUpCase(view); // if (result != null && result != NotUpCase){ // NotUpCase = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultEnglishName(View view = null); //SetDefaultOriginName(View view = null); //SetDefaultCode(View view = null); //SetDefaultLocaleCode(View view = null); //SetDefaul...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- VideoList [Detail=false]

Group: (default)
- Character [Order=1] [Detail=true]
- Code [Order=1] [Detail=true]
- EnglishName [Order=1] [Detail=true]
- LocaleCode [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- NotUpCase [Order=1] [Detail=true]
- OriginName [Order=1] [Detail=true]
- RepeatCharacter [Order=1] [Detail=true]
- Speaker [Order=1] [Detail=true]
- Vowel [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | Language | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultEnglishName(View view = null); //SetDefaultOriginName(View view = null); //SetDefaultCode(View view = null); //SetDefaultLocaleCode(View view = null); //SetDefaul... |
| GetDefaultCharacter | Language | { return Character; } |
| GetDefaultCode | Language | { return Code; } |
| GetDefaultEnglishName | Language | { return EnglishName; } |
| GetDefaultLocaleCode | Language | { return LocaleCode; } |
| GetDefaultName | Language | { return Name; } |
| GetDefaultNotUpCase | Language | { return NotUpCase; } |
| GetDefaultOriginName | Language | { return OriginName; } |
| GetDefaultRepeatCharacter | Language | { return RepeatCharacter; } |
| GetDefaultSpeaker | Language | { return Speaker; } |
| GetDefaultVowel | Language | { return Vowel; } |
| OnLoaded | Language | { base.OnLoaded(); } |
| OnSaving | Language | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultCharacter | Language | { //if (Character is null){ // var result = GetDefaultCharacter(view); // if (result != null && result != Character){ // Character = result; // } //} } |
| SetDefaultCode | Language | { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} } |
| SetDefaultEnglishName | Language | { //if (EnglishName is null){ // var result = GetDefaultEnglishName(view); // if (result != null && result != EnglishName){ // EnglishName = result; // } //} } |
| SetDefaultLocaleCode | Language | { //if (LocaleCode is null){ // var result = GetDefaultLocaleCode(view); // if (result != null && result != LocaleCode){ // LocaleCode = result; // } //} } |
| SetDefaultName | Language | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultNotUpCase | Language | { //if (NotUpCase is null){ // var result = GetDefaultNotUpCase(view); // if (result != null && result != NotUpCase){ // NotUpCase = result; // } //} } |
| SetDefaultOriginName | Language | { //if (OriginName is null){ // var result = GetDefaultOriginName(view); // if (result != null && result != OriginName){ // OriginName = result; // } //} } |
| SetDefaultRepeatCharacter | Language | { //if (RepeatCharacter is null){ // var result = GetDefaultRepeatCharacter(view); // if (result != null && result != RepeatCharacter){ // RepeatCharacter = result; // } //} } |
| SetDefaultSpeaker | Language | { //if (Speaker is null){ // var result = GetDefaultSpeaker(view); // if (result != null && result != Speaker){ // Speaker = result; // } //} } |
| SetDefaultVowel | Language | { //if (Vowel is null){ // var result = GetDefaultVowel(view); // if (result != null && result != Vowel){ // Vowel = result; // } //} } |

---

# Entity: LanguageSpelling

Caption entity: `Ngữ âm`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Language | Module.BusinessObjects.Language | Ngôn ngữ | No | GetDefaultLanguage: Language<br>SetDefaultLanguage: result | true | true |   | 1 |
| SpellingWord | Module.BusinessObjects.SpellingWord | Phiên âm | No | GetDefaultSpellingWord: SpellingWord<br>SetDefaultSpellingWord: result | false | false |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Language  
Default: Language  
Source: `GetDefaultLanguage()`  
Logic: { return Language; }

Field: Language  
Default: result  
Source: `SetDefaultLanguage()`  
Logic: { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} }

Field: SpellingWord  
Default: SpellingWord  
Source: `GetDefaultSpellingWord()`  
Logic: { return SpellingWord; }

Field: SpellingWord  
Default: result  
Source: `SetDefaultSpellingWord()`  
Logic: { //if (SpellingWord is null){ // var result = GetDefaultSpellingWord(view); // if (result != null && result != SpellingWord){ // SpellingWord = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultLanguage(View view = null); //SetDefaultSpellingWord(View view = null); }

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- SpellingWord [Detail=false]

Group: (default)
- Language [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | LanguageSpelling | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultLanguage(View view = null); //SetDefaultSpellingWord(View view = null); } |
| GetDefaultLanguage | LanguageSpelling | { return Language; } |
| GetDefaultName | LanguageSpelling | { return Name; } |
| GetDefaultSpellingWord | LanguageSpelling | { return SpellingWord; } |
| OnLoaded | LanguageSpelling | { base.OnLoaded(); } |
| OnSaving | LanguageSpelling | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultLanguage | LanguageSpelling | { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} } |
| SetDefaultName | LanguageSpelling | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultSpellingWord | LanguageSpelling | { //if (SpellingWord is null){ // var result = GetDefaultSpellingWord(view); // if (result != null && result != SpellingWord){ // SpellingWord = result; // } //} } |

---

# Entity: Match

Caption entity: `Trận đấu`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Date | DateTime? | Ngày | No | GetDefaultDate: Date<br>SetDefaultDate: result | true | true |   | 1 |
| Time | DateTime? | Giờ | No | GetDefaultTime: Time<br>SetDefaultTime: result | true | true |   | 1 |
| TournamentSeason | Module.BusinessObjects.TournamentSeason | Mùa giải | No | GetDefaultTournamentSeason: TournamentSeason<br>SetDefaultTournamentSeason: result | false | true |   | 1 |
| PostList | XPCollection <Module.BusinessObjects.Post> | Tin tức | No |  | false | true |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Date  
Default: Date  
Source: `GetDefaultDate()`  
Logic: { return Date; }

Field: Date  
Default: result  
Source: `SetDefaultDate()`  
Logic: { //if (Date is null){ // var result = GetDefaultDate(view); // if (result != null && result != Date){ // Date = result; // } //} }

Field: Time  
Default: Time  
Source: `GetDefaultTime()`  
Logic: { return Time; }

Field: Time  
Default: result  
Source: `SetDefaultTime()`  
Logic: { //if (Time is null){ // var result = GetDefaultTime(view); // if (result != null && result != Time){ // Time = result; // } //} }

Field: TournamentSeason  
Default: TournamentSeason  
Source: `GetDefaultTournamentSeason()`  
Logic: { return TournamentSeason; }

Field: TournamentSeason  
Default: result  
Source: `SetDefaultTournamentSeason()`  
Logic: { //if (TournamentSeason is null){ // var result = GetDefaultTournamentSeason(view); // if (result != null && result != TournamentSeason){ // TournamentSeason = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultDate(View view = null); //SetDefaultTime(View view = null); //SetDefaultTournamentSeason(View view = null); }

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- PostList [Detail=true]

Group: (default)
- Date [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- Time [Order=1] [Detail=true]
- TournamentSeason [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | Match | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultDate(View view = null); //SetDefaultTime(View view = null); //SetDefaultTournamentSeason(View view = null); } |
| GetDefaultDate | Match | { return Date; } |
| GetDefaultName | Match | { return Name; } |
| GetDefaultTime | Match | { return Time; } |
| GetDefaultTournamentSeason | Match | { return TournamentSeason; } |
| OnLoaded | Match | { base.OnLoaded(); } |
| OnSaving | Match | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultDate | Match | { //if (Date is null){ // var result = GetDefaultDate(view); // if (result != null && result != Date){ // Date = result; // } //} } |
| SetDefaultName | Match | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultTime | Match | { //if (Time is null){ // var result = GetDefaultTime(view); // if (result != null && result != Time){ // Time = result; // } //} } |
| SetDefaultTournamentSeason | Match | { //if (TournamentSeason is null){ // var result = GetDefaultTournamentSeason(view); // if (result != null && result != TournamentSeason){ // TournamentSeason = result; // } //} } |

---

# Entity: Media

Caption entity: `Hình ảnh`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Start | TimeSpan? | Bắt đầu | No | GetDefaultStart: Start<br>SetDefaultStart: result | true | true |   | 1 |
| End | TimeSpan? | Kết thúc | No | GetDefaultEnd: End<br>SetDefaultEnd: result | true | true |   | 1 |
| Content | string | Nội dung | No | GetDefaultContent: Content<br>SetDefaultContent: result | true | true |   | 1 |
| MediaFile | string | Tệp Media | No | GetDefaultMediaFile: MediaFile<br>SetDefaultMediaFile: result | true | true |   | 1 |
| MediaStart | TimeSpan? | Bắt đầu Media | No | GetDefaultMediaStart: MediaStart<br>SetDefaultMediaStart: result | false | true |   | 1 |
| MediaDuration | decimal | Thời lượng Media | No | GetDefaultMediaDuration: MediaDuration<br>SetDefaultMediaDuration: result | false | true |   | 1 |
| MediaSpeed | decimal? | Tốc độ | No | GetDefaultMediaSpeed: MediaSpeed<br>SetDefaultMediaSpeed: result | false | true |   | 1 |
| Photo | bool | Ảnh | No | GetDefaultPhoto: Photo<br>SetDefaultPhoto: result | false | true |   | 1 |
| Paragraph | Module.BusinessObjects.Paragraph | Đoạn văn bản | No | GetDefaultParagraph: Paragraph<br>SetDefaultParagraph: result | false | true |   | 1 |
| AudioList | XPCollection <Module.BusinessObjects.Audio> | Âm thanh | No |  | false | true |  |  |
| Video | Module.BusinessObjects.Video | Video | No | GetDefaultVideo: Video<br>SetDefaultVideo: result | false | false |  |  |
| Duration | decimal | Thời lượng | No | GetDefaultDuration: Duration<br>SetDefaultDuration: result | false | false |  |  |
| AudioDuration | decimal | Thời lượng âm | No | GetDefaultAudioDuration: AudioDuration<br>SetDefaultAudioDuration: result | false | false |  |  |
| Flag | bool | Cờ | No | GetDefaultFlag: Flag<br>SetDefaultFlag: result | false | false |  |  |
| Flag2 | bool | Cờ 2 | No | GetDefaultFlag2: Flag2<br>SetDefaultFlag2: result | false | false |  |  |
| Order | int? | Thứ tự | No | GetDefaultOrder: Order<br>SetDefaultOrder: result | false | false |  |  |
| Text | string | Văn bản | No | GetDefaultText: Text<br>SetDefaultText: result | false | false |  |  |
| TextPrevious | string | Văn bản trước | No | GetDefaultTextPrevious: TextPrevious<br>SetDefaultTextPrevious: result | false | false |  |  |
| TextNext | string | Văn bản sau | No | GetDefaultTextNext: TextNext<br>SetDefaultTextNext: result | false | false |  |  |
| ParagraphStyle | Module.BusinessObjects.ParagraphStyle | Kiểu cách | No | GetDefaultParagraphStyle: ParagraphStyle<br>SetDefaultParagraphStyle: result | true | false |  |  |
| MediaType | MediaType | Loại | No | GetDefaultMediaType: MediaType<br>SetDefaultMediaType: result | true | false |  |  |
| BookMark | Module.BusinessObjects.BookMark | Liên kết | No | GetDefaultBookMark: BookMark<br>SetDefaultBookMark: result | true | false |  |  |
| ShapeTypeText | string | Loại hình | No | GetDefaultShapeTypeText: ShapeTypeText<br>SetDefaultShapeTypeText: result | false | false |  |  |
| Height | decimal? | Cao | No | GetDefaultHeight: Height<br>SetDefaultHeight: result | false | false |  |  |
| Width | decimal? | Rộng | No | GetDefaultWidth: Width<br>SetDefaultWidth: result | false | false |  |  |
| TextWrappingType | Microsoft.Office.Interop.Word.WdWrapType | Bố cục | No | GetDefaultTextWrappingType: TextWrappingType<br>SetDefaultTextWrappingType: result | false | false |  |  |
| AllowOverlap | bool | Được đè | No | GetDefaultAllowOverlap: AllowOverlap<br>SetDefaultAllowOverlap: result | false | false |  |  |
| Alignment | Alignment | Căn lề | No | GetDefaultAlignment: Alignment<br>SetDefaultAlignment: result | false | false |  |  |
| AlignmentRelative | Microsoft.Office.Interop.Word.WdRelativeHorizontalPosition? | Mốc căn lề | No | GetDefaultAlignmentRelative: AlignmentRelative<br>SetDefaultAlignmentRelative: result | false | false |  |  |
| MoveWithText | bool | Theo văn bản | No | GetDefaultMoveWithText: MoveWithText<br>SetDefaultMoveWithText: result | false | false |  |  |
| UpperMedia | Module.BusinessObjects.Media | Cấp trên | No | GetDefaultUpperMedia: UpperMedia<br>SetDefaultUpperMedia: result | false | false |  |  |
| TextWrappingTypeNew | Microsoft.Office.Interop.Word.WdWrapType | Bố cục mới | No | GetDefaultTextWrappingTypeNew: TextWrappingTypeNew<br>SetDefaultTextWrappingTypeNew: result | false | false |  |  |
| AlignmentNew | Alignment | Căn lề mới | No | GetDefaultAlignmentNew: AlignmentNew<br>SetDefaultAlignmentNew: result | false | false |  |  |
| ShapeId | int? | Shape Id | No | GetDefaultShapeId: ShapeId<br>SetDefaultShapeId: result | false | false |  |  |
| ShapeName | string | Tên Shape | No | GetDefaultShapeName: ShapeName<br>SetDefaultShapeName: result | false | false |  |  |
| Top | decimal? | Phía trên | No | GetDefaultTop: Top<br>SetDefaultTop: result | false | false |  |  |
| PageNumber | int? | Trang số | No | GetDefaultPageNumber: PageNumber<br>SetDefaultPageNumber: result | false | false |  |  |
| Quantity | decimal? | Số lượng | No | GetDefaultQuantity: Quantity<br>SetDefaultQuantity: result | false | false |  |  |
| ResizeWithText | bool | Giãn theo văn bản | No | GetDefaultResizeWithText: ResizeWithText<br>SetDefaultResizeWithText: result | false | false |  |  |
| FillColor | Color? | Màu nền | No | GetDefaultFillColor: FillColor<br>SetDefaultFillColor: result | false | false |  |  |
| LineColor | Color? | Màu viền | No | GetDefaultLineColor: LineColor<br>SetDefaultLineColor: result | false | false |  |  |
| FillCode | string | Mã nền | No | GetDefaultFillCode: FillCode<br>SetDefaultFillCode: result | false | false |  |  |
| LineCode | string | Mã viền | No | GetDefaultLineCode: LineCode<br>SetDefaultLineCode: result | false | false |  |  |

## Default Logic

Field: Start  
Default: Start  
Source: `GetDefaultStart()`  
Logic: { return Start; }

Field: Start  
Default: result  
Source: `SetDefaultStart()`  
Logic: { //if (Start is null){ // var result = GetDefaultStart(view); // if (result != null && result != Start){ // Start = result; // } //} }

Field: End  
Default: End  
Source: `GetDefaultEnd()`  
Logic: { return End; }

Field: End  
Default: result  
Source: `SetDefaultEnd()`  
Logic: { //if (End is null){ // var result = GetDefaultEnd(view); // if (result != null && result != End){ // End = result; // } //} }

Field: Content  
Default: Content  
Source: `GetDefaultContent()`  
Logic: { return Content; }

Field: Content  
Default: result  
Source: `SetDefaultContent()`  
Logic: { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} }

Field: MediaFile  
Default: MediaFile  
Source: `GetDefaultMediaFile()`  
Logic: { return MediaFile; }

Field: MediaFile  
Default: result  
Source: `SetDefaultMediaFile()`  
Logic: { //if (MediaFile is null){ // var result = GetDefaultMediaFile(view); // if (result != null && result != MediaFile){ // MediaFile = result; // } //} }

Field: MediaStart  
Default: MediaStart  
Source: `GetDefaultMediaStart()`  
Logic: { return MediaStart; }

Field: MediaStart  
Default: result  
Source: `SetDefaultMediaStart()`  
Logic: { //if (MediaStart is null){ // var result = GetDefaultMediaStart(view); // if (result != null && result != MediaStart){ // MediaStart = result; // } //} }

Field: MediaDuration  
Default: MediaDuration  
Source: `GetDefaultMediaDuration()`  
Logic: { return MediaDuration; }

Field: MediaDuration  
Default: result  
Source: `SetDefaultMediaDuration()`  
Logic: { //if (MediaDuration is null){ // var result = GetDefaultMediaDuration(view); // if (result != null && result != MediaDuration){ // MediaDuration = result; // } //} }

Field: MediaSpeed  
Default: MediaSpeed  
Source: `GetDefaultMediaSpeed()`  
Logic: { return MediaSpeed; }

Field: MediaSpeed  
Default: result  
Source: `SetDefaultMediaSpeed()`  
Logic: { //if (MediaSpeed is null){ // var result = GetDefaultMediaSpeed(view); // if (result != null && result != MediaSpeed){ // MediaSpeed = result; // } //} }

Field: Photo  
Default: Photo  
Source: `GetDefaultPhoto()`  
Logic: { return Photo; }

Field: Photo  
Default: result  
Source: `SetDefaultPhoto()`  
Logic: { //if (Photo is null){ // var result = GetDefaultPhoto(view); // if (result != null && result != Photo){ // Photo = result; // } //} }

Field: Paragraph  
Default: Paragraph  
Source: `GetDefaultParagraph()`  
Logic: { return Paragraph; }

Field: Paragraph  
Default: result  
Source: `SetDefaultParagraph()`  
Logic: { //if (Paragraph is null){ // var result = GetDefaultParagraph(view); // if (result != null && result != Paragraph){ // Paragraph = result; // } //} }

Field: Video  
Default: Video  
Source: `GetDefaultVideo()`  
Logic: { return Video; }

Field: Video  
Default: result  
Source: `SetDefaultVideo()`  
Logic: { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} }

Field: Duration  
Default: Duration  
Source: `GetDefaultDuration()`  
Logic: { return Duration; }

Field: Duration  
Default: result  
Source: `SetDefaultDuration()`  
Logic: { //if (Duration is null){ // var result = GetDefaultDuration(view); // if (result != null && result != Duration){ // Duration = result; // } //} }

Field: AudioDuration  
Default: AudioDuration  
Source: `GetDefaultAudioDuration()`  
Logic: { return AudioDuration; }

Field: AudioDuration  
Default: result  
Source: `SetDefaultAudioDuration()`  
Logic: { //if (AudioDuration is null){ // var result = GetDefaultAudioDuration(view); // if (result != null && result != AudioDuration){ // AudioDuration = result; // } //} }

Field: Flag  
Default: Flag  
Source: `GetDefaultFlag()`  
Logic: { return Flag; }

Field: Flag  
Default: result  
Source: `SetDefaultFlag()`  
Logic: { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} }

Field: Flag2  
Default: Flag2  
Source: `GetDefaultFlag2()`  
Logic: { return Flag2; }

Field: Flag2  
Default: result  
Source: `SetDefaultFlag2()`  
Logic: { //if (Flag2 is null){ // var result = GetDefaultFlag2(view); // if (result != null && result != Flag2){ // Flag2 = result; // } //} }

Field: Order  
Default: Order  
Source: `GetDefaultOrder()`  
Logic: { return Order; }

Field: Order  
Default: result  
Source: `SetDefaultOrder()`  
Logic: { //if (Order is null){ // var result = GetDefaultOrder(view); // if (result != null && result != Order){ // Order = result; // } //} }

Field: Text  
Default: Text  
Source: `GetDefaultText()`  
Logic: { return Text; }

Field: Text  
Default: result  
Source: `SetDefaultText()`  
Logic: { //if (Text is null){ // var result = GetDefaultText(view); // if (result != null && result != Text){ // Text = result; // } //} }

Field: TextPrevious  
Default: TextPrevious  
Source: `GetDefaultTextPrevious()`  
Logic: { return TextPrevious; }

Field: TextPrevious  
Default: result  
Source: `SetDefaultTextPrevious()`  
Logic: { //if (TextPrevious is null){ // var result = GetDefaultTextPrevious(view); // if (result != null && result != TextPrevious){ // TextPrevious = result; // } //} }

Field: TextNext  
Default: TextNext  
Source: `GetDefaultTextNext()`  
Logic: { return TextNext; }

Field: TextNext  
Default: result  
Source: `SetDefaultTextNext()`  
Logic: { //if (TextNext is null){ // var result = GetDefaultTextNext(view); // if (result != null && result != TextNext){ // TextNext = result; // } //} }

Field: ParagraphStyle  
Default: ParagraphStyle  
Source: `GetDefaultParagraphStyle()`  
Logic: { return ParagraphStyle; }

Field: ParagraphStyle  
Default: result  
Source: `SetDefaultParagraphStyle()`  
Logic: { //if (ParagraphStyle is null){ // var result = GetDefaultParagraphStyle(view); // if (result != null && result != ParagraphStyle){ // ParagraphStyle = result; // } //} }

Field: MediaType  
Default: MediaType  
Source: `GetDefaultMediaType()`  
Logic: { return MediaType; }

Field: MediaType  
Default: result  
Source: `SetDefaultMediaType()`  
Logic: { //if (MediaType is null){ // var result = GetDefaultMediaType(view); // if (result != null && result != MediaType){ // MediaType = result; // } //} }

Field: BookMark  
Default: BookMark  
Source: `GetDefaultBookMark()`  
Logic: { return BookMark; }

Field: BookMark  
Default: result  
Source: `SetDefaultBookMark()`  
Logic: { //if (BookMark is null){ // var result = GetDefaultBookMark(view); // if (result != null && result != BookMark){ // BookMark = result; // } //} }

Field: ShapeTypeText  
Default: ShapeTypeText  
Source: `GetDefaultShapeTypeText()`  
Logic: { return ShapeTypeText; }

Field: ShapeTypeText  
Default: result  
Source: `SetDefaultShapeTypeText()`  
Logic: { //if (ShapeTypeText is null){ // var result = GetDefaultShapeTypeText(view); // if (result != null && result != ShapeTypeText){ // ShapeTypeText = result; // } //} }

Field: Height  
Default: Height  
Source: `GetDefaultHeight()`  
Logic: { return Height; }

Field: Height  
Default: result  
Source: `SetDefaultHeight()`  
Logic: { //if (Height is null){ // var result = GetDefaultHeight(view); // if (result != null && result != Height){ // Height = result; // } //} }

Field: Width  
Default: Width  
Source: `GetDefaultWidth()`  
Logic: { return Width; }

Field: Width  
Default: result  
Source: `SetDefaultWidth()`  
Logic: { //if (Width is null){ // var result = GetDefaultWidth(view); // if (result != null && result != Width){ // Width = result; // } //} }

Field: TextWrappingType  
Default: TextWrappingType  
Source: `GetDefaultTextWrappingType()`  
Logic: { return TextWrappingType; }

Field: TextWrappingType  
Default: result  
Source: `SetDefaultTextWrappingType()`  
Logic: { //if (TextWrappingType is null){ // var result = GetDefaultTextWrappingType(view); // if (result != null && result != TextWrappingType){ // TextWrappingType = result; // } //} }

Field: AllowOverlap  
Default: AllowOverlap  
Source: `GetDefaultAllowOverlap()`  
Logic: { return AllowOverlap; }

Field: AllowOverlap  
Default: result  
Source: `SetDefaultAllowOverlap()`  
Logic: { //if (AllowOverlap is null){ // var result = GetDefaultAllowOverlap(view); // if (result != null && result != AllowOverlap){ // AllowOverlap = result; // } //} }

Field: Alignment  
Default: Alignment  
Source: `GetDefaultAlignment()`  
Logic: { return Alignment; }

Field: Alignment  
Default: result  
Source: `SetDefaultAlignment()`  
Logic: { //if (Alignment is null){ // var result = GetDefaultAlignment(view); // if (result != null && result != Alignment){ // Alignment = result; // } //} }

Field: AlignmentRelative  
Default: AlignmentRelative  
Source: `GetDefaultAlignmentRelative()`  
Logic: { return AlignmentRelative; }

Field: AlignmentRelative  
Default: result  
Source: `SetDefaultAlignmentRelative()`  
Logic: { //if (AlignmentRelative is null){ // var result = GetDefaultAlignmentRelative(view); // if (result != null && result != AlignmentRelative){ // AlignmentRelative = result; // } //} }

Field: MoveWithText  
Default: MoveWithText  
Source: `GetDefaultMoveWithText()`  
Logic: { return MoveWithText; }

Field: MoveWithText  
Default: result  
Source: `SetDefaultMoveWithText()`  
Logic: { //if (MoveWithText is null){ // var result = GetDefaultMoveWithText(view); // if (result != null && result != MoveWithText){ // MoveWithText = result; // } //} }

Field: UpperMedia  
Default: UpperMedia  
Source: `GetDefaultUpperMedia()`  
Logic: { return UpperMedia; }

Field: UpperMedia  
Default: result  
Source: `SetDefaultUpperMedia()`  
Logic: { //if (UpperMedia is null){ // var result = GetDefaultUpperMedia(view); // if (result != null && result != UpperMedia){ // UpperMedia = result; // } //} }

Field: TextWrappingTypeNew  
Default: TextWrappingTypeNew  
Source: `GetDefaultTextWrappingTypeNew()`  
Logic: { return TextWrappingTypeNew; }

Field: TextWrappingTypeNew  
Default: result  
Source: `SetDefaultTextWrappingTypeNew()`  
Logic: { //if (TextWrappingTypeNew is null){ // var result = GetDefaultTextWrappingTypeNew(view); // if (result != null && result != TextWrappingTypeNew){ // TextWrappingTypeNew = result; // } //} }

Field: AlignmentNew  
Default: AlignmentNew  
Source: `GetDefaultAlignmentNew()`  
Logic: { return AlignmentNew; }

Field: AlignmentNew  
Default: result  
Source: `SetDefaultAlignmentNew()`  
Logic: { //if (AlignmentNew is null){ // var result = GetDefaultAlignmentNew(view); // if (result != null && result != AlignmentNew){ // AlignmentNew = result; // } //} }

Field: ShapeId  
Default: ShapeId  
Source: `GetDefaultShapeId()`  
Logic: { return ShapeId; }

Field: ShapeId  
Default: result  
Source: `SetDefaultShapeId()`  
Logic: { //if (ShapeId is null){ // var result = GetDefaultShapeId(view); // if (result != null && result != ShapeId){ // ShapeId = result; // } //} }

Field: ShapeName  
Default: ShapeName  
Source: `GetDefaultShapeName()`  
Logic: { return ShapeName; }

Field: ShapeName  
Default: result  
Source: `SetDefaultShapeName()`  
Logic: { //if (ShapeName is null){ // var result = GetDefaultShapeName(view); // if (result != null && result != ShapeName){ // ShapeName = result; // } //} }

Field: Top  
Default: Top  
Source: `GetDefaultTop()`  
Logic: { return Top; }

Field: Top  
Default: result  
Source: `SetDefaultTop()`  
Logic: { //if (Top is null){ // var result = GetDefaultTop(view); // if (result != null && result != Top){ // Top = result; // } //} }

Field: PageNumber  
Default: PageNumber  
Source: `GetDefaultPageNumber()`  
Logic: { return PageNumber; }

Field: PageNumber  
Default: result  
Source: `SetDefaultPageNumber()`  
Logic: { //if (PageNumber is null){ // var result = GetDefaultPageNumber(view); // if (result != null && result != PageNumber){ // PageNumber = result; // } //} }

Field: Quantity  
Default: Quantity  
Source: `GetDefaultQuantity()`  
Logic: { return Quantity; }

Field: Quantity  
Default: result  
Source: `SetDefaultQuantity()`  
Logic: { //if (Quantity is null){ // var result = GetDefaultQuantity(view); // if (result != null && result != Quantity){ // Quantity = result; // } //} }

Field: ResizeWithText  
Default: ResizeWithText  
Source: `GetDefaultResizeWithText()`  
Logic: { return ResizeWithText; }

Field: ResizeWithText  
Default: result  
Source: `SetDefaultResizeWithText()`  
Logic: { //if (ResizeWithText is null){ // var result = GetDefaultResizeWithText(view); // if (result != null && result != ResizeWithText){ // ResizeWithText = result; // } //} }

Field: FillColor  
Default: FillColor  
Source: `GetDefaultFillColor()`  
Logic: { return FillColor; }

Field: FillColor  
Default: result  
Source: `SetDefaultFillColor()`  
Logic: { //if (FillColor is null){ // var result = GetDefaultFillColor(view); // if (result != null && result != FillColor){ // FillColor = result; // } //} }

Field: LineColor  
Default: LineColor  
Source: `GetDefaultLineColor()`  
Logic: { return LineColor; }

Field: LineColor  
Default: result  
Source: `SetDefaultLineColor()`  
Logic: { //if (LineColor is null){ // var result = GetDefaultLineColor(view); // if (result != null && result != LineColor){ // LineColor = result; // } //} }

Field: FillCode  
Default: FillCode  
Source: `GetDefaultFillCode()`  
Logic: { return FillCode; }

Field: FillCode  
Default: result  
Source: `SetDefaultFillCode()`  
Logic: { //if (FillCode is null){ // var result = GetDefaultFillCode(view); // if (result != null && result != FillCode){ // FillCode = result; // } //} }

Field: LineCode  
Default: LineCode  
Source: `GetDefaultLineCode()`  
Logic: { return LineCode; }

Field: LineCode  
Default: result  
Source: `SetDefaultLineCode()`  
Logic: { //if (LineCode is null){ // var result = GetDefaultLineCode(view); // if (result != null && result != LineCode){ // LineCode = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultStart(View view = null); //SetDefaultEnd(View view = null); //SetDefaultContent(View view = null); //SetDefaultMediaFile(View view = null); //SetDefaultMediaStart(View view = null); //SetDefaultMedi...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- Alignment [Detail=false]
- AlignmentNew [Detail=false]
- AlignmentRelative [Detail=false]
- AllowOverlap [Detail=false]
- AppearanceDisableDelete
- AudioDuration [Detail=false]
- AudioList [Detail=true]
- BookMark [Detail=false]
- Duration [Detail=false]
- FillCode [Detail=false]
- FillColor [Detail=false]
- Flag [Detail=false]
- Flag2 [Detail=false]
- Height [Detail=false]
- LineCode [Detail=false]
- LineColor [Detail=false]
- MediaType [Detail=false]
- MoveWithText [Detail=false]
- Order [Detail=false]
- PageNumber [Detail=false]
- ParagraphStyle [Detail=false]
- Quantity [Detail=false]
- ResizeWithText [Detail=false]
- ShapeId [Detail=false]
- ShapeName [Detail=false]
- ShapeTypeText [Detail=false]
- Text [Detail=false]
- TextNext [Detail=false]
- TextPrevious [Detail=false]
- TextWrappingType [Detail=false]
- TextWrappingTypeNew [Detail=false]
- Top [Detail=false]
- UpperMedia [Detail=false]
- Video [Detail=false]
- Width [Detail=false]

Group: (default)
- Content [Order=1] [Detail=true]
- End [Order=1] [Detail=true]
- MediaDuration [Order=1] [Detail=true]
- MediaFile [Order=1] [Detail=true]
- MediaSpeed [Order=1] [Detail=true]
- MediaStart [Order=1] [Detail=true]
- Paragraph [Order=1] [Detail=true]
- Photo [Order=1] [Detail=true]
- Start [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | Media | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultStart(View view = null); //SetDefaultEnd(View view = null); //SetDefaultContent(View view = null); //SetDefaultMediaFile(View view = null); //SetDefaultMediaStart(View view = null); //SetDefaultMedi... |
| GetDefaultAlignment | Media | { return Alignment; } |
| GetDefaultAlignmentNew | Media | { return AlignmentNew; } |
| GetDefaultAlignmentRelative | Media | { return AlignmentRelative; } |
| GetDefaultAllowOverlap | Media | { return AllowOverlap; } |
| GetDefaultAudioDuration | Media | { return AudioDuration; } |
| GetDefaultBookMark | Media | { return BookMark; } |
| GetDefaultContent | Media | { return Content; } |
| GetDefaultDuration | Media | { return Duration; } |
| GetDefaultEnd | Media | { return End; } |
| GetDefaultFillCode | Media | { return FillCode; } |
| GetDefaultFillColor | Media | { return FillColor; } |
| GetDefaultFlag | Media | { return Flag; } |
| GetDefaultFlag2 | Media | { return Flag2; } |
| GetDefaultHeight | Media | { return Height; } |
| GetDefaultLineCode | Media | { return LineCode; } |
| GetDefaultLineColor | Media | { return LineColor; } |
| GetDefaultMediaDuration | Media | { return MediaDuration; } |
| GetDefaultMediaFile | Media | { return MediaFile; } |
| GetDefaultMediaSpeed | Media | { return MediaSpeed; } |
| GetDefaultMediaStart | Media | { return MediaStart; } |
| GetDefaultMediaType | Media | { return MediaType; } |
| GetDefaultMoveWithText | Media | { return MoveWithText; } |
| GetDefaultOrder | Media | { return Order; } |
| GetDefaultPageNumber | Media | { return PageNumber; } |
| GetDefaultParagraph | Media | { return Paragraph; } |
| GetDefaultParagraphStyle | Media | { return ParagraphStyle; } |
| GetDefaultPhoto | Media | { return Photo; } |
| GetDefaultQuantity | Media | { return Quantity; } |
| GetDefaultResizeWithText | Media | { return ResizeWithText; } |
| GetDefaultShapeId | Media | { return ShapeId; } |
| GetDefaultShapeName | Media | { return ShapeName; } |
| GetDefaultShapeTypeText | Media | { return ShapeTypeText; } |
| GetDefaultStart | Media | { return Start; } |
| GetDefaultText | Media | { return Text; } |
| GetDefaultTextNext | Media | { return TextNext; } |
| GetDefaultTextPrevious | Media | { return TextPrevious; } |
| GetDefaultTextWrappingType | Media | { return TextWrappingType; } |
| GetDefaultTextWrappingTypeNew | Media | { return TextWrappingTypeNew; } |
| GetDefaultTop | Media | { return Top; } |
| GetDefaultUpperMedia | Media | { return UpperMedia; } |
| GetDefaultVideo | Media | { return Video; } |
| GetDefaultWidth | Media | { return Width; } |
| OnLoaded | Media | { base.OnLoaded(); } |
| OnSaving | Media | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultAlignment | Media | { //if (Alignment is null){ // var result = GetDefaultAlignment(view); // if (result != null && result != Alignment){ // Alignment = result; // } //} } |
| SetDefaultAlignmentNew | Media | { //if (AlignmentNew is null){ // var result = GetDefaultAlignmentNew(view); // if (result != null && result != AlignmentNew){ // AlignmentNew = result; // } //} } |
| SetDefaultAlignmentRelative | Media | { //if (AlignmentRelative is null){ // var result = GetDefaultAlignmentRelative(view); // if (result != null && result != AlignmentRelative){ // AlignmentRelative = result; // } //} } |
| SetDefaultAllowOverlap | Media | { //if (AllowOverlap is null){ // var result = GetDefaultAllowOverlap(view); // if (result != null && result != AllowOverlap){ // AllowOverlap = result; // } //} } |
| SetDefaultAudioDuration | Media | { //if (AudioDuration is null){ // var result = GetDefaultAudioDuration(view); // if (result != null && result != AudioDuration){ // AudioDuration = result; // } //} } |
| SetDefaultBookMark | Media | { //if (BookMark is null){ // var result = GetDefaultBookMark(view); // if (result != null && result != BookMark){ // BookMark = result; // } //} } |
| SetDefaultContent | Media | { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} } |
| SetDefaultDuration | Media | { //if (Duration is null){ // var result = GetDefaultDuration(view); // if (result != null && result != Duration){ // Duration = result; // } //} } |
| SetDefaultEnd | Media | { //if (End is null){ // var result = GetDefaultEnd(view); // if (result != null && result != End){ // End = result; // } //} } |
| SetDefaultFillCode | Media | { //if (FillCode is null){ // var result = GetDefaultFillCode(view); // if (result != null && result != FillCode){ // FillCode = result; // } //} } |
| SetDefaultFillColor | Media | { //if (FillColor is null){ // var result = GetDefaultFillColor(view); // if (result != null && result != FillColor){ // FillColor = result; // } //} } |
| SetDefaultFlag | Media | { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} } |
| SetDefaultFlag2 | Media | { //if (Flag2 is null){ // var result = GetDefaultFlag2(view); // if (result != null && result != Flag2){ // Flag2 = result; // } //} } |
| SetDefaultHeight | Media | { //if (Height is null){ // var result = GetDefaultHeight(view); // if (result != null && result != Height){ // Height = result; // } //} } |
| SetDefaultLineCode | Media | { //if (LineCode is null){ // var result = GetDefaultLineCode(view); // if (result != null && result != LineCode){ // LineCode = result; // } //} } |
| SetDefaultLineColor | Media | { //if (LineColor is null){ // var result = GetDefaultLineColor(view); // if (result != null && result != LineColor){ // LineColor = result; // } //} } |
| SetDefaultMediaDuration | Media | { //if (MediaDuration is null){ // var result = GetDefaultMediaDuration(view); // if (result != null && result != MediaDuration){ // MediaDuration = result; // } //} } |
| SetDefaultMediaFile | Media | { //if (MediaFile is null){ // var result = GetDefaultMediaFile(view); // if (result != null && result != MediaFile){ // MediaFile = result; // } //} } |
| SetDefaultMediaSpeed | Media | { //if (MediaSpeed is null){ // var result = GetDefaultMediaSpeed(view); // if (result != null && result != MediaSpeed){ // MediaSpeed = result; // } //} } |
| SetDefaultMediaStart | Media | { //if (MediaStart is null){ // var result = GetDefaultMediaStart(view); // if (result != null && result != MediaStart){ // MediaStart = result; // } //} } |
| SetDefaultMediaType | Media | { //if (MediaType is null){ // var result = GetDefaultMediaType(view); // if (result != null && result != MediaType){ // MediaType = result; // } //} } |
| SetDefaultMoveWithText | Media | { //if (MoveWithText is null){ // var result = GetDefaultMoveWithText(view); // if (result != null && result != MoveWithText){ // MoveWithText = result; // } //} } |
| SetDefaultOrder | Media | { //if (Order is null){ // var result = GetDefaultOrder(view); // if (result != null && result != Order){ // Order = result; // } //} } |
| SetDefaultPageNumber | Media | { //if (PageNumber is null){ // var result = GetDefaultPageNumber(view); // if (result != null && result != PageNumber){ // PageNumber = result; // } //} } |
| SetDefaultParagraph | Media | { //if (Paragraph is null){ // var result = GetDefaultParagraph(view); // if (result != null && result != Paragraph){ // Paragraph = result; // } //} } |
| SetDefaultParagraphStyle | Media | { //if (ParagraphStyle is null){ // var result = GetDefaultParagraphStyle(view); // if (result != null && result != ParagraphStyle){ // ParagraphStyle = result; // } //} } |
| SetDefaultPhoto | Media | { //if (Photo is null){ // var result = GetDefaultPhoto(view); // if (result != null && result != Photo){ // Photo = result; // } //} } |
| SetDefaultQuantity | Media | { //if (Quantity is null){ // var result = GetDefaultQuantity(view); // if (result != null && result != Quantity){ // Quantity = result; // } //} } |
| SetDefaultResizeWithText | Media | { //if (ResizeWithText is null){ // var result = GetDefaultResizeWithText(view); // if (result != null && result != ResizeWithText){ // ResizeWithText = result; // } //} } |
| SetDefaultShapeId | Media | { //if (ShapeId is null){ // var result = GetDefaultShapeId(view); // if (result != null && result != ShapeId){ // ShapeId = result; // } //} } |
| SetDefaultShapeName | Media | { //if (ShapeName is null){ // var result = GetDefaultShapeName(view); // if (result != null && result != ShapeName){ // ShapeName = result; // } //} } |
| SetDefaultShapeTypeText | Media | { //if (ShapeTypeText is null){ // var result = GetDefaultShapeTypeText(view); // if (result != null && result != ShapeTypeText){ // ShapeTypeText = result; // } //} } |
| SetDefaultStart | Media | { //if (Start is null){ // var result = GetDefaultStart(view); // if (result != null && result != Start){ // Start = result; // } //} } |
| SetDefaultText | Media | { //if (Text is null){ // var result = GetDefaultText(view); // if (result != null && result != Text){ // Text = result; // } //} } |
| SetDefaultTextNext | Media | { //if (TextNext is null){ // var result = GetDefaultTextNext(view); // if (result != null && result != TextNext){ // TextNext = result; // } //} } |
| SetDefaultTextPrevious | Media | { //if (TextPrevious is null){ // var result = GetDefaultTextPrevious(view); // if (result != null && result != TextPrevious){ // TextPrevious = result; // } //} } |
| SetDefaultTextWrappingType | Media | { //if (TextWrappingType is null){ // var result = GetDefaultTextWrappingType(view); // if (result != null && result != TextWrappingType){ // TextWrappingType = result; // } //} } |
| SetDefaultTextWrappingTypeNew | Media | { //if (TextWrappingTypeNew is null){ // var result = GetDefaultTextWrappingTypeNew(view); // if (result != null && result != TextWrappingTypeNew){ // TextWrappingTypeNew = result; // } //} } |
| SetDefaultTop | Media | { //if (Top is null){ // var result = GetDefaultTop(view); // if (result != null && result != Top){ // Top = result; // } //} } |
| SetDefaultUpperMedia | Media | { //if (UpperMedia is null){ // var result = GetDefaultUpperMedia(view); // if (result != null && result != UpperMedia){ // UpperMedia = result; // } //} } |
| SetDefaultVideo | Media | { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} } |
| SetDefaultWidth | Media | { //if (Width is null){ // var result = GetDefaultWidth(view); // if (result != null && result != Width){ // Width = result; // } //} } |

---

# Entity: Member

Caption entity: `Thành viên`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | Yes | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Image | byte[] | Ảnh | No | SetDefaultImage: result | true | true |   | 1 |
| Manager | Module.BusinessObjects.Member | Quản lý | No | GetDefaultManager: Manager<br>SetDefaultManager: result | true | true |   | 1 |
| MemberDataServiceList | XPCollection <Module.BusinessObjects.MemberDataService> | Dịch vụ phần mềm | No |  | false | true |  |  |
| Update | DateTime? | Cập nhật | No | SetDefaultUpdate: GetDefaultUpdate()<br>GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null) | false | false |  |  |
| Updater | Module.BusinessObjects.Member | Người cập nhật | No | GetDefaultUpdater: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)<br>SetDefaultUpdater: GetDefaultUpdater() | false | false |  |  |
| IsUpperMember | bool | Là cấp trên | No | GetDefaultIsUpperMember: IsUpperMember<br>SetDefaultIsUpperMember: result | false | false |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Image  
Default: result  
Source: `SetDefaultImage()`  
Logic: { //if (Image is null){ // var result = GetDefaultImage(view); // if (result != null && result != Image){ // Image = result; // } //} }

Field: Manager  
Default: Manager  
Source: `GetDefaultManager()`  
Logic: { return Manager; }

Field: Manager  
Default: result  
Source: `SetDefaultManager()`  
Logic: { //if (Manager is null){ // var result = GetDefaultManager(view); // if (result != null && result != Manager){ // Manager = result; // } //} }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 3766 Oid: 827d8531-9d84-4fe1-94e4-4b78036f4fa1 if (!IsDeleted) Update = GetDefaultUpdate(); }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 3769 Oid: 39148b13-279f-4dbb-9c76-4b4cc5ec476b return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Updater  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultUpdater()`  
Logic: { //Code: 3771 Oid: 766a704e-f0b4-4ec6-8b6c-41cad64b0702 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: Updater  
Default: GetDefaultUpdater()  
Source: `SetDefaultUpdater()`  
Logic: { //Code: 3770 Oid: 8156df0f-cfb2-4587-91ca-453bf91e8eac Updater = GetDefaultUpdater(); }

Field: IsUpperMember  
Default: IsUpperMember  
Source: `GetDefaultIsUpperMember()`  
Logic: { return IsUpperMember; }

Field: IsUpperMember  
Default: result  
Source: `SetDefaultIsUpperMember()`  
Logic: { //if (IsUpperMember is null){ // var result = GetDefaultIsUpperMember(view); // if (result != null && result != IsUpperMember){ // IsUpperMember = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { #region 3768ImportCode base.AfterConstruction(); SetDefaultUpdate(); #endregion 3768ImportCode //SetDefaultName(View view = null); //SetDefaultImage(View view = null); //SetDefaultManager(View view = null); //SetDefaultUpdate(View view = null); //SetDefaultU...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 3767ImportCode base.OnSaving(); SetDefaultUpdate(); SetDefaultUpdater(); #endregion 3767ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- IsUpperMember [Detail=false]
- MemberDataServiceList [Detail=true]
- Update [Detail=false]
- Updater [Detail=false]

Group: (default)
- Image [Order=1] [Detail=true]
- Manager [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | Member | { #region 3768ImportCode base.AfterConstruction(); SetDefaultUpdate(); #endregion 3768ImportCode //SetDefaultName(View view = null); //SetDefaultImage(View view = null); //SetDefaultManager(View view = null); //SetDefaultUpdate(View view = null); //SetDefaultU... |
| GetDefaultIsUpperMember | Member | { return IsUpperMember; } |
| GetDefaultManager | Member | { return Manager; } |
| GetDefaultName | Member | { return Name; } |
| GetDefaultUpdate | Member | { //Code: 3769 Oid: 39148b13-279f-4dbb-9c76-4b4cc5ec476b return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultUpdater | Member | { //Code: 3771 Oid: 766a704e-f0b4-4ec6-8b6c-41cad64b0702 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| OnLoaded | Member | { base.OnLoaded(); } |
| OnSaving | Member | { #region 3767ImportCode base.OnSaving(); SetDefaultUpdate(); SetDefaultUpdater(); #endregion 3767ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&... |
| SetDefaultImage | Member | { //if (Image is null){ // var result = GetDefaultImage(view); // if (result != null && result != Image){ // Image = result; // } //} } |
| SetDefaultIsUpperMember | Member | { //if (IsUpperMember is null){ // var result = GetDefaultIsUpperMember(view); // if (result != null && result != IsUpperMember){ // IsUpperMember = result; // } //} } |
| SetDefaultManager | Member | { //if (Manager is null){ // var result = GetDefaultManager(view); // if (result != null && result != Manager){ // Manager = result; // } //} } |
| SetDefaultName | Member | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultUpdate | Member | { //Code: 3766 Oid: 827d8531-9d84-4fe1-94e4-4b78036f4fa1 if (!IsDeleted) Update = GetDefaultUpdate(); } |
| SetDefaultUpdater | Member | { //Code: 3770 Oid: 8156df0f-cfb2-4587-91ca-453bf91e8eac Updater = GetDefaultUpdater(); } |

---

# Entity: MemberDataService

Caption entity: `Dịch vụ Thành viên`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Member | Module.BusinessObjects.Member | Thành viên | No | SetDefaultMember: = null) Member = GetDefaultMember()<br>GetDefaultMember: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session) | false | true |   | 1 |
| SoftwareServiceType | Module.BusinessObjects.SoftwareServiceType | Loại dịch vụ | No | GetDefaultSoftwareServiceType: SoftwareServiceType<br>SetDefaultSoftwareServiceType: result | false | true |   | 1 |
| DataService | Module.BusinessObjects.DataService | Dịch vụ dữ liệu | No | GetDefaultDataService: DataService<br>SetDefaultDataService: result | false | true |   | 1 |
| Update | DateTime? | Cập nhật | No | GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)<br>SetDefaultUpdate: GetDefaultUpdate() | false | false |  |  |
| Updater | Module.BusinessObjects.Member | Người cập nhật | No | GetDefaultUpdater: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)<br>SetDefaultUpdater: GetDefaultUpdater() | false | false |  |  |

## Default Logic

Field: Member  
Default: = null) Member = GetDefaultMember()  
Source: `SetDefaultMember()`  
Logic: { //Code: 3540 Oid: 7eccdc7e-9bcc-44d6-82d1-78d6b4c893e8 if(Member == null) Member = GetDefaultMember(); }

Field: Member  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultMember()`  
Logic: { //Code: 3543 Oid: c3bb04dd-8687-413d-9918-0a2012ab5595 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: SoftwareServiceType  
Default: SoftwareServiceType  
Source: `GetDefaultSoftwareServiceType()`  
Logic: { return SoftwareServiceType; }

Field: SoftwareServiceType  
Default: result  
Source: `SetDefaultSoftwareServiceType()`  
Logic: { //if (SoftwareServiceType is null){ // var result = GetDefaultSoftwareServiceType(view); // if (result != null && result != SoftwareServiceType){ // SoftwareServiceType = result; // } //} }

Field: DataService  
Default: DataService  
Source: `GetDefaultDataService()`  
Logic: { return DataService; }

Field: DataService  
Default: result  
Source: `SetDefaultDataService()`  
Logic: { //if (DataService is null){ // var result = GetDefaultDataService(view); // if (result != null && result != DataService){ // DataService = result; // } //} }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 3548 Oid: c9d723b0-1189-46b5-ae18-4762595332f8 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 3545 Oid: 12d8f4d5-f8d2-4fdc-8fcc-c4d906a0ddcb if (!IsDeleted) Update = GetDefaultUpdate(); }

Field: Updater  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultUpdater()`  
Logic: { //Code: 3552 Oid: 4912e5e1-7ca6-43ae-bf9a-bfe52199d442 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: Updater  
Default: GetDefaultUpdater()  
Source: `SetDefaultUpdater()`  
Logic: { //Code: 3550 Oid: a18e3b74-06c6-46fe-96d4-d6283e39022d Updater = GetDefaultUpdater(); }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 3542ImportCode base.AfterConstruction(); SetDefaultMember(); #endregion 3542ImportCode //SetDefaultMember(View view = null); //SetDefaultSoftwareServiceType(View view = null); //SetDefaultDataService(View view = null); //SetDefa...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 3547ImportCode base.OnSaving(); SetDefaultUpdate(); SetDefaultUpdater(); #endregion 3547ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- Update [Detail=false]
- Updater [Detail=false]

Group: (default)
- DataService [Order=1] [Detail=true]
- Member [Order=1] [Detail=true]
- SoftwareServiceType [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | MemberDataService | { Oid = Guid.NewGuid(); #region 3542ImportCode base.AfterConstruction(); SetDefaultMember(); #endregion 3542ImportCode //SetDefaultMember(View view = null); //SetDefaultSoftwareServiceType(View view = null); //SetDefaultDataService(View view = null); //SetDefa... |
| GetDefaultDataService | MemberDataService | { return DataService; } |
| GetDefaultMember | MemberDataService | { //Code: 3543 Oid: c3bb04dd-8687-413d-9918-0a2012ab5595 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| GetDefaultSoftwareServiceType | MemberDataService | { return SoftwareServiceType; } |
| GetDefaultUpdate | MemberDataService | { //Code: 3548 Oid: c9d723b0-1189-46b5-ae18-4762595332f8 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultUpdater | MemberDataService | { //Code: 3552 Oid: 4912e5e1-7ca6-43ae-bf9a-bfe52199d442 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| OnLoaded | MemberDataService | { base.OnLoaded(); } |
| OnSaving | MemberDataService | { #region 3547ImportCode base.OnSaving(); SetDefaultUpdate(); SetDefaultUpdater(); #endregion 3547ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&... |
| SetDefaultDataService | MemberDataService | { //if (DataService is null){ // var result = GetDefaultDataService(view); // if (result != null && result != DataService){ // DataService = result; // } //} } |
| SetDefaultMember | MemberDataService | { //Code: 3540 Oid: 7eccdc7e-9bcc-44d6-82d1-78d6b4c893e8 if(Member == null) Member = GetDefaultMember(); } |
| SetDefaultSoftwareServiceType | MemberDataService | { //if (SoftwareServiceType is null){ // var result = GetDefaultSoftwareServiceType(view); // if (result != null && result != SoftwareServiceType){ // SoftwareServiceType = result; // } //} } |
| SetDefaultUpdate | MemberDataService | { //Code: 3545 Oid: 12d8f4d5-f8d2-4fdc-8fcc-c4d906a0ddcb if (!IsDeleted) Update = GetDefaultUpdate(); } |
| SetDefaultUpdater | MemberDataService | { //Code: 3550 Oid: a18e3b74-06c6-46fe-96d4-d6283e39022d Updater = GetDefaultUpdater(); } |

---

# Entity: ObjectRelation

Caption entity: `Quan hệ đối tượng`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Code | string | Mã | No | GetDefaultCode: Code<br>SetDefaultCode: result | true | true |   | 1 |
| Note | string | Ghi chú | No | GetDefaultNote: Note<br>SetDefaultNote: result | true | true |   | 1 |
| Update | DateTime? | Cập nhật | No | SetDefaultUpdate: GetDefaultUpdate()<br>GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null) | false | false |  |  |
| Updater | Module.BusinessObjects.Member | Người cập nhật | No | SetDefaultUpdater: GetDefaultUpdater()<br>GetDefaultUpdater: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session) | false | false |  |  |
| SystemType | System.Type | Kiểu hệ thống | No | GetDefaultSystemType: SystemType<br>SetDefaultSystemType: result | true | false |  |  |
| ObjectID | System.Guid? | Mã đối tượng | No | GetDefaultObjectID: ObjectID<br>SetDefaultObjectID: result | false | false |  |  |
| SoftwareObjectType | SoftwareObjectType | Kiểu đối tượng | No | GetDefaultSoftwareObjectType: SoftwareObjectType<br>SetDefaultSoftwareObjectType: enumValue | false | false |  |  |
| Folder | Module.BusinessObjects.Folder | Thư mục | No | GetDefaultFolder: Folder<br>SetDefaultFolder: result | false | false |  |  |
| Post | Module.BusinessObjects.Post | Bài viết | No | GetDefaultPost: Post<br>SetDefaultPost: result | false | false |  |  |
| PublicEvent | Module.BusinessObjects.PublicEvent | Sự kiện | No | GetDefaultPublicEvent: PublicEvent<br>SetDefaultPublicEvent: result | false | false |  |  |
| Order | int? | Thứ tự | No |  | true | false |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Code  
Default: Code  
Source: `GetDefaultCode()`  
Logic: { return Code; }

Field: Code  
Default: result  
Source: `SetDefaultCode()`  
Logic: { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} }

Field: Note  
Default: Note  
Source: `GetDefaultNote()`  
Logic: { return Note; }

Field: Note  
Default: result  
Source: `SetDefaultNote()`  
Logic: { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 1334 Oid: 0b703d4b-1d46-42a6-a934-c10cfdca4165 if (!IsDeleted) Update = GetDefaultUpdate(); }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 1336 Oid: a3f73d17-fbb5-42cd-a891-4d3f65be2a45 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Updater  
Default: GetDefaultUpdater()  
Source: `SetDefaultUpdater()`  
Logic: { //Code: 3668 Oid: a94dc48e-abb1-4f37-be58-e397ac3c39e4 Updater = GetDefaultUpdater(); }

Field: Updater  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultUpdater()`  
Logic: { //Code: 3670 Oid: 36ff8aed-e151-4c6f-b3e8-655557d842a9 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: SystemType  
Default: SystemType  
Source: `GetDefaultSystemType()`  
Logic: { return SystemType; }

Field: SystemType  
Default: result  
Source: `SetDefaultSystemType()`  
Logic: { //if (SystemType is null){ // var result = GetDefaultSystemType(view); // if (result != null && result != SystemType){ // SystemType = result; // } //} }

Field: ObjectID  
Default: ObjectID  
Source: `GetDefaultObjectID()`  
Logic: { return ObjectID; }

Field: ObjectID  
Default: result  
Source: `SetDefaultObjectID()`  
Logic: { //if (ObjectID is null){ // var result = GetDefaultObjectID(view); // if (result != null && result != ObjectID){ // ObjectID = result; // } //} }

Field: SoftwareObjectType  
Default: SoftwareObjectType  
Source: `GetDefaultSoftwareObjectType()`  
Logic: { return SoftwareObjectType; }

Field: SoftwareObjectType  
Default: enumValue  
Source: `SetDefaultSoftwareObjectType()`  
Logic: { //Code: 3702 Oid: 38248241-7a5a-4dc8-bd5a-ad791ce43f53 if (SystemType == null) return; string typeName = SystemType.Name; if (Enum.TryParse<SoftwareObjectType>(typeName, out var enumValue)) { SoftwareObjectType = enumValue; } }

Field: Folder  
Default: Folder  
Source: `GetDefaultFolder()`  
Logic: { return Folder; }

Field: Folder  
Default: result  
Source: `SetDefaultFolder()`  
Logic: { //if (Folder is null){ // var result = GetDefaultFolder(view); // if (result != null && result != Folder){ // Folder = result; // } //} }

Field: Post  
Default: Post  
Source: `GetDefaultPost()`  
Logic: { return Post; }

Field: Post  
Default: result  
Source: `SetDefaultPost()`  
Logic: { //if (Post is null){ // var result = GetDefaultPost(view); // if (result != null && result != Post){ // Post = result; // } //} }

Field: PublicEvent  
Default: PublicEvent  
Source: `GetDefaultPublicEvent()`  
Logic: { return PublicEvent; }

Field: PublicEvent  
Default: result  
Source: `SetDefaultPublicEvent()`  
Logic: { //if (PublicEvent is null){ // var result = GetDefaultPublicEvent(view); // if (result != null && result != PublicEvent){ // PublicEvent = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultCode(View view = null); //SetDefaultNote(View view = null); //SetDefaultUpdate(View view = null); //SetDefaultUpdater(View view = null); //SetDefaultSystemType(Vi...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 1335ImportCode base.OnSaving(); SetDefaultUpdate(); SetDefaultUpdater(); #endregion 1335ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- Folder [Detail=false]
- ObjectID [Detail=false]
- Order [Detail=false]
- Post [Detail=false]
- PublicEvent [Detail=false]
- SoftwareObjectType [Detail=false]
- SystemType [Detail=false]
- Update [Detail=false]
- Updater [Detail=false]

Group: (default)
- Code [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- Note [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | ObjectRelation | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultCode(View view = null); //SetDefaultNote(View view = null); //SetDefaultUpdate(View view = null); //SetDefaultUpdater(View view = null); //SetDefaultSystemType(Vi... |
| GetDefaultCode | ObjectRelation | { return Code; } |
| GetDefaultFolder | ObjectRelation | { return Folder; } |
| GetDefaultName | ObjectRelation | { return Name; } |
| GetDefaultNote | ObjectRelation | { return Note; } |
| GetDefaultObjectID | ObjectRelation | { return ObjectID; } |
| GetDefaultPost | ObjectRelation | { return Post; } |
| GetDefaultPublicEvent | ObjectRelation | { return PublicEvent; } |
| GetDefaultSoftwareObjectType | ObjectRelation | { return SoftwareObjectType; } |
| GetDefaultSystemType | ObjectRelation | { return SystemType; } |
| GetDefaultUpdate | ObjectRelation | { //Code: 1336 Oid: a3f73d17-fbb5-42cd-a891-4d3f65be2a45 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultUpdater | ObjectRelation | { //Code: 3670 Oid: 36ff8aed-e151-4c6f-b3e8-655557d842a9 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| OnLoaded | ObjectRelation | { base.OnLoaded(); } |
| OnSaving | ObjectRelation | { #region 1335ImportCode base.OnSaving(); SetDefaultUpdate(); SetDefaultUpdater(); #endregion 1335ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&... |
| SetDefaultCode | ObjectRelation | { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} } |
| SetDefaultFolder | ObjectRelation | { //if (Folder is null){ // var result = GetDefaultFolder(view); // if (result != null && result != Folder){ // Folder = result; // } //} } |
| SetDefaultName | ObjectRelation | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultNote | ObjectRelation | { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} } |
| SetDefaultObjectID | ObjectRelation | { //if (ObjectID is null){ // var result = GetDefaultObjectID(view); // if (result != null && result != ObjectID){ // ObjectID = result; // } //} } |
| SetDefaultPost | ObjectRelation | { //if (Post is null){ // var result = GetDefaultPost(view); // if (result != null && result != Post){ // Post = result; // } //} } |
| SetDefaultPublicEvent | ObjectRelation | { //if (PublicEvent is null){ // var result = GetDefaultPublicEvent(view); // if (result != null && result != PublicEvent){ // PublicEvent = result; // } //} } |
| SetDefaultSoftwareObjectType | ObjectRelation | { //Code: 3702 Oid: 38248241-7a5a-4dc8-bd5a-ad791ce43f53 if (SystemType == null) return; string typeName = SystemType.Name; if (Enum.TryParse<SoftwareObjectType>(typeName, out var enumValue)) { SoftwareObjectType = enumValue; } } |
| SetDefaultSystemType | ObjectRelation | { //if (SystemType is null){ // var result = GetDefaultSystemType(view); // if (result != null && result != SystemType){ // SystemType = result; // } //} } |
| SetDefaultUpdate | ObjectRelation | { //Code: 1334 Oid: 0b703d4b-1d46-42a6-a934-c10cfdca4165 if (!IsDeleted) Update = GetDefaultUpdate(); } |
| SetDefaultUpdater | ObjectRelation | { //Code: 3668 Oid: a94dc48e-abb1-4f37-be58-e397ac3c39e4 Updater = GetDefaultUpdater(); } |

---

# Entity: Paragraph

Caption entity: `Đoạn văn bản`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Order | int? | Thứ tự | No | GetDefaultOrder: Order<br>SetDefaultOrder: result | true | true |   | 1 |
| Code | string | Mã | No | GetDefaultCode: Code<br>SetDefaultCode: result | true | true |   | 1 |
| ParagraphStyle | Module.BusinessObjects.ParagraphStyle | Kiểu cách | No | GetDefaultParagraphStyle: ParagraphStyle<br>SetDefaultParagraphStyle: result | true | true |   | 1 |
| BookMark | Module.BusinessObjects.BookMark | Liên kết | No | GetDefaultBookMark: BookMark<br>SetDefaultBookMark: result | true | true |   | 1 |
| AudioList | XPCollection <Module.BusinessObjects.Audio> | Thành phần | No |  | false | true |  |  |
| MediaList | XPCollection <Module.BusinessObjects.Media> | Hình ảnh | No |  | false | true |  |  |
| Update | DateTime? | Cập nhật | No | GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)<br>SetDefaultUpdate: GetDefaultUpdate() | false | false |  |  |
| Flag | bool | Cờ | No | GetDefaultFlag: Flag<br>SetDefaultFlag: result | false | false |  |  |
| Video | Module.BusinessObjects.Video | Tư liệu | Yes | GetDefaultVideo: Video<br>SetDefaultVideo: result | false | false |  |  |
| Content | string | Nội dung | No | GetDefaultContent: Content<br>SetDefaultContent: result | false | false |  |  |
| ShapeIdList | string | Mã hình ảnh | No | GetDefaultShapeIdList: ShapeIdList<br>SetDefaultShapeIdList: result | false | false |  |  |

## Default Logic

Field: Order  
Default: Order  
Source: `GetDefaultOrder()`  
Logic: { return Order; }

Field: Order  
Default: result  
Source: `SetDefaultOrder()`  
Logic: { //if (Order is null){ // var result = GetDefaultOrder(view); // if (result != null && result != Order){ // Order = result; // } //} }

Field: Code  
Default: Code  
Source: `GetDefaultCode()`  
Logic: { return Code; }

Field: Code  
Default: result  
Source: `SetDefaultCode()`  
Logic: { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} }

Field: ParagraphStyle  
Default: ParagraphStyle  
Source: `GetDefaultParagraphStyle()`  
Logic: { return ParagraphStyle; }

Field: ParagraphStyle  
Default: result  
Source: `SetDefaultParagraphStyle()`  
Logic: { //if (ParagraphStyle is null){ // var result = GetDefaultParagraphStyle(view); // if (result != null && result != ParagraphStyle){ // ParagraphStyle = result; // } //} }

Field: BookMark  
Default: BookMark  
Source: `GetDefaultBookMark()`  
Logic: { return BookMark; }

Field: BookMark  
Default: result  
Source: `SetDefaultBookMark()`  
Logic: { //if (BookMark is null){ // var result = GetDefaultBookMark(view); // if (result != null && result != BookMark){ // BookMark = result; // } //} }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 1000 Oid: 281e82f1-f53d-426f-b75a-ad0a762325a8 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 0998 Oid: 862850da-e54e-4da4-9e7b-09837ce188e3 Update = GetDefaultUpdate(); }

Field: Flag  
Default: Flag  
Source: `GetDefaultFlag()`  
Logic: { return Flag; }

Field: Flag  
Default: result  
Source: `SetDefaultFlag()`  
Logic: { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} }

Field: Video  
Default: Video  
Source: `GetDefaultVideo()`  
Logic: { return Video; }

Field: Video  
Default: result  
Source: `SetDefaultVideo()`  
Logic: { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} }

Field: Content  
Default: Content  
Source: `GetDefaultContent()`  
Logic: { return Content; }

Field: Content  
Default: result  
Source: `SetDefaultContent()`  
Logic: { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} }

Field: ShapeIdList  
Default: ShapeIdList  
Source: `GetDefaultShapeIdList()`  
Logic: { return ShapeIdList; }

Field: ShapeIdList  
Default: result  
Source: `SetDefaultShapeIdList()`  
Logic: { //if (ShapeIdList is null){ // var result = GetDefaultShapeIdList(view); // if (result != null && result != ShapeIdList){ // ShapeIdList = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultOrder(View view = null); //SetDefaultCode(View view = null); //SetDefaultParagraphStyle(View view = null); //SetDefaultBookMark(View view = null); //SetDefaultUpdate(View view = null); //SetDefaultF...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 0999ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0999ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- AudioList [Detail=true]
- Content [Detail=false]
- Flag [Detail=false]
- MediaList [Detail=true]
- ShapeIdList [Detail=false]
- Update [Detail=false]
- Video [Detail=false]

Group: (default)
- BookMark [Order=1] [Detail=true]
- Code [Order=1] [Detail=true]
- Order [Order=1] [Detail=true]
- ParagraphStyle [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | Paragraph | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultOrder(View view = null); //SetDefaultCode(View view = null); //SetDefaultParagraphStyle(View view = null); //SetDefaultBookMark(View view = null); //SetDefaultUpdate(View view = null); //SetDefaultF... |
| GetDefaultBookMark | Paragraph | { return BookMark; } |
| GetDefaultCode | Paragraph | { return Code; } |
| GetDefaultContent | Paragraph | { return Content; } |
| GetDefaultFlag | Paragraph | { return Flag; } |
| GetDefaultOrder | Paragraph | { return Order; } |
| GetDefaultParagraphStyle | Paragraph | { return ParagraphStyle; } |
| GetDefaultShapeIdList | Paragraph | { return ShapeIdList; } |
| GetDefaultUpdate | Paragraph | { //Code: 1000 Oid: 281e82f1-f53d-426f-b75a-ad0a762325a8 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultVideo | Paragraph | { return Video; } |
| OnLoaded | Paragraph | { base.OnLoaded(); } |
| OnSaving | Paragraph | { #region 0999ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0999ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ... |
| SetDefaultBookMark | Paragraph | { //if (BookMark is null){ // var result = GetDefaultBookMark(view); // if (result != null && result != BookMark){ // BookMark = result; // } //} } |
| SetDefaultCode | Paragraph | { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} } |
| SetDefaultContent | Paragraph | { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} } |
| SetDefaultFlag | Paragraph | { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} } |
| SetDefaultOrder | Paragraph | { //if (Order is null){ // var result = GetDefaultOrder(view); // if (result != null && result != Order){ // Order = result; // } //} } |
| SetDefaultParagraphStyle | Paragraph | { //if (ParagraphStyle is null){ // var result = GetDefaultParagraphStyle(view); // if (result != null && result != ParagraphStyle){ // ParagraphStyle = result; // } //} } |
| SetDefaultShapeIdList | Paragraph | { //if (ShapeIdList is null){ // var result = GetDefaultShapeIdList(view); // if (result != null && result != ShapeIdList){ // ShapeIdList = result; // } //} } |
| SetDefaultUpdate | Paragraph | { //Code: 0998 Oid: 862850da-e54e-4da4-9e7b-09837ce188e3 Update = GetDefaultUpdate(); } |
| SetDefaultVideo | Paragraph | { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} } |

---

# Entity: ParagraphStyle

Caption entity: `Kiểu cách`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Font | string | Phông | No | GetDefaultFont: Font<br>SetDefaultFont: result | true | true |   | 1 |
| TranslateFont | string | Phông dịch | No | GetDefaultTranslateFont: TranslateFont<br>SetDefaultTranslateFont: result | true | true |   | 1 |
| Size | decimal? | Cỡ | No | GetDefaultSize: Size<br>SetDefaultSize: result | true | true |   | 1 |
| Color | Color? | Màu | No | GetDefaultColor: Color<br>SetDefaultColor: result | true | true |   | 1 |
| Bold | bool | Đậm | No | GetDefaultBold: Bold<br>SetDefaultBold: result | true | true |   | 1 |
| Italic | bool | Nghiêng | No | GetDefaultItalic: Italic<br>SetDefaultItalic: result | true | true |   | 1 |
| Underline | bool | Gạch dưới | No | GetDefaultUnderline: Underline<br>SetDefaultUnderline: result | true | true |   | 1 |
| Outline | int? | Outline | No | GetDefaultOutline: Outline<br>SetDefaultOutline: result | true | true |   | 1 |
| Alignment | Alignment | Căn lề | No | GetDefaultAlignment: Alignment<br>SetDefaultAlignment: result | true | true |   | 1 |
| SpacingBefore | decimal? | Cách trước | No | GetDefaultSpacingBefore: SpacingBefore<br>SetDefaultSpacingBefore: result | true | true |   | 1 |
| SpacingAfter | decimal? | Cách sau | No | GetDefaultSpacingAfter: SpacingAfter<br>SetDefaultSpacingAfter: result | true | true |   | 1 |
| SpacingLine | string | Cách dòng | No | GetDefaultSpacingLine: SpacingLine<br>SetDefaultSpacingLine: result | true | true |   | 1 |
| SpacingLineAt | decimal? | Chính xác | No | GetDefaultSpacingLineAt: SpacingLineAt<br>SetDefaultSpacingLineAt: result | true | true |   | 1 |
| IndentLeft | decimal? | Thụt trái | No | GetDefaultIndentLeft: IndentLeft<br>SetDefaultIndentLeft: result | true | true |   | 1 |
| IndentRight | decimal? | Thụt phải | No | GetDefaultIndentRight: IndentRight<br>SetDefaultIndentRight: result | true | true |   | 1 |
| IndentFirstLine | decimal? | Thụt đầu | No | GetDefaultIndentFirstLine: IndentFirstLine<br>SetDefaultIndentFirstLine: result | true | true |   | 1 |
| UpperStyle | Module.BusinessObjects.ParagraphStyle | Cấp trên | No | GetDefaultUpperStyle: UpperStyle<br>SetDefaultUpperStyle: result | true | true |   | 1 |
| Video | Module.BusinessObjects.Video | Tư liệu | No | GetDefaultVideo: Video<br>SetDefaultVideo: result | false | false |  |  |
| ElementQuantity | int? | Số lượng | No | GetDefaultElementQuantity: ElementQuantity<br>SetDefaultElementQuantity: result | true | false |  |  |
| Link | Module.BusinessObjects.BookMark | Liên kết | No | GetDefaultLink: Link<br>SetDefaultLink: result | false | false |  |  |
| Height | decimal? | Cao | No | GetDefaultHeight: Height<br>SetDefaultHeight: result | false | false |  |  |
| Width | decimal? | Rộng | No | GetDefaultWidth: Width<br>SetDefaultWidth: result | false | false |  |  |
| ObjectLayout | ObjectLayout | Bố cục | No | GetDefaultObjectLayout: ObjectLayout<br>SetDefaultObjectLayout: result | false | false |  |  |
| AlignmentRelative | AlignmentRelative | Mốc căn lề | No | GetDefaultAlignmentRelative: AlignmentRelative<br>SetDefaultAlignmentRelative: result | false | false |  |  |
| MoveWithText | bool | Dịch chuyển theo | No | GetDefaultMoveWithText: MoveWithText<br>SetDefaultMoveWithText: result | false | false |  |  |
| TextWrappingType | Microsoft.Office.Interop.Word.WdWrapType | Bố cục hình | No | GetDefaultTextWrappingType: TextWrappingType<br>SetDefaultTextWrappingType: result | false | false |  |  |
| ParagraphStyleType | ParagraphStyleType | Loại kiểu cách | No | GetDefaultParagraphStyleType: ParagraphStyleType<br>SetDefaultParagraphStyleType: result | false | false |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Font  
Default: Font  
Source: `GetDefaultFont()`  
Logic: { return Font; }

Field: Font  
Default: result  
Source: `SetDefaultFont()`  
Logic: { //if (Font is null){ // var result = GetDefaultFont(view); // if (result != null && result != Font){ // Font = result; // } //} }

Field: TranslateFont  
Default: TranslateFont  
Source: `GetDefaultTranslateFont()`  
Logic: { return TranslateFont; }

Field: TranslateFont  
Default: result  
Source: `SetDefaultTranslateFont()`  
Logic: { //if (TranslateFont is null){ // var result = GetDefaultTranslateFont(view); // if (result != null && result != TranslateFont){ // TranslateFont = result; // } //} }

Field: Size  
Default: Size  
Source: `GetDefaultSize()`  
Logic: { return Size; }

Field: Size  
Default: result  
Source: `SetDefaultSize()`  
Logic: { //if (Size is null){ // var result = GetDefaultSize(view); // if (result != null && result != Size){ // Size = result; // } //} }

Field: Color  
Default: Color  
Source: `GetDefaultColor()`  
Logic: { return Color; }

Field: Color  
Default: result  
Source: `SetDefaultColor()`  
Logic: { //if (Color is null){ // var result = GetDefaultColor(view); // if (result != null && result != Color){ // Color = result; // } //} }

Field: Bold  
Default: Bold  
Source: `GetDefaultBold()`  
Logic: { return Bold; }

Field: Bold  
Default: result  
Source: `SetDefaultBold()`  
Logic: { //if (Bold is null){ // var result = GetDefaultBold(view); // if (result != null && result != Bold){ // Bold = result; // } //} }

Field: Italic  
Default: Italic  
Source: `GetDefaultItalic()`  
Logic: { return Italic; }

Field: Italic  
Default: result  
Source: `SetDefaultItalic()`  
Logic: { //if (Italic is null){ // var result = GetDefaultItalic(view); // if (result != null && result != Italic){ // Italic = result; // } //} }

Field: Underline  
Default: Underline  
Source: `GetDefaultUnderline()`  
Logic: { return Underline; }

Field: Underline  
Default: result  
Source: `SetDefaultUnderline()`  
Logic: { //if (Underline is null){ // var result = GetDefaultUnderline(view); // if (result != null && result != Underline){ // Underline = result; // } //} }

Field: Outline  
Default: Outline  
Source: `GetDefaultOutline()`  
Logic: { return Outline; }

Field: Outline  
Default: result  
Source: `SetDefaultOutline()`  
Logic: { //if (Outline is null){ // var result = GetDefaultOutline(view); // if (result != null && result != Outline){ // Outline = result; // } //} }

Field: Alignment  
Default: Alignment  
Source: `GetDefaultAlignment()`  
Logic: { return Alignment; }

Field: Alignment  
Default: result  
Source: `SetDefaultAlignment()`  
Logic: { //if (Alignment is null){ // var result = GetDefaultAlignment(view); // if (result != null && result != Alignment){ // Alignment = result; // } //} }

Field: SpacingBefore  
Default: SpacingBefore  
Source: `GetDefaultSpacingBefore()`  
Logic: { return SpacingBefore; }

Field: SpacingBefore  
Default: result  
Source: `SetDefaultSpacingBefore()`  
Logic: { //if (SpacingBefore is null){ // var result = GetDefaultSpacingBefore(view); // if (result != null && result != SpacingBefore){ // SpacingBefore = result; // } //} }

Field: SpacingAfter  
Default: SpacingAfter  
Source: `GetDefaultSpacingAfter()`  
Logic: { return SpacingAfter; }

Field: SpacingAfter  
Default: result  
Source: `SetDefaultSpacingAfter()`  
Logic: { //if (SpacingAfter is null){ // var result = GetDefaultSpacingAfter(view); // if (result != null && result != SpacingAfter){ // SpacingAfter = result; // } //} }

Field: SpacingLine  
Default: SpacingLine  
Source: `GetDefaultSpacingLine()`  
Logic: { return SpacingLine; }

Field: SpacingLine  
Default: result  
Source: `SetDefaultSpacingLine()`  
Logic: { //if (SpacingLine is null){ // var result = GetDefaultSpacingLine(view); // if (result != null && result != SpacingLine){ // SpacingLine = result; // } //} }

Field: SpacingLineAt  
Default: SpacingLineAt  
Source: `GetDefaultSpacingLineAt()`  
Logic: { return SpacingLineAt; }

Field: SpacingLineAt  
Default: result  
Source: `SetDefaultSpacingLineAt()`  
Logic: { //if (SpacingLineAt is null){ // var result = GetDefaultSpacingLineAt(view); // if (result != null && result != SpacingLineAt){ // SpacingLineAt = result; // } //} }

Field: IndentLeft  
Default: IndentLeft  
Source: `GetDefaultIndentLeft()`  
Logic: { return IndentLeft; }

Field: IndentLeft  
Default: result  
Source: `SetDefaultIndentLeft()`  
Logic: { //if (IndentLeft is null){ // var result = GetDefaultIndentLeft(view); // if (result != null && result != IndentLeft){ // IndentLeft = result; // } //} }

Field: IndentRight  
Default: IndentRight  
Source: `GetDefaultIndentRight()`  
Logic: { return IndentRight; }

Field: IndentRight  
Default: result  
Source: `SetDefaultIndentRight()`  
Logic: { //if (IndentRight is null){ // var result = GetDefaultIndentRight(view); // if (result != null && result != IndentRight){ // IndentRight = result; // } //} }

Field: IndentFirstLine  
Default: IndentFirstLine  
Source: `GetDefaultIndentFirstLine()`  
Logic: { return IndentFirstLine; }

Field: IndentFirstLine  
Default: result  
Source: `SetDefaultIndentFirstLine()`  
Logic: { //if (IndentFirstLine is null){ // var result = GetDefaultIndentFirstLine(view); // if (result != null && result != IndentFirstLine){ // IndentFirstLine = result; // } //} }

Field: UpperStyle  
Default: UpperStyle  
Source: `GetDefaultUpperStyle()`  
Logic: { return UpperStyle; }

Field: UpperStyle  
Default: result  
Source: `SetDefaultUpperStyle()`  
Logic: { //if (UpperStyle is null){ // var result = GetDefaultUpperStyle(view); // if (result != null && result != UpperStyle){ // UpperStyle = result; // } //} }

Field: Video  
Default: Video  
Source: `GetDefaultVideo()`  
Logic: { return Video; }

Field: Video  
Default: result  
Source: `SetDefaultVideo()`  
Logic: { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} }

Field: ElementQuantity  
Default: ElementQuantity  
Source: `GetDefaultElementQuantity()`  
Logic: { return ElementQuantity; }

Field: ElementQuantity  
Default: result  
Source: `SetDefaultElementQuantity()`  
Logic: { //if (ElementQuantity is null){ // var result = GetDefaultElementQuantity(view); // if (result != null && result != ElementQuantity){ // ElementQuantity = result; // } //} }

Field: Link  
Default: Link  
Source: `GetDefaultLink()`  
Logic: { return Link; }

Field: Link  
Default: result  
Source: `SetDefaultLink()`  
Logic: { //if (Link is null){ // var result = GetDefaultLink(view); // if (result != null && result != Link){ // Link = result; // } //} }

Field: Height  
Default: Height  
Source: `GetDefaultHeight()`  
Logic: { return Height; }

Field: Height  
Default: result  
Source: `SetDefaultHeight()`  
Logic: { //if (Height is null){ // var result = GetDefaultHeight(view); // if (result != null && result != Height){ // Height = result; // } //} }

Field: Width  
Default: Width  
Source: `GetDefaultWidth()`  
Logic: { return Width; }

Field: Width  
Default: result  
Source: `SetDefaultWidth()`  
Logic: { //if (Width is null){ // var result = GetDefaultWidth(view); // if (result != null && result != Width){ // Width = result; // } //} }

Field: ObjectLayout  
Default: ObjectLayout  
Source: `GetDefaultObjectLayout()`  
Logic: { return ObjectLayout; }

Field: ObjectLayout  
Default: result  
Source: `SetDefaultObjectLayout()`  
Logic: { //if (ObjectLayout is null){ // var result = GetDefaultObjectLayout(view); // if (result != null && result != ObjectLayout){ // ObjectLayout = result; // } //} }

Field: AlignmentRelative  
Default: AlignmentRelative  
Source: `GetDefaultAlignmentRelative()`  
Logic: { return AlignmentRelative; }

Field: AlignmentRelative  
Default: result  
Source: `SetDefaultAlignmentRelative()`  
Logic: { //if (AlignmentRelative is null){ // var result = GetDefaultAlignmentRelative(view); // if (result != null && result != AlignmentRelative){ // AlignmentRelative = result; // } //} }

Field: MoveWithText  
Default: MoveWithText  
Source: `GetDefaultMoveWithText()`  
Logic: { return MoveWithText; }

Field: MoveWithText  
Default: result  
Source: `SetDefaultMoveWithText()`  
Logic: { //if (MoveWithText is null){ // var result = GetDefaultMoveWithText(view); // if (result != null && result != MoveWithText){ // MoveWithText = result; // } //} }

Field: TextWrappingType  
Default: TextWrappingType  
Source: `GetDefaultTextWrappingType()`  
Logic: { return TextWrappingType; }

Field: TextWrappingType  
Default: result  
Source: `SetDefaultTextWrappingType()`  
Logic: { //if (TextWrappingType is null){ // var result = GetDefaultTextWrappingType(view); // if (result != null && result != TextWrappingType){ // TextWrappingType = result; // } //} }

Field: ParagraphStyleType  
Default: ParagraphStyleType  
Source: `GetDefaultParagraphStyleType()`  
Logic: { return ParagraphStyleType; }

Field: ParagraphStyleType  
Default: result  
Source: `SetDefaultParagraphStyleType()`  
Logic: { //if (ParagraphStyleType is null){ // var result = GetDefaultParagraphStyleType(view); // if (result != null && result != ParagraphStyleType){ // ParagraphStyleType = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultFont(View view = null); //SetDefaultTranslateFont(View view = null); //SetDefaultSize(View view = null); //SetDefaultColor(View view = null); //SetDefaultBold(Vie...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AlignmentRelative [Detail=false]
- AppearanceDisableDelete
- ElementQuantity [Detail=false]
- Height [Detail=false]
- Link [Detail=false]
- MoveWithText [Detail=false]
- ObjectLayout [Detail=false]
- ParagraphStyleType [Detail=false]
- TextWrappingType [Detail=false]
- Video [Detail=false]
- Width [Detail=false]

Group: (default)
- Alignment [Order=1] [Detail=true]
- Bold [Order=1] [Detail=true]
- Color [Order=1] [Detail=true]
- Font [Order=1] [Detail=true]
- IndentFirstLine [Order=1] [Detail=true]
- IndentLeft [Order=1] [Detail=true]
- IndentRight [Order=1] [Detail=true]
- Italic [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- Outline [Order=1] [Detail=true]
- Size [Order=1] [Detail=true]
- SpacingAfter [Order=1] [Detail=true]
- SpacingBefore [Order=1] [Detail=true]
- SpacingLine [Order=1] [Detail=true]
- SpacingLineAt [Order=1] [Detail=true]
- TranslateFont [Order=1] [Detail=true]
- Underline [Order=1] [Detail=true]
- UpperStyle [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | ParagraphStyle | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultFont(View view = null); //SetDefaultTranslateFont(View view = null); //SetDefaultSize(View view = null); //SetDefaultColor(View view = null); //SetDefaultBold(Vie... |
| GetDefaultAlignment | ParagraphStyle | { return Alignment; } |
| GetDefaultAlignmentRelative | ParagraphStyle | { return AlignmentRelative; } |
| GetDefaultBold | ParagraphStyle | { return Bold; } |
| GetDefaultColor | ParagraphStyle | { return Color; } |
| GetDefaultElementQuantity | ParagraphStyle | { return ElementQuantity; } |
| GetDefaultFont | ParagraphStyle | { return Font; } |
| GetDefaultHeight | ParagraphStyle | { return Height; } |
| GetDefaultIndentFirstLine | ParagraphStyle | { return IndentFirstLine; } |
| GetDefaultIndentLeft | ParagraphStyle | { return IndentLeft; } |
| GetDefaultIndentRight | ParagraphStyle | { return IndentRight; } |
| GetDefaultItalic | ParagraphStyle | { return Italic; } |
| GetDefaultLink | ParagraphStyle | { return Link; } |
| GetDefaultMoveWithText | ParagraphStyle | { return MoveWithText; } |
| GetDefaultName | ParagraphStyle | { return Name; } |
| GetDefaultObjectLayout | ParagraphStyle | { return ObjectLayout; } |
| GetDefaultOutline | ParagraphStyle | { return Outline; } |
| GetDefaultParagraphStyleType | ParagraphStyle | { return ParagraphStyleType; } |
| GetDefaultSize | ParagraphStyle | { return Size; } |
| GetDefaultSpacingAfter | ParagraphStyle | { return SpacingAfter; } |
| GetDefaultSpacingBefore | ParagraphStyle | { return SpacingBefore; } |
| GetDefaultSpacingLine | ParagraphStyle | { return SpacingLine; } |
| GetDefaultSpacingLineAt | ParagraphStyle | { return SpacingLineAt; } |
| GetDefaultTextWrappingType | ParagraphStyle | { return TextWrappingType; } |
| GetDefaultTranslateFont | ParagraphStyle | { return TranslateFont; } |
| GetDefaultUnderline | ParagraphStyle | { return Underline; } |
| GetDefaultUpperStyle | ParagraphStyle | { return UpperStyle; } |
| GetDefaultVideo | ParagraphStyle | { return Video; } |
| GetDefaultWidth | ParagraphStyle | { return Width; } |
| OnLoaded | ParagraphStyle | { base.OnLoaded(); } |
| OnSaving | ParagraphStyle | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultAlignment | ParagraphStyle | { //if (Alignment is null){ // var result = GetDefaultAlignment(view); // if (result != null && result != Alignment){ // Alignment = result; // } //} } |
| SetDefaultAlignmentRelative | ParagraphStyle | { //if (AlignmentRelative is null){ // var result = GetDefaultAlignmentRelative(view); // if (result != null && result != AlignmentRelative){ // AlignmentRelative = result; // } //} } |
| SetDefaultBold | ParagraphStyle | { //if (Bold is null){ // var result = GetDefaultBold(view); // if (result != null && result != Bold){ // Bold = result; // } //} } |
| SetDefaultColor | ParagraphStyle | { //if (Color is null){ // var result = GetDefaultColor(view); // if (result != null && result != Color){ // Color = result; // } //} } |
| SetDefaultElementQuantity | ParagraphStyle | { //if (ElementQuantity is null){ // var result = GetDefaultElementQuantity(view); // if (result != null && result != ElementQuantity){ // ElementQuantity = result; // } //} } |
| SetDefaultFont | ParagraphStyle | { //if (Font is null){ // var result = GetDefaultFont(view); // if (result != null && result != Font){ // Font = result; // } //} } |
| SetDefaultHeight | ParagraphStyle | { //if (Height is null){ // var result = GetDefaultHeight(view); // if (result != null && result != Height){ // Height = result; // } //} } |
| SetDefaultIndentFirstLine | ParagraphStyle | { //if (IndentFirstLine is null){ // var result = GetDefaultIndentFirstLine(view); // if (result != null && result != IndentFirstLine){ // IndentFirstLine = result; // } //} } |
| SetDefaultIndentLeft | ParagraphStyle | { //if (IndentLeft is null){ // var result = GetDefaultIndentLeft(view); // if (result != null && result != IndentLeft){ // IndentLeft = result; // } //} } |
| SetDefaultIndentRight | ParagraphStyle | { //if (IndentRight is null){ // var result = GetDefaultIndentRight(view); // if (result != null && result != IndentRight){ // IndentRight = result; // } //} } |
| SetDefaultItalic | ParagraphStyle | { //if (Italic is null){ // var result = GetDefaultItalic(view); // if (result != null && result != Italic){ // Italic = result; // } //} } |
| SetDefaultLink | ParagraphStyle | { //if (Link is null){ // var result = GetDefaultLink(view); // if (result != null && result != Link){ // Link = result; // } //} } |
| SetDefaultMoveWithText | ParagraphStyle | { //if (MoveWithText is null){ // var result = GetDefaultMoveWithText(view); // if (result != null && result != MoveWithText){ // MoveWithText = result; // } //} } |
| SetDefaultName | ParagraphStyle | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultObjectLayout | ParagraphStyle | { //if (ObjectLayout is null){ // var result = GetDefaultObjectLayout(view); // if (result != null && result != ObjectLayout){ // ObjectLayout = result; // } //} } |
| SetDefaultOutline | ParagraphStyle | { //if (Outline is null){ // var result = GetDefaultOutline(view); // if (result != null && result != Outline){ // Outline = result; // } //} } |
| SetDefaultParagraphStyleType | ParagraphStyle | { //if (ParagraphStyleType is null){ // var result = GetDefaultParagraphStyleType(view); // if (result != null && result != ParagraphStyleType){ // ParagraphStyleType = result; // } //} } |
| SetDefaultSize | ParagraphStyle | { //if (Size is null){ // var result = GetDefaultSize(view); // if (result != null && result != Size){ // Size = result; // } //} } |
| SetDefaultSpacingAfter | ParagraphStyle | { //if (SpacingAfter is null){ // var result = GetDefaultSpacingAfter(view); // if (result != null && result != SpacingAfter){ // SpacingAfter = result; // } //} } |
| SetDefaultSpacingBefore | ParagraphStyle | { //if (SpacingBefore is null){ // var result = GetDefaultSpacingBefore(view); // if (result != null && result != SpacingBefore){ // SpacingBefore = result; // } //} } |
| SetDefaultSpacingLine | ParagraphStyle | { //if (SpacingLine is null){ // var result = GetDefaultSpacingLine(view); // if (result != null && result != SpacingLine){ // SpacingLine = result; // } //} } |
| SetDefaultSpacingLineAt | ParagraphStyle | { //if (SpacingLineAt is null){ // var result = GetDefaultSpacingLineAt(view); // if (result != null && result != SpacingLineAt){ // SpacingLineAt = result; // } //} } |
| SetDefaultTextWrappingType | ParagraphStyle | { //if (TextWrappingType is null){ // var result = GetDefaultTextWrappingType(view); // if (result != null && result != TextWrappingType){ // TextWrappingType = result; // } //} } |
| SetDefaultTranslateFont | ParagraphStyle | { //if (TranslateFont is null){ // var result = GetDefaultTranslateFont(view); // if (result != null && result != TranslateFont){ // TranslateFont = result; // } //} } |
| SetDefaultUnderline | ParagraphStyle | { //if (Underline is null){ // var result = GetDefaultUnderline(view); // if (result != null && result != Underline){ // Underline = result; // } //} } |
| SetDefaultUpperStyle | ParagraphStyle | { //if (UpperStyle is null){ // var result = GetDefaultUpperStyle(view); // if (result != null && result != UpperStyle){ // UpperStyle = result; // } //} } |
| SetDefaultVideo | ParagraphStyle | { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} } |
| SetDefaultWidth | ParagraphStyle | { //if (Width is null){ // var result = GetDefaultWidth(view); // if (result != null && result != Width){ // Width = result; // } //} } |

---

# Entity: Parameter

Caption entity: `Tham số`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | Yes | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Category | string | Phân loại | No | GetDefaultCategory: Category<br>SetDefaultCategory: result | true | true |   | 1 |
| ParameterFormat | ParameterFormat | Định dạng | No | GetDefaultParameterFormat: ParameterFormat<br>SetDefaultParameterFormat: result | true | true |   | 1 |
| Note | string | Ghi chú | No | GetDefaultNote: Note<br>SetDefaultNote: result | true | true |   | 1 |
| User | bool | Cá nhân | No | GetDefaultUser: User<br>SetDefaultUser: result | true | true |   | 1 |
| Value | string | Giá trị | No | GetDefaultValue: Value<br>SetDefaultValue: result | false | true |  |  |
| Update | DateTime | Cập nhật | No | SetDefaultUpdate: GetDefaultUpdate()<br>GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null) | false | false |  |  |
| Updater | Module.BusinessObjects.Member | Người cập nhật | No | GetDefaultUpdater: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)<br>SetDefaultUpdater: GetDefaultUpdater() | false | false |  |  |
| Order | int? | Thứ tự | No | SetDefaultOrder: = null) Order = GetDefaultOrder()<br>GetDefaultOrder: Computed in GetDefaultOrder | true | false |  |  |
| PermissionPolicyUser | DevExpress.Persistent.BaseImpl.PermissionPolicy.PermissionPolicyUser | Người dùng | No | GetDefaultPermissionPolicyUser: PermissionPolicyUser<br>SetDefaultPermissionPolicyUser: result | false | false |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Category  
Default: Category  
Source: `GetDefaultCategory()`  
Logic: { return Category; }

Field: Category  
Default: result  
Source: `SetDefaultCategory()`  
Logic: { //if (Category is null){ // var result = GetDefaultCategory(view); // if (result != null && result != Category){ // Category = result; // } //} }

Field: ParameterFormat  
Default: ParameterFormat  
Source: `GetDefaultParameterFormat()`  
Logic: { return ParameterFormat; }

Field: ParameterFormat  
Default: result  
Source: `SetDefaultParameterFormat()`  
Logic: { //if (ParameterFormat is null){ // var result = GetDefaultParameterFormat(view); // if (result != null && result != ParameterFormat){ // ParameterFormat = result; // } //} }

Field: Note  
Default: Note  
Source: `GetDefaultNote()`  
Logic: { return Note; }

Field: Note  
Default: result  
Source: `SetDefaultNote()`  
Logic: { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} }

Field: User  
Default: User  
Source: `GetDefaultUser()`  
Logic: { return User; }

Field: User  
Default: result  
Source: `SetDefaultUser()`  
Logic: { //if (User is null){ // var result = GetDefaultUser(view); // if (result != null && result != User){ // User = result; // } //} }

Field: Value  
Default: Value  
Source: `GetDefaultValue()`  
Logic: { return Value; }

Field: Value  
Default: result  
Source: `SetDefaultValue()`  
Logic: { //if (Value is null){ // var result = GetDefaultValue(view); // if (result != null && result != Value){ // Value = result; // } //} }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 0020 Oid: 403798e0-28db-4626-a719-41ff765f08ff Update = GetDefaultUpdate(); }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 0047 Oid: 619a1e2b-1e7f-4a0f-b0c1-cd1e0f5a07ff return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Updater  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultUpdater()`  
Logic: { //Code: 3580 Oid: 344e35b5-0117-4c64-a923-1dd2def03652 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: Updater  
Default: GetDefaultUpdater()  
Source: `SetDefaultUpdater()`  
Logic: { //Code: 3578 Oid: 9e98a438-5455-4c2a-9dee-fd4d85005802 Updater = GetDefaultUpdater(); }

Field: Order  
Default: = null) Order = GetDefaultOrder()  
Source: `SetDefaultOrder()`  
Logic: { //Code: 3584 Oid: c48bce00-b2be-47e6-96b0-25454d8ea343 if(Order == null) Order = GetDefaultOrder(); }

Field: Order  
Default: Computed in GetDefaultOrder  
Source: `GetDefaultOrder()`  
Logic: { //Code: 3582 Oid: a5233364-b16b-40d2-ad02-24ff639d8af7 //Code: 3582 Oid: a5233364-b16b-40d2-ad02-24ff639d8af7 var sort = new DevExpress.Xpo.SortProperty(nameof(Order), DevExpress.Xpo.DB.SortingDirection.Descending); var criteria = DevExpress.Data.Filtering.C...

Field: PermissionPolicyUser  
Default: PermissionPolicyUser  
Source: `GetDefaultPermissionPolicyUser()`  
Logic: { return PermissionPolicyUser; }

Field: PermissionPolicyUser  
Default: result  
Source: `SetDefaultPermissionPolicyUser()`  
Logic: { //if (PermissionPolicyUser is null){ // var result = GetDefaultPermissionPolicyUser(view); // if (result != null && result != PermissionPolicyUser){ // PermissionPolicyUser = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultCategory(View view = null); //SetDefaultParameterFormat(View view = null); //SetDefaultNote(View view = null); //SetDefaultUser(View view = null); //SetDefaultUpd...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 0508ImportCode base.OnSaving(); SetDefaultUpdate(); SetDefaultUpdater(); #endregion 0508ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- Order [Detail=false]
- PermissionPolicyUser [Detail=false]
- Update [Detail=false]
- Updater [Detail=false]
- Value [Detail=true]

Group: (default)
- Category [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- Note [Order=1] [Detail=true]
- ParameterFormat [Order=1] [Detail=true]
- User [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | Parameter | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultCategory(View view = null); //SetDefaultParameterFormat(View view = null); //SetDefaultNote(View view = null); //SetDefaultUser(View view = null); //SetDefaultUpd... |
| GetDefaultCategory | Parameter | { return Category; } |
| GetDefaultName | Parameter | { return Name; } |
| GetDefaultNote | Parameter | { return Note; } |
| GetDefaultOrder | Parameter | { //Code: 3582 Oid: a5233364-b16b-40d2-ad02-24ff639d8af7 //Code: 3582 Oid: a5233364-b16b-40d2-ad02-24ff639d8af7 var sort = new DevExpress.Xpo.SortProperty(nameof(Order), DevExpress.Xpo.DB.SortingDirection.Descending); var criteria = DevExpress.Data.Filtering.C... |
| GetDefaultParameterFormat | Parameter | { return ParameterFormat; } |
| GetDefaultPermissionPolicyUser | Parameter | { return PermissionPolicyUser; } |
| GetDefaultUpdate | Parameter | { //Code: 0047 Oid: 619a1e2b-1e7f-4a0f-b0c1-cd1e0f5a07ff return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultUpdater | Parameter | { //Code: 3580 Oid: 344e35b5-0117-4c64-a923-1dd2def03652 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| GetDefaultUser | Parameter | { return User; } |
| GetDefaultValue | Parameter | { return Value; } |
| OnLoaded | Parameter | { base.OnLoaded(); } |
| OnSaving | Parameter | { #region 0508ImportCode base.OnSaving(); SetDefaultUpdate(); SetDefaultUpdater(); #endregion 0508ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&... |
| SetDefaultCategory | Parameter | { //if (Category is null){ // var result = GetDefaultCategory(view); // if (result != null && result != Category){ // Category = result; // } //} } |
| SetDefaultName | Parameter | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultNote | Parameter | { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} } |
| SetDefaultOrder | Parameter | { //Code: 3584 Oid: c48bce00-b2be-47e6-96b0-25454d8ea343 if(Order == null) Order = GetDefaultOrder(); } |
| SetDefaultParameterFormat | Parameter | { //if (ParameterFormat is null){ // var result = GetDefaultParameterFormat(view); // if (result != null && result != ParameterFormat){ // ParameterFormat = result; // } //} } |
| SetDefaultPermissionPolicyUser | Parameter | { //if (PermissionPolicyUser is null){ // var result = GetDefaultPermissionPolicyUser(view); // if (result != null && result != PermissionPolicyUser){ // PermissionPolicyUser = result; // } //} } |
| SetDefaultUpdate | Parameter | { //Code: 0020 Oid: 403798e0-28db-4626-a719-41ff765f08ff Update = GetDefaultUpdate(); } |
| SetDefaultUpdater | Parameter | { //Code: 3578 Oid: 9e98a438-5455-4c2a-9dee-fd4d85005802 Updater = GetDefaultUpdater(); } |
| SetDefaultUser | Parameter | { //if (User is null){ // var result = GetDefaultUser(view); // if (result != null && result != User){ // User = result; // } //} } |
| SetDefaultValue | Parameter | { //if (Value is null){ // var result = GetDefaultValue(view); // if (result != null && result != Value){ // Value = result; // } //} } |

---

# Entity: Player

Caption entity: `Đấu thủ`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Code | string | Mã | Yes | GetDefaultCode: Code<br>SetDefaultCode: result | true | true |   | 1 |
| PlayerType | PlayerType | Loại | No | GetDefaultPlayerType: PlayerType<br>SetDefaultPlayerType: result | true | true |   | 1 |
| BusinessRole | string | Vai trò | No | GetDefaultBusinessRole: BusinessRole<br>SetDefaultBusinessRole: result | true | true |   | 1 |
| FromDate | DateTime? | Từ ngày | No | GetDefaultFromDate: FromDate<br>SetDefaultFromDate: result | false | true |   | 1 |
| ToDate | DateTime? | Đến ngày | No | GetDefaultToDate: ToDate<br>SetDefaultToDate: result | false | true |   | 1 |
| PostList | XPCollection <Module.BusinessObjects.Post> | Tin tức | No |  | false | true |  |  |
| InActive | bool | Ngừng | No | GetDefaultInActive: InActive<br>SetDefaultInActive: result | false | false |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Code  
Default: Code  
Source: `GetDefaultCode()`  
Logic: { return Code; }

Field: Code  
Default: result  
Source: `SetDefaultCode()`  
Logic: { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} }

Field: PlayerType  
Default: PlayerType  
Source: `GetDefaultPlayerType()`  
Logic: { return PlayerType; }

Field: PlayerType  
Default: result  
Source: `SetDefaultPlayerType()`  
Logic: { //if (PlayerType is null){ // var result = GetDefaultPlayerType(view); // if (result != null && result != PlayerType){ // PlayerType = result; // } //} }

Field: BusinessRole  
Default: BusinessRole  
Source: `GetDefaultBusinessRole()`  
Logic: { return BusinessRole; }

Field: BusinessRole  
Default: result  
Source: `SetDefaultBusinessRole()`  
Logic: { //if (BusinessRole is null){ // var result = GetDefaultBusinessRole(view); // if (result != null && result != BusinessRole){ // BusinessRole = result; // } //} }

Field: FromDate  
Default: FromDate  
Source: `GetDefaultFromDate()`  
Logic: { return FromDate; }

Field: FromDate  
Default: result  
Source: `SetDefaultFromDate()`  
Logic: { //if (FromDate is null){ // var result = GetDefaultFromDate(view); // if (result != null && result != FromDate){ // FromDate = result; // } //} }

Field: ToDate  
Default: ToDate  
Source: `GetDefaultToDate()`  
Logic: { return ToDate; }

Field: ToDate  
Default: result  
Source: `SetDefaultToDate()`  
Logic: { //if (ToDate is null){ // var result = GetDefaultToDate(view); // if (result != null && result != ToDate){ // ToDate = result; // } //} }

Field: InActive  
Default: InActive  
Source: `GetDefaultInActive()`  
Logic: { return InActive; }

Field: InActive  
Default: result  
Source: `SetDefaultInActive()`  
Logic: { //if (InActive is null){ // var result = GetDefaultInActive(view); // if (result != null && result != InActive){ // InActive = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultCode(View view = null); //SetDefaultPlayerType(View view = null); //SetDefaultBusinessRole(View view = null); //SetDefaultFromDate(View view = null); //SetDefault...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- InActive [Detail=false]
- PostList [Detail=true]

Group: (default)
- BusinessRole [Order=1] [Detail=true]
- Code [Order=1] [Detail=true]
- FromDate [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- PlayerType [Order=1] [Detail=true]
- ToDate [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | Player | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultCode(View view = null); //SetDefaultPlayerType(View view = null); //SetDefaultBusinessRole(View view = null); //SetDefaultFromDate(View view = null); //SetDefault... |
| GetDefaultBusinessRole | Player | { return BusinessRole; } |
| GetDefaultCode | Player | { return Code; } |
| GetDefaultFromDate | Player | { return FromDate; } |
| GetDefaultInActive | Player | { return InActive; } |
| GetDefaultName | Player | { return Name; } |
| GetDefaultPlayerType | Player | { return PlayerType; } |
| GetDefaultToDate | Player | { return ToDate; } |
| OnLoaded | Player | { base.OnLoaded(); } |
| OnSaving | Player | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultBusinessRole | Player | { //if (BusinessRole is null){ // var result = GetDefaultBusinessRole(view); // if (result != null && result != BusinessRole){ // BusinessRole = result; // } //} } |
| SetDefaultCode | Player | { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} } |
| SetDefaultFromDate | Player | { //if (FromDate is null){ // var result = GetDefaultFromDate(view); // if (result != null && result != FromDate){ // FromDate = result; // } //} } |
| SetDefaultInActive | Player | { //if (InActive is null){ // var result = GetDefaultInActive(view); // if (result != null && result != InActive){ // InActive = result; // } //} } |
| SetDefaultName | Player | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultPlayerType | Player | { //if (PlayerType is null){ // var result = GetDefaultPlayerType(view); // if (result != null && result != PlayerType){ // PlayerType = result; // } //} } |
| SetDefaultToDate | Player | { //if (ToDate is null){ // var result = GetDefaultToDate(view); // if (result != null && result != ToDate){ // ToDate = result; // } //} } |

---

# Entity: Post

Caption entity: `Bài viết`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | Yes | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| NameOrigin | string | Tên gốc | No | SetDefaultNameOrigin: GetDefaultNameOrigin()<br>GetDefaultNameOrigin: Name | true | true |   | 1 |
| CreatedDate | DateTime? | Ngày | No | GetDefaultCreatedDate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)<br>SetDefaultCreatedDate: = null) CreatedDate = GetDefaultCreatedDate() | true | true |   | 1 |
| Image | byte[] | Ảnh | No | SetDefaultImage: result | true | true |   | 1 |
| Source | string | Nguồn | No | GetDefaultSource: Source<br>SetDefaultSource: result | false | true |   | 1 |
| Member | Module.BusinessObjects.Member | Quản lý | No | SetDefaultMember: = null) Member = GetDefaultMember()<br>GetDefaultMember: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session) | true | true |   | 1 |
| Content | string | Nội dung | No | GetDefaultContent: Content<br>SetDefaultContent: result | false | true |  |  |
| ContentOrigin | string | Nội dung gốc | No | SetDefaultContentOrigin: GetDefaultContentOrigin()<br>GetDefaultContentOrigin: null | false | true |  |  |
| BookMarkList | XPCollection <Module.BusinessObjects.BookMark> | Liên kết | No |  | false | true |  |  |
| ObjectRelationList | XPCollection <Module.BusinessObjects.ObjectRelation> | Quan hệ | No |  | false | true |  |  |
| Update | DateTime? | Cập nhật | No | GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)<br>SetDefaultUpdate: GetDefaultUpdate() | true | false |  |  |
| Code | string | Mã | No | GetDefaultCode: Code<br>SetDefaultCode: result | false | false |  |  |
| Order | int? | Thứ tự | No | GetDefaultOrder: Order<br>SetDefaultOrder: result | false | false |  |  |
| Folder | Module.BusinessObjects.Folder | Thư mục | No | GetDefaultFolder: Folder<br>SetDefaultFolder: result | false | false |  |  |
| Flag | bool | Cờ | No | GetDefaultFlag: Flag<br>SetDefaultFlag: result | false | false |  |  |
| Match | Module.BusinessObjects.Match | Trận đấu | No | GetDefaultMatch: Match<br>SetDefaultMatch: result | false | false |  |  |
| TournamentSeason | Module.BusinessObjects.TournamentSeason | Mùa giải | No | GetDefaultTournamentSeason: TournamentSeason<br>SetDefaultTournamentSeason: result | false | false |  |  |
| Player | Module.BusinessObjects.Player | Đấu thủ | No | GetDefaultPlayer: Player<br>SetDefaultPlayer: result | false | false |  |  |
| PublicEvent | Module.BusinessObjects.PublicEvent | Sự kiện | No | GetDefaultPublicEvent: PublicEvent<br>SetDefaultPublicEvent: result | false | false |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: NameOrigin  
Default: GetDefaultNameOrigin()  
Source: `SetDefaultNameOrigin()`  
Logic: { //Code: 1304 Oid: 8bacc760-6297-4e9a-9ed7-4bf3f4da5747 if(String.IsNullOrEmpty(NameOrigin)) NameOrigin = GetDefaultNameOrigin(); }

Field: NameOrigin  
Default: Name  
Source: `GetDefaultNameOrigin()`  
Logic: { //Code: 1303 Oid: ee23d7b4-f9bc-4b05-bcbb-21ecf650e144 return Name; }

Field: CreatedDate  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultCreatedDate()`  
Logic: { //Code: 1293 Oid: 66598e4a-2bdd-4974-8d17-6327abf67947 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: CreatedDate  
Default: = null) CreatedDate = GetDefaultCreatedDate()  
Source: `SetDefaultCreatedDate()`  
Logic: { //Code: 1294 Oid: c08b185c-97c1-4cf4-ac18-17edb7479d20 if(CreatedDate == null) CreatedDate = GetDefaultCreatedDate(); }

Field: Image  
Default: result  
Source: `SetDefaultImage()`  
Logic: { //if (Image is null){ // var result = GetDefaultImage(view); // if (result != null && result != Image){ // Image = result; // } //} }

Field: Source  
Default: Source  
Source: `GetDefaultSource()`  
Logic: { return Source; }

Field: Source  
Default: result  
Source: `SetDefaultSource()`  
Logic: { //if (Source is null){ // var result = GetDefaultSource(view); // if (result != null && result != Source){ // Source = result; // } //} }

Field: Member  
Default: = null) Member = GetDefaultMember()  
Source: `SetDefaultMember()`  
Logic: { //Code: 1296 Oid: d313a232-a0eb-44fc-9f8d-011a07014990 if(Member == null) Member = GetDefaultMember(); }

Field: Member  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultMember()`  
Logic: { //Code: 1297 Oid: 085ff789-c5d5-483c-991a-6cecd5a7f1ad return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: Content  
Default: Content  
Source: `GetDefaultContent()`  
Logic: { return Content; }

Field: Content  
Default: result  
Source: `SetDefaultContent()`  
Logic: { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} }

Field: ContentOrigin  
Default: GetDefaultContentOrigin()  
Source: `SetDefaultContentOrigin()`  
Logic: { //Code: 1306 Oid: 4fddb9c7-5ef4-4544-b0bc-2d6d22af4046 if(String.IsNullOrEmpty(ContentOrigin)) ContentOrigin = GetDefaultContentOrigin(); }

Field: ContentOrigin  
Default: null  
Source: `GetDefaultContentOrigin()`  
Logic: { //Code: 1305 Oid: 33bcb202-c98d-4270-a48d-5724c3774449 return null; }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 1292 Oid: b7063dde-0d38-40a2-9780-42ca89efa348 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 1290 Oid: 55bc4bb8-f130-488c-9fad-18d93e0a604a if (!IsDeleted) Update = GetDefaultUpdate(); }

Field: Code  
Default: Code  
Source: `GetDefaultCode()`  
Logic: { return Code; }

Field: Code  
Default: result  
Source: `SetDefaultCode()`  
Logic: { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} }

Field: Order  
Default: Order  
Source: `GetDefaultOrder()`  
Logic: { return Order; }

Field: Order  
Default: result  
Source: `SetDefaultOrder()`  
Logic: { //if (Order is null){ // var result = GetDefaultOrder(view); // if (result != null && result != Order){ // Order = result; // } //} }

Field: Folder  
Default: Folder  
Source: `GetDefaultFolder()`  
Logic: { return Folder; }

Field: Folder  
Default: result  
Source: `SetDefaultFolder()`  
Logic: { //if (Folder is null){ // var result = GetDefaultFolder(view); // if (result != null && result != Folder){ // Folder = result; // } //} }

Field: Flag  
Default: Flag  
Source: `GetDefaultFlag()`  
Logic: { return Flag; }

Field: Flag  
Default: result  
Source: `SetDefaultFlag()`  
Logic: { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} }

Field: Match  
Default: Match  
Source: `GetDefaultMatch()`  
Logic: { return Match; }

Field: Match  
Default: result  
Source: `SetDefaultMatch()`  
Logic: { //if (Match is null){ // var result = GetDefaultMatch(view); // if (result != null && result != Match){ // Match = result; // } //} }

Field: TournamentSeason  
Default: TournamentSeason  
Source: `GetDefaultTournamentSeason()`  
Logic: { return TournamentSeason; }

Field: TournamentSeason  
Default: result  
Source: `SetDefaultTournamentSeason()`  
Logic: { //if (TournamentSeason is null){ // var result = GetDefaultTournamentSeason(view); // if (result != null && result != TournamentSeason){ // TournamentSeason = result; // } //} }

Field: Player  
Default: Player  
Source: `GetDefaultPlayer()`  
Logic: { return Player; }

Field: Player  
Default: result  
Source: `SetDefaultPlayer()`  
Logic: { //if (Player is null){ // var result = GetDefaultPlayer(view); // if (result != null && result != Player){ // Player = result; // } //} }

Field: PublicEvent  
Default: PublicEvent  
Source: `GetDefaultPublicEvent()`  
Logic: { return PublicEvent; }

Field: PublicEvent  
Default: result  
Source: `SetDefaultPublicEvent()`  
Logic: { //if (PublicEvent is null){ // var result = GetDefaultPublicEvent(view); // if (result != null && result != PublicEvent){ // PublicEvent = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 1295ImportCode base.AfterConstruction(); SetDefaultCreatedDate(); SetDefaultMember(); #endregion 1295ImportCode //SetDefaultName(View view = null); //SetDefaultNameOrigin(View view = null); //SetDefaultCreatedDate(View view = nu...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 1291ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 1291ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- BookMarkList [Detail=true]
- Code [Detail=false]
- Content [Detail=true]
- ContentOrigin [Detail=true]
- Flag [Detail=false]
- Folder [Detail=false]
- Match [Detail=false]
- ObjectRelationList [Detail=true]
- Order [Detail=false]
- Player [Detail=false]
- PublicEvent [Detail=false]
- TournamentSeason [Detail=false]
- Update [Detail=false]

Group: (default)
- CreatedDate [Order=1] [Detail=true]
- Image [Order=1] [Detail=true]
- Member [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- NameOrigin [Order=1] [Detail=true]
- Source [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | Post | { Oid = Guid.NewGuid(); #region 1295ImportCode base.AfterConstruction(); SetDefaultCreatedDate(); SetDefaultMember(); #endregion 1295ImportCode //SetDefaultName(View view = null); //SetDefaultNameOrigin(View view = null); //SetDefaultCreatedDate(View view = nu... |
| GetDefaultCode | Post | { return Code; } |
| GetDefaultContent | Post | { return Content; } |
| GetDefaultContentOrigin | Post | { //Code: 1305 Oid: 33bcb202-c98d-4270-a48d-5724c3774449 return null; } |
| GetDefaultCreatedDate | Post | { //Code: 1293 Oid: 66598e4a-2bdd-4974-8d17-6327abf67947 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultFlag | Post | { return Flag; } |
| GetDefaultFolder | Post | { return Folder; } |
| GetDefaultMatch | Post | { return Match; } |
| GetDefaultMember | Post | { //Code: 1297 Oid: 085ff789-c5d5-483c-991a-6cecd5a7f1ad return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| GetDefaultName | Post | { return Name; } |
| GetDefaultNameOrigin | Post | { //Code: 1303 Oid: ee23d7b4-f9bc-4b05-bcbb-21ecf650e144 return Name; } |
| GetDefaultOrder | Post | { return Order; } |
| GetDefaultPlayer | Post | { return Player; } |
| GetDefaultPublicEvent | Post | { return PublicEvent; } |
| GetDefaultSource | Post | { return Source; } |
| GetDefaultTournamentSeason | Post | { return TournamentSeason; } |
| GetDefaultUpdate | Post | { //Code: 1292 Oid: b7063dde-0d38-40a2-9780-42ca89efa348 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| OnLoaded | Post | { base.OnLoaded(); } |
| OnSaving | Post | { #region 1291ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 1291ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ... |
| SetDefaultCode | Post | { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} } |
| SetDefaultContent | Post | { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} } |
| SetDefaultContentOrigin | Post | { //Code: 1306 Oid: 4fddb9c7-5ef4-4544-b0bc-2d6d22af4046 if(String.IsNullOrEmpty(ContentOrigin)) ContentOrigin = GetDefaultContentOrigin(); } |
| SetDefaultCreatedDate | Post | { //Code: 1294 Oid: c08b185c-97c1-4cf4-ac18-17edb7479d20 if(CreatedDate == null) CreatedDate = GetDefaultCreatedDate(); } |
| SetDefaultFlag | Post | { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} } |
| SetDefaultFolder | Post | { //if (Folder is null){ // var result = GetDefaultFolder(view); // if (result != null && result != Folder){ // Folder = result; // } //} } |
| SetDefaultImage | Post | { //if (Image is null){ // var result = GetDefaultImage(view); // if (result != null && result != Image){ // Image = result; // } //} } |
| SetDefaultMatch | Post | { //if (Match is null){ // var result = GetDefaultMatch(view); // if (result != null && result != Match){ // Match = result; // } //} } |
| SetDefaultMember | Post | { //Code: 1296 Oid: d313a232-a0eb-44fc-9f8d-011a07014990 if(Member == null) Member = GetDefaultMember(); } |
| SetDefaultName | Post | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultNameOrigin | Post | { //Code: 1304 Oid: 8bacc760-6297-4e9a-9ed7-4bf3f4da5747 if(String.IsNullOrEmpty(NameOrigin)) NameOrigin = GetDefaultNameOrigin(); } |
| SetDefaultOrder | Post | { //if (Order is null){ // var result = GetDefaultOrder(view); // if (result != null && result != Order){ // Order = result; // } //} } |
| SetDefaultPlayer | Post | { //if (Player is null){ // var result = GetDefaultPlayer(view); // if (result != null && result != Player){ // Player = result; // } //} } |
| SetDefaultPublicEvent | Post | { //if (PublicEvent is null){ // var result = GetDefaultPublicEvent(view); // if (result != null && result != PublicEvent){ // PublicEvent = result; // } //} } |
| SetDefaultSource | Post | { //if (Source is null){ // var result = GetDefaultSource(view); // if (result != null && result != Source){ // Source = result; // } //} } |
| SetDefaultTournamentSeason | Post | { //if (TournamentSeason is null){ // var result = GetDefaultTournamentSeason(view); // if (result != null && result != TournamentSeason){ // TournamentSeason = result; // } //} } |
| SetDefaultUpdate | Post | { //Code: 1290 Oid: 55bc4bb8-f130-488c-9fad-18d93e0a604a if (!IsDeleted) Update = GetDefaultUpdate(); } |

---

# Entity: Product

Caption entity: `Sản phẩm`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | Yes | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Brand | string | Hãng | No | GetDefaultBrand: Brand<br>SetDefaultBrand: result | true | true |   | 1 |
| Code | string | Mã | No | GetDefaultCode: Code<br>SetDefaultCode: result | false | true |   | 1 |
| Member | Module.BusinessObjects.Member | Quản lý | No | SetDefaultMember: = null) Member = GetDefaultMember()<br>GetDefaultMember: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session) | false | true |   | 1 |
| Image | byte[] | Ảnh | No | SetDefaultImage: result | true | true |   | 1 |
| Price | decimal? | Giá | No | GetDefaultPrice: Price<br>SetDefaultPrice: result | true | true |   | 1 |
| PriceSale | decimal? | Giá KM | No | GetDefaultPriceSale: PriceSale<br>SetDefaultPriceSale: result | false | true |   | 1 |
| PermissionPolicyRole | DevExpress.Persistent.BaseImpl.PermissionPolicy.PermissionPolicyRole | Nhóm | No | GetDefaultPermissionPolicyRole: PermissionPolicyRole | false | true |   | 1 |
| Variation | bool | Có biến thể | No | GetDefaultVariation: Variation<br>SetDefaultVariation: result | false | true |   | 1 |
| BookMarkList | XPCollection <Module.BusinessObjects.BookMark> | Liên kết | No |  | false | true |  |  |
| Feature | string | Đặc điểm | No | GetDefaultFeature: Feature<br>SetDefaultFeature: result | false | true |  |  |
| Introduction | string | Giới thiệu | No | GetDefaultIntroduction: Introduction<br>SetDefaultIntroduction: result | false | true |  |  |
| Specification | string | Thông số | No | GetDefaultSpecification: Specification<br>SetDefaultSpecification: result | false | true |  |  |
| Manual | string | Sử dụng | No | GetDefaultManual: Manual<br>SetDefaultManual: result | false | true |  |  |
| ProductList | XPCollection <Module.BusinessObjects.Product> | Biến thể | No |  | false | true |  |  |
| FolderList | XPCollection <Module.BusinessObjects.Folder> | Thư mục | No |  | false | true |  |  |
| Update | DateTime | Cập nhật | No | GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)<br>SetDefaultUpdate: GetDefaultUpdate() | false | false |  |  |
| Updater | Module.BusinessObjects.Member | Người cập nhật | No | GetDefaultUpdater: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)<br>SetDefaultUpdater: GetDefaultUpdater() | false | false |  |  |
| CreatedDate | DateTime? | Ngày tạo | No | SetDefaultCreatedDate: = null) CreatedDate = GetDefaultCreatedDate()<br>GetDefaultCreatedDate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null) | false | false |  |  |
| Folder | Module.BusinessObjects.Folder | Thư mục | No | GetDefaultFolder: Folder<br>SetDefaultFolder: result | false | false |  |  |
| English | string | Tên khác | No | GetDefaultEnglish: English<br>SetDefaultEnglish: result | false | false |  |  |
| Warranty | int? | Bảo hành | No | GetDefaultWarranty: Warranty<br>SetDefaultWarranty: result | false | false |  |  |
| Round | Round | Tròn giá | No | GetDefaultRound: Round<br>SetDefaultRound: result | false | false |  |  |
| EAN | string | Mã EAN | No | GetDefaultEAN: EAN<br>SetDefaultEAN: result | false | false |  |  |
| CustomsDescription | string | Mô tả HQ | No | GetDefaultCustomsDescription: CustomsDescription<br>SetDefaultCustomsDescription: result | false | false |  |  |
| Size | string | Kích thước | No | GetDefaultSize: Size<br>SetDefaultSize: result | false | false |  |  |
| Weight | decimal? | Khối lượng | No | GetDefaultWeight: Weight<br>SetDefaultWeight: result | false | false |  |  |
| WeightConverted | decimal? | KL quy đổi | No | GetDefaultWeightConverted: WeightConverted<br>SetDefaultWeightConverted: result | false | false |  |  |
| InActive | bool | Ngừng | No | GetDefaultInActive: InActive<br>SetDefaultInActive: result | false | false |  |  |
| ReleaseDate | DateTime? | Phát hành | No | GetDefaultReleaseDate: ReleaseDate<br>SetDefaultReleaseDate: result | false | false |  |  |
| ProductParent | Module.BusinessObjects.Product | Sản phẩm | No | GetDefaultProductParent: ProductParent<br>SetDefaultProductParent: result | false | false |  |  |
| PriceWeb | string | Giá web | No | GetDefaultPriceWeb: PriceWeb<br>SetDefaultPriceWeb: result | false | false |  |  |
| Order | int? | Thứ tự | No |  | false | false |  |  |
| Display | bool |  | No |  |  |  |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Brand  
Default: Brand  
Source: `GetDefaultBrand()`  
Logic: { return Brand; }

Field: Brand  
Default: result  
Source: `SetDefaultBrand()`  
Logic: { //if (Brand is null){ // var result = GetDefaultBrand(view); // if (result != null && result != Brand){ // Brand = result; // } //} }

Field: Code  
Default: Code  
Source: `GetDefaultCode()`  
Logic: { return Code; }

Field: Code  
Default: result  
Source: `SetDefaultCode()`  
Logic: { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} }

Field: Member  
Default: = null) Member = GetDefaultMember()  
Source: `SetDefaultMember()`  
Logic: { //Code: 2517 Oid: dfa01d84-33e9-4c25-a63f-8edc3c78cf7b if(Member == null) Member = GetDefaultMember(); }

Field: Member  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultMember()`  
Logic: { //Code: 2518 Oid: ebce587f-ca02-4040-8007-0bcab81bfe01 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: Image  
Default: result  
Source: `SetDefaultImage()`  
Logic: { //if (Image is null){ // var result = GetDefaultImage(view); // if (result != null && result != Image){ // Image = result; // } //} }

Field: Price  
Default: Price  
Source: `GetDefaultPrice()`  
Logic: { return Price; }

Field: Price  
Default: result  
Source: `SetDefaultPrice()`  
Logic: { //if (Price is null){ // var result = GetDefaultPrice(view); // if (result != null && result != Price){ // Price = result; // } //} }

Field: PriceSale  
Default: PriceSale  
Source: `GetDefaultPriceSale()`  
Logic: { return PriceSale; }

Field: PriceSale  
Default: result  
Source: `SetDefaultPriceSale()`  
Logic: { //if (PriceSale is null){ // var result = GetDefaultPriceSale(view); // if (result != null && result != PriceSale){ // PriceSale = result; // } //} }

Field: PermissionPolicyRole  
Default: PermissionPolicyRole  
Source: `GetDefaultPermissionPolicyRole()`  
Logic: { return PermissionPolicyRole; }

Field: Variation  
Default: Variation  
Source: `GetDefaultVariation()`  
Logic: { return Variation; }

Field: Variation  
Default: result  
Source: `SetDefaultVariation()`  
Logic: { //if (Variation is null){ // var result = GetDefaultVariation(view); // if (result != null && result != Variation){ // Variation = result; // } //} }

Field: Feature  
Default: Feature  
Source: `GetDefaultFeature()`  
Logic: { return Feature; }

Field: Feature  
Default: result  
Source: `SetDefaultFeature()`  
Logic: { //if (Feature is null){ // var result = GetDefaultFeature(view); // if (result != null && result != Feature){ // Feature = result; // } //} }

Field: Introduction  
Default: Introduction  
Source: `GetDefaultIntroduction()`  
Logic: { return Introduction; }

Field: Introduction  
Default: result  
Source: `SetDefaultIntroduction()`  
Logic: { //if (Introduction is null){ // var result = GetDefaultIntroduction(view); // if (result != null && result != Introduction){ // Introduction = result; // } //} }

Field: Specification  
Default: Specification  
Source: `GetDefaultSpecification()`  
Logic: { return Specification; }

Field: Specification  
Default: result  
Source: `SetDefaultSpecification()`  
Logic: { //if (Specification is null){ // var result = GetDefaultSpecification(view); // if (result != null && result != Specification){ // Specification = result; // } //} }

Field: Manual  
Default: Manual  
Source: `GetDefaultManual()`  
Logic: { return Manual; }

Field: Manual  
Default: result  
Source: `SetDefaultManual()`  
Logic: { //if (Manual is null){ // var result = GetDefaultManual(view); // if (result != null && result != Manual){ // Manual = result; // } //} }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 0156 Oid: 6025b938-e351-4bdb-8d1b-eb2a3a992e64 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 0175 Oid: 30233bbc-bcd6-469e-94ce-c4b8f2a64de6 Update = GetDefaultUpdate(); }

Field: Updater  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultUpdater()`  
Logic: { //Code: 3757 Oid: ba8f0f23-4799-4d5b-b303-19e7ce9d8e32 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: Updater  
Default: GetDefaultUpdater()  
Source: `SetDefaultUpdater()`  
Logic: { //Code: 3756 Oid: 6712552f-a1d4-47bf-a74e-63e210891694 Updater = GetDefaultUpdater(); }

Field: CreatedDate  
Default: = null) CreatedDate = GetDefaultCreatedDate()  
Source: `SetDefaultCreatedDate()`  
Logic: { //Code: 3762 Oid: 350732ea-0b67-4092-bbb5-52234317978d if(CreatedDate == null) CreatedDate = GetDefaultCreatedDate(); }

Field: CreatedDate  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultCreatedDate()`  
Logic: { //Code: 3761 Oid: 0eefb60d-d179-4069-a280-3f3b131ebf42 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Folder  
Default: Folder  
Source: `GetDefaultFolder()`  
Logic: { return Folder; }

Field: Folder  
Default: result  
Source: `SetDefaultFolder()`  
Logic: { //if (Folder is null){ // var result = GetDefaultFolder(view); // if (result != null && result != Folder){ // Folder = result; // } //} }

Field: English  
Default: English  
Source: `GetDefaultEnglish()`  
Logic: { return English; }

Field: English  
Default: result  
Source: `SetDefaultEnglish()`  
Logic: { //if (English is null){ // var result = GetDefaultEnglish(view); // if (result != null && result != English){ // English = result; // } //} }

Field: Warranty  
Default: Warranty  
Source: `GetDefaultWarranty()`  
Logic: { return Warranty; }

Field: Warranty  
Default: result  
Source: `SetDefaultWarranty()`  
Logic: { //if (Warranty is null){ // var result = GetDefaultWarranty(view); // if (result != null && result != Warranty){ // Warranty = result; // } //} }

Field: Round  
Default: Round  
Source: `GetDefaultRound()`  
Logic: { return Round; }

Field: Round  
Default: result  
Source: `SetDefaultRound()`  
Logic: { //if (Round is null){ // var result = GetDefaultRound(view); // if (result != null && result != Round){ // Round = result; // } //} }

Field: EAN  
Default: EAN  
Source: `GetDefaultEAN()`  
Logic: { return EAN; }

Field: EAN  
Default: result  
Source: `SetDefaultEAN()`  
Logic: { //if (EAN is null){ // var result = GetDefaultEAN(view); // if (result != null && result != EAN){ // EAN = result; // } //} }

Field: CustomsDescription  
Default: CustomsDescription  
Source: `GetDefaultCustomsDescription()`  
Logic: { return CustomsDescription; }

Field: CustomsDescription  
Default: result  
Source: `SetDefaultCustomsDescription()`  
Logic: { //if (CustomsDescription is null){ // var result = GetDefaultCustomsDescription(view); // if (result != null && result != CustomsDescription){ // CustomsDescription = result; // } //} }

Field: Size  
Default: Size  
Source: `GetDefaultSize()`  
Logic: { return Size; }

Field: Size  
Default: result  
Source: `SetDefaultSize()`  
Logic: { //if (Size is null){ // var result = GetDefaultSize(view); // if (result != null && result != Size){ // Size = result; // } //} }

Field: Weight  
Default: Weight  
Source: `GetDefaultWeight()`  
Logic: { return Weight; }

Field: Weight  
Default: result  
Source: `SetDefaultWeight()`  
Logic: { //if (Weight is null){ // var result = GetDefaultWeight(view); // if (result != null && result != Weight){ // Weight = result; // } //} }

Field: WeightConverted  
Default: WeightConverted  
Source: `GetDefaultWeightConverted()`  
Logic: { return WeightConverted; }

Field: WeightConverted  
Default: result  
Source: `SetDefaultWeightConverted()`  
Logic: { //if (WeightConverted is null){ // var result = GetDefaultWeightConverted(view); // if (result != null && result != WeightConverted){ // WeightConverted = result; // } //} }

Field: InActive  
Default: InActive  
Source: `GetDefaultInActive()`  
Logic: { return InActive; }

Field: InActive  
Default: result  
Source: `SetDefaultInActive()`  
Logic: { //if (InActive is null){ // var result = GetDefaultInActive(view); // if (result != null && result != InActive){ // InActive = result; // } //} }

Field: ReleaseDate  
Default: ReleaseDate  
Source: `GetDefaultReleaseDate()`  
Logic: { return ReleaseDate; }

Field: ReleaseDate  
Default: result  
Source: `SetDefaultReleaseDate()`  
Logic: { //if (ReleaseDate is null){ // var result = GetDefaultReleaseDate(view); // if (result != null && result != ReleaseDate){ // ReleaseDate = result; // } //} }

Field: ProductParent  
Default: ProductParent  
Source: `GetDefaultProductParent()`  
Logic: { return ProductParent; }

Field: ProductParent  
Default: result  
Source: `SetDefaultProductParent()`  
Logic: { //if (ProductParent is null){ // var result = GetDefaultProductParent(view); // if (result != null && result != ProductParent){ // ProductParent = result; // } //} }

Field: PriceWeb  
Default: PriceWeb  
Source: `GetDefaultPriceWeb()`  
Logic: { return PriceWeb; }

Field: PriceWeb  
Default: result  
Source: `SetDefaultPriceWeb()`  
Logic: { //if (PriceWeb is null){ // var result = GetDefaultPriceWeb(view); // if (result != null && result != PriceWeb){ // PriceWeb = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 0391ImportCode base.AfterConstruction(); SetDefaultUpdate(); SetDefaultMember(); SetDefaultCreatedDate(); #endregion 0391ImportCode Display = true; //SetDefaultName(View view = null); //SetDefaultBrand(View view = null); //SetDe...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 0503ImportCode base.OnSaving(); SetDefaultUpdate(); SetDefaultUpdater(); #endregion 0503ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- BookMarkList [Detail=true]
- CreatedDate [Detail=false]
- CustomsDescription [Detail=false]
- Display
- EAN [Detail=false]
- English [Detail=false]
- Feature [Detail=true]
- Folder [Detail=false]
- FolderList [Detail=true]
- InActive [Detail=false]
- Introduction [Detail=true]
- Manual [Detail=true]
- Order [Detail=false]
- PriceWeb [Detail=false]
- ProductList [Detail=true]
- ProductParent [Detail=false]
- ReleaseDate [Detail=false]
- Round [Detail=false]
- Size [Detail=false]
- Specification [Detail=true]
- Update [Detail=false]
- Updater [Detail=false]
- Warranty [Detail=false]
- Weight [Detail=false]
- WeightConverted [Detail=false]

Group: (default)
- Brand [Order=1] [Detail=true]
- Code [Order=1] [Detail=true]
- Image [Order=1] [Detail=true]
- Member [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- PermissionPolicyRole [Order=1] [Detail=true]
- Price [Order=1] [Detail=true]
- PriceSale [Order=1] [Detail=true]
- Variation [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | Product | { Oid = Guid.NewGuid(); #region 0391ImportCode base.AfterConstruction(); SetDefaultUpdate(); SetDefaultMember(); SetDefaultCreatedDate(); #endregion 0391ImportCode Display = true; //SetDefaultName(View view = null); //SetDefaultBrand(View view = null); //SetDe... |
| GetDefaultBrand | Product | { return Brand; } |
| GetDefaultCode | Product | { return Code; } |
| GetDefaultCreatedDate | Product | { //Code: 3761 Oid: 0eefb60d-d179-4069-a280-3f3b131ebf42 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultCustomsDescription | Product | { return CustomsDescription; } |
| GetDefaultEAN | Product | { return EAN; } |
| GetDefaultEnglish | Product | { return English; } |
| GetDefaultFeature | Product | { return Feature; } |
| GetDefaultFolder | Product | { return Folder; } |
| GetDefaultInActive | Product | { return InActive; } |
| GetDefaultIntroduction | Product | { return Introduction; } |
| GetDefaultManual | Product | { return Manual; } |
| GetDefaultMember | Product | { //Code: 2518 Oid: ebce587f-ca02-4040-8007-0bcab81bfe01 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| GetDefaultName | Product | { return Name; } |
| GetDefaultPermissionPolicyRole | Product | { return PermissionPolicyRole; } |
| GetDefaultPrice | Product | { return Price; } |
| GetDefaultPriceSale | Product | { return PriceSale; } |
| GetDefaultPriceWeb | Product | { return PriceWeb; } |
| GetDefaultProductParent | Product | { return ProductParent; } |
| GetDefaultReleaseDate | Product | { return ReleaseDate; } |
| GetDefaultRound | Product | { return Round; } |
| GetDefaultSize | Product | { return Size; } |
| GetDefaultSpecification | Product | { return Specification; } |
| GetDefaultUpdate | Product | { //Code: 0156 Oid: 6025b938-e351-4bdb-8d1b-eb2a3a992e64 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultUpdater | Product | { //Code: 3757 Oid: ba8f0f23-4799-4d5b-b303-19e7ce9d8e32 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| GetDefaultVariation | Product | { return Variation; } |
| GetDefaultWarranty | Product | { return Warranty; } |
| GetDefaultWeight | Product | { return Weight; } |
| GetDefaultWeightConverted | Product | { return WeightConverted; } |
| OnLoaded | Product | { base.OnLoaded(); } |
| OnSaving | Product | { #region 0503ImportCode base.OnSaving(); SetDefaultUpdate(); SetDefaultUpdater(); #endregion 0503ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&... |
| SetDefaultBrand | Product | { //if (Brand is null){ // var result = GetDefaultBrand(view); // if (result != null && result != Brand){ // Brand = result; // } //} } |
| SetDefaultCode | Product | { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} } |
| SetDefaultCreatedDate | Product | { //Code: 3762 Oid: 350732ea-0b67-4092-bbb5-52234317978d if(CreatedDate == null) CreatedDate = GetDefaultCreatedDate(); } |
| SetDefaultCustomsDescription | Product | { //if (CustomsDescription is null){ // var result = GetDefaultCustomsDescription(view); // if (result != null && result != CustomsDescription){ // CustomsDescription = result; // } //} } |
| SetDefaultEAN | Product | { //if (EAN is null){ // var result = GetDefaultEAN(view); // if (result != null && result != EAN){ // EAN = result; // } //} } |
| SetDefaultEnglish | Product | { //if (English is null){ // var result = GetDefaultEnglish(view); // if (result != null && result != English){ // English = result; // } //} } |
| SetDefaultFeature | Product | { //if (Feature is null){ // var result = GetDefaultFeature(view); // if (result != null && result != Feature){ // Feature = result; // } //} } |
| SetDefaultFolder | Product | { //if (Folder is null){ // var result = GetDefaultFolder(view); // if (result != null && result != Folder){ // Folder = result; // } //} } |
| SetDefaultImage | Product | { //if (Image is null){ // var result = GetDefaultImage(view); // if (result != null && result != Image){ // Image = result; // } //} } |
| SetDefaultInActive | Product | { //if (InActive is null){ // var result = GetDefaultInActive(view); // if (result != null && result != InActive){ // InActive = result; // } //} } |
| SetDefaultIntroduction | Product | { //if (Introduction is null){ // var result = GetDefaultIntroduction(view); // if (result != null && result != Introduction){ // Introduction = result; // } //} } |
| SetDefaultManual | Product | { //if (Manual is null){ // var result = GetDefaultManual(view); // if (result != null && result != Manual){ // Manual = result; // } //} } |
| SetDefaultMember | Product | { //Code: 2517 Oid: dfa01d84-33e9-4c25-a63f-8edc3c78cf7b if(Member == null) Member = GetDefaultMember(); } |
| SetDefaultName | Product | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultPrice | Product | { //if (Price is null){ // var result = GetDefaultPrice(view); // if (result != null && result != Price){ // Price = result; // } //} } |
| SetDefaultPriceSale | Product | { //if (PriceSale is null){ // var result = GetDefaultPriceSale(view); // if (result != null && result != PriceSale){ // PriceSale = result; // } //} } |
| SetDefaultPriceWeb | Product | { //if (PriceWeb is null){ // var result = GetDefaultPriceWeb(view); // if (result != null && result != PriceWeb){ // PriceWeb = result; // } //} } |
| SetDefaultProductParent | Product | { //if (ProductParent is null){ // var result = GetDefaultProductParent(view); // if (result != null && result != ProductParent){ // ProductParent = result; // } //} } |
| SetDefaultReleaseDate | Product | { //if (ReleaseDate is null){ // var result = GetDefaultReleaseDate(view); // if (result != null && result != ReleaseDate){ // ReleaseDate = result; // } //} } |
| SetDefaultRound | Product | { //if (Round is null){ // var result = GetDefaultRound(view); // if (result != null && result != Round){ // Round = result; // } //} } |
| SetDefaultSize | Product | { //if (Size is null){ // var result = GetDefaultSize(view); // if (result != null && result != Size){ // Size = result; // } //} } |
| SetDefaultSpecification | Product | { //if (Specification is null){ // var result = GetDefaultSpecification(view); // if (result != null && result != Specification){ // Specification = result; // } //} } |
| SetDefaultUpdate | Product | { //Code: 0175 Oid: 30233bbc-bcd6-469e-94ce-c4b8f2a64de6 Update = GetDefaultUpdate(); } |
| SetDefaultUpdater | Product | { //Code: 3756 Oid: 6712552f-a1d4-47bf-a74e-63e210891694 Updater = GetDefaultUpdater(); } |
| SetDefaultVariation | Product | { //if (Variation is null){ // var result = GetDefaultVariation(view); // if (result != null && result != Variation){ // Variation = result; // } //} } |
| SetDefaultWarranty | Product | { //if (Warranty is null){ // var result = GetDefaultWarranty(view); // if (result != null && result != Warranty){ // Warranty = result; // } //} } |
| SetDefaultWeight | Product | { //if (Weight is null){ // var result = GetDefaultWeight(view); // if (result != null && result != Weight){ // Weight = result; // } //} } |
| SetDefaultWeightConverted | Product | { //if (WeightConverted is null){ // var result = GetDefaultWeightConverted(view); // if (result != null && result != WeightConverted){ // WeightConverted = result; // } //} } |

---

# Entity: PublicEvent

Caption entity: `Sự kiện`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Code | string | Mã | Yes | GetDefaultCode: Code<br>SetDefaultCode: result | true | true |   | 1 |
| Name | string | Tên | Yes | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| English | string | Tiếng Anh | No | GetDefaultEnglish: English<br>SetDefaultEnglish: result | false | true |   | 1 |
| Org | string | Tổ chức | No | GetDefaultOrg: Org<br>SetDefaultOrg: result | true | true |   | 1 |
| Member | Module.BusinessObjects.Member | Quản lý | No | GetDefaultMember: Member<br>SetDefaultMember: result | false | true |   | 1 |
| Icon | byte[] | Biểu tượng | No | SetDefaultIcon: result | true | true |   | 1 |
| StartTime | DateTime? | Bắt đầu | No | GetDefaultStartTime: StartTime<br>SetDefaultStartTime: result | true | true |   | 1 |
| EventType | EventType | Loại | No | GetDefaultEventType: EventType<br>SetDefaultEventType: result | true | true |   | 1 |
| ObjectRelationList | XPCollection <Module.BusinessObjects.ObjectRelation> | Tham dự | No |  | false | true |  |  |
| PostList | XPCollection <Module.BusinessObjects.Post> | Tin tức | No |  | false | true |  |  |
| Update | DateTime | Cập nhật | No | SetDefaultUpdate: GetDefaultUpdate()<br>GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null) | false | false |  |  |
| Updater | Module.BusinessObjects.Member | Người cập nhật | No | GetDefaultUpdater: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)<br>SetDefaultUpdater: GetDefaultUpdater() | false | false |  |  |
| Local | bool | Nội bộ | No | GetDefaultLocal: Local<br>SetDefaultLocal: result | false | false |  |  |
| Gender | bool? | Giới tính | No | GetDefaultGender: Gender<br>SetDefaultGender: result | false | false |  |  |

## Default Logic

Field: Code  
Default: Code  
Source: `GetDefaultCode()`  
Logic: { return Code; }

Field: Code  
Default: result  
Source: `SetDefaultCode()`  
Logic: { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} }

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: English  
Default: English  
Source: `GetDefaultEnglish()`  
Logic: { return English; }

Field: English  
Default: result  
Source: `SetDefaultEnglish()`  
Logic: { //if (English is null){ // var result = GetDefaultEnglish(view); // if (result != null && result != English){ // English = result; // } //} }

Field: Org  
Default: Org  
Source: `GetDefaultOrg()`  
Logic: { return Org; }

Field: Org  
Default: result  
Source: `SetDefaultOrg()`  
Logic: { //if (Org is null){ // var result = GetDefaultOrg(view); // if (result != null && result != Org){ // Org = result; // } //} }

Field: Member  
Default: Member  
Source: `GetDefaultMember()`  
Logic: { return Member; }

Field: Member  
Default: result  
Source: `SetDefaultMember()`  
Logic: { //if (Member is null){ // var result = GetDefaultMember(view); // if (result != null && result != Member){ // Member = result; // } //} }

Field: Icon  
Default: result  
Source: `SetDefaultIcon()`  
Logic: { //if (Icon is null){ // var result = GetDefaultIcon(view); // if (result != null && result != Icon){ // Icon = result; // } //} }

Field: StartTime  
Default: StartTime  
Source: `GetDefaultStartTime()`  
Logic: { return StartTime; }

Field: StartTime  
Default: result  
Source: `SetDefaultStartTime()`  
Logic: { //if (StartTime is null){ // var result = GetDefaultStartTime(view); // if (result != null && result != StartTime){ // StartTime = result; // } //} }

Field: EventType  
Default: EventType  
Source: `GetDefaultEventType()`  
Logic: { return EventType; }

Field: EventType  
Default: result  
Source: `SetDefaultEventType()`  
Logic: { //if (EventType is null){ // var result = GetDefaultEventType(view); // if (result != null && result != EventType){ // EventType = result; // } //} }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 0082 Oid: 7d65bd9f-8421-405c-a2c1-8090a493784e Update = GetDefaultUpdate(); }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 0169 Oid: 23064e1c-2230-4930-9cb9-c8c98243959d return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Updater  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultUpdater()`  
Logic: { //Code: 3958 Oid: fab16cdf-e1f1-4f09-b044-b13ec8590cf6 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: Updater  
Default: GetDefaultUpdater()  
Source: `SetDefaultUpdater()`  
Logic: { //Code: 3957 Oid: 634829b1-b929-4958-813d-dabd8e7661f2 Updater = GetDefaultUpdater(); }

Field: Local  
Default: Local  
Source: `GetDefaultLocal()`  
Logic: { return Local; }

Field: Local  
Default: result  
Source: `SetDefaultLocal()`  
Logic: { //if (Local is null){ // var result = GetDefaultLocal(view); // if (result != null && result != Local){ // Local = result; // } //} }

Field: Gender  
Default: Gender  
Source: `GetDefaultGender()`  
Logic: { return Gender; }

Field: Gender  
Default: result  
Source: `SetDefaultGender()`  
Logic: { //if (Gender is null){ // var result = GetDefaultGender(view); // if (result != null && result != Gender){ // Gender = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 0394ImportCode base.AfterConstruction(); SetDefaultUpdate(); #endregion 0394ImportCode //SetDefaultCode(View view = null); //SetDefaultName(View view = null); //SetDefaultEnglish(View view = null); //SetDefaultOrg(View view = nu...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 0504ImportCode base.OnSaving(); SetDefaultUpdate(); SetDefaultUpdater(); #endregion 0504ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- Gender [Detail=false]
- Local [Detail=false]
- ObjectRelationList [Detail=true]
- PostList [Detail=true]
- Update [Detail=false]
- Updater [Detail=false]

Group: (default)
- Code [Order=1] [Detail=true]
- English [Order=1] [Detail=true]
- EventType [Order=1] [Detail=true]
- Icon [Order=1] [Detail=true]
- Member [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- Org [Order=1] [Detail=true]
- StartTime [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | PublicEvent | { Oid = Guid.NewGuid(); #region 0394ImportCode base.AfterConstruction(); SetDefaultUpdate(); #endregion 0394ImportCode //SetDefaultCode(View view = null); //SetDefaultName(View view = null); //SetDefaultEnglish(View view = null); //SetDefaultOrg(View view = nu... |
| GetDefaultCode | PublicEvent | { return Code; } |
| GetDefaultEnglish | PublicEvent | { return English; } |
| GetDefaultEventType | PublicEvent | { return EventType; } |
| GetDefaultGender | PublicEvent | { return Gender; } |
| GetDefaultLocal | PublicEvent | { return Local; } |
| GetDefaultMember | PublicEvent | { return Member; } |
| GetDefaultName | PublicEvent | { return Name; } |
| GetDefaultOrg | PublicEvent | { return Org; } |
| GetDefaultStartTime | PublicEvent | { return StartTime; } |
| GetDefaultUpdate | PublicEvent | { //Code: 0169 Oid: 23064e1c-2230-4930-9cb9-c8c98243959d return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultUpdater | PublicEvent | { //Code: 3958 Oid: fab16cdf-e1f1-4f09-b044-b13ec8590cf6 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| OnLoaded | PublicEvent | { base.OnLoaded(); } |
| OnSaving | PublicEvent | { #region 0504ImportCode base.OnSaving(); SetDefaultUpdate(); SetDefaultUpdater(); #endregion 0504ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&... |
| SetDefaultCode | PublicEvent | { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} } |
| SetDefaultEnglish | PublicEvent | { //if (English is null){ // var result = GetDefaultEnglish(view); // if (result != null && result != English){ // English = result; // } //} } |
| SetDefaultEventType | PublicEvent | { //if (EventType is null){ // var result = GetDefaultEventType(view); // if (result != null && result != EventType){ // EventType = result; // } //} } |
| SetDefaultGender | PublicEvent | { //if (Gender is null){ // var result = GetDefaultGender(view); // if (result != null && result != Gender){ // Gender = result; // } //} } |
| SetDefaultIcon | PublicEvent | { //if (Icon is null){ // var result = GetDefaultIcon(view); // if (result != null && result != Icon){ // Icon = result; // } //} } |
| SetDefaultLocal | PublicEvent | { //if (Local is null){ // var result = GetDefaultLocal(view); // if (result != null && result != Local){ // Local = result; // } //} } |
| SetDefaultMember | PublicEvent | { //if (Member is null){ // var result = GetDefaultMember(view); // if (result != null && result != Member){ // Member = result; // } //} } |
| SetDefaultName | PublicEvent | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultOrg | PublicEvent | { //if (Org is null){ // var result = GetDefaultOrg(view); // if (result != null && result != Org){ // Org = result; // } //} } |
| SetDefaultStartTime | PublicEvent | { //if (StartTime is null){ // var result = GetDefaultStartTime(view); // if (result != null && result != StartTime){ // StartTime = result; // } //} } |
| SetDefaultUpdate | PublicEvent | { //Code: 0082 Oid: 7d65bd9f-8421-405c-a2c1-8090a493784e Update = GetDefaultUpdate(); } |
| SetDefaultUpdater | PublicEvent | { //Code: 3957 Oid: 634829b1-b929-4958-813d-dabd8e7661f2 Updater = GetDefaultUpdater(); } |

---

# Entity: SeparateAudio

Caption entity: `Ngăn cách âm thanh`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Time | TimeSpan | Thời gian | Yes | GetDefaultTime: Time<br>SetDefaultTime: result | true | true |   | 1 |
| Content | string | Nội dung | No | GetDefaultContent: Content<br>SetDefaultContent: result | true | true |   | 1 |
| Video | Module.BusinessObjects.Video | Video | No | GetDefaultVideo: Video<br>SetDefaultVideo: result | false | true |   | 1 |

## Default Logic

Field: Time  
Default: Time  
Source: `GetDefaultTime()`  
Logic: { return Time; }

Field: Time  
Default: result  
Source: `SetDefaultTime()`  
Logic: { //if (Time is null){ // var result = GetDefaultTime(view); // if (result != null && result != Time){ // Time = result; // } //} }

Field: Content  
Default: Content  
Source: `GetDefaultContent()`  
Logic: { return Content; }

Field: Content  
Default: result  
Source: `SetDefaultContent()`  
Logic: { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} }

Field: Video  
Default: Video  
Source: `GetDefaultVideo()`  
Logic: { return Video; }

Field: Video  
Default: result  
Source: `SetDefaultVideo()`  
Logic: { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultTime(View view = null); //SetDefaultContent(View view = null); //SetDefaultVideo(View view = null); }

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete

Group: (default)
- Content [Order=1] [Detail=true]
- Time [Order=1] [Detail=true]
- Video [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | SeparateAudio | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultTime(View view = null); //SetDefaultContent(View view = null); //SetDefaultVideo(View view = null); } |
| GetDefaultContent | SeparateAudio | { return Content; } |
| GetDefaultTime | SeparateAudio | { return Time; } |
| GetDefaultVideo | SeparateAudio | { return Video; } |
| OnLoaded | SeparateAudio | { base.OnLoaded(); } |
| OnSaving | SeparateAudio | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultContent | SeparateAudio | { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} } |
| SetDefaultTime | SeparateAudio | { //if (Time is null){ // var result = GetDefaultTime(view); // if (result != null && result != Time){ // Time = result; // } //} } |
| SetDefaultVideo | SeparateAudio | { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} } |

---

# Entity: SoftwareServiceType

Caption entity: `Loại dịch vụ`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Code | string | Mã | Yes | GetDefaultCode: Code<br>SetDefaultCode: result | true | true |   | 1 |
| DataService | Module.BusinessObjects.DataService | Mặc định | No | GetDefaultDataService: DataService<br>SetDefaultDataService: result | false | true |   | 1 |
| Member | Module.BusinessObjects.Member | Quản lý | No | GetDefaultMember: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)<br>SetDefaultMember: = null) Member = GetDefaultMember() | true | true |   | 1 |
| DataServiceList | XPCollection <Module.BusinessObjects.DataService> | Dịch vụ | No |  | false | true |  |  |
| Update | DateTime? | Cập nhật | No | SetDefaultUpdate: GetDefaultUpdate()<br>GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null) | true | false |  |  |
| Updater | Module.BusinessObjects.Member | Người cập nhật | No | GetDefaultUpdater: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)<br>SetDefaultUpdater: GetDefaultUpdater() | false | false |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Code  
Default: Code  
Source: `GetDefaultCode()`  
Logic: { return Code; }

Field: Code  
Default: result  
Source: `SetDefaultCode()`  
Logic: { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} }

Field: DataService  
Default: DataService  
Source: `GetDefaultDataService()`  
Logic: { return DataService; }

Field: DataService  
Default: result  
Source: `SetDefaultDataService()`  
Logic: { //if (DataService is null){ // var result = GetDefaultDataService(view); // if (result != null && result != DataService){ // DataService = result; // } //} }

Field: Member  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultMember()`  
Logic: { //Code: 3536 Oid: 3f8442ea-c5ab-4fee-b516-83319262184d return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: Member  
Default: = null) Member = GetDefaultMember()  
Source: `SetDefaultMember()`  
Logic: { //Code: 3533 Oid: 2fa19702-7edc-4611-9fb0-ab1720e32203 if(Member == null) Member = GetDefaultMember(); }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 3524 Oid: a9e3c837-792d-482c-b8a3-a7017015c0ad if (!IsDeleted) Update = GetDefaultUpdate(); }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 3527 Oid: 105ba830-bf58-4551-b487-c345e243aadf return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Updater  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultUpdater()`  
Logic: { //Code: 3531 Oid: 34f422a5-bb42-4592-80b4-ac87287959c1 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: Updater  
Default: GetDefaultUpdater()  
Source: `SetDefaultUpdater()`  
Logic: { //Code: 3529 Oid: b8ed695e-f4ce-463e-a2db-4846aab42d5a Updater = GetDefaultUpdater(); }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 3535ImportCode base.AfterConstruction(); SetDefaultMember(); #endregion 3535ImportCode //SetDefaultName(View view = null); //SetDefaultCode(View view = null); //SetDefaultDataService(View view = null); //SetDefaultMember(View vi...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 3526ImportCode base.OnSaving(); SetDefaultUpdate(); SetDefaultUpdater(); #endregion 3526ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- DataServiceList [Detail=true]
- Update [Detail=false]
- Updater [Detail=false]

Group: (default)
- Code [Order=1] [Detail=true]
- DataService [Order=1] [Detail=true]
- Member [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | SoftwareServiceType | { Oid = Guid.NewGuid(); #region 3535ImportCode base.AfterConstruction(); SetDefaultMember(); #endregion 3535ImportCode //SetDefaultName(View view = null); //SetDefaultCode(View view = null); //SetDefaultDataService(View view = null); //SetDefaultMember(View vi... |
| GetDefaultCode | SoftwareServiceType | { return Code; } |
| GetDefaultDataService | SoftwareServiceType | { return DataService; } |
| GetDefaultMember | SoftwareServiceType | { //Code: 3536 Oid: 3f8442ea-c5ab-4fee-b516-83319262184d return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| GetDefaultName | SoftwareServiceType | { return Name; } |
| GetDefaultUpdate | SoftwareServiceType | { //Code: 3527 Oid: 105ba830-bf58-4551-b487-c345e243aadf return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultUpdater | SoftwareServiceType | { //Code: 3531 Oid: 34f422a5-bb42-4592-80b4-ac87287959c1 return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| OnLoaded | SoftwareServiceType | { base.OnLoaded(); } |
| OnSaving | SoftwareServiceType | { #region 3526ImportCode base.OnSaving(); SetDefaultUpdate(); SetDefaultUpdater(); #endregion 3526ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&... |
| SetDefaultCode | SoftwareServiceType | { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} } |
| SetDefaultDataService | SoftwareServiceType | { //if (DataService is null){ // var result = GetDefaultDataService(view); // if (result != null && result != DataService){ // DataService = result; // } //} } |
| SetDefaultMember | SoftwareServiceType | { //Code: 3533 Oid: 2fa19702-7edc-4611-9fb0-ab1720e32203 if(Member == null) Member = GetDefaultMember(); } |
| SetDefaultName | SoftwareServiceType | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultUpdate | SoftwareServiceType | { //Code: 3524 Oid: a9e3c837-792d-482c-b8a3-a7017015c0ad if (!IsDeleted) Update = GetDefaultUpdate(); } |
| SetDefaultUpdater | SoftwareServiceType | { //Code: 3529 Oid: b8ed695e-f4ce-463e-a2db-4846aab42d5a Updater = GetDefaultUpdater(); } |

---

# Entity: SpellingWord

Caption entity: `Phiên âm`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Language | Module.BusinessObjects.Language | Ngôn ngữ | No | GetDefaultLanguage: Session.FindObject<Language>( DevExpress.Data.Filtering.CriteriaOperator.Parse("LocaleCode = ?", "en-US") )<br>SetDefaultLanguage: GetDefaultLanguage() | true | true |   | 1 |
| LanguageSpellingList | XPCollection <Module.BusinessObjects.LanguageSpelling> | Ngữ âm | No |  | false | true |  |  |
| SpellingLanguage | Module.BusinessObjects.Language | Ngữ phiên | No | GetDefaultSpellingLanguage: SpellingLanguage<br>SetDefaultSpellingLanguage: result | false | false |  |  |
| Spelling | string | Phiên âm | No | GetDefaultSpelling: Spelling<br>SetDefaultSpelling: Assigned in SetDefaultSpelling | false | false |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Language  
Default: Session.FindObject<Language>( DevExpress.Data.Filtering.CriteriaOperator.Parse("LocaleCode = ?", "en-US") )  
Source: `GetDefaultLanguage()`  
Logic: { //Code: 3320 Oid: 6ccbc609-6fd3-436b-9a1d-1023aa31d478 return Session.FindObject<Language>( DevExpress.Data.Filtering.CriteriaOperator.Parse("LocaleCode = ?", "en-US") ); }

Field: Language  
Default: GetDefaultLanguage()  
Source: `SetDefaultLanguage()`  
Logic: { //Code: 3321 Oid: 22830f74-9832-4ea1-b1e6-a16da751e2ce Language = GetDefaultLanguage(); }

Field: SpellingLanguage  
Default: SpellingLanguage  
Source: `GetDefaultSpellingLanguage()`  
Logic: { return SpellingLanguage; }

Field: SpellingLanguage  
Default: result  
Source: `SetDefaultSpellingLanguage()`  
Logic: { //if (SpellingLanguage is null){ // var result = GetDefaultSpellingLanguage(view); // if (result != null && result != SpellingLanguage){ // SpellingLanguage = result; // } //} }

Field: Spelling  
Default: Spelling  
Source: `GetDefaultSpelling()`  
Logic: { return Spelling; }

Field: Spelling  
Default: Assigned in SetDefaultSpelling  
Source: `SetDefaultSpelling()`  
Logic: { //Code: 3325 Oid: 047102a4-3f36-4049-9276-2d2d4885afbd if (SpellingLanguage == null || LanguageSpellingList == null) return; // Tìm LanguageSpelling phù hợp với SpellingLanguage var match = LanguageSpellingList.FirstOrDefault( ls => ls.Language != null && ls...

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 3322ImportCode base.AfterConstruction(); SetDefaultLanguage(); #endregion 3322ImportCode //SetDefaultName(View view = null); //SetDefaultLanguage(View view = null); //SetDefaultSpellingLanguage(View view = null); //SetDefaultSpe...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- LanguageSpellingList [Detail=true]
- Spelling [Detail=false]
- SpellingLanguage [Detail=false]

Group: (default)
- Language [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | SpellingWord | { Oid = Guid.NewGuid(); #region 3322ImportCode base.AfterConstruction(); SetDefaultLanguage(); #endregion 3322ImportCode //SetDefaultName(View view = null); //SetDefaultLanguage(View view = null); //SetDefaultSpellingLanguage(View view = null); //SetDefaultSpe... |
| GetDefaultLanguage | SpellingWord | { //Code: 3320 Oid: 6ccbc609-6fd3-436b-9a1d-1023aa31d478 return Session.FindObject<Language>( DevExpress.Data.Filtering.CriteriaOperator.Parse("LocaleCode = ?", "en-US") ); } |
| GetDefaultName | SpellingWord | { return Name; } |
| GetDefaultSpelling | SpellingWord | { return Spelling; } |
| GetDefaultSpellingLanguage | SpellingWord | { return SpellingLanguage; } |
| OnLoaded | SpellingWord | { base.OnLoaded(); } |
| OnSaving | SpellingWord | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultLanguage | SpellingWord | { //Code: 3321 Oid: 22830f74-9832-4ea1-b1e6-a16da751e2ce Language = GetDefaultLanguage(); } |
| SetDefaultName | SpellingWord | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultSpelling | SpellingWord | { //Code: 3325 Oid: 047102a4-3f36-4049-9276-2d2d4885afbd if (SpellingLanguage == null \|\| LanguageSpellingList == null) return; // Tìm LanguageSpelling phù hợp với SpellingLanguage var match = LanguageSpellingList.FirstOrDefault( ls => ls.Language != null && ls... |
| SetDefaultSpellingLanguage | SpellingWord | { //if (SpellingLanguage is null){ // var result = GetDefaultSpellingLanguage(view); // if (result != null && result != SpellingLanguage){ // SpellingLanguage = result; // } //} } |

---

# Entity: Term

Caption entity: `Thuật ngữ`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | Yes | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Translate | string | Dịch | No | GetDefaultTranslate: Translate<br>SetDefaultTranslate: result | true | true |   | 1 |
| LanguageTranslate | bool | Ngữ dịch | No | GetDefaultLanguageTranslate: LanguageTranslate<br>SetDefaultLanguageTranslate: result | false | true |   | 1 |
| GoogleTranslate | string | Máy dịch | No | GetDefaultGoogleTranslate: GoogleTranslate<br>SetDefaultGoogleTranslate: result | true | true |   | 1 |
| WordType | WordType | Từ loại | No | GetDefaultWordType: WordType<br>SetDefaultWordType: result | false | true |   | 1 |
| TermLocationList | XPCollection <Module.BusinessObjects.TermLocation> | Thuật vị | No |  | false | true |  |  |
| Update | DateTime | Cập nhật | No | GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)<br>SetDefaultUpdate: GetDefaultUpdate() | true | false |  |  |
| Video | Module.BusinessObjects.Video | Video | Yes | GetDefaultVideo: Video<br>SetDefaultVideo: result | false | false |  |  |
| TermType | TermType | Loại | Yes | GetDefaultTermType: TermType<br>SetDefaultTermType: result | false | false |  |  |
| Quantity | int? | Số thuật vị | No | GetDefaultQuantity: Quantity<br>SetDefaultQuantity: result | true | false |  |  |
| Flag | bool | Cờ 1 | No | GetDefaultFlag: Flag<br>SetDefaultFlag: result | false | false |  |  |
| NumberValue | decimal? | Trị số | No | SetDefaultNumberValue: result<br>GetDefaultNumberValue: Tools.TryConvertTextToNumber(Name) | false | false |  |  |
| DateValue | DateTime? | Trị ngày | No | GetDefaultDateValue: DateValue<br>SetDefaultDateValue: result | false | false |  |  |
| Length | int? | Ký tự | No | GetDefaultLength: Name.Length<br>SetDefaultLength: GetDefaultLength() | false | false |  |  |
| WordQuantity | int? | Số từ | No | GetDefaultWordQuantity: WordQuantity<br>SetDefaultWordQuantity: result | false | false |  |  |
| Status | Status | Trạng thái | No | GetDefaultStatus: Status<br>SetDefaultStatus: result | false | false |  |  |
| Note | string | Ghi chú | No | GetDefaultNote: Note<br>SetDefaultNote: result | false | false |  |  |
| LikeTerm | int? | Đồng dạng | No | GetDefaultLikeTerm: LikeTerm<br>SetDefaultLikeTerm: result | false | false |  |  |
| Flag2 | bool | Cờ 2 | No | GetDefaultFlag2: Flag2<br>SetDefaultFlag2: result | false | false |  |  |
| Overlap | bool | Đè nhau | No | SetDefaultOverlap: result<br>GetDefaultOverlap: TermLocationList?.FirstOrDefault(m =>m.Overlap) != null | false | false |  |  |
| Note2 | string | Ghi chú 2 | No | GetDefaultNote2: Note2<br>SetDefaultNote2: result | false | false |  |  |
| LikeWord | int? | Từ vựng | No | GetDefaultLikeWord: LikeWord<br>SetDefaultLikeWord: result | false | false |  |  |
| Language | Module.BusinessObjects.Language | Ngôn ngữ | No | GetDefaultLanguage: Language<br>SetDefaultLanguage: result | false | false |  |  |
| TranslateDataSource | System.Collections.Generic.IList<string> |  | No |  |  |  |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Translate  
Default: Translate  
Source: `GetDefaultTranslate()`  
Logic: { return Translate; }

Field: Translate  
Default: result  
Source: `SetDefaultTranslate()`  
Logic: { //if (Translate is null){ // var result = GetDefaultTranslate(view); // if (result != null && result != Translate){ // Translate = result; // } //} }

Field: LanguageTranslate  
Default: LanguageTranslate  
Source: `GetDefaultLanguageTranslate()`  
Logic: { return LanguageTranslate; }

Field: LanguageTranslate  
Default: result  
Source: `SetDefaultLanguageTranslate()`  
Logic: { //if (LanguageTranslate is null){ // var result = GetDefaultLanguageTranslate(view); // if (result != null && result != LanguageTranslate){ // LanguageTranslate = result; // } //} }

Field: GoogleTranslate  
Default: GoogleTranslate  
Source: `GetDefaultGoogleTranslate()`  
Logic: { return GoogleTranslate; }

Field: GoogleTranslate  
Default: result  
Source: `SetDefaultGoogleTranslate()`  
Logic: { //if (GoogleTranslate is null){ // var result = GetDefaultGoogleTranslate(view); // if (result != null && result != GoogleTranslate){ // GoogleTranslate = result; // } //} }

Field: WordType  
Default: WordType  
Source: `GetDefaultWordType()`  
Logic: { return WordType; }

Field: WordType  
Default: result  
Source: `SetDefaultWordType()`  
Logic: { //if (WordType is null){ // var result = GetDefaultWordType(view); // if (result != null && result != WordType){ // WordType = result; // } //} }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 0129 Oid: 40b70e30-391a-47bd-91f3-42a048f6b222 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 0160 Oid: f1dac60c-604b-4f64-860a-3c943c780a7b Update = GetDefaultUpdate(); }

Field: Video  
Default: Video  
Source: `GetDefaultVideo()`  
Logic: { return Video; }

Field: Video  
Default: result  
Source: `SetDefaultVideo()`  
Logic: { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} }

Field: TermType  
Default: TermType  
Source: `GetDefaultTermType()`  
Logic: { return TermType; }

Field: TermType  
Default: result  
Source: `SetDefaultTermType()`  
Logic: { //if (TermType is null){ // var result = GetDefaultTermType(view); // if (result != null && result != TermType){ // TermType = result; // } //} }

Field: Quantity  
Default: Quantity  
Source: `GetDefaultQuantity()`  
Logic: { return Quantity; }

Field: Quantity  
Default: result  
Source: `SetDefaultQuantity()`  
Logic: { //if (Quantity is null){ // var result = GetDefaultQuantity(view); // if (result != null && result != Quantity){ // Quantity = result; // } //} }

Field: Flag  
Default: Flag  
Source: `GetDefaultFlag()`  
Logic: { return Flag; }

Field: Flag  
Default: result  
Source: `SetDefaultFlag()`  
Logic: { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} }

Field: NumberValue  
Default: result  
Source: `SetDefaultNumberValue()`  
Logic: { //if (NumberValue is null){ // var result = GetDefaultNumberValue(view); // if (result != null && result != NumberValue){ // NumberValue = result; // } //} }

Field: NumberValue  
Default: Tools.TryConvertTextToNumber(Name)  
Source: `GetDefaultNumberValue()`  
Logic: { //Code: 0957 Oid: 5ac80d81-b7c3-4001-9cf7-f2c2349cd6a2 if (!string.IsNullOrEmpty(Name)) { return Tools.TryConvertTextToNumber(Name); } return null; }

Field: DateValue  
Default: DateValue  
Source: `GetDefaultDateValue()`  
Logic: { return DateValue; }

Field: DateValue  
Default: result  
Source: `SetDefaultDateValue()`  
Logic: { //if (DateValue is null){ // var result = GetDefaultDateValue(view); // if (result != null && result != DateValue){ // DateValue = result; // } //} }

Field: Length  
Default: Name.Length  
Source: `GetDefaultLength()`  
Logic: { //Code: 0948 Oid: ea4758cc-78b5-4407-8305-9be0dd66ba3d if (!string.IsNullOrEmpty(Name)) return Name.Length; return null; }

Field: Length  
Default: GetDefaultLength()  
Source: `SetDefaultLength()`  
Logic: { //Code: 0949 Oid: ffcabccb-b083-4384-abb7-4143d68489cb Length = GetDefaultLength(); }

Field: WordQuantity  
Default: WordQuantity  
Source: `GetDefaultWordQuantity()`  
Logic: { return WordQuantity; }

Field: WordQuantity  
Default: result  
Source: `SetDefaultWordQuantity()`  
Logic: { //if (WordQuantity is null){ // var result = GetDefaultWordQuantity(view); // if (result != null && result != WordQuantity){ // WordQuantity = result; // } //} }

Field: Status  
Default: Status  
Source: `GetDefaultStatus()`  
Logic: { return Status; }

Field: Status  
Default: result  
Source: `SetDefaultStatus()`  
Logic: { //if (Status is null){ // var result = GetDefaultStatus(view); // if (result != null && result != Status){ // Status = result; // } //} }

Field: Note  
Default: Note  
Source: `GetDefaultNote()`  
Logic: { return Note; }

Field: Note  
Default: result  
Source: `SetDefaultNote()`  
Logic: { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} }

Field: LikeTerm  
Default: LikeTerm  
Source: `GetDefaultLikeTerm()`  
Logic: { return LikeTerm; }

Field: LikeTerm  
Default: result  
Source: `SetDefaultLikeTerm()`  
Logic: { //if (LikeTerm is null){ // var result = GetDefaultLikeTerm(view); // if (result != null && result != LikeTerm){ // LikeTerm = result; // } //} }

Field: Flag2  
Default: Flag2  
Source: `GetDefaultFlag2()`  
Logic: { return Flag2; }

Field: Flag2  
Default: result  
Source: `SetDefaultFlag2()`  
Logic: { //if (Flag2 is null){ // var result = GetDefaultFlag2(view); // if (result != null && result != Flag2){ // Flag2 = result; // } //} }

Field: Overlap  
Default: result  
Source: `SetDefaultOverlap()`  
Logic: { //if (Overlap is null){ // var result = GetDefaultOverlap(view); // if (result != null && result != Overlap){ // Overlap = result; // } //} }

Field: Overlap  
Default: TermLocationList?.FirstOrDefault(m =>m.Overlap) != null  
Source: `GetDefaultOverlap()`  
Logic: { //Code: 1073 Oid: 7cb30f8b-f63b-4bd2-a5a3-4ef5ebfb7662 return TermLocationList?.FirstOrDefault(m =>m.Overlap) != null; }

Field: Note2  
Default: Note2  
Source: `GetDefaultNote2()`  
Logic: { return Note2; }

Field: Note2  
Default: result  
Source: `SetDefaultNote2()`  
Logic: { //if (Note2 is null){ // var result = GetDefaultNote2(view); // if (result != null && result != Note2){ // Note2 = result; // } //} }

Field: LikeWord  
Default: LikeWord  
Source: `GetDefaultLikeWord()`  
Logic: { return LikeWord; }

Field: LikeWord  
Default: result  
Source: `SetDefaultLikeWord()`  
Logic: { //if (LikeWord is null){ // var result = GetDefaultLikeWord(view); // if (result != null && result != LikeWord){ // LikeWord = result; // } //} }

Field: Language  
Default: Language  
Source: `GetDefaultLanguage()`  
Logic: { return Language; }

Field: Language  
Default: result  
Source: `SetDefaultLanguage()`  
Logic: { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 0410ImportCode base.AfterConstruction(); SetDefaultUpdate(); #endregion 0410ImportCode //SetDefaultName(View view = null); //SetDefaultTranslate(View view = null); //SetDefaultLanguageTranslate(View view = null); //SetDefaultGoo...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 0513ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0513ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- DateValue [Detail=false]
- Flag [Detail=false]
- Flag2 [Detail=false]
- Language [Detail=false]
- Length [Detail=false]
- LikeTerm [Detail=false]
- LikeWord [Detail=false]
- Note [Detail=false]
- Note2 [Detail=false]
- NumberValue [Detail=false]
- Overlap [Detail=false]
- Quantity [Detail=false]
- Status [Detail=false]
- TermLocationList [Detail=true]
- TermType [Detail=false]
- TranslateDataSource
- Update [Detail=false]
- Video [Detail=false]
- WordQuantity [Detail=false]

Group: (default)
- GoogleTranslate [Order=1] [Detail=true]
- LanguageTranslate [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- Translate [Order=1] [Detail=true]
- WordType [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | Term | { Oid = Guid.NewGuid(); #region 0410ImportCode base.AfterConstruction(); SetDefaultUpdate(); #endregion 0410ImportCode //SetDefaultName(View view = null); //SetDefaultTranslate(View view = null); //SetDefaultLanguageTranslate(View view = null); //SetDefaultGoo... |
| GetDefaultDateValue | Term | { return DateValue; } |
| GetDefaultFlag | Term | { return Flag; } |
| GetDefaultFlag2 | Term | { return Flag2; } |
| GetDefaultGoogleTranslate | Term | { return GoogleTranslate; } |
| GetDefaultLanguage | Term | { return Language; } |
| GetDefaultLanguageTranslate | Term | { return LanguageTranslate; } |
| GetDefaultLength | Term | { //Code: 0948 Oid: ea4758cc-78b5-4407-8305-9be0dd66ba3d if (!string.IsNullOrEmpty(Name)) return Name.Length; return null; } |
| GetDefaultLikeTerm | Term | { return LikeTerm; } |
| GetDefaultLikeWord | Term | { return LikeWord; } |
| GetDefaultName | Term | { return Name; } |
| GetDefaultNote | Term | { return Note; } |
| GetDefaultNote2 | Term | { return Note2; } |
| GetDefaultNumberValue | Term | { //Code: 0957 Oid: 5ac80d81-b7c3-4001-9cf7-f2c2349cd6a2 if (!string.IsNullOrEmpty(Name)) { return Tools.TryConvertTextToNumber(Name); } return null; } |
| GetDefaultOverlap | Term | { //Code: 1073 Oid: 7cb30f8b-f63b-4bd2-a5a3-4ef5ebfb7662 return TermLocationList?.FirstOrDefault(m =>m.Overlap) != null; } |
| GetDefaultQuantity | Term | { return Quantity; } |
| GetDefaultStatus | Term | { return Status; } |
| GetDefaultTermType | Term | { return TermType; } |
| GetDefaultTranslate | Term | { return Translate; } |
| GetDefaultUpdate | Term | { //Code: 0129 Oid: 40b70e30-391a-47bd-91f3-42a048f6b222 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultVideo | Term | { return Video; } |
| GetDefaultWordQuantity | Term | { return WordQuantity; } |
| GetDefaultWordType | Term | { return WordType; } |
| OnLoaded | Term | { base.OnLoaded(); } |
| OnSaving | Term | { #region 0513ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0513ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ... |
| SetDefaultDateValue | Term | { //if (DateValue is null){ // var result = GetDefaultDateValue(view); // if (result != null && result != DateValue){ // DateValue = result; // } //} } |
| SetDefaultFlag | Term | { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} } |
| SetDefaultFlag2 | Term | { //if (Flag2 is null){ // var result = GetDefaultFlag2(view); // if (result != null && result != Flag2){ // Flag2 = result; // } //} } |
| SetDefaultGoogleTranslate | Term | { //if (GoogleTranslate is null){ // var result = GetDefaultGoogleTranslate(view); // if (result != null && result != GoogleTranslate){ // GoogleTranslate = result; // } //} } |
| SetDefaultLanguage | Term | { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} } |
| SetDefaultLanguageTranslate | Term | { //if (LanguageTranslate is null){ // var result = GetDefaultLanguageTranslate(view); // if (result != null && result != LanguageTranslate){ // LanguageTranslate = result; // } //} } |
| SetDefaultLength | Term | { //Code: 0949 Oid: ffcabccb-b083-4384-abb7-4143d68489cb Length = GetDefaultLength(); } |
| SetDefaultLikeTerm | Term | { //if (LikeTerm is null){ // var result = GetDefaultLikeTerm(view); // if (result != null && result != LikeTerm){ // LikeTerm = result; // } //} } |
| SetDefaultLikeWord | Term | { //if (LikeWord is null){ // var result = GetDefaultLikeWord(view); // if (result != null && result != LikeWord){ // LikeWord = result; // } //} } |
| SetDefaultName | Term | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultNote | Term | { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} } |
| SetDefaultNote2 | Term | { //if (Note2 is null){ // var result = GetDefaultNote2(view); // if (result != null && result != Note2){ // Note2 = result; // } //} } |
| SetDefaultNumberValue | Term | { //if (NumberValue is null){ // var result = GetDefaultNumberValue(view); // if (result != null && result != NumberValue){ // NumberValue = result; // } //} } |
| SetDefaultOverlap | Term | { //if (Overlap is null){ // var result = GetDefaultOverlap(view); // if (result != null && result != Overlap){ // Overlap = result; // } //} } |
| SetDefaultQuantity | Term | { //if (Quantity is null){ // var result = GetDefaultQuantity(view); // if (result != null && result != Quantity){ // Quantity = result; // } //} } |
| SetDefaultStatus | Term | { //if (Status is null){ // var result = GetDefaultStatus(view); // if (result != null && result != Status){ // Status = result; // } //} } |
| SetDefaultTermType | Term | { //if (TermType is null){ // var result = GetDefaultTermType(view); // if (result != null && result != TermType){ // TermType = result; // } //} } |
| SetDefaultTranslate | Term | { //if (Translate is null){ // var result = GetDefaultTranslate(view); // if (result != null && result != Translate){ // Translate = result; // } //} } |
| SetDefaultUpdate | Term | { //Code: 0160 Oid: f1dac60c-604b-4f64-860a-3c943c780a7b Update = GetDefaultUpdate(); } |
| SetDefaultVideo | Term | { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} } |
| SetDefaultWordQuantity | Term | { //if (WordQuantity is null){ // var result = GetDefaultWordQuantity(view); // if (result != null && result != WordQuantity){ // WordQuantity = result; // } //} } |
| SetDefaultWordType | Term | { //if (WordType is null){ // var result = GetDefaultWordType(view); // if (result != null && result != WordType){ // WordType = result; // } //} } |

---

# Entity: TermCorrection

Caption entity: `Sửa thuật ngữ`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| TermLocationCorrectionList | XPCollection <Module.BusinessObjects.TermLocationCorrection> | Sửa thuật vị | No |  | false | true |  |  |
| Term | Module.BusinessObjects.Term | Thuật ngữ | No | GetDefaultTerm: Term<br>SetDefaultTerm: result | true | false |  |  |
| OptionNumber | int? | Số tùy chọn | No | GetDefaultOptionNumber: OptionNumber<br>SetDefaultOptionNumber: result | true | false |  |  |

## Default Logic

Field: Term  
Default: Term  
Source: `GetDefaultTerm()`  
Logic: { return Term; }

Field: Term  
Default: result  
Source: `SetDefaultTerm()`  
Logic: { //if (Term is null){ // var result = GetDefaultTerm(view); // if (result != null && result != Term){ // Term = result; // } //} }

Field: OptionNumber  
Default: OptionNumber  
Source: `GetDefaultOptionNumber()`  
Logic: { return OptionNumber; }

Field: OptionNumber  
Default: result  
Source: `SetDefaultOptionNumber()`  
Logic: { //if (OptionNumber is null){ // var result = GetDefaultOptionNumber(view); // if (result != null && result != OptionNumber){ // OptionNumber = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultTerm(View view = null); //SetDefaultOptionNumber(View view = null); }

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- OptionNumber [Detail=false]
- Term [Detail=false]
- TermLocationCorrectionList [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | TermCorrection | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultTerm(View view = null); //SetDefaultOptionNumber(View view = null); } |
| GetDefaultOptionNumber | TermCorrection | { return OptionNumber; } |
| GetDefaultTerm | TermCorrection | { return Term; } |
| OnLoaded | TermCorrection | { base.OnLoaded(); } |
| OnSaving | TermCorrection | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultOptionNumber | TermCorrection | { //if (OptionNumber is null){ // var result = GetDefaultOptionNumber(view); // if (result != null && result != OptionNumber){ // OptionNumber = result; // } //} } |
| SetDefaultTerm | TermCorrection | { //if (Term is null){ // var result = GetDefaultTerm(view); // if (result != null && result != Term){ // Term = result; // } //} } |

---

# Entity: TermLocation

Caption entity: `Thuật vị`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Term | Module.BusinessObjects.Term | Thuật ngữ | Yes | GetDefaultTerm: Term<br>SetDefaultTerm: result | false | true |   | 1 |
| Location | int? | Vị trí | No | GetDefaultLocation: Location<br>SetDefaultLocation: result | true | true |   | 1 |
| Sentence | int? | Câu | No | GetDefaultSentence: Sentence<br>SetDefaultSentence: result | false | true |   | 1 |
| Translate | string | Dịch | No | GetDefaultTranslate: Translate<br>SetDefaultTranslate: result | true | true |   | 1 |
| MachineTranslate | string | Máy dịch | Yes | GetDefaultMachineTranslate: MachineTranslate<br>SetDefaultMachineTranslate: result | false | true |   | 1 |
| Flag | bool | Cờ | No | GetDefaultFlag: Flag<br>SetDefaultFlag: result | true | false |  |  |
| TranslateLocation | int? | Vị trí dịch | No | SetDefaultTranslateLocation: result<br>GetDefaultTranslateLocation: Computed in GetDefaultTranslateLocation | false | false |  |  |
| Overlap | bool | Đè | No | GetDefaultOverlap: Overlap<br>SetDefaultOverlap: result | true | false |  |  |
| Audio | Module.BusinessObjects.Audio | Thành phần | No | GetDefaultAudio: Audio<br>SetDefaultAudio: result | false | false |  |  |
| ReplaceTranslate | bool | Thay dịch | No | GetDefaultReplaceTranslate: ReplaceTranslate<br>SetDefaultReplaceTranslate: result | false | false |  |  |
| Length | int? | Ký tự | No | SetDefaultLength: = null) Length = GetDefaultLength()<br>GetDefaultLength: MachineTranslate.Length | false | false |  |  |
| Note | string | Ghi chú | No | GetDefaultNote: Note<br>SetDefaultNote: result | false | false |  |  |
| Flag2 | bool | Cờ 2 | No | GetDefaultFlag2: Flag2<br>SetDefaultFlag2: result | false | false |  |  |
| Note2 | string | Ghi chú 2 | No | GetDefaultNote2: Note2<br>SetDefaultNote2: result | false | false |  |  |
| TermLocations | XPCollection<Module.BusinessObjects.TermLocation> | Thuật vị liên quan | No |  | false | true |  |  |
| TranslateDataSource | System.Collections.Generic.IList<string> |  | No |  |  |  |  |  |

## Default Logic

Field: Term  
Default: Term  
Source: `GetDefaultTerm()`  
Logic: { return Term; }

Field: Term  
Default: result  
Source: `SetDefaultTerm()`  
Logic: { //if (Term is null){ // var result = GetDefaultTerm(view); // if (result != null && result != Term){ // Term = result; // } //} }

Field: Location  
Default: Location  
Source: `GetDefaultLocation()`  
Logic: { return Location; }

Field: Location  
Default: result  
Source: `SetDefaultLocation()`  
Logic: { //if (Location is null){ // var result = GetDefaultLocation(view); // if (result != null && result != Location){ // Location = result; // } //} }

Field: Sentence  
Default: Sentence  
Source: `GetDefaultSentence()`  
Logic: { return Sentence; }

Field: Sentence  
Default: result  
Source: `SetDefaultSentence()`  
Logic: { //if (Sentence is null){ // var result = GetDefaultSentence(view); // if (result != null && result != Sentence){ // Sentence = result; // } //} }

Field: Translate  
Default: Translate  
Source: `GetDefaultTranslate()`  
Logic: { return Translate; }

Field: Translate  
Default: result  
Source: `SetDefaultTranslate()`  
Logic: { //if (Translate is null){ // var result = GetDefaultTranslate(view); // if (result != null && result != Translate){ // Translate = result; // } //} }

Field: MachineTranslate  
Default: MachineTranslate  
Source: `GetDefaultMachineTranslate()`  
Logic: { return MachineTranslate; }

Field: MachineTranslate  
Default: result  
Source: `SetDefaultMachineTranslate()`  
Logic: { //if (MachineTranslate is null){ // var result = GetDefaultMachineTranslate(view); // if (result != null && result != MachineTranslate){ // MachineTranslate = result; // } //} }

Field: Flag  
Default: Flag  
Source: `GetDefaultFlag()`  
Logic: { return Flag; }

Field: Flag  
Default: result  
Source: `SetDefaultFlag()`  
Logic: { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} }

Field: TranslateLocation  
Default: result  
Source: `SetDefaultTranslateLocation()`  
Logic: { //if (TranslateLocation is null){ // var result = GetDefaultTranslateLocation(view); // if (result != null && result != TranslateLocation){ // TranslateLocation = result; // } //} }

Field: TranslateLocation  
Default: Computed in GetDefaultTranslateLocation  
Source: `GetDefaultTranslateLocation()`  
Logic: { //Code: 0950 Oid: 98f214ad-347f-43df-ae64-80795343b453 if (!string.IsNullOrEmpty(MachineTranslate)) { //Ưu tiên dịch máy string translate = !string.IsNullOrEmpty(MachineTranslate) ? MachineTranslate : Translate; if (string.IsNullOrEmpty(translate) || Term is...

Field: Overlap  
Default: Overlap  
Source: `GetDefaultOverlap()`  
Logic: { return Overlap; }

Field: Overlap  
Default: result  
Source: `SetDefaultOverlap()`  
Logic: { //if (Overlap is null){ // var result = GetDefaultOverlap(view); // if (result != null && result != Overlap){ // Overlap = result; // } //} }

Field: Audio  
Default: Audio  
Source: `GetDefaultAudio()`  
Logic: { return Audio; }

Field: Audio  
Default: result  
Source: `SetDefaultAudio()`  
Logic: { //if (Audio is null){ // var result = GetDefaultAudio(view); // if (result != null && result != Audio){ // Audio = result; // } //} }

Field: ReplaceTranslate  
Default: ReplaceTranslate  
Source: `GetDefaultReplaceTranslate()`  
Logic: { return ReplaceTranslate; }

Field: ReplaceTranslate  
Default: result  
Source: `SetDefaultReplaceTranslate()`  
Logic: { //if (ReplaceTranslate is null){ // var result = GetDefaultReplaceTranslate(view); // if (result != null && result != ReplaceTranslate){ // ReplaceTranslate = result; // } //} }

Field: Length  
Default: = null) Length = GetDefaultLength()  
Source: `SetDefaultLength()`  
Logic: { //Code: 1439 Oid: dad1c0bc-a456-41ac-b39e-9753f2316a50 if(Length == null) Length = GetDefaultLength(); }

Field: Length  
Default: MachineTranslate.Length  
Source: `GetDefaultLength()`  
Logic: { //Code: 1438 Oid: e2438d0b-e086-4831-b33f-97a944579175 if (!string.IsNullOrEmpty(MachineTranslate)) return MachineTranslate.Length; return null; }

Field: Note  
Default: Note  
Source: `GetDefaultNote()`  
Logic: { return Note; }

Field: Note  
Default: result  
Source: `SetDefaultNote()`  
Logic: { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} }

Field: Flag2  
Default: Flag2  
Source: `GetDefaultFlag2()`  
Logic: { return Flag2; }

Field: Flag2  
Default: result  
Source: `SetDefaultFlag2()`  
Logic: { //if (Flag2 is null){ // var result = GetDefaultFlag2(view); // if (result != null && result != Flag2){ // Flag2 = result; // } //} }

Field: Note2  
Default: Note2  
Source: `GetDefaultNote2()`  
Logic: { return Note2; }

Field: Note2  
Default: result  
Source: `SetDefaultNote2()`  
Logic: { //if (Note2 is null){ // var result = GetDefaultNote2(view); // if (result != null && result != Note2){ // Note2 = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultTerm(View view = null); //SetDefaultLocation(View view = null); //SetDefaultSentence(View view = null); //SetDefaultTranslate(View view = null); //SetDefaultMachineTranslate(View view = null); //Set...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- Audio [Detail=false]
- Flag [Detail=false]
- Flag2 [Detail=false]
- Length [Detail=false]
- Note [Detail=false]
- Note2 [Detail=false]
- Overlap [Detail=false]
- ReplaceTranslate [Detail=false]
- TermLocations [Detail=true]
- TranslateDataSource
- TranslateLocation [Detail=false]

Group: (default)
- Location [Order=1] [Detail=true]
- MachineTranslate [Order=1] [Detail=true]
- Sentence [Order=1] [Detail=true]
- Term [Order=1] [Detail=true]
- Translate [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | TermLocation | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultTerm(View view = null); //SetDefaultLocation(View view = null); //SetDefaultSentence(View view = null); //SetDefaultTranslate(View view = null); //SetDefaultMachineTranslate(View view = null); //Set... |
| GetDefaultAudio | TermLocation | { return Audio; } |
| GetDefaultFlag | TermLocation | { return Flag; } |
| GetDefaultFlag2 | TermLocation | { return Flag2; } |
| GetDefaultLength | TermLocation | { //Code: 1438 Oid: e2438d0b-e086-4831-b33f-97a944579175 if (!string.IsNullOrEmpty(MachineTranslate)) return MachineTranslate.Length; return null; } |
| GetDefaultLocation | TermLocation | { return Location; } |
| GetDefaultMachineTranslate | TermLocation | { return MachineTranslate; } |
| GetDefaultNote | TermLocation | { return Note; } |
| GetDefaultNote2 | TermLocation | { return Note2; } |
| GetDefaultOverlap | TermLocation | { return Overlap; } |
| GetDefaultReplaceTranslate | TermLocation | { return ReplaceTranslate; } |
| GetDefaultSentence | TermLocation | { return Sentence; } |
| GetDefaultTerm | TermLocation | { return Term; } |
| GetDefaultTranslate | TermLocation | { return Translate; } |
| GetDefaultTranslateLocation | TermLocation | { //Code: 0950 Oid: 98f214ad-347f-43df-ae64-80795343b453 if (!string.IsNullOrEmpty(MachineTranslate)) { //Ưu tiên dịch máy string translate = !string.IsNullOrEmpty(MachineTranslate) ? MachineTranslate : Translate; if (string.IsNullOrEmpty(translate) \|\| Term is... |
| OnLoaded | TermLocation | { base.OnLoaded(); } |
| OnSaving | TermLocation | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultAudio | TermLocation | { //if (Audio is null){ // var result = GetDefaultAudio(view); // if (result != null && result != Audio){ // Audio = result; // } //} } |
| SetDefaultFlag | TermLocation | { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} } |
| SetDefaultFlag2 | TermLocation | { //if (Flag2 is null){ // var result = GetDefaultFlag2(view); // if (result != null && result != Flag2){ // Flag2 = result; // } //} } |
| SetDefaultLength | TermLocation | { //Code: 1439 Oid: dad1c0bc-a456-41ac-b39e-9753f2316a50 if(Length == null) Length = GetDefaultLength(); } |
| SetDefaultLocation | TermLocation | { //if (Location is null){ // var result = GetDefaultLocation(view); // if (result != null && result != Location){ // Location = result; // } //} } |
| SetDefaultMachineTranslate | TermLocation | { //if (MachineTranslate is null){ // var result = GetDefaultMachineTranslate(view); // if (result != null && result != MachineTranslate){ // MachineTranslate = result; // } //} } |
| SetDefaultNote | TermLocation | { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} } |
| SetDefaultNote2 | TermLocation | { //if (Note2 is null){ // var result = GetDefaultNote2(view); // if (result != null && result != Note2){ // Note2 = result; // } //} } |
| SetDefaultOverlap | TermLocation | { //if (Overlap is null){ // var result = GetDefaultOverlap(view); // if (result != null && result != Overlap){ // Overlap = result; // } //} } |
| SetDefaultReplaceTranslate | TermLocation | { //if (ReplaceTranslate is null){ // var result = GetDefaultReplaceTranslate(view); // if (result != null && result != ReplaceTranslate){ // ReplaceTranslate = result; // } //} } |
| SetDefaultSentence | TermLocation | { //if (Sentence is null){ // var result = GetDefaultSentence(view); // if (result != null && result != Sentence){ // Sentence = result; // } //} } |
| SetDefaultTerm | TermLocation | { //if (Term is null){ // var result = GetDefaultTerm(view); // if (result != null && result != Term){ // Term = result; // } //} } |
| SetDefaultTranslate | TermLocation | { //if (Translate is null){ // var result = GetDefaultTranslate(view); // if (result != null && result != Translate){ // Translate = result; // } //} } |
| SetDefaultTranslateLocation | TermLocation | { //if (TranslateLocation is null){ // var result = GetDefaultTranslateLocation(view); // if (result != null && result != TranslateLocation){ // TranslateLocation = result; // } //} } |

---

# Entity: TermLocationCorrection

Caption entity: `Sửa thuật vị`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Caption | string | Tên | No | GetDefaultCaption: Caption<br>SetDefaultCaption: result | true | true |   | 1 |
| CorrectionOptionList | XPCollection <Module.BusinessObjects.CorrectionOption> | Tùy chọn | No |  | false | true |  |  |
| TermCorrection | Module.BusinessObjects.TermCorrection | Sửa thuật ngữ | No | GetDefaultTermCorrection: TermCorrection<br>SetDefaultTermCorrection: result | false | false |  |  |
| OptionNumber | int? | Số tùy chọn | No | GetDefaultOptionNumber: OptionNumber<br>SetDefaultOptionNumber: result | true | false |  |  |
| TermLocation | Module.BusinessObjects.TermLocation | Thuật vị | No | GetDefaultTermLocation: TermLocation<br>SetDefaultTermLocation: result | true | false |  |  |

## Default Logic

Field: Caption  
Default: Caption  
Source: `GetDefaultCaption()`  
Logic: { return Caption; }

Field: Caption  
Default: result  
Source: `SetDefaultCaption()`  
Logic: { //if (Caption is null){ // var result = GetDefaultCaption(view); // if (result != null && result != Caption){ // Caption = result; // } //} }

Field: TermCorrection  
Default: TermCorrection  
Source: `GetDefaultTermCorrection()`  
Logic: { return TermCorrection; }

Field: TermCorrection  
Default: result  
Source: `SetDefaultTermCorrection()`  
Logic: { //if (TermCorrection is null){ // var result = GetDefaultTermCorrection(view); // if (result != null && result != TermCorrection){ // TermCorrection = result; // } //} }

Field: OptionNumber  
Default: OptionNumber  
Source: `GetDefaultOptionNumber()`  
Logic: { return OptionNumber; }

Field: OptionNumber  
Default: result  
Source: `SetDefaultOptionNumber()`  
Logic: { //if (OptionNumber is null){ // var result = GetDefaultOptionNumber(view); // if (result != null && result != OptionNumber){ // OptionNumber = result; // } //} }

Field: TermLocation  
Default: TermLocation  
Source: `GetDefaultTermLocation()`  
Logic: { return TermLocation; }

Field: TermLocation  
Default: result  
Source: `SetDefaultTermLocation()`  
Logic: { //if (TermLocation is null){ // var result = GetDefaultTermLocation(view); // if (result != null && result != TermLocation){ // TermLocation = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultCaption(View view = null); //SetDefaultTermCorrection(View view = null); //SetDefaultOptionNumber(View view = null); //SetDefaultTermLocation(View view = null); }

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- CorrectionOptionList [Detail=true]
- OptionNumber [Detail=false]
- TermCorrection [Detail=false]
- TermLocation [Detail=false]

Group: (default)
- Caption [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | TermLocationCorrection | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultCaption(View view = null); //SetDefaultTermCorrection(View view = null); //SetDefaultOptionNumber(View view = null); //SetDefaultTermLocation(View view = null); } |
| GetDefaultCaption | TermLocationCorrection | { return Caption; } |
| GetDefaultOptionNumber | TermLocationCorrection | { return OptionNumber; } |
| GetDefaultTermCorrection | TermLocationCorrection | { return TermCorrection; } |
| GetDefaultTermLocation | TermLocationCorrection | { return TermLocation; } |
| OnLoaded | TermLocationCorrection | { base.OnLoaded(); } |
| OnSaving | TermLocationCorrection | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultCaption | TermLocationCorrection | { //if (Caption is null){ // var result = GetDefaultCaption(view); // if (result != null && result != Caption){ // Caption = result; // } //} } |
| SetDefaultOptionNumber | TermLocationCorrection | { //if (OptionNumber is null){ // var result = GetDefaultOptionNumber(view); // if (result != null && result != OptionNumber){ // OptionNumber = result; // } //} } |
| SetDefaultTermCorrection | TermLocationCorrection | { //if (TermCorrection is null){ // var result = GetDefaultTermCorrection(view); // if (result != null && result != TermCorrection){ // TermCorrection = result; // } //} } |
| SetDefaultTermLocation | TermLocationCorrection | { //if (TermLocation is null){ // var result = GetDefaultTermLocation(view); // if (result != null && result != TermLocation){ // TermLocation = result; // } //} } |

---

# Entity: TournamentSeason

Caption entity: `Mùa giải`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No |  | true | true |   | 1 |
| Code | string | Mã | Yes | GetDefaultCode: Code<br>SetDefaultCode: result | true | true |   | 1 |
| Begin | DateTime? | Khai mạc | No | GetDefaultBegin: Begin<br>SetDefaultBegin: result | true | true |   | 1 |
| End | DateTime? | Bế mạc | No | GetDefaultEnd: End<br>SetDefaultEnd: result | true | true |   | 1 |
| Sponsor | string | Nhà tài trợ | No | GetDefaultSponsor: Sponsor<br>SetDefaultSponsor: result | false | true |   | 1 |
| MatchList | XPCollection <Module.BusinessObjects.Match> | Trận đấu | No |  | false | true |  |  |
| PostList | XPCollection <Module.BusinessObjects.Post> | Tin tức | No |  | false | true |  |  |

## Default Logic

Field: Code  
Default: Code  
Source: `GetDefaultCode()`  
Logic: { return Code; }

Field: Code  
Default: result  
Source: `SetDefaultCode()`  
Logic: { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} }

Field: Begin  
Default: Begin  
Source: `GetDefaultBegin()`  
Logic: { return Begin; }

Field: Begin  
Default: result  
Source: `SetDefaultBegin()`  
Logic: { //if (Begin is null){ // var result = GetDefaultBegin(view); // if (result != null && result != Begin){ // Begin = result; // } //} }

Field: End  
Default: End  
Source: `GetDefaultEnd()`  
Logic: { return End; }

Field: End  
Default: result  
Source: `SetDefaultEnd()`  
Logic: { //if (End is null){ // var result = GetDefaultEnd(view); // if (result != null && result != End){ // End = result; // } //} }

Field: Sponsor  
Default: Sponsor  
Source: `GetDefaultSponsor()`  
Logic: { return Sponsor; }

Field: Sponsor  
Default: result  
Source: `SetDefaultSponsor()`  
Logic: { //if (Sponsor is null){ // var result = GetDefaultSponsor(view); // if (result != null && result != Sponsor){ // Sponsor = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultCode(View view = null); //SetDefaultBegin(View view = null); //SetDefaultEnd(View view = null); //SetDefaultSponsor(View view = null); }

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- MatchList [Detail=true]
- PostList [Detail=true]

Group: (default)
- Begin [Order=1] [Detail=true]
- Code [Order=1] [Detail=true]
- End [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- Sponsor [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | TournamentSeason | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultCode(View view = null); //SetDefaultBegin(View view = null); //SetDefaultEnd(View view = null); //SetDefaultSponsor(View view = null); } |
| GetDefaultBegin | TournamentSeason | { return Begin; } |
| GetDefaultCode | TournamentSeason | { return Code; } |
| GetDefaultEnd | TournamentSeason | { return End; } |
| GetDefaultSponsor | TournamentSeason | { return Sponsor; } |
| OnLoaded | TournamentSeason | { base.OnLoaded(); } |
| OnSaving | TournamentSeason | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultBegin | TournamentSeason | { //if (Begin is null){ // var result = GetDefaultBegin(view); // if (result != null && result != Begin){ // Begin = result; // } //} } |
| SetDefaultCode | TournamentSeason | { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} } |
| SetDefaultEnd | TournamentSeason | { //if (End is null){ // var result = GetDefaultEnd(view); // if (result != null && result != End){ // End = result; // } //} } |
| SetDefaultSponsor | TournamentSeason | { //if (Sponsor is null){ // var result = GetDefaultSponsor(view); // if (result != null && result != Sponsor){ // Sponsor = result; // } //} } |

---

# Entity: TranslateObject

Caption entity: `Đối tượng dịch`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Content | string | Nội dung | No | GetDefaultContent: Content<br>SetDefaultContent: result | false | true |  |  |
| ObjectID | System.Guid | Mã đối tượng | No | GetDefaultObjectID: ObjectID<br>SetDefaultObjectID: result | false | false |  |  |
| SystemType | System.Type | Kiểu hệ thống | No | GetDefaultSystemType: SystemType<br>SetDefaultSystemType: result | true | false |  |  |
| Field | StringLookup | Trường | No | GetDefaultField: Field<br>SetDefaultField: result | true | false |  |  |
| Video | Module.BusinessObjects.Video | Tư liệu | No | GetDefaultVideo: Video<br>SetDefaultVideo: result | false | false |  |  |
| Flag | bool | Cờ | No | GetDefaultFlag: Flag<br>SetDefaultFlag: result | false | false |  |  |
| Order | int? | Thứ tự | No | GetDefaultOrder: Order<br>SetDefaultOrder: result | false | false |  |  |
| FieldSource | System.Collections.Generic.IList<StringLookup> |  | No |  |  |  |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Content  
Default: Content  
Source: `GetDefaultContent()`  
Logic: { return Content; }

Field: Content  
Default: result  
Source: `SetDefaultContent()`  
Logic: { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} }

Field: ObjectID  
Default: ObjectID  
Source: `GetDefaultObjectID()`  
Logic: { return ObjectID; }

Field: ObjectID  
Default: result  
Source: `SetDefaultObjectID()`  
Logic: { //if (ObjectID is null){ // var result = GetDefaultObjectID(view); // if (result != null && result != ObjectID){ // ObjectID = result; // } //} }

Field: SystemType  
Default: SystemType  
Source: `GetDefaultSystemType()`  
Logic: { return SystemType; }

Field: SystemType  
Default: result  
Source: `SetDefaultSystemType()`  
Logic: { //if (SystemType is null){ // var result = GetDefaultSystemType(view); // if (result != null && result != SystemType){ // SystemType = result; // } //} }

Field: Field  
Default: Field  
Source: `GetDefaultField()`  
Logic: { return Field; }

Field: Field  
Default: result  
Source: `SetDefaultField()`  
Logic: { //if (Field is null){ // var result = GetDefaultField(view); // if (result != null && result != Field){ // Field = result; // } //} }

Field: Video  
Default: Video  
Source: `GetDefaultVideo()`  
Logic: { return Video; }

Field: Video  
Default: result  
Source: `SetDefaultVideo()`  
Logic: { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} }

Field: Flag  
Default: Flag  
Source: `GetDefaultFlag()`  
Logic: { return Flag; }

Field: Flag  
Default: result  
Source: `SetDefaultFlag()`  
Logic: { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} }

Field: Order  
Default: Order  
Source: `GetDefaultOrder()`  
Logic: { return Order; }

Field: Order  
Default: result  
Source: `SetDefaultOrder()`  
Logic: { //if (Order is null){ // var result = GetDefaultOrder(view); // if (result != null && result != Order){ // Order = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultObjectID(View view = null); //SetDefaultSystemType(View view = null); //SetDefaultField(View view = null); //SetDefaultVideo(View view = null); //SetDefaultFlag(V...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- Content [Detail=true]
- Field [Detail=false]
- FieldSource
- Flag [Detail=false]
- ObjectID [Detail=false]
- Order [Detail=false]
- SystemType [Detail=false]
- Video [Detail=false]

Group: (default)
- Name [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | TranslateObject | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultObjectID(View view = null); //SetDefaultSystemType(View view = null); //SetDefaultField(View view = null); //SetDefaultVideo(View view = null); //SetDefaultFlag(V... |
| GetDefaultContent | TranslateObject | { return Content; } |
| GetDefaultField | TranslateObject | { return Field; } |
| GetDefaultFlag | TranslateObject | { return Flag; } |
| GetDefaultName | TranslateObject | { return Name; } |
| GetDefaultObjectID | TranslateObject | { return ObjectID; } |
| GetDefaultOrder | TranslateObject | { return Order; } |
| GetDefaultSystemType | TranslateObject | { return SystemType; } |
| GetDefaultVideo | TranslateObject | { return Video; } |
| OnLoaded | TranslateObject | { base.OnLoaded(); } |
| OnSaving | TranslateObject | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultContent | TranslateObject | { //if (Content is null){ // var result = GetDefaultContent(view); // if (result != null && result != Content){ // Content = result; // } //} } |
| SetDefaultField | TranslateObject | { //if (Field is null){ // var result = GetDefaultField(view); // if (result != null && result != Field){ // Field = result; // } //} } |
| SetDefaultFlag | TranslateObject | { //if (Flag is null){ // var result = GetDefaultFlag(view); // if (result != null && result != Flag){ // Flag = result; // } //} } |
| SetDefaultName | TranslateObject | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultObjectID | TranslateObject | { //if (ObjectID is null){ // var result = GetDefaultObjectID(view); // if (result != null && result != ObjectID){ // ObjectID = result; // } //} } |
| SetDefaultOrder | TranslateObject | { //if (Order is null){ // var result = GetDefaultOrder(view); // if (result != null && result != Order){ // Order = result; // } //} } |
| SetDefaultSystemType | TranslateObject | { //if (SystemType is null){ // var result = GetDefaultSystemType(view); // if (result != null && result != SystemType){ // SystemType = result; // } //} } |
| SetDefaultVideo | TranslateObject | { //if (Video is null){ // var result = GetDefaultVideo(view); // if (result != null && result != Video){ // Video = result; // } //} } |

---

# Entity: TranslateWord

Caption entity: `Từ dịch`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| Language | Module.BusinessObjects.Language | Ngôn ngữ | No | GetDefaultLanguage: Language<br>SetDefaultLanguage: result | true | true |   | 1 |
| Context | string | Ngữ cảnh | No | GetDefaultContext: Context<br>SetDefaultContext: result | false | true |   | 1 |
| Update | DateTime | Cập nhật | No | SetDefaultUpdate: GetDefaultUpdate()<br>GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null) | false | false |  |  |
| Creator | Module.BusinessObjects.Member | Người tạo | No | GetDefaultCreator: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)<br>SetDefaultCreator: = null) Creator = GetDefaultCreator() | false | false |  |  |
| DictionaryWord | Module.BusinessObjects.DictionaryWord | Từ ngữ | No | GetDefaultDictionaryWord: DictionaryWord<br>SetDefaultDictionaryWord: result | false | false |  |  |
| Order | int? | Thứ tự | No | GetDefaultOrder: Order<br>SetDefaultOrder: result | false | false |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Language  
Default: Language  
Source: `GetDefaultLanguage()`  
Logic: { return Language; }

Field: Language  
Default: result  
Source: `SetDefaultLanguage()`  
Logic: { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} }

Field: Context  
Default: Context  
Source: `GetDefaultContext()`  
Logic: { return Context; }

Field: Context  
Default: result  
Source: `SetDefaultContext()`  
Logic: { //if (Context is null){ // var result = GetDefaultContext(view); // if (result != null && result != Context){ // Context = result; // } //} }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 0583 Oid: bd799cc0-eeb3-45e7-b01b-f81892d76ec7 Update = GetDefaultUpdate(); }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 0585 Oid: 753d545b-e8e9-4d2e-87f5-3ec2a4258f3e return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Creator  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultCreator()`  
Logic: { //Code: 0588 Oid: 8186a28e-a6ae-401d-b6ab-547813dd7fda return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: Creator  
Default: = null) Creator = GetDefaultCreator()  
Source: `SetDefaultCreator()`  
Logic: { //Code: 0586 Oid: c16a82ee-9fd1-49c0-99da-337f463c410a if(Creator == null) Creator = GetDefaultCreator(); }

Field: DictionaryWord  
Default: DictionaryWord  
Source: `GetDefaultDictionaryWord()`  
Logic: { return DictionaryWord; }

Field: DictionaryWord  
Default: result  
Source: `SetDefaultDictionaryWord()`  
Logic: { //if (DictionaryWord is null){ // var result = GetDefaultDictionaryWord(view); // if (result != null && result != DictionaryWord){ // DictionaryWord = result; // } //} }

Field: Order  
Default: Order  
Source: `GetDefaultOrder()`  
Logic: { return Order; }

Field: Order  
Default: result  
Source: `SetDefaultOrder()`  
Logic: { //if (Order is null){ // var result = GetDefaultOrder(view); // if (result != null && result != Order){ // Order = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 0587ImportCode base.AfterConstruction(); SetDefaultCreator(); #endregion 0587ImportCode //SetDefaultName(View view = null); //SetDefaultLanguage(View view = null); //SetDefaultContext(View view = null); //SetDefaultUpdate(View v...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 0584ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0584ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- Creator [Detail=false]
- DictionaryWord [Detail=false]
- Order [Detail=false]
- Update [Detail=false]

Group: (default)
- Context [Order=1] [Detail=true]
- Language [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | TranslateWord | { Oid = Guid.NewGuid(); #region 0587ImportCode base.AfterConstruction(); SetDefaultCreator(); #endregion 0587ImportCode //SetDefaultName(View view = null); //SetDefaultLanguage(View view = null); //SetDefaultContext(View view = null); //SetDefaultUpdate(View v... |
| GetDefaultContext | TranslateWord | { return Context; } |
| GetDefaultCreator | TranslateWord | { //Code: 0588 Oid: 8186a28e-a6ae-401d-b6ab-547813dd7fda return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| GetDefaultDictionaryWord | TranslateWord | { return DictionaryWord; } |
| GetDefaultLanguage | TranslateWord | { return Language; } |
| GetDefaultName | TranslateWord | { return Name; } |
| GetDefaultOrder | TranslateWord | { return Order; } |
| GetDefaultUpdate | TranslateWord | { //Code: 0585 Oid: 753d545b-e8e9-4d2e-87f5-3ec2a4258f3e return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| OnLoaded | TranslateWord | { base.OnLoaded(); } |
| OnSaving | TranslateWord | { #region 0584ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0584ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ... |
| SetDefaultContext | TranslateWord | { //if (Context is null){ // var result = GetDefaultContext(view); // if (result != null && result != Context){ // Context = result; // } //} } |
| SetDefaultCreator | TranslateWord | { //Code: 0586 Oid: c16a82ee-9fd1-49c0-99da-337f463c410a if(Creator == null) Creator = GetDefaultCreator(); } |
| SetDefaultDictionaryWord | TranslateWord | { //if (DictionaryWord is null){ // var result = GetDefaultDictionaryWord(view); // if (result != null && result != DictionaryWord){ // DictionaryWord = result; // } //} } |
| SetDefaultLanguage | TranslateWord | { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} } |
| SetDefaultName | TranslateWord | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultOrder | TranslateWord | { //if (Order is null){ // var result = GetDefaultOrder(view); // if (result != null && result != Order){ // Order = result; // } //} } |
| SetDefaultUpdate | TranslateWord | { //Code: 0583 Oid: bd799cc0-eeb3-45e7-b01b-f81892d76ec7 Update = GetDefaultUpdate(); } |

---

# Entity: Video

Caption entity: `Tư liệu`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Code | string | Mã | Yes | SetDefaultCode: GetDefaultCode()<br>GetDefaultCode: Computed in GetDefaultCode | true | true |   | 1 |
| Name | string | Tên | Yes | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| DocumentType | DocumentType | Loại | No | GetDefaultDocumentType: DocumentType<br>SetDefaultDocumentType: result | true | true |   | 1 |
| Member | Module.BusinessObjects.Member | Quản lý | No | SetDefaultMember: = null) Member = GetDefaultMember()<br>GetDefaultMember: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session) | true | true |   | 1 |
| Date | DateTime | Ngày | No | SetDefaultDate: GetDefaultDate()<br>GetDefaultDate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null) | true | true |   | 1 |
| LanguageOrigin | Module.BusinessObjects.Language | Ngữ gốc | No | GetDefaultLanguageOrigin: LanguageOrigin<br>SetDefaultLanguageOrigin: result | false | true |   | 1 |
| LanguageTranslate | Module.BusinessObjects.Language | Ngữ dịch | No | GetDefaultLanguageTranslate: LanguageTranslate<br>SetDefaultLanguageTranslate: result | false | true |   | 1 |
| Path | string | Đường dẫn | No | GetDefaultPath: Path<br>SetDefaultPath: result | false | true |   | 1 |
| Status | Status | Trạng thái | No | GetDefaultStatus: Status<br>SetDefaultStatus: result | true | true |   | 1 |
| AudioList | XPCollection <Module.BusinessObjects.Audio> | Thành phần | No |  | false | true |  |  |
| ElementBatchList | XPCollection <Module.BusinessObjects.ElementBatch> | Lô | No |  | false | true |  |  |
| TermList | XPCollection <Module.BusinessObjects.Term> | Thuật ngữ | No |  | false | true |  |  |
| TermLocationList | XPCollection <Module.BusinessObjects.TermLocation> | Thuật vị | No |  | false | true |  |  |
| MediaList | XPCollection <Module.BusinessObjects.Media> | Hình ảnh | No |  | false | true |  |  |
| ParagraphList | XPCollection <Module.BusinessObjects.Paragraph> | Đoạn văn | No |  | false | true |  |  |
| ParagraphStyleList | XPCollection <Module.BusinessObjects.ParagraphStyle> | Kiểu cách | No |  | false | true |  |  |
| LanguageList | XPCollection <Module.BusinessObjects.Language> | Ngôn ngữ | No |  | false | true |  |  |
| TranslateObjectList | XPCollection <Module.BusinessObjects.TranslateObject> | Đối tượng | No |  | false | true |  |  |
| FileList | XPCollection <Module.BusinessObjects.BookMark> | Liên kết | No |  | false | true |  |  |
| Note | string | Ghi chú | No | GetDefaultNote: Note<br>SetDefaultNote: result | false | true |  |  |
| FontColor | bool | Màu phông | No | GetDefaultFontColor: FontColor<br>SetDefaultFontColor: result | false | false |  |  |
| FontBold | bool | Đậm phông | No | GetDefaultFontBold: FontBold<br>SetDefaultFontBold: result | false | false |  |  |
| FontItalic | bool | Nghiêng phông | No | GetDefaultFontItalic: FontItalic<br>SetDefaultFontItalic: result | false | false |  |  |
| FontUnderline | bool | Gạch phông | No | GetDefaultFontUnderline: FontUnderline<br>SetDefaultFontUnderline: result | false | false |  |  |
| Outline | bool | Outline | No | GetDefaultOutline: Outline<br>SetDefaultOutline: result | false | false |  |  |
| Alignment | bool | Căn lề | No | GetDefaultAlignment: Alignment<br>SetDefaultAlignment: result | false | false |  |  |
| Spacing | bool | Cách dòng | No | GetDefaultSpacing: Spacing<br>SetDefaultSpacing: result | false | false |  |  |
| Indent | bool | Thụt | No | GetDefaultIndent: Indent<br>SetDefaultIndent: result | false | false |  |  |
| NodeFontColor | bool | Màu phông | No | GetDefaultNodeFontColor: NodeFontColor<br>SetDefaultNodeFontColor: result | false | false |  |  |
| NodeFontBold | bool | Đậm phông | No | GetDefaultNodeFontBold: NodeFontBold<br>SetDefaultNodeFontBold: result | false | false |  |  |
| NodeFontItalic | bool | Nghiêng phông | No | GetDefaultNodeFontItalic: NodeFontItalic<br>SetDefaultNodeFontItalic: result | false | false |  |  |
| NodeFontUnderline | bool | Gạch phông | No | GetDefaultNodeFontUnderline: NodeFontUnderline<br>SetDefaultNodeFontUnderline: result | false | false |  |  |
| NodeLink | bool | Hyper Link | No | GetDefaultNodeLink: NodeLink<br>SetDefaultNodeLink: result | false | false |  |  |
| NodeSuper | bool | Super Script | No | GetDefaultNodeSuper: NodeSuper<br>SetDefaultNodeSuper: result | false | false |  |  |
| UpperElementImport | bool | Cấp trên | No | GetDefaultUpperElementImport: UpperElementImport<br>SetDefaultUpperElementImport: result | false | false |  |  |
| Number | bool | Số và kí tự | No | GetDefaultNumber: Number<br>SetDefaultNumber: result | false | false |  |  |
| CheckSpelling | bool | Lỗi chính tả | No | GetDefaultCheckSpelling: CheckSpelling<br>SetDefaultCheckSpelling: result | false | false |  |  |
| WithTermPosition | bool | Kèm thuật vị | No | GetDefaultWithTermPosition: WithTermPosition<br>SetDefaultWithTermPosition: result | false | false |  |  |
| ElementSpacing | int? | Khoảng tách | No | SetDefaultElementSpacing: = null) ElementSpacing = GetDefaultElementSpacing()<br>GetDefaultElementSpacing: 500 | false | false |  |  |
| BlankSpacing | int | Khoảng trắng | No | GetDefaultBlankSpacing: BlankSpacing<br>SetDefaultBlankSpacing: result | false | false |  |  |
| Update | DateTime? | Cập nhật | No | SetDefaultUpdate: GetDefaultUpdate()<br>GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null) | true | false |  |  |
| CodeUnique | bool | Mã duy nhất | No | GetDefaultCodeUnique: CodeUnique<br>SetDefaultCodeUnique: result | false | false |  |  |
| UpcaseNumbering | bool | Tự động hoa | No | GetDefaultUpcaseNumbering: UpcaseNumbering<br>SetDefaultUpcaseNumbering: result | false | false |  |  |
| AbbyyTermLocation | bool | Thuật vị lỗi | No | GetDefaultAbbyyTermLocation: AbbyyTermLocation<br>SetDefaultAbbyyTermLocation: result | false | false |  |  |
| KeepSpace | bool | Giữ dấu cách | No | GetDefaultKeepSpace: KeepSpace<br>SetDefaultKeepSpace: result | false | false |  |  |
| ImportByNode | bool | Nạp theo Node | No | GetDefaultImportByNode: ImportByNode<br>SetDefaultImportByNode: result | false | false |  |  |
| ImportParagraph | bool | Nạp đoạn văn bản | No | GetDefaultImportParagraph: ImportParagraph<br>SetDefaultImportParagraph: result | false | false |  |  |
| RightIndent | bool | Thụt phải | No | GetDefaultRightIndent: RightIndent<br>SetDefaultRightIndent: result | false | false |  |  |
| OriginStyleExport | bool | Xuất giữ kiểu | No | GetDefaultOriginStyleExport: OriginStyleExport<br>SetDefaultOriginStyleExport: result | false | false |  |  |
| CreateWordStyle | bool | Tạo Word Style | No | GetDefaultCreateWordStyle: CreateWordStyle<br>SetDefaultCreateWordStyle: result | false | false |  |  |
| Open | bool | Công khai | No | GetDefaultOpen: Open<br>SetDefaultOpen: result | false | false |  |  |
| Folder | Module.BusinessObjects.Folder | Thư mục | No | GetDefaultFolder: Folder<br>SetDefaultFolder: result | false | false |  |  |
| BrLine | bool | Xuống dòng BR | No | GetDefaultBrLine: BrLine<br>SetDefaultBrLine: result | false | false |  |  |
| IsPhoto | bool | Ảnh | No | GetDefaultIsPhoto: IsPhoto<br>SetDefaultIsPhoto: result | false | false |  |  |
| TextObjectGroup | bool | Văn bản nhóm  | No | GetDefaultTextObjectGroup: TextObjectGroup<br>SetDefaultTextObjectGroup: result | false | false |  |  |
| FootNote | bool | FootNote | No | GetDefaultFootNote: FootNote<br>SetDefaultFootNote: result | false | false |  |  |

## Default Logic

Field: Code  
Default: GetDefaultCode()  
Source: `SetDefaultCode()`  
Logic: { //Code: 0964 Oid: 518b400b-102b-453a-a004-02e71f17adb9 if(String.IsNullOrEmpty(Code)) Code = GetDefaultCode(); }

Field: Code  
Default: Computed in GetDefaultCode  
Source: `GetDefaultCode()`  
Logic: { //Code: 0963 Oid: a06c5e41-3636-4e95-9d10-01cc2cc1e043 var keyCodeObject = Module.Helpers.ParameterHelper.GetSettingParameter(Session, "CodeObject"); var parser = string.Format("and Update >='{0}-01-01' and Update <'{1}-01-01'", Update.Value.Year, Update.Val...

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: DocumentType  
Default: DocumentType  
Source: `GetDefaultDocumentType()`  
Logic: { return DocumentType; }

Field: DocumentType  
Default: result  
Source: `SetDefaultDocumentType()`  
Logic: { //if (DocumentType is null){ // var result = GetDefaultDocumentType(view); // if (result != null && result != DocumentType){ // DocumentType = result; // } //} }

Field: Member  
Default: = null) Member = GetDefaultMember()  
Source: `SetDefaultMember()`  
Logic: { //Code: 0965 Oid: 3aaaf203-e103-4f3a-96e2-1be38032599a if(Member == null) Member = GetDefaultMember(); }

Field: Member  
Default: Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session)  
Source: `GetDefaultMember()`  
Logic: { //Code: 0966 Oid: 0d3ac554-c7fa-41fd-976c-04f12a2ae1ce return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); }

Field: Date  
Default: GetDefaultDate()  
Source: `SetDefaultDate()`  
Logic: { //Code: 0926 Oid: 00a0ce6b-dc50-4756-95ff-302fa92a5d31 Date= GetDefaultDate(); }

Field: Date  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultDate()`  
Logic: { //Code: 0925 Oid: 0d8f4daa-b67a-43e9-96d8-ce9a1cae333e return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: LanguageOrigin  
Default: LanguageOrigin  
Source: `GetDefaultLanguageOrigin()`  
Logic: { return LanguageOrigin; }

Field: LanguageOrigin  
Default: result  
Source: `SetDefaultLanguageOrigin()`  
Logic: { //if (LanguageOrigin is null){ // var result = GetDefaultLanguageOrigin(view); // if (result != null && result != LanguageOrigin){ // LanguageOrigin = result; // } //} }

Field: LanguageTranslate  
Default: LanguageTranslate  
Source: `GetDefaultLanguageTranslate()`  
Logic: { return LanguageTranslate; }

Field: LanguageTranslate  
Default: result  
Source: `SetDefaultLanguageTranslate()`  
Logic: { //if (LanguageTranslate is null){ // var result = GetDefaultLanguageTranslate(view); // if (result != null && result != LanguageTranslate){ // LanguageTranslate = result; // } //} }

Field: Path  
Default: Path  
Source: `GetDefaultPath()`  
Logic: { return Path; }

Field: Path  
Default: result  
Source: `SetDefaultPath()`  
Logic: { //if (Path is null){ // var result = GetDefaultPath(view); // if (result != null && result != Path){ // Path = result; // } //} }

Field: Status  
Default: Status  
Source: `GetDefaultStatus()`  
Logic: { return Status; }

Field: Status  
Default: result  
Source: `SetDefaultStatus()`  
Logic: { //if (Status is null){ // var result = GetDefaultStatus(view); // if (result != null && result != Status){ // Status = result; // } //} }

Field: Note  
Default: Note  
Source: `GetDefaultNote()`  
Logic: { return Note; }

Field: Note  
Default: result  
Source: `SetDefaultNote()`  
Logic: { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} }

Field: FontColor  
Default: FontColor  
Source: `GetDefaultFontColor()`  
Logic: { return FontColor; }

Field: FontColor  
Default: result  
Source: `SetDefaultFontColor()`  
Logic: { //if (FontColor is null){ // var result = GetDefaultFontColor(view); // if (result != null && result != FontColor){ // FontColor = result; // } //} }

Field: FontBold  
Default: FontBold  
Source: `GetDefaultFontBold()`  
Logic: { return FontBold; }

Field: FontBold  
Default: result  
Source: `SetDefaultFontBold()`  
Logic: { //if (FontBold is null){ // var result = GetDefaultFontBold(view); // if (result != null && result != FontBold){ // FontBold = result; // } //} }

Field: FontItalic  
Default: FontItalic  
Source: `GetDefaultFontItalic()`  
Logic: { return FontItalic; }

Field: FontItalic  
Default: result  
Source: `SetDefaultFontItalic()`  
Logic: { //if (FontItalic is null){ // var result = GetDefaultFontItalic(view); // if (result != null && result != FontItalic){ // FontItalic = result; // } //} }

Field: FontUnderline  
Default: FontUnderline  
Source: `GetDefaultFontUnderline()`  
Logic: { return FontUnderline; }

Field: FontUnderline  
Default: result  
Source: `SetDefaultFontUnderline()`  
Logic: { //if (FontUnderline is null){ // var result = GetDefaultFontUnderline(view); // if (result != null && result != FontUnderline){ // FontUnderline = result; // } //} }

Field: Outline  
Default: Outline  
Source: `GetDefaultOutline()`  
Logic: { return Outline; }

Field: Outline  
Default: result  
Source: `SetDefaultOutline()`  
Logic: { //if (Outline is null){ // var result = GetDefaultOutline(view); // if (result != null && result != Outline){ // Outline = result; // } //} }

Field: Alignment  
Default: Alignment  
Source: `GetDefaultAlignment()`  
Logic: { return Alignment; }

Field: Alignment  
Default: result  
Source: `SetDefaultAlignment()`  
Logic: { //if (Alignment is null){ // var result = GetDefaultAlignment(view); // if (result != null && result != Alignment){ // Alignment = result; // } //} }

Field: Spacing  
Default: Spacing  
Source: `GetDefaultSpacing()`  
Logic: { return Spacing; }

Field: Spacing  
Default: result  
Source: `SetDefaultSpacing()`  
Logic: { //if (Spacing is null){ // var result = GetDefaultSpacing(view); // if (result != null && result != Spacing){ // Spacing = result; // } //} }

Field: Indent  
Default: Indent  
Source: `GetDefaultIndent()`  
Logic: { return Indent; }

Field: Indent  
Default: result  
Source: `SetDefaultIndent()`  
Logic: { //if (Indent is null){ // var result = GetDefaultIndent(view); // if (result != null && result != Indent){ // Indent = result; // } //} }

Field: NodeFontColor  
Default: NodeFontColor  
Source: `GetDefaultNodeFontColor()`  
Logic: { return NodeFontColor; }

Field: NodeFontColor  
Default: result  
Source: `SetDefaultNodeFontColor()`  
Logic: { //if (NodeFontColor is null){ // var result = GetDefaultNodeFontColor(view); // if (result != null && result != NodeFontColor){ // NodeFontColor = result; // } //} }

Field: NodeFontBold  
Default: NodeFontBold  
Source: `GetDefaultNodeFontBold()`  
Logic: { return NodeFontBold; }

Field: NodeFontBold  
Default: result  
Source: `SetDefaultNodeFontBold()`  
Logic: { //if (NodeFontBold is null){ // var result = GetDefaultNodeFontBold(view); // if (result != null && result != NodeFontBold){ // NodeFontBold = result; // } //} }

Field: NodeFontItalic  
Default: NodeFontItalic  
Source: `GetDefaultNodeFontItalic()`  
Logic: { return NodeFontItalic; }

Field: NodeFontItalic  
Default: result  
Source: `SetDefaultNodeFontItalic()`  
Logic: { //if (NodeFontItalic is null){ // var result = GetDefaultNodeFontItalic(view); // if (result != null && result != NodeFontItalic){ // NodeFontItalic = result; // } //} }

Field: NodeFontUnderline  
Default: NodeFontUnderline  
Source: `GetDefaultNodeFontUnderline()`  
Logic: { return NodeFontUnderline; }

Field: NodeFontUnderline  
Default: result  
Source: `SetDefaultNodeFontUnderline()`  
Logic: { //if (NodeFontUnderline is null){ // var result = GetDefaultNodeFontUnderline(view); // if (result != null && result != NodeFontUnderline){ // NodeFontUnderline = result; // } //} }

Field: NodeLink  
Default: NodeLink  
Source: `GetDefaultNodeLink()`  
Logic: { return NodeLink; }

Field: NodeLink  
Default: result  
Source: `SetDefaultNodeLink()`  
Logic: { //if (NodeLink is null){ // var result = GetDefaultNodeLink(view); // if (result != null && result != NodeLink){ // NodeLink = result; // } //} }

Field: NodeSuper  
Default: NodeSuper  
Source: `GetDefaultNodeSuper()`  
Logic: { return NodeSuper; }

Field: NodeSuper  
Default: result  
Source: `SetDefaultNodeSuper()`  
Logic: { //if (NodeSuper is null){ // var result = GetDefaultNodeSuper(view); // if (result != null && result != NodeSuper){ // NodeSuper = result; // } //} }

Field: UpperElementImport  
Default: UpperElementImport  
Source: `GetDefaultUpperElementImport()`  
Logic: { return UpperElementImport; }

Field: UpperElementImport  
Default: result  
Source: `SetDefaultUpperElementImport()`  
Logic: { //if (UpperElementImport is null){ // var result = GetDefaultUpperElementImport(view); // if (result != null && result != UpperElementImport){ // UpperElementImport = result; // } //} }

Field: Number  
Default: Number  
Source: `GetDefaultNumber()`  
Logic: { return Number; }

Field: Number  
Default: result  
Source: `SetDefaultNumber()`  
Logic: { //if (Number is null){ // var result = GetDefaultNumber(view); // if (result != null && result != Number){ // Number = result; // } //} }

Field: CheckSpelling  
Default: CheckSpelling  
Source: `GetDefaultCheckSpelling()`  
Logic: { return CheckSpelling; }

Field: CheckSpelling  
Default: result  
Source: `SetDefaultCheckSpelling()`  
Logic: { //if (CheckSpelling is null){ // var result = GetDefaultCheckSpelling(view); // if (result != null && result != CheckSpelling){ // CheckSpelling = result; // } //} }

Field: WithTermPosition  
Default: WithTermPosition  
Source: `GetDefaultWithTermPosition()`  
Logic: { return WithTermPosition; }

Field: WithTermPosition  
Default: result  
Source: `SetDefaultWithTermPosition()`  
Logic: { //if (WithTermPosition is null){ // var result = GetDefaultWithTermPosition(view); // if (result != null && result != WithTermPosition){ // WithTermPosition = result; // } //} }

Field: ElementSpacing  
Default: = null) ElementSpacing = GetDefaultElementSpacing()  
Source: `SetDefaultElementSpacing()`  
Logic: { //Code: 1043 Oid: dac8aa01-d3fe-4a65-ad95-5fcfb93b88c3 if(ElementSpacing == null) ElementSpacing = GetDefaultElementSpacing(); }

Field: ElementSpacing  
Default: 500  
Source: `GetDefaultElementSpacing()`  
Logic: { //Code: 1042 Oid: afc14cbf-7aef-4c77-92c8-9f3ab8653714 return 500; }

Field: BlankSpacing  
Default: BlankSpacing  
Source: `GetDefaultBlankSpacing()`  
Logic: { return BlankSpacing; }

Field: BlankSpacing  
Default: result  
Source: `SetDefaultBlankSpacing()`  
Logic: { //if (BlankSpacing is null){ // var result = GetDefaultBlankSpacing(view); // if (result != null && result != BlankSpacing){ // BlankSpacing = result; // } //} }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 0959 Oid: 35976f5e-63b8-45c0-9bce-56c38470f735 Update= GetDefaultUpdate(); }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 0961 Oid: c1cab016-e695-4d93-934b-b77f4dea224f return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: CodeUnique  
Default: CodeUnique  
Source: `GetDefaultCodeUnique()`  
Logic: { return CodeUnique; }

Field: CodeUnique  
Default: result  
Source: `SetDefaultCodeUnique()`  
Logic: { //if (CodeUnique is null){ // var result = GetDefaultCodeUnique(view); // if (result != null && result != CodeUnique){ // CodeUnique = result; // } //} }

Field: UpcaseNumbering  
Default: UpcaseNumbering  
Source: `GetDefaultUpcaseNumbering()`  
Logic: { return UpcaseNumbering; }

Field: UpcaseNumbering  
Default: result  
Source: `SetDefaultUpcaseNumbering()`  
Logic: { //if (UpcaseNumbering is null){ // var result = GetDefaultUpcaseNumbering(view); // if (result != null && result != UpcaseNumbering){ // UpcaseNumbering = result; // } //} }

Field: AbbyyTermLocation  
Default: AbbyyTermLocation  
Source: `GetDefaultAbbyyTermLocation()`  
Logic: { return AbbyyTermLocation; }

Field: AbbyyTermLocation  
Default: result  
Source: `SetDefaultAbbyyTermLocation()`  
Logic: { //if (AbbyyTermLocation is null){ // var result = GetDefaultAbbyyTermLocation(view); // if (result != null && result != AbbyyTermLocation){ // AbbyyTermLocation = result; // } //} }

Field: KeepSpace  
Default: KeepSpace  
Source: `GetDefaultKeepSpace()`  
Logic: { return KeepSpace; }

Field: KeepSpace  
Default: result  
Source: `SetDefaultKeepSpace()`  
Logic: { //if (KeepSpace is null){ // var result = GetDefaultKeepSpace(view); // if (result != null && result != KeepSpace){ // KeepSpace = result; // } //} }

Field: ImportByNode  
Default: ImportByNode  
Source: `GetDefaultImportByNode()`  
Logic: { return ImportByNode; }

Field: ImportByNode  
Default: result  
Source: `SetDefaultImportByNode()`  
Logic: { //if (ImportByNode is null){ // var result = GetDefaultImportByNode(view); // if (result != null && result != ImportByNode){ // ImportByNode = result; // } //} }

Field: ImportParagraph  
Default: ImportParagraph  
Source: `GetDefaultImportParagraph()`  
Logic: { return ImportParagraph; }

Field: ImportParagraph  
Default: result  
Source: `SetDefaultImportParagraph()`  
Logic: { //if (ImportParagraph is null){ // var result = GetDefaultImportParagraph(view); // if (result != null && result != ImportParagraph){ // ImportParagraph = result; // } //} }

Field: RightIndent  
Default: RightIndent  
Source: `GetDefaultRightIndent()`  
Logic: { return RightIndent; }

Field: RightIndent  
Default: result  
Source: `SetDefaultRightIndent()`  
Logic: { //if (RightIndent is null){ // var result = GetDefaultRightIndent(view); // if (result != null && result != RightIndent){ // RightIndent = result; // } //} }

Field: OriginStyleExport  
Default: OriginStyleExport  
Source: `GetDefaultOriginStyleExport()`  
Logic: { return OriginStyleExport; }

Field: OriginStyleExport  
Default: result  
Source: `SetDefaultOriginStyleExport()`  
Logic: { //if (OriginStyleExport is null){ // var result = GetDefaultOriginStyleExport(view); // if (result != null && result != OriginStyleExport){ // OriginStyleExport = result; // } //} }

Field: CreateWordStyle  
Default: CreateWordStyle  
Source: `GetDefaultCreateWordStyle()`  
Logic: { return CreateWordStyle; }

Field: CreateWordStyle  
Default: result  
Source: `SetDefaultCreateWordStyle()`  
Logic: { //if (CreateWordStyle is null){ // var result = GetDefaultCreateWordStyle(view); // if (result != null && result != CreateWordStyle){ // CreateWordStyle = result; // } //} }

Field: Open  
Default: Open  
Source: `GetDefaultOpen()`  
Logic: { return Open; }

Field: Open  
Default: result  
Source: `SetDefaultOpen()`  
Logic: { //if (Open is null){ // var result = GetDefaultOpen(view); // if (result != null && result != Open){ // Open = result; // } //} }

Field: Folder  
Default: Folder  
Source: `GetDefaultFolder()`  
Logic: { return Folder; }

Field: Folder  
Default: result  
Source: `SetDefaultFolder()`  
Logic: { //if (Folder is null){ // var result = GetDefaultFolder(view); // if (result != null && result != Folder){ // Folder = result; // } //} }

Field: BrLine  
Default: BrLine  
Source: `GetDefaultBrLine()`  
Logic: { return BrLine; }

Field: BrLine  
Default: result  
Source: `SetDefaultBrLine()`  
Logic: { //if (BrLine is null){ // var result = GetDefaultBrLine(view); // if (result != null && result != BrLine){ // BrLine = result; // } //} }

Field: IsPhoto  
Default: IsPhoto  
Source: `GetDefaultIsPhoto()`  
Logic: { return IsPhoto; }

Field: IsPhoto  
Default: result  
Source: `SetDefaultIsPhoto()`  
Logic: { //if (IsPhoto is null){ // var result = GetDefaultIsPhoto(view); // if (result != null && result != IsPhoto){ // IsPhoto = result; // } //} }

Field: TextObjectGroup  
Default: TextObjectGroup  
Source: `GetDefaultTextObjectGroup()`  
Logic: { return TextObjectGroup; }

Field: TextObjectGroup  
Default: result  
Source: `SetDefaultTextObjectGroup()`  
Logic: { //if (TextObjectGroup is null){ // var result = GetDefaultTextObjectGroup(view); // if (result != null && result != TextObjectGroup){ // TextObjectGroup = result; // } //} }

Field: FootNote  
Default: FootNote  
Source: `GetDefaultFootNote()`  
Logic: { return FootNote; }

Field: FootNote  
Default: result  
Source: `SetDefaultFootNote()`  
Logic: { //if (FootNote is null){ // var result = GetDefaultFootNote(view); // if (result != null && result != FootNote){ // FootNote = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 0440ImportCode base.AfterConstruction(); SetDefaultUpdate(); SetDefaultDate(); SetDefaultCode(); SetDefaultMember(); SetDefaultElementSpacing(); #endregion 0440ImportCode //SetDefaultCode(View view = null); //SetDefaultName(View...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 0960ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0960ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ...

## UI Layout

Group: (default)
- AbbyyTermLocation [Detail=false]
- Alignment [Detail=false]
- AppearanceDisableDelete
- AudioList [Detail=true]
- BlankSpacing [Detail=false]
- BrLine [Detail=false]
- CheckSpelling [Detail=false]
- CodeUnique [Detail=false]
- CreateWordStyle [Detail=false]
- ElementBatchList [Detail=true]
- ElementSpacing [Detail=false]
- FileList [Detail=true]
- Folder [Detail=false]
- FontBold [Detail=false]
- FontColor [Detail=false]
- FontItalic [Detail=false]
- FontUnderline [Detail=false]
- FootNote [Detail=false]
- ImportByNode [Detail=false]
- ImportParagraph [Detail=false]
- Indent [Detail=false]
- IsPhoto [Detail=false]
- KeepSpace [Detail=false]
- LanguageList [Detail=true]
- MediaList [Detail=true]
- NodeFontBold [Detail=false]
- NodeFontColor [Detail=false]
- NodeFontItalic [Detail=false]
- NodeFontUnderline [Detail=false]
- NodeLink [Detail=false]
- NodeSuper [Detail=false]
- Note [Detail=true]
- Number [Detail=false]
- Open [Detail=false]
- OriginStyleExport [Detail=false]
- Outline [Detail=false]
- ParagraphList [Detail=true]
- ParagraphStyleList [Detail=true]
- RightIndent [Detail=false]
- Spacing [Detail=false]
- TermList [Detail=true]
- TermLocationList [Detail=true]
- TextObjectGroup [Detail=false]
- TranslateObjectList [Detail=true]
- UpcaseNumbering [Detail=false]
- Update [Detail=false]
- UpperElementImport [Detail=false]
- WithTermPosition [Detail=false]

Group: (default)
- Code [Order=1] [Detail=true]
- Date [Order=1] [Detail=true]
- DocumentType [Order=1] [Detail=true]
- LanguageOrigin [Order=1] [Detail=true]
- LanguageTranslate [Order=1] [Detail=true]
- Member [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- Path [Order=1] [Detail=true]
- Status [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | Video | { Oid = Guid.NewGuid(); #region 0440ImportCode base.AfterConstruction(); SetDefaultUpdate(); SetDefaultDate(); SetDefaultCode(); SetDefaultMember(); SetDefaultElementSpacing(); #endregion 0440ImportCode //SetDefaultCode(View view = null); //SetDefaultName(View... |
| GetDefaultAbbyyTermLocation | Video | { return AbbyyTermLocation; } |
| GetDefaultAlignment | Video | { return Alignment; } |
| GetDefaultBlankSpacing | Video | { return BlankSpacing; } |
| GetDefaultBrLine | Video | { return BrLine; } |
| GetDefaultCheckSpelling | Video | { return CheckSpelling; } |
| GetDefaultCode | Video | { //Code: 0963 Oid: a06c5e41-3636-4e95-9d10-01cc2cc1e043 var keyCodeObject = Module.Helpers.ParameterHelper.GetSettingParameter(Session, "CodeObject"); var parser = string.Format("and Update >='{0}-01-01' and Update <'{1}-01-01'", Update.Value.Year, Update.Val... |
| GetDefaultCodeUnique | Video | { return CodeUnique; } |
| GetDefaultCreateWordStyle | Video | { return CreateWordStyle; } |
| GetDefaultDate | Video | { //Code: 0925 Oid: 0d8f4daa-b67a-43e9-96d8-ce9a1cae333e return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultDocumentType | Video | { return DocumentType; } |
| GetDefaultElementSpacing | Video | { //Code: 1042 Oid: afc14cbf-7aef-4c77-92c8-9f3ab8653714 return 500; } |
| GetDefaultFolder | Video | { return Folder; } |
| GetDefaultFontBold | Video | { return FontBold; } |
| GetDefaultFontColor | Video | { return FontColor; } |
| GetDefaultFontItalic | Video | { return FontItalic; } |
| GetDefaultFontUnderline | Video | { return FontUnderline; } |
| GetDefaultFootNote | Video | { return FootNote; } |
| GetDefaultImportByNode | Video | { return ImportByNode; } |
| GetDefaultImportParagraph | Video | { return ImportParagraph; } |
| GetDefaultIndent | Video | { return Indent; } |
| GetDefaultIsPhoto | Video | { return IsPhoto; } |
| GetDefaultKeepSpace | Video | { return KeepSpace; } |
| GetDefaultLanguageOrigin | Video | { return LanguageOrigin; } |
| GetDefaultLanguageTranslate | Video | { return LanguageTranslate; } |
| GetDefaultMember | Video | { //Code: 0966 Oid: 0d3ac554-c7fa-41fd-976c-04f12a2ae1ce return Module.Helpers.XafXpoHelper.GetCurrentUser<Member>(Session); } |
| GetDefaultName | Video | { return Name; } |
| GetDefaultNodeFontBold | Video | { return NodeFontBold; } |
| GetDefaultNodeFontColor | Video | { return NodeFontColor; } |
| GetDefaultNodeFontItalic | Video | { return NodeFontItalic; } |
| GetDefaultNodeFontUnderline | Video | { return NodeFontUnderline; } |
| GetDefaultNodeLink | Video | { return NodeLink; } |
| GetDefaultNodeSuper | Video | { return NodeSuper; } |
| GetDefaultNote | Video | { return Note; } |
| GetDefaultNumber | Video | { return Number; } |
| GetDefaultOpen | Video | { return Open; } |
| GetDefaultOriginStyleExport | Video | { return OriginStyleExport; } |
| GetDefaultOutline | Video | { return Outline; } |
| GetDefaultPath | Video | { return Path; } |
| GetDefaultRightIndent | Video | { return RightIndent; } |
| GetDefaultSpacing | Video | { return Spacing; } |
| GetDefaultStatus | Video | { return Status; } |
| GetDefaultTextObjectGroup | Video | { return TextObjectGroup; } |
| GetDefaultUpcaseNumbering | Video | { return UpcaseNumbering; } |
| GetDefaultUpdate | Video | { //Code: 0961 Oid: c1cab016-e695-4d93-934b-b77f4dea224f return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| GetDefaultUpperElementImport | Video | { return UpperElementImport; } |
| GetDefaultWithTermPosition | Video | { return WithTermPosition; } |
| OnLoaded | Video | { base.OnLoaded(); } |
| OnSaving | Video | { #region 0960ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0960ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ... |
| SetDefaultAbbyyTermLocation | Video | { //if (AbbyyTermLocation is null){ // var result = GetDefaultAbbyyTermLocation(view); // if (result != null && result != AbbyyTermLocation){ // AbbyyTermLocation = result; // } //} } |
| SetDefaultAlignment | Video | { //if (Alignment is null){ // var result = GetDefaultAlignment(view); // if (result != null && result != Alignment){ // Alignment = result; // } //} } |
| SetDefaultBlankSpacing | Video | { //if (BlankSpacing is null){ // var result = GetDefaultBlankSpacing(view); // if (result != null && result != BlankSpacing){ // BlankSpacing = result; // } //} } |
| SetDefaultBrLine | Video | { //if (BrLine is null){ // var result = GetDefaultBrLine(view); // if (result != null && result != BrLine){ // BrLine = result; // } //} } |
| SetDefaultCheckSpelling | Video | { //if (CheckSpelling is null){ // var result = GetDefaultCheckSpelling(view); // if (result != null && result != CheckSpelling){ // CheckSpelling = result; // } //} } |
| SetDefaultCode | Video | { //Code: 0964 Oid: 518b400b-102b-453a-a004-02e71f17adb9 if(String.IsNullOrEmpty(Code)) Code = GetDefaultCode(); } |
| SetDefaultCodeUnique | Video | { //if (CodeUnique is null){ // var result = GetDefaultCodeUnique(view); // if (result != null && result != CodeUnique){ // CodeUnique = result; // } //} } |
| SetDefaultCreateWordStyle | Video | { //if (CreateWordStyle is null){ // var result = GetDefaultCreateWordStyle(view); // if (result != null && result != CreateWordStyle){ // CreateWordStyle = result; // } //} } |
| SetDefaultDate | Video | { //Code: 0926 Oid: 00a0ce6b-dc50-4756-95ff-302fa92a5d31 Date= GetDefaultDate(); } |
| SetDefaultDocumentType | Video | { //if (DocumentType is null){ // var result = GetDefaultDocumentType(view); // if (result != null && result != DocumentType){ // DocumentType = result; // } //} } |
| SetDefaultElementSpacing | Video | { //Code: 1043 Oid: dac8aa01-d3fe-4a65-ad95-5fcfb93b88c3 if(ElementSpacing == null) ElementSpacing = GetDefaultElementSpacing(); } |
| SetDefaultFolder | Video | { //if (Folder is null){ // var result = GetDefaultFolder(view); // if (result != null && result != Folder){ // Folder = result; // } //} } |
| SetDefaultFontBold | Video | { //if (FontBold is null){ // var result = GetDefaultFontBold(view); // if (result != null && result != FontBold){ // FontBold = result; // } //} } |
| SetDefaultFontColor | Video | { //if (FontColor is null){ // var result = GetDefaultFontColor(view); // if (result != null && result != FontColor){ // FontColor = result; // } //} } |
| SetDefaultFontItalic | Video | { //if (FontItalic is null){ // var result = GetDefaultFontItalic(view); // if (result != null && result != FontItalic){ // FontItalic = result; // } //} } |
| SetDefaultFontUnderline | Video | { //if (FontUnderline is null){ // var result = GetDefaultFontUnderline(view); // if (result != null && result != FontUnderline){ // FontUnderline = result; // } //} } |
| SetDefaultFootNote | Video | { //if (FootNote is null){ // var result = GetDefaultFootNote(view); // if (result != null && result != FootNote){ // FootNote = result; // } //} } |
| SetDefaultImportByNode | Video | { //if (ImportByNode is null){ // var result = GetDefaultImportByNode(view); // if (result != null && result != ImportByNode){ // ImportByNode = result; // } //} } |
| SetDefaultImportParagraph | Video | { //if (ImportParagraph is null){ // var result = GetDefaultImportParagraph(view); // if (result != null && result != ImportParagraph){ // ImportParagraph = result; // } //} } |
| SetDefaultIndent | Video | { //if (Indent is null){ // var result = GetDefaultIndent(view); // if (result != null && result != Indent){ // Indent = result; // } //} } |
| SetDefaultIsPhoto | Video | { //if (IsPhoto is null){ // var result = GetDefaultIsPhoto(view); // if (result != null && result != IsPhoto){ // IsPhoto = result; // } //} } |
| SetDefaultKeepSpace | Video | { //if (KeepSpace is null){ // var result = GetDefaultKeepSpace(view); // if (result != null && result != KeepSpace){ // KeepSpace = result; // } //} } |
| SetDefaultLanguageOrigin | Video | { //if (LanguageOrigin is null){ // var result = GetDefaultLanguageOrigin(view); // if (result != null && result != LanguageOrigin){ // LanguageOrigin = result; // } //} } |
| SetDefaultLanguageTranslate | Video | { //if (LanguageTranslate is null){ // var result = GetDefaultLanguageTranslate(view); // if (result != null && result != LanguageTranslate){ // LanguageTranslate = result; // } //} } |
| SetDefaultMember | Video | { //Code: 0965 Oid: 3aaaf203-e103-4f3a-96e2-1be38032599a if(Member == null) Member = GetDefaultMember(); } |
| SetDefaultName | Video | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultNodeFontBold | Video | { //if (NodeFontBold is null){ // var result = GetDefaultNodeFontBold(view); // if (result != null && result != NodeFontBold){ // NodeFontBold = result; // } //} } |
| SetDefaultNodeFontColor | Video | { //if (NodeFontColor is null){ // var result = GetDefaultNodeFontColor(view); // if (result != null && result != NodeFontColor){ // NodeFontColor = result; // } //} } |
| SetDefaultNodeFontItalic | Video | { //if (NodeFontItalic is null){ // var result = GetDefaultNodeFontItalic(view); // if (result != null && result != NodeFontItalic){ // NodeFontItalic = result; // } //} } |
| SetDefaultNodeFontUnderline | Video | { //if (NodeFontUnderline is null){ // var result = GetDefaultNodeFontUnderline(view); // if (result != null && result != NodeFontUnderline){ // NodeFontUnderline = result; // } //} } |
| SetDefaultNodeLink | Video | { //if (NodeLink is null){ // var result = GetDefaultNodeLink(view); // if (result != null && result != NodeLink){ // NodeLink = result; // } //} } |
| SetDefaultNodeSuper | Video | { //if (NodeSuper is null){ // var result = GetDefaultNodeSuper(view); // if (result != null && result != NodeSuper){ // NodeSuper = result; // } //} } |
| SetDefaultNote | Video | { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} } |
| SetDefaultNumber | Video | { //if (Number is null){ // var result = GetDefaultNumber(view); // if (result != null && result != Number){ // Number = result; // } //} } |
| SetDefaultOpen | Video | { //if (Open is null){ // var result = GetDefaultOpen(view); // if (result != null && result != Open){ // Open = result; // } //} } |
| SetDefaultOriginStyleExport | Video | { //if (OriginStyleExport is null){ // var result = GetDefaultOriginStyleExport(view); // if (result != null && result != OriginStyleExport){ // OriginStyleExport = result; // } //} } |
| SetDefaultOutline | Video | { //if (Outline is null){ // var result = GetDefaultOutline(view); // if (result != null && result != Outline){ // Outline = result; // } //} } |
| SetDefaultPath | Video | { //if (Path is null){ // var result = GetDefaultPath(view); // if (result != null && result != Path){ // Path = result; // } //} } |
| SetDefaultRightIndent | Video | { //if (RightIndent is null){ // var result = GetDefaultRightIndent(view); // if (result != null && result != RightIndent){ // RightIndent = result; // } //} } |
| SetDefaultSpacing | Video | { //if (Spacing is null){ // var result = GetDefaultSpacing(view); // if (result != null && result != Spacing){ // Spacing = result; // } //} } |
| SetDefaultStatus | Video | { //if (Status is null){ // var result = GetDefaultStatus(view); // if (result != null && result != Status){ // Status = result; // } //} } |
| SetDefaultTextObjectGroup | Video | { //if (TextObjectGroup is null){ // var result = GetDefaultTextObjectGroup(view); // if (result != null && result != TextObjectGroup){ // TextObjectGroup = result; // } //} } |
| SetDefaultUpcaseNumbering | Video | { //if (UpcaseNumbering is null){ // var result = GetDefaultUpcaseNumbering(view); // if (result != null && result != UpcaseNumbering){ // UpcaseNumbering = result; // } //} } |
| SetDefaultUpdate | Video | { //Code: 0959 Oid: 35976f5e-63b8-45c0-9bce-56c38470f735 Update= GetDefaultUpdate(); } |
| SetDefaultUpperElementImport | Video | { //if (UpperElementImport is null){ // var result = GetDefaultUpperElementImport(view); // if (result != null && result != UpperElementImport){ // UpperElementImport = result; // } //} } |
| SetDefaultWithTermPosition | Video | { //if (WithTermPosition is null){ // var result = GetDefaultWithTermPosition(view); // if (result != null && result != WithTermPosition){ // WithTermPosition = result; // } //} } |

---

# Entity: Voice

Caption entity: `Giọng đọc`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | false | true |   | 1 |
| Code | string | Mã | Yes | GetDefaultCode: Code<br>SetDefaultCode: result | true | true |   | 1 |
| Gender | Gender | Giới tính | No | GetDefaultGender: Gender<br>SetDefaultGender: result | true | true |   | 1 |
| Template | DevExpress.Persistent.BaseImpl.FileData | Mẫu | No | GetDefaultTemplate: Template<br>SetDefaultTemplate: result | false | true |   | 1 |
| Language | Module.BusinessObjects.Language | Ngôn ngữ | No | GetDefaultLanguage: Language<br>SetDefaultLanguage: result | true | true |   | 1 |
| Note | string | Ghi chú | No | GetDefaultNote: Note<br>SetDefaultNote: result | true | true |   | 1 |
| VowelSpeed | decimal | Tốc độ | No | GetDefaultVowelSpeed: VowelSpeed<br>SetDefaultVowelSpeed: result | false | false |  |  |
| SpeelingMinutes | decimal? | Âm phút | No | GetDefaultSpeelingMinutes: SpeelingMinutes<br>SetDefaultSpeelingMinutes: result | false | false |  |  |
| DataService | Module.BusinessObjects.DataService | Dịch vụ Dữ liệu | No | GetDefaultDataService: DataService<br>SetDefaultDataService: result | false | false |  |  |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: Code  
Default: Code  
Source: `GetDefaultCode()`  
Logic: { return Code; }

Field: Code  
Default: result  
Source: `SetDefaultCode()`  
Logic: { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} }

Field: Gender  
Default: Gender  
Source: `GetDefaultGender()`  
Logic: { return Gender; }

Field: Gender  
Default: result  
Source: `SetDefaultGender()`  
Logic: { //if (Gender is null){ // var result = GetDefaultGender(view); // if (result != null && result != Gender){ // Gender = result; // } //} }

Field: Template  
Default: Template  
Source: `GetDefaultTemplate()`  
Logic: { return Template; }

Field: Template  
Default: result  
Source: `SetDefaultTemplate()`  
Logic: { //if (Template is null){ // var result = GetDefaultTemplate(view); // if (result != null && result != Template){ // Template = result; // } //} }

Field: Language  
Default: Language  
Source: `GetDefaultLanguage()`  
Logic: { return Language; }

Field: Language  
Default: result  
Source: `SetDefaultLanguage()`  
Logic: { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} }

Field: Note  
Default: Note  
Source: `GetDefaultNote()`  
Logic: { return Note; }

Field: Note  
Default: result  
Source: `SetDefaultNote()`  
Logic: { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} }

Field: VowelSpeed  
Default: VowelSpeed  
Source: `GetDefaultVowelSpeed()`  
Logic: { return VowelSpeed; }

Field: VowelSpeed  
Default: result  
Source: `SetDefaultVowelSpeed()`  
Logic: { //if (VowelSpeed is null){ // var result = GetDefaultVowelSpeed(view); // if (result != null && result != VowelSpeed){ // VowelSpeed = result; // } //} }

Field: SpeelingMinutes  
Default: SpeelingMinutes  
Source: `GetDefaultSpeelingMinutes()`  
Logic: { return SpeelingMinutes; }

Field: SpeelingMinutes  
Default: result  
Source: `SetDefaultSpeelingMinutes()`  
Logic: { //if (SpeelingMinutes is null){ // var result = GetDefaultSpeelingMinutes(view); // if (result != null && result != SpeelingMinutes){ // SpeelingMinutes = result; // } //} }

Field: DataService  
Default: DataService  
Source: `GetDefaultDataService()`  
Logic: { return DataService; }

Field: DataService  
Default: result  
Source: `SetDefaultDataService()`  
Logic: { //if (DataService is null){ // var result = GetDefaultDataService(view); // if (result != null && result != DataService){ // DataService = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 0572ImportCode base.AfterConstruction(); VowelSpeed = 1; #endregion 0572ImportCode //SetDefaultName(View view = null); //SetDefaultCode(View view = null); //SetDefaultGender(View view = null); //SetDefaultTemplate(View view = nu...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete
- DataService [Detail=false]
- SpeelingMinutes [Detail=false]
- VowelSpeed [Detail=false]

Group: (default)
- Code [Order=1] [Detail=true]
- Gender [Order=1] [Detail=true]
- Language [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- Note [Order=1] [Detail=true]
- Template [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | Voice | { Oid = Guid.NewGuid(); #region 0572ImportCode base.AfterConstruction(); VowelSpeed = 1; #endregion 0572ImportCode //SetDefaultName(View view = null); //SetDefaultCode(View view = null); //SetDefaultGender(View view = null); //SetDefaultTemplate(View view = nu... |
| GetDefaultCode | Voice | { return Code; } |
| GetDefaultDataService | Voice | { return DataService; } |
| GetDefaultGender | Voice | { return Gender; } |
| GetDefaultLanguage | Voice | { return Language; } |
| GetDefaultName | Voice | { return Name; } |
| GetDefaultNote | Voice | { return Note; } |
| GetDefaultSpeelingMinutes | Voice | { return SpeelingMinutes; } |
| GetDefaultTemplate | Voice | { return Template; } |
| GetDefaultVowelSpeed | Voice | { return VowelSpeed; } |
| OnLoaded | Voice | { base.OnLoaded(); } |
| OnSaving | Voice | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultCode | Voice | { //if (Code is null){ // var result = GetDefaultCode(view); // if (result != null && result != Code){ // Code = result; // } //} } |
| SetDefaultDataService | Voice | { //if (DataService is null){ // var result = GetDefaultDataService(view); // if (result != null && result != DataService){ // DataService = result; // } //} } |
| SetDefaultGender | Voice | { //if (Gender is null){ // var result = GetDefaultGender(view); // if (result != null && result != Gender){ // Gender = result; // } //} } |
| SetDefaultLanguage | Voice | { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} } |
| SetDefaultName | Voice | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultNote | Voice | { //if (Note is null){ // var result = GetDefaultNote(view); // if (result != null && result != Note){ // Note = result; // } //} } |
| SetDefaultSpeelingMinutes | Voice | { //if (SpeelingMinutes is null){ // var result = GetDefaultSpeelingMinutes(view); // if (result != null && result != SpeelingMinutes){ // SpeelingMinutes = result; // } //} } |
| SetDefaultTemplate | Voice | { //if (Template is null){ // var result = GetDefaultTemplate(view); // if (result != null && result != Template){ // Template = result; // } //} } |
| SetDefaultVowelSpeed | Voice | { //if (VowelSpeed is null){ // var result = GetDefaultVowelSpeed(view); // if (result != null && result != VowelSpeed){ // VowelSpeed = result; // } //} } |

---

# Entity: WebExtractor

Caption entity: `Trích Web`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| URL | string | Trang web | Yes | GetDefaultURL: URL<br>SetDefaultURL: result | true | true |   | 1 |
| Name | string | Nội dung | Yes | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| SystemType | System.Type | Kiểu hệ thống | No | GetDefaultSystemType: SystemType<br>SetDefaultSystemType: result | true | true |   | 1 |
| ConnectTimeOut | int | Thời gian đợi | No | GetDefaultConnectTimeOut: 20<br>SetDefaultConnectTimeOut: = 0) ConnectTimeOut = GetDefaultConnectTimeOut() | true | true |   | 1 |
| Automatic | bool | Tự động | No | GetDefaultAutomatic: Automatic<br>SetDefaultAutomatic: result | false | true |   | 1 |
| Repeat | bool | Lặp lại | No | GetDefaultRepeat: Repeat<br>SetDefaultRepeat: result | false | true |   | 1 |
| Addresses | string | Danh sách | No | GetDefaultAddresses: Addresses<br>SetDefaultAddresses: result | false | true |  |  |
| Update | DateTime | Cập nhật | No | SetDefaultUpdate: GetDefaultUpdate()<br>GetDefaultUpdate: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null) | true | false |  |  |
| Start | int | Bắt đầu | No | GetDefaultStart: Start<br>SetDefaultStart: result | false | false |  |  |
| End | int | Kết thúc | No | GetDefaultEnd: End<br>SetDefaultEnd: result | false | false |  |  |
| Display | bool |  | No |  |  |  |  |  |

## Default Logic

Field: URL  
Default: URL  
Source: `GetDefaultURL()`  
Logic: { return URL; }

Field: URL  
Default: result  
Source: `SetDefaultURL()`  
Logic: { //if (URL is null){ // var result = GetDefaultURL(view); // if (result != null && result != URL){ // URL = result; // } //} }

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: SystemType  
Default: SystemType  
Source: `GetDefaultSystemType()`  
Logic: { return SystemType; }

Field: SystemType  
Default: result  
Source: `SetDefaultSystemType()`  
Logic: { //if (SystemType is null){ // var result = GetDefaultSystemType(view); // if (result != null && result != SystemType){ // SystemType = result; // } //} }

Field: ConnectTimeOut  
Default: 20  
Source: `GetDefaultConnectTimeOut()`  
Logic: { //Code: 0033 Oid: 80ac292f-b470-4061-a4f3-e7b351b40aa5 return 20; }

Field: ConnectTimeOut  
Default: = 0) ConnectTimeOut = GetDefaultConnectTimeOut()  
Source: `SetDefaultConnectTimeOut()`  
Logic: { //Code: 0038 Oid: 17237acf-6f7b-4213-834a-1ddd11fdab95 if(ConnectTimeOut == 0) ConnectTimeOut = GetDefaultConnectTimeOut(); }

Field: Automatic  
Default: Automatic  
Source: `GetDefaultAutomatic()`  
Logic: { return Automatic; }

Field: Automatic  
Default: result  
Source: `SetDefaultAutomatic()`  
Logic: { //if (Automatic is null){ // var result = GetDefaultAutomatic(view); // if (result != null && result != Automatic){ // Automatic = result; // } //} }

Field: Repeat  
Default: Repeat  
Source: `GetDefaultRepeat()`  
Logic: { return Repeat; }

Field: Repeat  
Default: result  
Source: `SetDefaultRepeat()`  
Logic: { //if (Repeat is null){ // var result = GetDefaultRepeat(view); // if (result != null && result != Repeat){ // Repeat = result; // } //} }

Field: Addresses  
Default: Addresses  
Source: `GetDefaultAddresses()`  
Logic: { return Addresses; }

Field: Addresses  
Default: result  
Source: `SetDefaultAddresses()`  
Logic: { //if (Addresses is null){ // var result = GetDefaultAddresses(view); // if (result != null && result != Addresses){ // Addresses = result; // } //} }

Field: Update  
Default: GetDefaultUpdate()  
Source: `SetDefaultUpdate()`  
Logic: { //Code: 0039 Oid: 846312c2-b879-482d-8862-c72d74941769 Update = GetDefaultUpdate(); }

Field: Update  
Default: (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null)  
Source: `GetDefaultUpdate()`  
Logic: { //Code: 0079 Oid: aadb2ebe-4582-47bf-9634-5a8375af5b57 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); }

Field: Start  
Default: Start  
Source: `GetDefaultStart()`  
Logic: { return Start; }

Field: Start  
Default: result  
Source: `SetDefaultStart()`  
Logic: { //if (Start is null){ // var result = GetDefaultStart(view); // if (result != null && result != Start){ // Start = result; // } //} }

Field: End  
Default: End  
Source: `GetDefaultEnd()`  
Logic: { return End; }

Field: End  
Default: result  
Source: `SetDefaultEnd()`  
Logic: { //if (End is null){ // var result = GetDefaultEnd(view); // if (result != null && result != End){ // End = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); #region 0392ImportCode base.AfterConstruction(); SetDefaultConnectTimeOut(); SetDefaultUpdate(); #endregion 0392ImportCode Display = true; //SetDefaultURL(View view = null); //SetDefaultName(View view = null); //SetDefaultSystemType(Vie...

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { #region 0516ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0516ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ...

## UI Layout

Group: (default)
- Addresses [Detail=true]
- AppearanceDisableDelete
- Display
- End [Detail=false]
- Start [Detail=false]
- Update [Detail=false]

Group: (default)
- Automatic [Order=1] [Detail=true]
- ConnectTimeOut [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- Repeat [Order=1] [Detail=true]
- SystemType [Order=1] [Detail=true]
- URL [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | WebExtractor | { Oid = Guid.NewGuid(); #region 0392ImportCode base.AfterConstruction(); SetDefaultConnectTimeOut(); SetDefaultUpdate(); #endregion 0392ImportCode Display = true; //SetDefaultURL(View view = null); //SetDefaultName(View view = null); //SetDefaultSystemType(Vie... |
| GetDefaultAddresses | WebExtractor | { return Addresses; } |
| GetDefaultAutomatic | WebExtractor | { return Automatic; } |
| GetDefaultConnectTimeOut | WebExtractor | { //Code: 0033 Oid: 80ac292f-b470-4061-a4f3-e7b351b40aa5 return 20; } |
| GetDefaultEnd | WebExtractor | { return End; } |
| GetDefaultName | WebExtractor | { return Name; } |
| GetDefaultRepeat | WebExtractor | { return Repeat; } |
| GetDefaultStart | WebExtractor | { return Start; } |
| GetDefaultSystemType | WebExtractor | { return SystemType; } |
| GetDefaultURL | WebExtractor | { return URL; } |
| GetDefaultUpdate | WebExtractor | { //Code: 0079 Oid: aadb2ebe-4582-47bf-9634-5a8375af5b57 return (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); } |
| OnLoaded | WebExtractor | { base.OnLoaded(); } |
| OnSaving | WebExtractor | { #region 0516ImportCode base.OnSaving(); SetDefaultUpdate(); #endregion 0516ImportCode // Update = (DateTime)Session.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer ... |
| SetDefaultAddresses | WebExtractor | { //if (Addresses is null){ // var result = GetDefaultAddresses(view); // if (result != null && result != Addresses){ // Addresses = result; // } //} } |
| SetDefaultAutomatic | WebExtractor | { //if (Automatic is null){ // var result = GetDefaultAutomatic(view); // if (result != null && result != Automatic){ // Automatic = result; // } //} } |
| SetDefaultConnectTimeOut | WebExtractor | { //Code: 0038 Oid: 17237acf-6f7b-4213-834a-1ddd11fdab95 if(ConnectTimeOut == 0) ConnectTimeOut = GetDefaultConnectTimeOut(); } |
| SetDefaultEnd | WebExtractor | { //if (End is null){ // var result = GetDefaultEnd(view); // if (result != null && result != End){ // End = result; // } //} } |
| SetDefaultName | WebExtractor | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultRepeat | WebExtractor | { //if (Repeat is null){ // var result = GetDefaultRepeat(view); // if (result != null && result != Repeat){ // Repeat = result; // } //} } |
| SetDefaultStart | WebExtractor | { //if (Start is null){ // var result = GetDefaultStart(view); // if (result != null && result != Start){ // Start = result; // } //} } |
| SetDefaultSystemType | WebExtractor | { //if (SystemType is null){ // var result = GetDefaultSystemType(view); // if (result != null && result != SystemType){ // SystemType = result; // } //} } |
| SetDefaultURL | WebExtractor | { //if (URL is null){ // var result = GetDefaultURL(view); // if (result != null && result != URL){ // URL = result; // } //} } |
| SetDefaultUpdate | WebExtractor | { //Code: 0039 Oid: 846312c2-b879-482d-8862-c72d74941769 Update = GetDefaultUpdate(); } |

---

# Entity: Word

Caption entity: `Từ vựng`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |
| NoSignWord | string | Không dấu | No | GetDefaultNoSignWord: NoSignWord<br>SetDefaultNoSignWord: result | true | true |   | 1 |
| Language | Module.BusinessObjects.Language | Ngôn ngữ | No | GetDefaultLanguage: Language<br>SetDefaultLanguage: result | true | true |   | 1 |
| WordQuantity | int? | Số từ | No | GetDefaultWordQuantity: WordQuantity<br>SetDefaultWordQuantity: result | true | true |   | 1 |
| Length | int? | Ký tự | No | GetDefaultLength: Name.Length<br>SetDefaultLength: GetDefaultLength() | false | true |   | 1 |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Field: NoSignWord  
Default: NoSignWord  
Source: `GetDefaultNoSignWord()`  
Logic: { return NoSignWord; }

Field: NoSignWord  
Default: result  
Source: `SetDefaultNoSignWord()`  
Logic: { //if (NoSignWord is null){ // var result = GetDefaultNoSignWord(view); // if (result != null && result != NoSignWord){ // NoSignWord = result; // } //} }

Field: Language  
Default: Language  
Source: `GetDefaultLanguage()`  
Logic: { return Language; }

Field: Language  
Default: result  
Source: `SetDefaultLanguage()`  
Logic: { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} }

Field: WordQuantity  
Default: WordQuantity  
Source: `GetDefaultWordQuantity()`  
Logic: { return WordQuantity; }

Field: WordQuantity  
Default: result  
Source: `SetDefaultWordQuantity()`  
Logic: { //if (WordQuantity is null){ // var result = GetDefaultWordQuantity(view); // if (result != null && result != WordQuantity){ // WordQuantity = result; // } //} }

Field: Length  
Default: Name.Length  
Source: `GetDefaultLength()`  
Logic: { //Code: 1567 Oid: c595d1b3-8f44-48bc-9bae-a18258468247 if (!string.IsNullOrEmpty(Name)) return Name.Length; return null; }

Field: Length  
Default: GetDefaultLength()  
Source: `SetDefaultLength()`  
Logic: { //Code: 1568 Oid: c3ab1941-f7f9-440f-b427-f8a1ed8501ef Length = GetDefaultLength(); }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultNoSignWord(View view = null); //SetDefaultLanguage(View view = null); //SetDefaultWordQuantity(View view = null); //SetDefaultLength(View view = null); }

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete

Group: (default)
- Language [Order=1] [Detail=true]
- Length [Order=1] [Detail=true]
- Name [Order=1] [Detail=true]
- NoSignWord [Order=1] [Detail=true]
- WordQuantity [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | Word | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); //SetDefaultNoSignWord(View view = null); //SetDefaultLanguage(View view = null); //SetDefaultWordQuantity(View view = null); //SetDefaultLength(View view = null); } |
| GetDefaultLanguage | Word | { return Language; } |
| GetDefaultLength | Word | { //Code: 1567 Oid: c595d1b3-8f44-48bc-9bae-a18258468247 if (!string.IsNullOrEmpty(Name)) return Name.Length; return null; } |
| GetDefaultName | Word | { return Name; } |
| GetDefaultNoSignWord | Word | { return NoSignWord; } |
| GetDefaultWordQuantity | Word | { return WordQuantity; } |
| OnLoaded | Word | { base.OnLoaded(); } |
| OnSaving | Word | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultLanguage | Word | { //if (Language is null){ // var result = GetDefaultLanguage(view); // if (result != null && result != Language){ // Language = result; // } //} } |
| SetDefaultLength | Word | { //Code: 1568 Oid: c3ab1941-f7f9-440f-b427-f8a1ed8501ef Length = GetDefaultLength(); } |
| SetDefaultName | Word | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |
| SetDefaultNoSignWord | Word | { //if (NoSignWord is null){ // var result = GetDefaultNoSignWord(view); // if (result != null && result != NoSignWord){ // NoSignWord = result; // } //} } |
| SetDefaultWordQuantity | Word | { //if (WordQuantity is null){ // var result = GetDefaultWordQuantity(view); // if (result != null && result != WordQuantity){ // WordQuantity = result; // } //} } |

---

# Entity: WordNoSign

Caption entity: `Từ không dấu`

## Fields

| Field | Type | Caption | Required | DefaultValue | VisibleInList | VisibleInDetail | UIGroup | Order |
|---|---|---|---|---|---|---|---|---|
| AppearanceDisableDelete | bool |  | No |  |  |  |  |  |
| Name | string | Tên | No | GetDefaultName: Name<br>SetDefaultName: result | true | true |   | 1 |

## Default Logic

Field: Name  
Default: Name  
Source: `GetDefaultName()`  
Logic: { return Name; }

Field: Name  
Default: result  
Source: `SetDefaultName()`  
Logic: { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} }

Lifecycle: AfterConstruction  
Logic: { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); }

Lifecycle: OnLoaded  
Logic: { base.OnLoaded(); }

Lifecycle: OnSaving  
Logic: { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De...

## UI Layout

Group: (default)
- AppearanceDisableDelete

Group: (default)
- Name [Order=1] [Detail=true]

## Method Discovery

| MethodName | Entity | Logic m? t? ng?n |
|---|---|---|
| AfterConstruction | WordNoSign | { Oid = Guid.NewGuid(); base.AfterConstruction(); //SetDefaultName(View view = null); } |
| GetDefaultName | WordNoSign | { return Name; } |
| OnLoaded | WordNoSign | { base.OnLoaded(); } |
| OnSaving | WordNoSign | { base.OnSaving(); if (!(Session is NestedUnitOfWork)&& (Session.DataLayer != null)) { // if (Session.ObjectLayer is DevExpress.ExpressApp.Security.ClientServer.SecuredSessionObjectLayer) // { // //Khi đang mở Object // } // else if ((Session.ObjectLayer is De... |
| SetDefaultName | WordNoSign | { //if (Name is null){ // var result = GetDefaultName(view); // if (result != null && result != Name){ // Name = result; // } //} } |

---
