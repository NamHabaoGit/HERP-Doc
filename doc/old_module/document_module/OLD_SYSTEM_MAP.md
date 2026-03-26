# SYSTEM MAP - Hệ thống cũ ENTOSDocument

## Phạm vi phân tích

Repository này có nhiều project, nhưng phần "hệ thống cũ" phục vụ nghiệp vụ `Document` nằm chủ yếu ở:

- `ENTOSDocument.Module`: lõi domain, business object, service và controller nghiệp vụ.
- `ENTOSDocument.Win`: giao diện desktop Win/XAF cũ, chứa các controller và luồng thao tác cho module `Document`.

Không đưa vào bản đồ này:

- `ENTOSDocument.Blazor.Server`
- `ENTOSDocument.Web.Server`
- các project test

## Cấu trúc thư mục hệ thống cũ

| Thư mục | Vai trò trong hệ thống cũ |
| --- | --- |
| `ENTOSDocument.Module/BusinessObjects` | Entity/business object và các quan hệ persistent của hệ thống cũ |
| `ENTOSDocument.Module/Services` | Xử lý nghiệp vụ chính: import, tách thành phần, trích xuất thuật ngữ, dịch lô, export |
| `ENTOSDocument.Module/Controllers` | Action nghiệp vụ trên UI XAF cho module `Document` |
| `ENTOSDocument.Module/SystemObjects` | Các object hỗ trợ như popup, file attachment, long task, utility object |
| `ENTOSDocument.Module/SystemServices` | Dịch vụ hệ thống/phụ trợ như translate, storage, notification, parameter |
| `ENTOSDocument.Win/Controllers` | Luồng thao tác desktop cũ cho `Document`, `BookMark`, `Folder`, `Media`, `Post`, `Product` |
| `ENTOSDocument.Win/Services` | Service UI Win cho các thao tác cũ |

## Danh sách entity

Hệ thống cũ có nhiều business object pha trộn nhiều domain. Dưới đây là các entity liên quan trực tiếp đến nghiệp vụ `Document`.

### Nhóm tổ chức và đối tượng gốc

| Entity | Vai trò |
| --- | --- |
| `Folder` | Cây thư mục nghiệp vụ, gồm folder con và chứa `Video`, `Post`, `BookMark`, `Product` |
| `Video` | Aggregate root trung tâm của module `Document`; đại diện cho một tư liệu/tài liệu nguồn cần xử lý |
| `BookMark` | Liên kết, tập tin hoặc URL nguồn; dùng để nạp dữ liệu và gắn nguồn cho `Video`, `Post`, `Product`, `Folder` |
| `Post` | Bài viết hoặc nội dung ngoại vi; có thể liên kết folder, bookmark và được dịch qua `TranslateObject` |
| `Product` | Đối tượng sản phẩm được tham chiếu từ bookmark; nằm trong module cũ nhưng là phần bao quanh `Document` |
| `ObjectRelation` | Bảng quan hệ bổ sung giữa `Folder`, `Post` và các đối tượng ngoại vi |

### Nhóm nội dung tài liệu

| Entity | Vai trò |
| --- | --- |
| `Audio` | Thành phần nội dung của `Video`; lưu start/end, content, subtitle, voice, speed, note |
| `Paragraph` | Đoạn văn bản trong `Video`; nhóm `Audio` và `Media` theo khối văn bản |
| `ParagraphStyle` | Kiểu dáng của đoạn văn hoặc phần tử trong `Video` |
| `Media` | Đối tượng media, shape, hình ảnh hoặc khung trong tài liệu Word hay luồng export |
| `TranslateObject` | Gói nội dung HTML của đối tượng cần dịch/xuất dịch quay lại vào object đích như `Post` hoặc object khác |

### Nhóm thuật ngữ và chỉnh sửa

| Entity | Vai trò |
| --- | --- |
| `Term` | Thuật ngữ của một `Video`; có tên, bản dịch, ngôn ngữ, loại và trạng thái |
| `TermLocation` | Vị trí xuất hiện của `Term` trong từng `Audio`; là bảng nối giữa term và element |
| `TermCorrection` | Tập hợp lỗi hoặc chỉnh sửa cho một `Term` |
| `TermLocationCorrection` | Đề xuất chỉnh sửa tại từng `TermLocation` |
| `CorrectionOption` | Lựa chọn thay thế cho correction workflow |
| `ElementTranslate` | Đơn vị dịch hoặc cấu hình dịch bổ sung gắn với `Audio` |

### Nhóm dịch lô và chuyển đổi ngôn ngữ

| Entity | Vai trò |
| --- | --- |
| `ElementBatch` | Nhóm `Audio` theo lô để thực hiện dịch hàng loạt |
| `BatchTranslate` | Bản ghi dịch theo từng ngôn ngữ cho một `ElementBatch` |
| `Language` | Danh mục ngôn ngữ; dùng cho `Video`, `Term`, `Voice`, `DictionaryWord`, `TranslateWord` |
| `Voice` | Giọng đọc/TTS voice; gắn với `Language` và `DataService` |
| `DataService` | Cấu hình dịch vụ ngoại vi như API, TTS, AI hoặc service code |
| `DataServiceParameter` | Tham số của `DataService` |
| `SoftwareServiceType` | Nhóm loại dịch vụ như `TTS` hoặc phân loại data service |

### Nhóm từ điển và ngữ âm

| Entity | Vai trò |
| --- | --- |
| `Dictionary` | Từ điển nghiệp vụ để nạp/xuất thuật ngữ |
| `DictionaryWord` | Từ mục gốc trong từ điển |
| `TranslateWord` | Các bản dịch theo ngôn ngữ của `DictionaryWord` |
| `SpellingWord` | Mẫu phiên âm hoặc phát âm |
| `LanguageSpelling` | Bảng nối `SpellingWord` với `Language` hoặc ngôn ngữ âm |
| `Word` | Từ vựng đã chuẩn hóa theo ngôn ngữ |
| `WordNoSign` | Biến thể không dấu của từ |

## Workflow chính

### 1. Tổ chức tài liệu trong cây thư mục

- `Folder` là điểm vào chính của hệ thống cũ.
- `Folder` tạo thành cây `UpperFolder -> LowerFolder`.
- Các đối tượng nghiệp vụ được treo vào folder: `Video`, `Post`, `BookMark`, `Product`.
- `FolderViewController` cho thấy hệ thống cũ có luồng chọn tập thể, export ra máy và lọc theo nhóm thư mục.

### 2. Nạp nguồn vào hệ thống

- Nguồn ban đầu thường đi qua `BookMark`.
- `BookMarkViewController` hỗ trợ dán URL, kiểm tra URL hỏng, đếm thời lượng, đồng bộ ghi chú, đối soát khớp đối tượng.
- `BookMark` có thể trỏ đến `Folder`, `Video`, `Post`, `Product`.
- `TranslateObjectViewController.ImportObjectElement` và `VideoService.FillContentFromHtmlNode(...)` cho thấy một luồng quan trọng: nạp HTML hoặc tài liệu nguồn thành danh sách `Audio`.

### 3. Quản lý tư liệu trung tâm (`Video`)

- `Video` là aggregate root của nghiệp vụ `Document`.
- Một `Video` lưu metadata tài liệu: mã, tên, loại tài liệu, ngôn ngữ gốc/dịch, thư mục, ghi chú.
- Từ `Video`, hệ thống quản lý các danh sách con:
- `AudioList`
- `TermList`
- `ElementBatchList`
- `MediaList`
- `ParagraphList`
- `ParagraphStyleList`
- `TranslateObjectList`
- `FileList` (`BookMark`)
- `DocumentType` trên `Video` cho thấy hệ thống cũ dùng chung một model cho các chế độ như `Analysis`, `Translation`, `VoiceOver`, `Editing`, `Video`.

### 4. Phân đoạn nội dung thành `Audio`

- `Audio` là đơn vị thao tác chính của quá trình biên tập.
- Mỗi `Audio` thuộc về một `Video`, có thể thuộc `Paragraph`, `ElementBatch`, `TranslateObject`, `BookMark`.
- `AudioViewController` cho thấy các thao tác nghiệp vụ cũ:
- đồng bộ dịch ngữ/element translate
- tìm kiểu chữ
- sửa hoa/thường
- tính voice speed
- nạp thuật ngữ từ thành phần
- kiểm tra chính tả
- tách/gộp thành phần
- canh hàng, đồng bộ timestamp, đánh cờ

### 5. Trích xuất và quản lý thuật ngữ

- `TermService.ImportTermsFromDictionaries(...)` cho thấy luồng nạp thuật ngữ từ `Dictionary` vào `Video`.
- `Term` được tạo theo `Video` + `Language`, sau đó cập nhật vị trí xuất hiện bằng `UpdatePosition(...)`.
- `TermLocation` là bảng thực thi nghiệp vụ quan trọng nhất của term: nó gắn `Term` với từng `Audio`.
- `TermViewController` cho thấy các luồng cũ:
- import term từ dictionary, từ cụm từ, chữ hoa, số, ngày giờ
- cập nhật vị trí/xuất hiện
- mở các element có term
- tách/gộp term
- dịch term theo context
- thay bản dịch trên từng vị trí
- đồng bộ case và đồng bộ term
- xuất term ngược lại ra dictionary/word list

### 6. Chỉnh sửa vị trí term

- `TermLocationViewController` cho thấy workflow sửa tại vị trí:
- thay term/bản dịch ngay trên từng location
- di chuyển vị trí tiến/lùi
- xử lý overlap
- đồng bộ term location
- mở element gốc
- đánh cờ và xử lý spelling
- `TermCorrection` và `TermLocationCorrection` là lớp đề xuất sửa lỗi.
- `TermLocationCorrectionViewController.AutoCorrect` cho thấy hệ thống cũ có chế độ tự sửa khi correction chỉ có một lựa chọn hợp lệ.

### 7. Dịch lô theo nhóm element

- `ElementBatch` gom nhóm `Audio` của một `Video`.
- `BatchTranslateService.CreateBatchTranslate(...)` tạo `BatchTranslate` theo từng ngôn ngữ trong `Video.LanguageList`.
- `BatchTranslateViewController` cho thấy workflow cũ:
- tạo batch translate
- tạo prompt/lệnh dịch vào clipboard
- reverse translate
- dịch từng lô
- đồng bộ, khớp dòng giữa các ngôn ngữ
- xuất ngược kết quả ra `Audio`
- Workflow này cho thấy hệ thống cũ được vận hành nửa thủ công, nửa bán tự động: sinh prompt, đưa vào clipboard, nhận kết quả, sau đó canh dòng và import lại.

### 8. Quản lý đoạn văn, style và media

- `Paragraph` nhóm các `Audio` và `Media` theo khối nội dung.
- `ParagraphStyle` lưu style font, căn lề, spacing gốc và style dịch.
- `Media` lưu shape, hình hoặc khung media trong tài liệu.
- `VideoService.ExportMedia(...)` cho thấy workflow export ngược ra file Word/docx và map lại media/shape.
- Nhóm này cho thấy hệ thống cũ không chỉ quản lý subtitle/text mà còn bảo toàn cấu trúc trình bày của tài liệu Word.

### 9. Đối tượng dịch HTML ngoại biên (`TranslateObject`)

- `TranslateObject` lưu `Content` HTML, `ObjectID`, `SystemType`, `Field`, `Video`.
- `TranslateObjectViewController` cho thấy hai hướng:
- import nội dung HTML thành `Audio`
- export nội dung đã dịch quay lại field của object đích, ví dụ `Post.Content`
- Đây là cầu nối giữa module `Document` và các object nội dung ngoại vi.

### 10. Cấu hình ngôn ngữ, giọng đọc và data service

- `Language`, `Voice`, `DataService`, `DataServiceParameter`, `SoftwareServiceType` là nhóm cấu hình kỹ thuật.
- `Voice` thuộc `Language` và `DataService`.
- `DataService` có `ParameterList`, `VoiceList`, và thuộc `SoftwareServiceType`.
- Nhóm này phục vụ:
- translation service
- TTS/voice over
- similarity/matching
- các thao tác AI/service bên ngoài trong hệ thống cũ

## Quan hệ giữa các entity

### Quan hệ trung tâm

| Từ entity | Quan hệ | Đến entity | Ghi chú |
| --- | --- | --- | --- |
| `Folder` | 1-n | `Folder` | Cây thư mục cha-con (`UpperFolder` / `LowerFolder`) |
| `Folder` | 1-n | `Video` | Thư mục chứa tư liệu |
| `Folder` | 1-n | `Post` | Thư mục chứa bài viết |
| `Folder` | 1-n | `BookMark` | Thư mục chứa nguồn/liên kết |
| `Folder` | n-n / 1-n | `Product` | Vừa có `ProductList`, vừa có `GroupProductList` |
| `Video` | 1-n | `Audio` | `Video-AudioList`, aggregate quan trọng nhất |
| `Video` | 1-n | `ElementBatch` | Gom nhóm element để dịch lô |
| `Video` | 1-n | `Term` | Danh sách thuật ngữ của tài liệu |
| `Video` | 1-n | `Media` | Hình, shape, media trong tài liệu |
| `Video` | 1-n | `Paragraph` | Đoạn văn |
| `Video` | 1-n | `ParagraphStyle` | Style tài liệu |
| `Video` | 1-n | `TranslateObject` | Nội dung HTML cần dịch/xuất lại |
| `Video` | 1-n | `BookMark` | `FileList`, tệp/liên kết nguồn của video |
| `Video` | n-n | `Language` | `LanguageList-VideoList`; video dùng đa ngôn ngữ |

### Quan hệ trong luồng nội dung

| Từ entity | Quan hệ | Đến entity | Ghi chú |
| --- | --- | --- | --- |
| `Audio` | n-1 | `Video` | Mỗi element thuộc một video |
| `Audio` | n-1 | `Voice` | Giọng đọc/TTS |
| `Audio` | n-1 | `Paragraph` | Element nằm trong đoạn văn |
| `Audio` | n-1 | `ParagraphStyle` | Style áp cho element |
| `Audio` | n-1 | `ElementBatch` | Element thuộc một lô dịch |
| `Audio` | n-1 | `BookMark` | Element gắn nguồn/liên kết |
| `Audio` | n-1 | `TranslateObject` | Element sinh ra từ object HTML |
| `Audio` | 1-n | `ElementTranslate` | Dữ liệu dịch/voice bổ sung theo element |
| `Audio` | 1-n | `TermLocation` | Các vị trí thuật ngữ trong element |
| `Paragraph` | 1-n | `Audio` | Nhóm text |
| `Paragraph` | 1-n | `Media` | Nhóm media cùng đoạn |
| `Media` | n-1 | `Video` | Media của tài liệu |
| `Media` | n-1 | `Paragraph` | Media trong một đoạn |
| `Media` | n-n / tham chiếu | `Audio` | Quan hệ `AudioList-MediaList` |
| `Media` | n-1 | `BookMark` | Media có thể gắn bookmark nguồn |

### Quan hệ trong luồng thuật ngữ

| Từ entity | Quan hệ | Đến entity | Ghi chú |
| --- | --- | --- | --- |
| `Term` | n-1 | `Video` | Mỗi term thuộc về một tài liệu |
| `Term` | n-1 | `Language` | Ngôn ngữ của term |
| `Term` | 1-n | `TermLocation` | Các lần xuất hiện của term |
| `TermLocation` | n-1 | `Audio` | Vị trí term nằm trong một element |
| `TermCorrection` | n-1 | `Term` | Phiên hoặc chu kỳ sửa cho term |
| `TermCorrection` | 1-n (logic) | `TermLocationCorrection` | Danh sách correction theo từng vị trí |
| `TermLocationCorrection` | n-1 | `TermLocation` | Lỗi sửa tại một vị trí cụ thể |
| `TermLocationCorrection` | n-n (logic) | `CorrectionOption` | Danh sách phương án thay thế |

### Quan hệ trong luồng dịch lô và cấu hình

| Từ entity | Quan hệ | Đến entity | Ghi chú |
| --- | --- | --- | --- |
| `ElementBatch` | n-1 | `Video` | Lô thuộc một video |
| `ElementBatch` | 1-n | `Audio` | Tập element trong lô |
| `ElementBatch` | 1-n | `BatchTranslate` | Bản dịch theo ngôn ngữ |
| `BatchTranslate` | n-1 | `ElementBatch` | Bản ghi dịch của lô |
| `BatchTranslate` | n-1 | `Language` | Ngôn ngữ dịch của lô |
| `Voice` | n-1 | `Language` | Mỗi voice thuộc một ngôn ngữ |
| `Voice` | n-1 | `DataService` | Voice được cấp bởi một data service |
| `DataService` | 1-n | `DataServiceParameter` | Tham số kết nối/gọi service |
| `DataService` | 1-n | `Voice` | Voice TTS |
| `DataService` | n-1 | `SoftwareServiceType` | Phân loại service |

### Quan hệ trong luồng từ điển

| Từ entity | Quan hệ | Đến entity | Ghi chú |
| --- | --- | --- | --- |
| `Dictionary` | 1-n | `DictionaryWord` | Từ mục thuộc từ điển |
| `DictionaryWord` | 1-n | `TranslateWord` | Mỗi từ có nhiều bản dịch theo ngôn ngữ |
| `DictionaryWord` | n-1 | `Dictionary` | Thuộc một từ điển |
| `TranslateWord` | n-1 | `Language` | Ngôn ngữ dịch |
| `SpellingWord` | n-1 | `Language` | Mẫu phiên âm theo ngôn ngữ |
| `SpellingWord` | 1-n | `LanguageSpelling` | Chi tiết phát âm/ngôn ngữ |

## Tổng kết ngắn

Hệ thống cũ `Document` là một ứng dụng desktop XAF/XPO có tâm là `Video`. Mọi nghiệp vụ quan trọng đều quay quanh việc:

- tổ chức nguồn trong `Folder` và `BookMark`
- biến đổi nguồn thành `Audio`
- trích xuất và quản lý `Term` cùng `TermLocation`
- dịch lô qua `ElementBatch` và `BatchTranslate`
- giữ cấu trúc trình bày qua `Paragraph`, `ParagraphStyle`, `Media`
- xuất kết quả quay lại object ngoại biên qua `TranslateObject`

Nói cách khác, đây là hệ thống xử lý tài liệu đa bước, kết hợp quản lý nguồn, phân đoạn nội dung, thuật ngữ, dịch thuật, voice và export tài liệu trong cùng một domain model cũ.
