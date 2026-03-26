# Module Structure

## Module Structure

BaseCode hiện tại có hai trục kỹ thuật song song:

- `XAF` là trục triển khai module nghiệp vụ chính, theo pattern `XAF/Modules/<Feature>/HERP.<Feature>`, `HERP.<Feature>.Win`, `HERP.<Feature>.Blazor`.
- `MAUI` đã có `HERP.Domain` và `HERP.Infrastructure`, nhưng chưa có `Application` project riêng; phần module ERP đang được tổ chức chủ yếu ở nhánh `XAF`.
- `XAF/HERP/HERP.Module` đang là composition root của shell app XAF, chứa `HERPEFCoreDbContext`, module loader, và nơi host đăng ký các feature module.

Kết luận cho module mới: để bám đúng BaseCode hiện có và không thay đổi kiến trúc, `Document` nên được triển khai như một XAF feature module mới tại `XAF/Modules/Document`.

### Available Layers In BaseCode

| Layer | Tình trạng trong BaseCode | Cách dùng cho `Document` |
| --- | --- | --- |
| `Domain` | Có theo hai dạng: `MAUI/HERP/HERP.Domain` và domain model thực tế trong các XAF module `BusinessObjects` | Với module mới, entity nghiệp vụ nên nằm trong `XAF/Modules/Document/HERP.Document/BusinessObjects` để khớp pattern hiện tại |
| `Application` | Chưa có project `Application` riêng trong solution XAF | Không tạo layer mới; use case/workflow đặt trong `HERP.Document/Services` |
| `Infrastructure` | EF Core persistence tập trung tại `XAF/HERP/HERP.Module/BusinessObjects/HERPDbContext.cs`; các host có service adapter riêng | `Document` sẽ được map vào `HERPEFCoreDbContext`; adapter gọi dịch vụ ngoài đặt trong service hiện có của module |
| `Presentation` | `HERP.Document`, `HERP.Document.Win`, `HERP.Document.Blazor`, cùng host `HERP.Win`, `HERP.Blazor.Server`, `HERP.WebApi` | UI action nằm trong `Controllers`; host chỉ nạp module và render UI |
| `Controllers` | BaseCode đang dùng XAF controllers theo module/host | Controller nghiệp vụ của `Document` nên nằm trước tiên ở `HERP.Document/Controllers`; chỉ tách xuống Win/Blazor nếu phụ thuộc nền tảng |

### Folder Structure To Create

```text
XAF/Modules/Document/
  HERP.Document/
    BusinessObjects/
      Core/
      Content/
      Layout/
      Terminology/
      Translation/
      Integration/
      Configuration/
    Services/
      Workflow/
      Import/
      Translation/
      Terminology/
      Export/
      Integration/
    Controllers/
    Validation/
    Messages/
    Enums/
    Module.cs
    Model.DesignedDiffs.xafml
    HERP.Document.csproj
  HERP.Document.Win/
    Controllers/
    WinModule.cs
    Model.xafml
    HERP.Document.Win.csproj
  HERP.Document.Blazor/
    Controllers/
    BlazorModule.cs
    Model.xafml
    HERP.Document.Blazor.csproj
```

### Host Wiring Required By BaseCode

- `XAF/HERP/HERP.Module/Module.cs`: thêm `RequiredModuleTypes.Add(typeof(HERP.Document.HERPDocumentModule));`
- `XAF/HERP/HERP.Module/BusinessObjects/HERPDbContext.cs`: thêm `DbSet<>`, index, quan hệ, cascade rule cho entity của `Document`
- `XAF/HERP/HERP.Win/WinModule.cs` và `XAF/HERP/HERP.Blazor.Server/BlazorModule.cs`: nạp `HERP.Document.Win` / `HERP.Document.Blazor` nếu theo pattern các module khác
- `XAF/HERP.slnx`: thêm 3 project của module vào folder `/Modules/Document/`

### Placement Rules

- Entity EF/XAF đặt trong `HERP.Document/BusinessObjects`
- Base entity nên kế thừa từ `HerpAuditedObject`, `HerpCompanyScopedAuditedObject`, `HerpDocumentObject`, `HerpDocumentLineObject` tùy vai trò
- Validation runtime đặt trong `Validation`
- Message key, validation text, error code đặt trong `Messages`
- Workflow/use case đặt trong `Services`
- XAF actions đặt trong `Controllers`
- Không đưa business rule vào `Win`, `Blazor`, `WebApi`, `View`, hoặc code-behind UI

## Entities Mapping

### Aggregate And Cross-Module Boundaries

- `Video` là aggregate root trung tâm của module `Document`
- `Folder` là aggregate quản lý cây thư mục
- `Dictionary` là aggregate riêng cho từ điển và từ vựng
- `Language`, `Voice`, `DataService` là configuration entity của riêng module `Document`, không đặt vào `HERP.Base`
- `Product`, `Post` trong spec là external object; không tái tạo trong `Document`, chỉ liên kết qua khóa ngoại mềm hoặc bridge object

### Entity Placement

| Spec entity / nhóm | Vai trò | Vị trí triển khai theo BaseCode |
| --- | --- | --- |
| `Video` | Aggregate root trung tâm | `HERP.Document/BusinessObjects/Core/Video.cs`, kế thừa `HerpDocumentObject` |
| `Folder` | Cây thư mục tài liệu | `HERP.Document/BusinessObjects/Core/Folder.cs`, kế thừa `HerpCompanyScopedAuditedObject` |
| `BookMark` | Nguồn URL/file/import source | `HERP.Document/BusinessObjects/Integration/BookMark.cs` |
| `ObjectRelation` | Quan hệ tới object ngoài module | `HERP.Document/BusinessObjects/Integration/ObjectRelation.cs` |
| `TranslateObject` | Bridge import/export HTML sang object ngoài | `HERP.Document/BusinessObjects/Integration/TranslateObject.cs` |
| `Audio` | Đơn vị nội dung thao tác chính | `HERP.Document/BusinessObjects/Content/Audio.cs` |
| `Paragraph` | Nhóm đoạn nội dung | `HERP.Document/BusinessObjects/Layout/Paragraph.cs` |
| `ParagraphStyle` | Style trình bày | `HERP.Document/BusinessObjects/Layout/ParagraphStyle.cs` |
| `Media` | Shape/image/frame | `HERP.Document/BusinessObjects/Layout/Media.cs` |
| `Term` | Thuật ngữ theo tài liệu | `HERP.Document/BusinessObjects/Terminology/Term.cs` |
| `TermLocation` | Vị trí xuất hiện trong `Audio` | `HERP.Document/BusinessObjects/Terminology/TermLocation.cs` |
| `TermCorrection` | Correction cấp term | `HERP.Document/BusinessObjects/Terminology/TermCorrection.cs` |
| `TermLocationCorrection` | Correction cấp location | `HERP.Document/BusinessObjects/Terminology/TermLocationCorrection.cs` |
| `CorrectionOption` | Lựa chọn sửa | `HERP.Document/BusinessObjects/Terminology/CorrectionOption.cs` |
| `Dictionary` | Aggregate từ điển | `HERP.Document/BusinessObjects/Terminology/Dictionary.cs` |
| `DictionaryWord` | Entry từ điển | `HERP.Document/BusinessObjects/Terminology/DictionaryWord.cs` |
| `TranslateWord` | Bản dịch của từ | `HERP.Document/BusinessObjects/Terminology/TranslateWord.cs` |
| `SpellingWord` | Mẫu phát âm | `HERP.Document/BusinessObjects/Terminology/SpellingWord.cs` |
| `LanguageSpelling` | Nối ngôn ngữ và phát âm | `HERP.Document/BusinessObjects/Terminology/LanguageSpelling.cs` |
| `Word` | Từ chuẩn hóa | `HERP.Document/BusinessObjects/Terminology/Word.cs` |
| `WordNoSign` | Từ không dấu | `HERP.Document/BusinessObjects/Terminology/WordNoSign.cs` |
| `ElementTranslate` | Nội dung dịch cấp `Audio` | `HERP.Document/BusinessObjects/Translation/ElementTranslate.cs` |
| `ElementBatch` | Lô dịch | `HERP.Document/BusinessObjects/Translation/ElementBatch.cs` |
| `BatchTranslate` | Kết quả dịch theo ngôn ngữ | `HERP.Document/BusinessObjects/Translation/BatchTranslate.cs` |
| `Language` | Danh mục ngôn ngữ của module | `HERP.Document/BusinessObjects/Configuration/Language.cs` |
| `Voice` | Voice/TTS theo ngôn ngữ | `HERP.Document/BusinessObjects/Configuration/Voice.cs` |
| `DataService` | Cấu hình dịch vụ ngoài | `HERP.Document/BusinessObjects/Configuration/DataService.cs` |
| `DataServiceParameter` | Parameter của `DataService` | `HERP.Document/BusinessObjects/Configuration/DataServiceParameter.cs` |
| `SoftwareServiceType` | Phân loại dịch vụ | `HERP.Document/BusinessObjects/Configuration/SoftwareServiceType.cs` |
| `Product` | Object ngoài module | Reuse `HERP.MasterData` hoặc module `Products`, chỉ tham chiếu từ `ObjectRelation` / `TranslateObject` |
| `Post` | Object ngoài module | Không tạo trong `Document`; bridge qua `TranslateObject` |

### Suggested Base Classes

- `Video`: `HerpDocumentObject`
- `ElementBatch`, `BatchTranslate` nếu có số chứng từ riêng: `HerpDocumentObject`
- `Audio`, `Paragraph`, `Media`, `Term`, `TranslateObject`: `HerpCompanyScopedAuditedObject` hoặc `HerpAuditedObject`
- Line-like child object nếu cần số dòng cố định: `HerpDocumentLineObject`

## Services Mapping

BaseCode chưa có `Application` layer riêng, nên toàn bộ use case nghiệp vụ của `Document` nên tập trung ở `HERP.Document/Services`.

### Service Placement

| Nhóm service | Vị trí phù hợp | Trách nhiệm |
| --- | --- | --- |
| `DocumentWorkflowService` | `Services/Workflow/` | Tạo mới document root, clone cấu trúc, đổi trạng thái, kiểm tra điều kiện trước publish/export |
| `FolderService` | `Services/Workflow/` | Duy trì cây thư mục, move/reorder/rebuild path |
| `DocumentImportService` | `Services/Import/` | Nhận file/URL/HTML nguồn, parse thành `Video`, `Audio`, `Paragraph`, `Media` |
| `BookmarkImportService` | `Services/Import/` | Đồng bộ dữ liệu nguồn từ `BookMark` |
| `AudioEditingService` | `Services/Workflow/` | Split/merge audio, normalize text, sync timestamp, resequence |
| `TerminologyExtractionService` | `Services/Terminology/` | Tạo term từ content hoặc dictionary, cập nhật `TermLocation` |
| `TerminologyCorrectionService` | `Services/Terminology/` | Áp correction, resolve overlap, auto-correct khi chỉ có một lựa chọn hợp lệ |
| `DictionaryService` | `Services/Terminology/` | Import/export dictionary, sync word list |
| `BatchTranslationService` | `Services/Translation/` | Tạo `ElementBatch`, tạo `BatchTranslate`, nhận kết quả dịch, map ngược ra `Audio` |
| `PromptGenerationService` | `Services/Translation/` | Sinh prompt/cấu trúc nhập xuất cho workflow bán tự động |
| `TranslateObjectService` | `Services/Integration/` | Import HTML từ object ngoài và export nội dung đã dịch ngược lại object đích |
| `LayoutExportService` | `Services/Export/` | Preserve `Paragraph`, `ParagraphStyle`, `Media` khi export |
| `ExternalDataServiceExecutor` | `Services/Integration/` hoặc `Services/Translation/` | Đọc `DataService`, `DataServiceParameter` và thực thi integration với TTS/AI/translation |

### Business Rule Placement

- Rule đơn giản, cục bộ theo entity: triển khai trong entity `Validate()` theo pattern `IHerpBusinessValidatable`
- Rule xuyên aggregate hoặc có side effect: đặt trong `Services`
- Số chứng từ nếu cần: dùng `INumberingService` từ `HERP.Base.Services`
- Audit/company scope: dùng base classes hiện có từ `HERP.Base.BusinessObjects`
- Setting hoặc parameter chung: ưu tiên tái dùng pattern service như `HERP.Administration.Services.SettingProvider`, không query trực tiếp từ controller

### Persistence Mapping

Mọi entity của `Document` vẫn được persist qua `HERPEFCoreDbContext` hiện tại:

- thêm `DbSet<Video>`, `DbSet<Audio>`, `DbSet<Term>`...
- khai báo unique index cho code/document no nếu cần
- khai báo `HasMany().WithOne().OnDelete(...)` cho các collection root-child
- cấu hình join/mapping cho quan hệ nhiều-nhiều như `Video` - `Language` nếu thực sự cần

Không tạo DbContext riêng nếu chưa có yêu cầu kiến trúc mới.

## Controllers / Actions

Controllers chỉ là presentation trigger cho service, không chứa business rule.

### XAF Controllers In `HERP.Document`

| Chức năng UI | Controller phù hợp | Service phía sau |
| --- | --- | --- |
| Quản lý cây `Folder` | `FolderController` | `FolderService` |
| Nạp nguồn từ URL/file/HTML | `DocumentImportController` | `DocumentImportService`, `BookmarkImportService` |
| Tạo và điều phối vòng đời `Video` | `DocumentLifecycleController` | `DocumentWorkflowService` |
| Biên tập `Audio` | `AudioEditingController` | `AudioEditingService` |
| Trích xuất và đồng bộ term | `TerminologyController` | `TerminologyExtractionService`, `DictionaryService` |
| Correction theo vị trí | `TermCorrectionController` | `TerminologyCorrectionService` |
| Tạo batch, import/export dịch | `BatchTranslationController` | `BatchTranslationService`, `PromptGenerationService` |
| Import/export `TranslateObject` | `TranslateObjectController` | `TranslateObjectService` |
| Test connection `DataService` hoặc sync parameter | `DataServiceController` | `ExternalDataServiceExecutor` |

### Win / Blazor Controllers

- `HERP.Document.Win/Controllers`: chỉ dành cho action phụ thuộc editor desktop, clipboard, file picker, hoặc integration cục bộ máy
- `HERP.Document.Blazor/Controllers`: chỉ dành cho action phụ thuộc UX web hoặc browser interaction
- Nếu action dùng chung được cho cả hai, giữ ở `HERP.Document/Controllers`

### API Surface

Nếu cần API cho import/export hoặc automation:

- đặt ở `XAF/HERP/HERP.WebApi/API/Document/`
- API controller chỉ nhận request, gọi `HERP.Document/Services`, và trả DTO/result
- không viết business workflow trực tiếp trong Web API controller

### Workflow Mapping From Legacy Spec

| Workflow cũ | Mapping mới theo BaseCode |
| --- | --- |
| `Folder` tổ chức cây nội dung | `Folder` entity + `FolderController` + `FolderService` |
| `BookMark` nạp nguồn | `BookMark` entity + `DocumentImportController` + `BookmarkImportService` |
| `Video` là root tài liệu | `Video` aggregate + `DocumentLifecycleController` + `DocumentWorkflowService` |
| `Audio` là đơn vị thao tác | `Audio` entity + `AudioEditingController` + `AudioEditingService` |
| Term và term location | `Term*` entities + `TerminologyController` + `TerminologyExtractionService` |
| Correction workflow | `TermCorrection*` entities + `TermCorrectionController` + `TerminologyCorrectionService` |
| Batch translate | `ElementBatch`, `BatchTranslate` + `BatchTranslationController` + `BatchTranslationService` |
| Paragraph/style/media preserve layout | `Paragraph`, `ParagraphStyle`, `Media` + `LayoutExportService` |
| TranslateObject bridge ra object ngoài | `TranslateObject` + `TranslateObjectController` + `TranslateObjectService` |
| Language/Voice/DataService configuration | configuration entities + XAF CRUD + `DataServiceController` khi cần thao tác kỹ thuật |

Thiết kế này giữ nguyên kiến trúc hiện có:

- module mới vẫn là XAF feature module
- `HERP.Module` vẫn là composition root
- `HERPEFCoreDbContext` vẫn là persistence entry point
- không thêm layer hay project mới ngoài pattern BaseCode hiện tại
