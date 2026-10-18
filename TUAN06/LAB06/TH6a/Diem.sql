-- Tạo bảng Diem
CREATE TABLE Diem (
    MaSinhVien VARCHAR(10),
    MaMonHoc VARCHAR(10),
    Diem FLOAT,
    PRIMARY KEY (MaSinhVien, MaMonHoc) -- Khóa chính gồm 2 cột
);

-- Thêm dữ liệu mẫu (Dùng các mã đã có ở bài trước: SV01, SV02 và MH01, MH02...)
INSERT INTO Diem VALUES 
('SV01', 'MH01', 8.5),
('SV01', 'MH02', 7.0),
('SV02', 'MH01', 9.0),
('SV02', 'MH03', 6.5),
('SV03', 'MH02', 10.0); 
-- Lưu ý: Nếu lúc nãy bạn chưa thêm SV03 vào bảng SinhVien thì dòng cuối sẽ báo lỗi khóa ngoại. 
-- Nếu lỗi, bạn chỉ cần xóa dòng cuối đi, hoặc thêm SV03 vào bảng SinhVien trước.