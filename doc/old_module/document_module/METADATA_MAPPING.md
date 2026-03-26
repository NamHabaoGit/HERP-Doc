# Entity Mapping

| Old Entity | New Entity | Status | Notes |
|---|---|---|---|
| ApplicationUserLoginInfo | ApplicationUserLoginInfo | OK | `HERP.Base.Security.ApplicationUserLoginInfo` |
| Audio | Element | OK | Rename từ `Audio` sang `Element` |
| BatchTranslate | BatchTranslate | OK | Cùng domain |
| BookMark | BookMark | OK | Cùng domain |
| Concept | - | NOT_FOUND | Không có entity tương ứng |
| CorrectionOption | CorrectionOption | OK | Cùng workflow correction |
| DataService | DataService | OK | Cùng domain cấu hình service |
| DataServiceLog | - | NOT_FOUND | Chưa có persistent log entity |
| DataServiceParameter | DataServiceParameter | OK | Cùng domain |
| Dictionary | Dictionary | OK | Cùng domain |
| DictionaryWord | DictionaryWord | OK | Cùng domain |
| ElementBatch | ElementBatch | OK | Cùng domain |
| ElementTranslate | ElementTranslate | OK | Cùng domain |
| ExceptionWord | - | NOT_FOUND | Không có entity tương ứng |
| Folder | Folder | OK | Cùng domain |
| GoogleBucket | - | NOT_FOUND | Không có entity tương ứng |
| GoogleKey | - | NOT_FOUND | Không có entity tương ứng |
| GradeSubject | - | NOT_FOUND | Ngoài phạm vi domain HERP hiện tại |
| Language | Language | OK | Cùng domain |
| LanguageSpelling | LanguageSpelling | OK | Cùng domain |
| Match | - | NOT_FOUND | Ngoài phạm vi domain HERP hiện tại |
| Media | Media | OK | Cùng domain |
| Member | - | NOT_FOUND | Không có entity tương ứng |
| MemberDataService | - | NOT_FOUND | Không có entity tương ứng |
| ObjectRelation | ObjectRelation | OK | Cùng domain |
| Paragraph | Paragraph | OK | Cùng domain |
| ParagraphStyle | ParagraphStyle | OK | Cùng domain |
| Parameter | UserSetting / SystemSetting | AMBIGUOUS | Gần nhất về semantics setting, không phải 1-1 |
| Player | - | NOT_FOUND | Ngoài phạm vi domain HERP hiện tại |
| Post | - | NOT_FOUND | Không có entity XAF tương ứng |
| Product | Product | AMBIGUOUS | Map sang `HERP.MasterData.BusinessObjects.Product` cho tập field rút gọn |
| PublicEvent | - | NOT_FOUND | Ngoài phạm vi domain HERP hiện tại |
| SeparateAudio | - | NOT_FOUND | Không có entity riêng, logic nên nằm ở service |
| SoftwareServiceType | SoftwareServiceType | OK | Cùng domain |
| SpellingWord | SpellingWord | OK | Cùng domain |
| Term | Term | OK | Cùng domain |
| TermCorrection | TermCorrection | OK | Cùng domain |
| TermLocation | TermLocation | OK | Cùng domain |
| TermLocationCorrection | TermLocationCorrection | OK | Cùng domain |
| TournamentSeason | - | NOT_FOUND | Ngoài phạm vi domain HERP hiện tại |
| TranslateObject | TranslateObject | OK | Cùng domain |
| TranslateWord | TranslateWord | OK | Cùng domain |
| Video | Video | OK | Cùng aggregate root |
| Voice | Voice | OK | Cùng domain |
| WebExtractor | - | NOT_FOUND | Không có entity extractor riêng |
| Word | Word | OK | Cùng domain |
| WordNoSign | WordNoSign | OK | Cùng domain |

---

# Field Mapping

## Entity: Audio -> Element

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Start | StartTime | TimeSpan? | OK |
| End | EndTime | TimeSpan? | OK |
| Voice | Voice | reference | OK |
| Content | SourceText | string | OK |
| Subtitle | TranslatedText | string | OK |
| ElementTranslateList | Translations | collection | OK |
| Video | Video | reference | OK |
| Update | ModifiedOnUtc | DateTime? | OK |
| Note | Notes | string | OK |
| Order | Sequence | int | OK |
| Paragraph | Paragraph | reference | OK |
| LanguageTranslate | Language | reference | AMBIGUOUS |

## Entity: BatchTranslate

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Language | TargetLanguage | reference | OK |
| Content | PromptPayload | string | OK |
| Translate | ResultPayload | string | OK |
| ElementBatch | ElementBatch | reference | OK |

## Entity: BookMark

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Name | Name | string | OK |
| URL | SourceUrl | string | OK |
| Note | Description | string | OK |
| Update | ModifiedOnUtc | DateTime? | OK |
| Folder | Folder | reference | OK |
| Code | Code | string | OK |
| CreatedDate | CreatedOnUtc | DateTime | OK |
| Updater | ModifiedByName | string | AMBIGUOUS |

## Entity: CorrectionOption

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Name | ProposedValue | string | AMBIGUOUS |
| TermLocationCorrection | TermCorrection | reference | AMBIGUOUS |

## Entity: DataService

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Code | Code | string | OK |
| Name | Name | string | OK |
| Address | Endpoint | string | OK |
| DataServiceParameterList | Parameters | collection | OK |
| SoftwareServiceType | SoftwareServiceType | reference | OK |
| Update | ModifiedOnUtc | DateTime? | OK |
| InActive | IsEnabled | bool | AMBIGUOUS |

## Entity: DataServiceParameter

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Name | Name | string | OK |
| Value | Value | string | OK |
| DataService | DataService | reference | OK |
| Note | Description | string | OK |
| InActive | IsSecret | bool | AMBIGUOUS |

## Entity: Dictionary

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Name | Name | string | OK |
| DictionaryWordList | Words | collection | OK |
| Update | ModifiedOnUtc | DateTime? | OK |
| Symbol | Code | string | AMBIGUOUS |

## Entity: DictionaryWord

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Name | Name | string | OK |
| Dictionary | Dictionary | reference | OK |
| TranslateWordList | Translations | collection | OK |
| NoSignWord | Word.NormalizedValue | string | AMBIGUOUS |
| LanguageOrigin | Word.Language | reference | AMBIGUOUS |
| Creator | CreatedByName | string | AMBIGUOUS |
| Update | ModifiedOnUtc | DateTime? | OK |

## Entity: ElementBatch

| Old Field | New Property | Type | Status |
|---|---|---|---|
| BatchTranslateList | Translations | collection | OK |
| AudioList | Elements | collection | OK |
| Video | Video | reference | OK |
| Content | Description | string | AMBIGUOUS |

## Entity: ElementTranslate

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Content | Value | string | OK |
| Audio | Element | reference | OK |
| Language | Language | reference | OK |
| Update | ModifiedOnUtc | DateTime? | OK |

## Entity: Folder

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Name | Name | string | OK |
| Code | Code | string | OK |
| UpperFolder | Parent | reference | OK |
| Parent | Parent | reference | OK |
| LowerFolder | Children | collection | OK |
| Children | Children | collection | OK |
| VideoList | Videos | collection | OK |
| BookMarkList | BookMarks | collection | OK |
| ObjectRelationList | ObjectRelations | collection | OK |
| Update | ModifiedOnUtc | DateTime? | OK |
| CreatedDate | CreatedOnUtc | DateTime | OK |
| InActive | IsActive | bool | AMBIGUOUS |
| URL | NormalizedPath | string | AMBIGUOUS |
| Content | Description | string | AMBIGUOUS |

## Entity: Language

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Name | Name | string | OK |
| Code | Code | string | OK |
| LocaleCode | IsoCode | string | OK |
| OriginName | NativeName | string | OK |
| EnglishName | NativeName | string | AMBIGUOUS |

## Entity: LanguageSpelling

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Language | Language | reference | OK |
| SpellingWord | SpellingWord | reference | OK |
| Name | Name | string | OK |

## Entity: Media

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Paragraph | Paragraph | reference | OK |
| Video | Video | reference | OK |
| Order | Sequence | int | OK |
| MediaType | MediaType | string | OK |
| MediaFile | SourceUrl | string | AMBIGUOUS |
| Photo | SourceUrl | string | AMBIGUOUS |
| Content | Name | string | AMBIGUOUS |

## Entity: ObjectRelation

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Name | Name | string | OK |
| Code | Code | string | OK |
| Note | Description | string | OK |
| Update | ModifiedOnUtc | DateTime? | OK |
| ObjectID | ExternalObjectId | string | OK |
| SoftwareObjectType | ExternalEntityName | string | OK |
| Folder | Folder | reference | OK |
| SystemType | ExternalObjectType | enum | AMBIGUOUS |
| Updater | ModifiedByName | string | AMBIGUOUS |

## Entity: Paragraph

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Order | Sequence | int | OK |
| Code | Code | string | OK |
| ParagraphStyle | ParagraphStyle | reference | OK |
| AudioList | Elements | collection | OK |
| MediaList | MediaItems | collection | OK |
| Update | ModifiedOnUtc | DateTime? | OK |
| Video | Video | reference | OK |
| Content | Description | string | AMBIGUOUS |

## Entity: ParagraphStyle

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Name | Name | string | OK |
| Font | FontFamily | string | OK |
| Size | FontSize | decimal? | OK |
| Alignment | TextAlignment | string | OK |
| Video | Video | reference | OK |
| Bold | FontWeight | string | AMBIGUOUS |
| Italic | FontWeight | string | AMBIGUOUS |

## Entity: Product -> MasterData.Product

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Name | Name | string | OK |
| Code | Code | string | OK |
| Price | StandardCost | decimal | AMBIGUOUS |
| PriceSale | ListPrice | decimal | AMBIGUOUS |
| InActive | IsActive | bool | AMBIGUOUS |
| Update | ModifiedOnUtc | DateTime? | OK |
| EAN | Barcode | string | AMBIGUOUS |
| Feature | Description | string | AMBIGUOUS |
| Introduction | Description | string | AMBIGUOUS |
| Specification | Description | string | AMBIGUOUS |
| CustomsDescription | Description | string | AMBIGUOUS |

## Entity: SoftwareServiceType

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Name | Name | string | OK |
| Code | Code | string | OK |
| Update | ModifiedOnUtc | DateTime? | OK |
| Updater | ModifiedByName | string | AMBIGUOUS |

## Entity: SpellingWord

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Name | Name | string | OK |
| Spelling | PhoneticText | string | OK |
| LanguageSpellingList | LanguageSpellings | collection | OK |

## Entity: Term

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Name | SourceTerm | string | AMBIGUOUS |
| Translate | TranslatedTerm | string | OK |
| Video | Video | reference | OK |
| TermLocationList | Locations | collection | OK |
| Language | Language | reference | OK |
| Update | ModifiedOnUtc | DateTime? | OK |
| Note | Description | string | OK |
| LanguageTranslate | Language | reference | AMBIGUOUS |

## Entity: TermCorrection

| Old Field | New Property | Type | Status |
|---|---|---|---|
| TermLocationCorrectionList | LocationCorrections | collection | OK |
| Term | Term | reference | OK |
| OptionNumber | Options | collection | AMBIGUOUS |

## Entity: TermLocation

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Term | Term | reference | OK |
| Audio | Element | reference | OK |
| Length | Length | int | OK |
| Location | StartIndex | int | OK |
| Note | Description | string | OK |
| Sentence | Element.SourceText | string | AMBIGUOUS |
| Translate | Element.TranslatedText | string | AMBIGUOUS |

## Entity: TermLocationCorrection

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Caption | ReplacementText | string | AMBIGUOUS |
| TermCorrection | TermCorrection | reference | OK |
| TermLocation | TermLocation | reference | OK |

## Entity: TranslateObject

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Name | Name | string | OK |
| Content | SourceHtml | string | OK |
| ObjectID | ExternalObjectId | string | OK |
| SystemType | ExternalObjectType | enum | AMBIGUOUS |
| Video | Video | reference | OK |
| FieldSource | SourceFieldName | string | OK |
| Update | ModifiedOnUtc | DateTime? | OK |

## Entity: TranslateWord

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Language | Language | reference | OK |
| DictionaryWord | DictionaryWord | reference | OK |
| Name | Value | string | AMBIGUOUS |
| Context | Description | string | AMBIGUOUS |
| Update | ModifiedOnUtc | DateTime? | OK |
| Creator | CreatedByName | string | AMBIGUOUS |

## Entity: Video

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Code | Code | string | OK |
| Name | Name | string | OK |
| DocumentType | Mode | enum | OK |
| Date | DocumentDate | DateTime | OK |
| LanguageOrigin | SourceLanguage | reference | OK |
| Status | Status | enum | OK |
| AudioList | Elements | collection | OK |
| ElementBatchList | Batches | collection | OK |
| TermList | Terms | collection | OK |
| MediaList | MediaItems | collection | OK |
| ParagraphList | Paragraphs | collection | OK |
| ParagraphStyleList | ParagraphStyles | collection | OK |
| TranslateObjectList | TranslateObjects | collection | OK |
| Update | ModifiedOnUtc | DateTime? | OK |
| Note | Description | string | OK |
| Folder | Folder | reference | OK |
| FileList | SourceBookmark | reference | AMBIGUOUS |
| Path | ExternalReference | string | AMBIGUOUS |

## Entity: Voice

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Name | Name | string | OK |
| Code | Code | string | OK |
| Language | Language | reference | OK |
| DataService | DataService | reference | OK |
| Note | Description | string | OK |
| Template | Description | string | AMBIGUOUS |

## Entity: Word

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Name | Name | string | OK |
| NoSignWord | NormalizedValue | string | OK |
| Language | Language | reference | OK |

## Entity: WordNoSign

| Old Field | New Property | Type | Status |
|---|---|---|---|
| Name | Value | string | OK |

---

# Metadata Mapping

## Entity: Audio -> Element

| Property | Caption | Required | Default | VisibleList | VisibleDetail | Group | Order |
|---|---|---|---|---|---|---|---|
| StartTime | Bắt đầu | Yes | none | Yes | Yes | default | 1 |
| EndTime | Kết thúc | No | none | Yes | Yes | default | 1 |
| Voice | Giọng | No | none | No | Yes | default | 1 |
| SourceText | Nội dung | No | none | Yes | Yes | default | 1 |
| TranslatedText | Dịch | No | none | Yes | Yes | default | 1 |
| Notes | Ghi chú | No | none | No | No | default | - |
| Sequence | Thứ tự | No | none | No | No | default | - |

## Entity: BookMark

| Property | Caption | Required | Default | VisibleList | VisibleDetail | Group | Order |
|---|---|---|---|---|---|---|---|
| Name | Name | Yes | constructor default | Yes | Yes | default | 1 |
| SourceUrl | URL | No | none | Yes | Yes | default | 1 |
| Description | Note | No | none | No | Yes | default | 1 |
| Folder | Folder | No | none | No | Yes | default | - |
| Code | Code | Yes | constructor GUID-based code | No | Yes | default | - |

## Entity: DataService

| Property | Caption | Required | Default | VisibleList | VisibleDetail | Group | Order |
|---|---|---|---|---|---|---|---|
| Code | Code | Yes | constructor GUID-based code | Yes | Yes | default | 1 |
| Name | Name | Yes | constructor default | Yes | Yes | default | 1 |
| Endpoint | Address | No | none | Yes | Yes | default | 1 |
| SoftwareServiceType | SoftwareServiceType | No | none | Yes | Yes | default | 1 |

## Entity: Dictionary

| Property | Caption | Required | Default | VisibleList | VisibleDetail | Group | Order |
|---|---|---|---|---|---|---|---|
| Name | Name | Yes | constructor default | Yes | Yes | default | 1 |
| Words | DictionaryWordList | No | none | No | Yes | default | - |

## Entity: Folder

| Property | Caption | Required | Default | VisibleList | VisibleDetail | Group | Order |
|---|---|---|---|---|---|---|---|
| Name | Name | Yes | constructor default | Yes | Yes | default | 1 |
| Code | Code | Yes | constructor GUID-based code | No | Yes | default | 1 |
| Parent | UpperFolder | No | none | No | Yes | default | 1 |
| Children | LowerFolder | No | none | No | Yes | default | - |

## Entity: Language

| Property | Caption | Required | Default | VisibleList | VisibleDetail | Group | Order |
|---|---|---|---|---|---|---|---|
| Name | Name | Yes | constructor default | Yes | Yes | default | 1 |
| Code | Code | Yes | constructor GUID-based code | Yes | Yes | default | 1 |
| IsoCode | LocaleCode | No | none | Yes | Yes | default | 1 |
| NativeName | OriginName | No | none | Yes | Yes | default | 1 |

## Entity: ParagraphStyle

| Property | Caption | Required | Default | VisibleList | VisibleDetail | Group | Order |
|---|---|---|---|---|---|---|---|
| Name | Name | Yes | constructor default | Yes | Yes | default | 1 |
| FontFamily | Font | No | none | Yes | Yes | default | 1 |
| FontSize | Size | No | none | Yes | Yes | default | 1 |
| TextAlignment | Alignment | No | none | Yes | Yes | default | 1 |

## Entity: Term

| Property | Caption | Required | Default | VisibleList | VisibleDetail | Group | Order |
|---|---|---|---|---|---|---|---|
| SourceTerm | Name | No | none | Yes | Yes | default | 1 |
| TranslatedTerm | Translate | No | none | Yes | Yes | default | 1 |
| Language | Language | No | none | Yes | Yes | default | 1 |
| Video | Video | No | none | No | Yes | default | - |
| Description | Note | No | none | No | Yes | default | - |

## Entity: TranslateObject

| Property | Caption | Required | Default | VisibleList | VisibleDetail | Group | Order |
|---|---|---|---|---|---|---|---|
| Name | Name | Yes | constructor default | Yes | Yes | default | 1 |
| SourceHtml | Content | No | none | Yes | Yes | default | 1 |
| ExternalObjectId | ObjectID | No | none | Yes | Yes | default | 1 |
| SourceFieldName | FieldSource | No | none | No | Yes | default | - |

## Entity: Video

| Property | Caption | Required | Default | VisibleList | VisibleDetail | Group | Order |
|---|---|---|---|---|---|---|---|
| Code | Code | Yes | constructor GUID-based code | Yes | Yes | default | 1 |
| Name | Name | Yes | constructor default | Yes | Yes | default | 1 |
| Mode | DocumentType | No | `DocumentMode.Translation` | Yes | Yes | default | 1 |
| DocumentDate | Date | Yes | `DateTime.Today` | Yes | Yes | default | 1 |
| SourceLanguage | LanguageOrigin | No | none | Yes | Yes | default | 1 |
| Status | Status | No | `Draft` | Yes | Yes | default | 1 |
| Description | Note | No | none | No | Yes | default | - |
| Folder | Folder | No | none | No | Yes | default | - |

## Entity: Voice

| Property | Caption | Required | Default | VisibleList | VisibleDetail | Group | Order |
|---|---|---|---|---|---|---|---|
| Name | Name | Yes | constructor default | Yes | Yes | default | 1 |
| Code | Code | Yes | constructor GUID-based code | Yes | Yes | default | 1 |
| Language | Language | No | none | Yes | Yes | default | 1 |
| DataService | DataService | No | none | Yes | Yes | default | 1 |

## Entity: Word

| Property | Caption | Required | Default | VisibleList | VisibleDetail | Group | Order |
|---|---|---|---|---|---|---|---|
| Name | Name | Yes | constructor default | Yes | Yes | default | 1 |
| NormalizedValue | NoSignWord | No | none | Yes | Yes | default | 1 |
| Language | Language | No | none | Yes | Yes | default | 1 |

---

# Default Logic Mapping

- `Video.DocumentDate -> DateTime.Today`
  Source: `HerpDocumentObject.DocumentDate`

- `Video.Status -> Draft`
  Source: `HerpDocumentObject.Status`

- `Video.Mode -> DocumentMode.Translation`
  Source: property initializer

- `Video.Code -> "VIDEO-" + Guid`
  Source: constructor

- `Video.Name -> "New Video"`
  Source: constructor

- `Element.Code -> "ELEMENT-" + Guid`
  Source: constructor

- `Element.Name -> "Element"`
  Source: constructor

- `BookMark.Code -> "BOOKMARK-" + Guid`
  Source: constructor

- `BookMark.Name -> "New Bookmark"`
  Source: constructor

- `BookMark.IsImported -> false`
  Source: CLR default

- `Folder.Code -> "FOLDER-" + Guid`
  Source: constructor

- `Folder.Name -> "New Folder"`
  Source: constructor

- `DataService.Code -> "SERVICE-" + Guid`
  Source: constructor

- `DataService.Name -> "Data Service"`
  Source: constructor

- `DataService.IsEnabled -> true`
  Source: property initializer

- `ElementBatch.DocumentDate -> DateTime.Today`
  Source: `HerpDocumentObject.DocumentDate`

- `BatchTranslate.DocumentDate -> DateTime.Today`
  Source: `HerpDocumentObject.DocumentDate`

- `ModifiedOnUtc / CreatedOnUtc`
  Source: `HERPEFCoreDbContext.ApplyAuditInfo()`
  Applies to legacy `Update`, `CreatedDate`, `Creator`, `Updater` family

---

# Missing Fields

## Legacy entities without a target entity

- `Concept`
- `DataServiceLog`
- `ExceptionWord`
- `GoogleBucket`
- `GoogleKey`
- `GradeSubject`
- `Match`
- `Member`
- `MemberDataService`
- `Player`
- `Post`
- `PublicEvent`
- `SeparateAudio`
- `TournamentSeason`
- `WebExtractor`

## Ambiguous entity-level mappings

- `Parameter -> UserSetting / SystemSetting`
- `Product -> Product` chỉ áp dụng cho tập field master-data rút gọn

## High-impact missing fields on mapped entities

- `Audio`: `AudioLink`, `AudioDuration`, `AudioRate`, `SubtitleTime`, `SpellingTime`, `AudioTime`, `Speaker`, `CaseType`, `NextElement`, `PreviousElement`, `BookMark`, `TranslateObject`, `ElementBatch`
- `Video`: `LanguageList`, `LanguageTranslate`, `TermLocationList`, `Font*`, `NodeFont*`, `ElementSpacing`, `BlankSpacing`, `Import*`, `OriginStyleExport`, `CreateWordStyle`, `FootNote`
- `Media`: `Height`, `Width`, `Alignment*`, `TextWrappingType*`, `FillColor`, `LineColor`, `PageNumber`
- `ParagraphStyle`: `Underline`, `Spacing*`, `Indent*`, `ObjectLayout`, `MoveWithText`
- `Term`: `GoogleTranslate`, `NumberValue`, `DateValue`, `Length`, `WordQuantity`, `TermType`, `TranslateDataSource`
- `DataService`: `APIKey`, `ApiMethodType`, `MaxConcurrency`, `Pause`, `IsDefault`
- `Product`: `Brand`, `Variation`, `Warranty`, `Weight`, `ReleaseDate`, `PriceWeb`

---

# Warnings

- `Audio -> Element` là rename lớn nhất. Metadata UI của `Audio` phải được áp lên `Element`, không áp lên `ElementTranslate`.
- Nhiều field legacy dạng `Update`, `CreatedDate`, `Creator`, `Updater` nên map vào audit fields UTC: `CreatedOnUtc`, `ModifiedOnUtc`, `CreatedByName`, `ModifiedByName`.
- `InActive` trong hệ cũ mang nghĩa phủ định; entity mới dùng `IsActive` hoặc `IsEnabled`, nên CodeAgent phải đảo nghĩa khi generate metadata/default logic.
- `Product.Price -> StandardCost` và `Product.PriceSale -> ListPrice` chỉ là mapping tạm; cần xác nhận lại business semantics trước khi generate UI metadata chính thức.
- `Language.EnglishName` và `Language.OriginName` không còn tách bạch hoàn toàn; `OriginName -> NativeName` chắc hơn, còn `EnglishName` là `AMBIGUOUS`.
- `CorrectionOption.Name -> ProposedValue`, `TranslateWord.Name -> Value`, `Term.Name -> SourceTerm` là mapping theo business meaning; nếu vẫn cần `Name` cho display, nên mirror thay vì overwrite.
- `TranslateObject.SystemType` và `ObjectRelation.SystemType` hiện map sang enum `ExternalObjectType`, không còn là `System.Type`; đây là type mismatch có chủ đích.
- `Folder.URL -> NormalizedPath` chỉ là mapping gần đúng. Nếu legacy `URL` là hyperlink ngoài hệ thống thì hiện chưa có property 1-1.
- `ApplicationUserLoginInfo` thuộc security/base, không thuộc Document domain; chỉ nên áp metadata khi thật sự cần UI quản trị đăng nhập.
