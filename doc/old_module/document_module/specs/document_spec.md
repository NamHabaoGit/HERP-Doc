# Module: Document

## Entities
- `Folder`: Cây thư mục nghiệp vụ để tổ chức tài liệu, nguồn liên kết và các đối tượng nội dung liên quan.
- `Video`: Đối tượng trung tâm của module, đại diện cho một tài liệu/tư liệu nguồn cần phân tích, dịch, biên tập hoặc xuất bản.
- `BookMark`: Nguồn đầu vào dạng liên kết, tập tin hoặc URL, dùng để nạp dữ liệu vào hệ thống và gắn nguồn cho các đối tượng nghiệp vụ.
- `Post`: Nội dung bài viết liên quan, có thể nhận nội dung dịch trả về từ module Document.
- `Product`: Đối tượng sản phẩm được liên kết từ nguồn hoặc thư mục, đóng vai trò đối tượng ngoại vi bao quanh nghiệp vụ tài liệu.
- `ObjectRelation`: Bản ghi quan hệ bổ sung giữa thư mục, bài viết và các đối tượng liên quan.
- `Audio`: Đơn vị nội dung thao tác chính của tài liệu, chứa đoạn text/subtitle cùng thông tin thời gian, giọng đọc và ghi chú.
- `Paragraph`: Khối đoạn văn dùng để nhóm các `Audio` và `Media`.
- `ParagraphStyle`: Thông tin định dạng trình bày của đoạn văn hoặc phần tử nội dung.
- `Media`: Thành phần hình ảnh, shape hoặc khung trình bày đi kèm tài liệu.
- `TranslateObject`: Gói nội dung HTML của đối tượng ngoại vi cần nhập vào để dịch và xuất ngược kết quả ra đối tượng đích.
- `Term`: Thuật ngữ của một tài liệu, có bản gốc, bản dịch, ngôn ngữ, loại và trạng thái xử lý.
- `TermLocation`: Vị trí xuất hiện của thuật ngữ trong từng `Audio`.
- `TermCorrection`: Phiên chỉnh sửa hoặc tập lỗi gắn với một thuật ngữ.
- `TermLocationCorrection`: Đề xuất chỉnh sửa tại từng vị trí xuất hiện của thuật ngữ.
- `CorrectionOption`: Phương án thay thế trong quy trình chỉnh sửa thuật ngữ.
- `ElementTranslate`: Dữ liệu dịch hoặc cấu hình dịch bổ sung gắn với từng `Audio`.
- `ElementBatch`: Nhóm các `Audio` theo lô để phục vụ dịch hàng loạt.
- `BatchTranslate`: Bản dịch của một lô theo từng ngôn ngữ.
- `Language`: Danh mục ngôn ngữ dùng cho tài liệu, thuật ngữ, giọng đọc và từ điển.
- `Voice`: Cấu hình giọng đọc/TTS theo ngôn ngữ và dịch vụ cung cấp.
- `DataService`: Dịch vụ kỹ thuật bên ngoài dùng cho dịch, TTS hoặc xử lý AI.
- `DataServiceParameter`: Tham số cấu hình của dịch vụ kỹ thuật.
- `SoftwareServiceType`: Phân loại loại dịch vụ kỹ thuật.
- `Dictionary`: Bộ từ điển nghiệp vụ để nạp và xuất thuật ngữ.
- `DictionaryWord`: Mục từ gốc của từ điển.
- `TranslateWord`: Bản dịch theo ngôn ngữ của một mục từ.
- `SpellingWord`: Dữ liệu phiên âm hoặc phát âm.
- `LanguageSpelling`: Liên kết giữa phát âm và ngôn ngữ.
- `Word`: Từ vựng chuẩn hóa theo ngôn ngữ.
- `WordNoSign`: Biến thể không dấu của từ.

## Business Rules
- `Video` là aggregate root của toàn bộ nghiệp vụ Document; các thành phần như `Audio`, `Term`, `ElementBatch`, `Paragraph`, `Media`, `TranslateObject` đều vận hành trong ngữ cảnh của một `Video`.
- `Folder` tổ chức dữ liệu theo cây cha-con và là điểm truy cập nghiệp vụ để gom nhóm `Video`, `BookMark`, `Post` và đối tượng liên quan.
- Nguồn dữ liệu đầu vào thường được tiếp nhận qua `BookMark`, sau đó được nhập thành nội dung chi tiết để xử lý trong `Video`.
- Một `Video` có thể vận hành ở nhiều chế độ tài liệu khác nhau như phân tích, dịch, lồng tiếng, biên tập hoặc xử lý video; cùng một mô hình dữ liệu được dùng xuyên suốt các chế độ này.
- `Audio` là đơn vị thao tác nhỏ nhất cho biên tập và dịch thuật; các thao tác kiểm tra, đồng bộ, tách/gộp, chỉnh chữ hoa-thường, tính tốc độ voice và đánh cờ đều diễn ra ở cấp này.
- `Audio` có thể đồng thời gắn với ngữ cảnh đoạn văn, style, lô dịch, nguồn bookmark hoặc đối tượng HTML nhập vào.
- Thuật ngữ luôn gắn với một `Video` và một `Language`; vị trí xuất hiện của thuật ngữ phải được quản lý tường minh qua `TermLocation`.
- Quy trình thuật ngữ phải hỗ trợ nạp từ từ điển, cập nhật vị trí xuất hiện, dịch theo ngữ cảnh, thay bản dịch theo từng vị trí, đồng bộ hình thức chữ và xuất ngược lại kho từ điển.
- Chỉnh sửa thuật ngữ được quản lý thành hai lớp: chỉnh sửa cấp thuật ngữ và chỉnh sửa cấp vị trí; nếu một lỗi chỉ có một phương án hợp lệ thì hệ thống cũ có khả năng tự sửa.
- `ElementBatch` được tạo để gom nhiều `Audio` của cùng một `Video`; mỗi ngôn ngữ mục tiêu có một `BatchTranslate` tương ứng.
- Dịch lô trong hệ thống cũ là quy trình bán tự động: sinh prompt/lệnh, đưa ra ngoài để dịch, nhận kết quả, canh dòng và nhập ngược lại vào `Audio`.
- `Paragraph`, `ParagraphStyle` và `Media` phải giữ được cấu trúc trình bày của tài liệu gốc, không chỉ lưu nội dung văn bản.
- `TranslateObject` là cầu nối giữa Document và các đối tượng ngoại vi; nội dung HTML có thể được nhập thành `Audio`, sau đó xuất ngược phần đã dịch vào đúng trường của đối tượng đích.
- `Language`, `Voice`, `DataService` và tham số dịch vụ là nhóm cấu hình nền để hỗ trợ translation, TTS, matching hoặc các xử lý AI/service ngoài hệ thống.
- Từ điển và ngữ âm là tài sản dùng chung cho chuẩn hóa thuật ngữ; module Document không chỉ tiêu thụ mà còn có khả năng xuất ngược thuật ngữ đã hiệu chỉnh về kho từ điển.

## Workflows
### 1. Tổ chức tài liệu
- Người dùng tạo và quản lý cây `Folder`.
- Tài liệu, nguồn liên kết và nội dung liên quan được treo dưới từng thư mục.
- Từ thư mục có thể thực hiện lọc, chọn nhiều đối tượng và xuất dữ liệu phục vụ vận hành.

### 2. Nạp nguồn tài liệu
- Người dùng đưa nguồn vào hệ thống qua `BookMark` hoặc nội dung HTML.
- Hệ thống kiểm tra nguồn, đồng bộ thông tin phụ trợ và liên kết nguồn với `Video` hoặc đối tượng liên quan.
- Nội dung nguồn được phân rã thành danh sách `Audio` để bắt đầu xử lý nghiệp vụ.

### 3. Quản lý tài liệu trung tâm
- Người dùng quản trị metadata của `Video` như mã, tên, loại tài liệu, ngôn ngữ, thư mục và ghi chú.
- Từ một `Video`, người dùng truy cập và vận hành toàn bộ danh sách con: `Audio`, `Term`, `ElementBatch`, `Media`, `Paragraph`, `ParagraphStyle`, `TranslateObject`, `BookMark`.

### 4. Biên tập nội dung theo phần tử
- Nội dung tài liệu được thao tác ở cấp `Audio`.
- Người dùng thực hiện các hành động biên tập như tách/gộp phần tử, sửa chính tả, đồng bộ timestamp, tính tốc độ giọng đọc, đồng bộ bản dịch hoặc đánh cờ xử lý.

### 5. Trích xuất và quản lý thuật ngữ
- Thuật ngữ được nạp từ từ điển hoặc sinh ra từ nội dung tài liệu.
- Hệ thống xác định vị trí xuất hiện của từng thuật ngữ trong các `Audio`.
- Người dùng dịch thuật ngữ, điều chỉnh bản dịch theo ngữ cảnh, cập nhật vị trí và đồng bộ lại toàn bộ tài liệu.

### 6. Chỉnh sửa tại vị trí thuật ngữ
- Người dùng xử lý lỗi hoặc thay thế tại từng `TermLocation`.
- Hệ thống hỗ trợ dịch chuyển vị trí, xử lý chồng lấn, mở phần tử nguồn, áp dụng correction và tự sửa khi chỉ có một lựa chọn hợp lệ.

### 7. Dịch lô nhiều ngôn ngữ
- Người dùng gom các `Audio` thành `ElementBatch`.
- Hệ thống tạo `BatchTranslate` theo từng ngôn ngữ mục tiêu.
- Người dùng sinh prompt/lệnh dịch, nhận kết quả dịch, canh dòng, đồng bộ giữa các ngôn ngữ và xuất ngược nội dung dịch vào `Audio`.

### 8. Bảo toàn cấu trúc trình bày
- `Paragraph`, `ParagraphStyle` và `Media` được dùng để duy trì khối nội dung, style và media của tài liệu gốc.
- Khi xuất ngược tài liệu, hệ thống phải map lại nội dung và media về đúng cấu trúc trình bày.

### 9. Dịch nội dung HTML của đối tượng ngoại vi
- Hệ thống nhập nội dung HTML của `TranslateObject` thành các `Audio`.
- Người dùng xử lý dịch trong module Document.
- Kết quả được xuất ngược về đúng field của đối tượng nguồn như bài viết hoặc đối tượng nghiệp vụ khác.

### 10. Quản lý cấu hình ngôn ngữ và dịch vụ
- Người dùng quản trị ngôn ngữ, giọng đọc và dịch vụ kỹ thuật.
- Các cấu hình này được dùng chung cho dịch thuật, lồng tiếng và các thao tác tự động hóa.

## Important Notes
- Hệ thống cũ pha trộn nhiều domain xung quanh `Document`; khi triển khai lại cần tách rõ phần lõi tài liệu với các đối tượng ngoại vi như `Post`, `Product` hoặc các quan hệ dùng chung.
- `Video` là trung tâm nghiệp vụ nhưng tên gọi này dễ gây hiểu nhầm vì dữ liệu thực tế bao phủ cả tài liệu văn bản, subtitle, voice-over và nội dung HTML; nên cân nhắc tên miền mới phản ánh đúng nghiệp vụ hơn.
- Mô hình cũ vận hành nửa thủ công, nửa bán tự động, đặc biệt trong workflow dịch lô; khi làm mới cần quyết định rõ phần nào tiếp tục cần con người can thiệp và phần nào sẽ tự động hóa.
- Cần bảo toàn khả năng truy vết từ nguồn đầu vào (`BookMark`, HTML, file) tới phần tử nội dung (`Audio`), thuật ngữ (`TermLocation`) và kết quả xuất ngược.
- Phần trình bày tài liệu là yêu cầu nghiệp vụ quan trọng, không được xem như dữ liệu phụ; việc triển khai lại phải hỗ trợ giữ paragraph, style, media và mapping khi export.
- Từ điển, thuật ngữ, voice và data service là tài sản dùng chung nhiều luồng; nên thiết kế thành năng lực nền tái sử dụng được thay vì gắn cứng vào một màn hình xử lý.
- Có rủi ro mô hình cũ đang chứa nhiều action UI desktop đặc thù; khi triển khai lại chỉ nên giữ quy tắc nghiệp vụ và tái thiết kế lại trải nghiệm thao tác phù hợp nền tảng mới.
