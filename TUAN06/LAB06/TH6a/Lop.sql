-- 1. Tạo bảng Lop (nếu chưa có)
CREATE TABLE Lop (
    MaLop VARCHAR(10) PRIMARY KEY,
    TenLop NVARCHAR(50),
    MaKhoa VARCHAR(10)
);

-- Thêm dữ liệu mẫu cho bảng Lop
INSERT INTO Lop VALUES 
('L01', N'Lớp CNTT 1', 'CNTT'),
('L02', N'Lớp CNTT 2', 'CNTT'),
('L03', N'Lớp Kinh tế 1', 'KT');

-- 2. Tạo bảng SinhVien
CREATE TABLE SinhVien (
    MaSinhVien VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50),
    NgaySinh DATE,
    MaLop VARCHAR(10)
);

-- Thêm dữ liệu mẫu cho bảng SinhVien (Lưu ý định dạng ngày là YYYY-MM-DD)
INSERT INTO SinhVien VALUES 
('SV01', N'Nguyễn Văn A', '2003-05-15', 'L01'),
('SV02', N'Trần Thị B', '2003-08-20', 'L02');