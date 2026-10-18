CREATE TABLE Khoa (
    MaKhoa VARCHAR(10) PRIMARY KEY,
    TenKhoa NVARCHAR(50)
);

INSERT INTO Khoa VALUES 
('CNTT', N'Công nghệ thông tin'),
('KT', N'Kinh tế'),
('DT', N'Điện tử'),
('CK', N'Cơ khí'),
('NN', N'Ngoại ngữ');