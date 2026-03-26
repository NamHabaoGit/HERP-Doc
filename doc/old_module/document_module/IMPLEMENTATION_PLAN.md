# Implementation Plan

## Scope

Tai lieu nay chia module `Document` thanh cac task theo thu tu trien khai de phu hop voi kien truc hien tai cua repo: `HERP.Base` -> `HERP.MasterData` -> feature module XAF moi `HERP.Document`.

## Nguyen tac sap xep

- Lam xong skeleton va host wiring truoc khi them business object.
- Dung vertical slices theo nhom nghiep vu lon: core document, import, content editing, terminology, translation, layout/export, integration.
- Cac task UI/controller chi duoc tao sau khi service nghiep vu o task truoc da ro rang.
- Test va migration duoc them song song theo tung cum task, nhung co mot task rieng de chot verification cuoi.

## Task 1. Scaffold module skeleton

- Muc tieu:
  - Tao bo khung `HERP.Document`, `HERP.Document.Win`, `HERP.Document.Blazor`.
  - Khai bao project references, module classes, solution entries, va folder structure dung pattern cac module XAF hien co.
- File can tao:
  - `XAF/Modules/Document/HERP.Document/HERP.Document.csproj`
  - `XAF/Modules/Document/HERP.Document/Module.cs`
  - `XAF/Modules/Document/HERP.Document/Model.DesignedDiffs.xafml`
  - `XAF/Modules/Document/HERP.Document.Win/HERP.Document.Win.csproj`
  - `XAF/Modules/Document/HERP.Document.Win/WinModule.cs`
  - `XAF/Modules/Document/HERP.Document.Win/Model.xafml`
  - `XAF/Modules/Document/HERP.Document.Blazor/HERP.Document.Blazor.csproj`
  - `XAF/Modules/Document/HERP.Document.Blazor/BlazorModule.cs`
  - `XAF/Modules/Document/HERP.Document.Blazor/Model.xafml`
- Dependency voi task khac:
  - Khong phu thuoc task nao.
  - La dependency bat buoc cho Task 2 den Task 12.

## Task 2. Wire module vao shell app va DbContext

- Muc tieu:
  - Dang ky `HERP.Document` vao `HERP.Module`, `HERP.Win`, `HERP.Blazor.Server`, `HERP.slnx`.
  - Chuan bi `HERPDbContext` de nhan cac entity Document o cac task sau.
- File can tao:
  - Khong can tao file moi neu dung lai host files hien co.
  - Neu muon tach cau hinh: `XAF/Modules/Document/HERP.Document/Persistence/DocumentModelBuilder.cs`
- Dependency voi task khac:
  - Phu thuoc Task 1.
  - La dependency cho Task 3 den Task 12.

## Task 3. Tao domain core entities

- Muc tieu:
  - Tao aggregate root va nhom entity nen cua module: `Video`, `Folder`, `BookMark`, `ObjectRelation`.
  - Xac lap quan he cha-con, company scope, document numbering, status, audit.
- File can tao:
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Core/Video.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Core/Folder.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Integration/BookMark.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Integration/ObjectRelation.cs`
  - `XAF/Modules/Document/HERP.Document/Enums/DocumentMode.cs`
  - `XAF/Modules/Document/HERP.Document/Messages/DocumentMessageKeys.cs`
  - `XAF/Modules/Document/HERP.Document/Validation/DocumentValidationMessages.cs`
- Dependency voi task khac:
  - Phu thuoc Task 1 va Task 2.
  - La dependency cho Task 4 den Task 12.

## Task 4. Tao entities content va layout

- Muc tieu:
  - Tao model cho `Audio`, `Paragraph`, `ParagraphStyle`, `Media`.
  - Bao toan cau truc trinh bay va lien ket noi dung voi `Video`.
- File can tao:
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Content/Audio.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Layout/Paragraph.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Layout/ParagraphStyle.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Layout/Media.cs`
- Dependency voi task khac:
  - Phu thuoc Task 3.
  - La dependency cho Task 5, Task 6, Task 8, Task 9, Task 10.

## Task 5. Tao entities terminology va dictionary

- Muc tieu:
  - Model hoa `Term`, `TermLocation`, `TermCorrection`, `TermLocationCorrection`, `CorrectionOption`.
  - Tao nhom dictionary dung chung: `Dictionary`, `DictionaryWord`, `TranslateWord`, `SpellingWord`, `LanguageSpelling`, `Word`, `WordNoSign`.
- File can tao:
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Terminology/Term.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Terminology/TermLocation.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Terminology/TermCorrection.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Terminology/TermLocationCorrection.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Terminology/CorrectionOption.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Terminology/Dictionary.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Terminology/DictionaryWord.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Terminology/TranslateWord.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Terminology/SpellingWord.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Terminology/LanguageSpelling.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Terminology/Word.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Terminology/WordNoSign.cs`
- Dependency voi task khac:
  - Phu thuoc Task 3 va Task 4.
  - La dependency cho Task 8 va Task 11.

## Task 6. Tao entities translation va configuration

- Muc tieu:
  - Model hoa `ElementTranslate`, `ElementBatch`, `BatchTranslate`.
  - Tao danh muc cau hinh `Language`, `Voice`, `DataService`, `DataServiceParameter`, `SoftwareServiceType`.
- File can tao:
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Translation/ElementTranslate.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Translation/ElementBatch.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Translation/BatchTranslate.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Configuration/Language.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Configuration/Voice.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Configuration/DataService.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Configuration/DataServiceParameter.cs`
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Configuration/SoftwareServiceType.cs`
- Dependency voi task khac:
  - Phu thuoc Task 3 va Task 4.
  - La dependency cho Task 8, Task 9, Task 10 va Task 11.

## Task 7. Tao integration bridge entities

- Muc tieu:
  - Tao `TranslateObject` de nhap/xuat noi dung HTML voi object ngoai module.
  - Chuan hoa reference mem toi `Post`, `Product`, hoac business object ngoai.
- File can tao:
  - `XAF/Modules/Document/HERP.Document/BusinessObjects/Integration/TranslateObject.cs`
  - `XAF/Modules/Document/HERP.Document/Enums/ExternalObjectType.cs`
- Dependency voi task khac:
  - Phu thuoc Task 3 va Task 4.
  - La dependency cho Task 10 va Task 11.

## Task 8. Tao services nghiep vu core va import/editing

- Muc tieu:
  - Tao service xu ly vong doi tai lieu, cay thu muc, nhap nguon, va bien tap content.
  - Dat business rules xuyen aggregate ra khoi controller.
- File can tao:
  - `XAF/Modules/Document/HERP.Document/Services/Workflow/DocumentWorkflowService.cs`
  - `XAF/Modules/Document/HERP.Document/Services/Workflow/FolderService.cs`
  - `XAF/Modules/Document/HERP.Document/Services/Import/DocumentImportService.cs`
  - `XAF/Modules/Document/HERP.Document/Services/Import/BookmarkImportService.cs`
  - `XAF/Modules/Document/HERP.Document/Services/Workflow/AudioEditingService.cs`
  - `XAF/Modules/Document/HERP.Document/Contracts/IDocumentImportParser.cs`
- Dependency voi task khac:
  - Phu thuoc Task 3, Task 4 va Task 6.
  - La dependency cho Task 11.

## Task 9. Tao services terminology va batch translation

- Muc tieu:
  - Trien khai extraction, correction, dictionary sync, batch translation, prompt generation.
  - Dinh nghia boundary giua xu ly thu cong va ban tu dong trong workflow dich.
- File can tao:
  - `XAF/Modules/Document/HERP.Document/Services/Terminology/TerminologyExtractionService.cs`
  - `XAF/Modules/Document/HERP.Document/Services/Terminology/TerminologyCorrectionService.cs`
  - `XAF/Modules/Document/HERP.Document/Services/Terminology/DictionaryService.cs`
  - `XAF/Modules/Document/HERP.Document/Services/Translation/BatchTranslationService.cs`
  - `XAF/Modules/Document/HERP.Document/Services/Translation/PromptGenerationService.cs`
  - `XAF/Modules/Document/HERP.Document/Contracts/ITranslationGateway.cs`
  - `XAF/Modules/Document/HERP.Document/Contracts/ITermExtractionGateway.cs`
- Dependency voi task khac:
  - Phu thuoc Task 4, Task 5 va Task 6.
  - La dependency cho Task 11 va Task 12.

## Task 10. Tao services export va external integration

- Muc tieu:
  - Trien khai export giu nguyen layout va import/export HTML voi object ngoai.
  - Doc cau hinh `DataService` va dong goi adapter cho TTS, AI, translation service.
- File can tao:
  - `XAF/Modules/Document/HERP.Document/Services/Export/LayoutExportService.cs`
  - `XAF/Modules/Document/HERP.Document/Services/Integration/TranslateObjectService.cs`
  - `XAF/Modules/Document/HERP.Document/Services/Integration/ExternalDataServiceExecutor.cs`
  - `XAF/Modules/Document/HERP.Document/Contracts/IHtmlContentMapper.cs`
  - `XAF/Modules/Document/HERP.Document/Contracts/IDataServiceExecutor.cs`
- Dependency voi task khac:
  - Phu thuoc Task 4, Task 6 va Task 7.
  - La dependency cho Task 11 va Task 12.

## Task 11. Tao XAF controllers va actions

- Muc tieu:
  - Tao action/controller cho folder, import, lifecycle, audio editing, terminology, correction, batch translation, translate object, data service.
  - Bao dam controller chi goi service, khong chua business rule.
- File can tao:
  - `XAF/Modules/Document/HERP.Document/Controllers/FolderController.cs`
  - `XAF/Modules/Document/HERP.Document/Controllers/DocumentImportController.cs`
  - `XAF/Modules/Document/HERP.Document/Controllers/DocumentLifecycleController.cs`
  - `XAF/Modules/Document/HERP.Document/Controllers/AudioEditingController.cs`
  - `XAF/Modules/Document/HERP.Document/Controllers/TerminologyController.cs`
  - `XAF/Modules/Document/HERP.Document/Controllers/TermCorrectionController.cs`
  - `XAF/Modules/Document/HERP.Document/Controllers/BatchTranslationController.cs`
  - `XAF/Modules/Document/HERP.Document/Controllers/TranslateObjectController.cs`
  - `XAF/Modules/Document/HERP.Document/Controllers/DataServiceController.cs`
  - `XAF/Modules/Document/HERP.Document.Win/Controllers/DocumentDesktopController.cs`
  - `XAF/Modules/Document/HERP.Document.Blazor/Controllers/DocumentBlazorController.cs`
- Dependency voi task khac:
  - Phu thuoc Task 8, Task 9 va Task 10.
  - La dependency cho Task 12.

## Task 12. Tao tests, migration plan va verification

- Muc tieu:
  - Viet unit test cho entity validation va service rules quan trong.
  - Viet integration test cho import -> edit -> terminology -> batch translate -> export.
  - Chot migration checklist va build/test verification cho module.
- File can tao:
  - `tests/XAF/Modules/Document/HERP.Document.Tests/BusinessObjects/VideoTests.cs`
  - `tests/XAF/Modules/Document/HERP.Document.Tests/Services/DocumentWorkflowServiceTests.cs`
  - `tests/XAF/Modules/Document/HERP.Document.Tests/Services/TerminologyExtractionServiceTests.cs`
  - `tests/XAF/Modules/Document/HERP.Document.Tests/Services/BatchTranslationServiceTests.cs`
  - `tests/XAF/Modules/Document/HERP.Document.Tests/Integration/DocumentModuleFlowTests.cs`
  - `docs/old_module/document_module/MIGRATION_CHECKLIST.md`
  - `docs/old_module/document_module/MEASUREMENT_PLAN.md`
- Dependency voi task khac:
  - Phu thuoc Task 3 den Task 11.
  - La task chot truoc khi module duoc coi la san sang scaffold va implement day du.

## Thu tu uu tien de bat dau code

1. Task 1
2. Task 2
3. Task 3
4. Task 4
5. Task 6
6. Task 8
7. Task 5
8. Task 9
9. Task 7
10. Task 10
11. Task 11
12. Task 12

## Ghi chu thuc thi

- Quy mo module lon, nen chia implementation thanh milestone nho:
  - Milestone A: Task 1 -> Task 4
  - Milestone B: Task 6 -> Task 8
  - Milestone C: Task 5 -> Task 9
  - Milestone D: Task 7 -> Task 12
- Ke hoach do hieu nang can duoc thuc hien o Task 12:
  - Do thoi gian import mot `Video` lon thanh danh sach `Audio`.
  - Do thoi gian extraction term tren tai lieu dai.
  - Do thoi gian tao batch translate va map ket qua quay lai `Audio`.
  - Kiem tra query shape de tranh N+1 voi `Video` -> `Audio` -> `TermLocation`.
