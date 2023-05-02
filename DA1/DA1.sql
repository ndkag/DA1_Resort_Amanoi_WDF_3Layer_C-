create database DA1
go
use DA1
go
--1.Bảng tài khoản
CREATE TABLE Account
(
    UserName VARCHAR(100) PRIMARY KEY,
	DisplayName nvarchar(100),
    Password VARCHAR(100) NOT NULL,
	Type int default 1 --User =1 and Admin =0.
);
insert into Account(UserName,DisplayName,Password,Type) values
('Khang', 'khang','202cb962ac59075b964b07152d234b70',1)

--2.Bảng khách hàng
CREATE TABLE KhachHang (
  MaKH INT PRIMARY KEY IDENTITY,
  TenKH NVARCHAR(50) NOT NULL,
  DiaChi NVARCHAR(100),
  SoDienThoai NVARCHAR(20),
  NgayTao DATETIME DEFAULT GETDATE()
);
--3. Bảng phòng
CREATE TABLE Phong (
  MaPhong INT PRIMARY KEY IDENTITY,
  TenPhong NVARCHAR(50) NOT NULL,
  TrangThaiPhong NVARCHAR(20) NOT NULL, --VD: trống, sửa chữa, nâng cấp
  GiaTien DECIMAL(18, 0) NOT NULL,
  SoLuongNguoi INT NOT NULL,
  KhaNangDatPhong INT NOT NULL --Là số ngày khách có thể thuê phòng
);
--4. Bảng đặt phòng
CREATE TABLE DatPhong (
  MaDatPhong INT PRIMARY KEY IDENTITY,
  MaKH INT NOT NULL,
  MaPhong INT NOT NULL,
  NgayDen DATETIME NOT NULL,
  NgayDi DATETIME NOT NULL,
  GhiChu NVARCHAR(100),
  FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) on delete cascade on update cascade,
  FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong) on delete cascade on update cascade
);
--5. Bảng dịch vụ
CREATE TABLE DichVu (
  MaDV INT PRIMARY KEY IDENTITY,
  TenDV NVARCHAR(50) NOT NULL,
  GiaTien DECIMAL(18, 0) NOT NULL
);
--6. Bảng chi tiết đặt phòng
CREATE TABLE ChiTietDatPhong (
  MaCTDP INT PRIMARY KEY IDENTITY,
  MaDatPhong INT NOT NULL,
  MaDV INT NOT NULL,
  SoLuong INT NOT NULL,
  GiaTien DECIMAL(18, 0) NOT NULL,
  FOREIGN KEY (MaDatPhong) REFERENCES DatPhong(MaDatPhong),
  FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV)
);
--7. Bảng nhân viên
CREATE TABLE NhanVien (
  MaNV INT PRIMARY KEY IDENTITY,
  TenNV NVARCHAR(50) NOT NULL,
  DiaChi NVARCHAR(100),
  SoDienThoai NVARCHAR(20),
  ViTri NVARCHAR(50) NOT NULL,
  Luong DECIMAL(18, 0) NOT NULL
);
--8. Bảng hoá đơn
CREATE TABLE HoaDon (
  MaHD INT PRIMARY KEY IDENTITY,
  MaDatPhong INT NOT NULL,
  TongTien DECIMAL(18, 0) NOT NULL,
  NgayThanhToan DATETIME,
  GhiChu NVARCHAR(100),
  FOREIGN KEY (MaDatPhong) REFERENCES DatPhong(MaDatPhong)
);


--Nhập dữ liệu bảng phòng
INSERT INTO Phong (TenPhong, TrangThaiPhong, GiaTien, SoLuongNguoi, KhaNangDatPhong)
VALUES (N'Phong doi', N'Trong', 1000000, 2, 10)
INSERT INTO Phong (TenPhong, TrangThaiPhong, GiaTien, SoLuongNguoi, KhaNangDatPhong)VALUES
(N'Phong don', N'Trong', 600000, 1, 10),
(N'Phong don1', N'Trong', 600000, 1, 10),
(N'Phòng gia đình', N'Trong', 2000000, 4, 10)
Go
--Nhập dữ liệu vào bảng DichVu:

INSERT INTO DichVu (TenDV, GiaTien)
VALUES (N'Giặt ủi', 50000),
(N'Đồ ăn nhẹ', 20000),
(N'Nước giải khát', 15000),
(N'Bể bơi', 50000);
GO
--  đặt phòng mới
DECLARE @MaKH INT = (SELECT MaKH FROM KhachHang WHERE TenKH = N'Nguyen Thi B')
DECLARE @MaPhong INT = (SELECT MaPhong FROM Phong WHERE TenPhong = N'Phong don')
INSERT INTO DatPhong (MaKH, MaPhong, NgayDen, NgayDi, GhiChu)
VALUES (@MaKH, @MaPhong, '2023-03-17', '2023-03-20', N'Ghi chu')
GO
--Nhập dữ liệu bảng khách hàng
INSERT INTO KhachHang ( TenKH, DiaChi,SoDienThoai)
VALUES (N'Nguyen Van A', N'123 Nguyen Hue, Quan 1, TP. Ho Chi Minh', '0901234567')
INSERT INTO KhachHang ( TenKH, DiaChi,SoDienThoai)
VALUES (N'Nguyen Thi B', N'50 Nguyen Hue, Quan 1, TP. Ho Chi Minh', '0901234568')
GO
--Nhập dữ liệu vào bảng ChiTietDatPhong:

DECLARE @MaDatPhong INT = (SELECT MaDatPhong FROM DatPhong WHERE MaKH = 2)
DECLARE @MaDV1 INT = (SELECT MaDV FROM DichVu WHERE TenDV = 'Giặt ủi')
DECLARE @MaDV2 INT = (SELECT MaDV FROM DichVu WHERE TenDV = 'Đồ ăn nhẹ')
INSERT INTO ChiTietDatPhong (MaDatPhong, MaDV, SoLuong, GiaTien)
VALUES (@MaDatPhong, @MaDV1, 2, 100000),
(@MaDatPhong, @MaDV2, 4, 80000);


--Nhập dữ liệu vào bảng NhanVien:

INSERT INTO NhanVien (TenNV, DiaChi, SoDienThoai, ViTri, Luong)
VALUES (N'Trần Văn A', N'12 Đường Trần Hưng Đạo, Quận 1, TP. Hồ Chí Minh', '0901234567', N'Lễ tân', 15000000),
(N'Nguyễn Thị B', N'50 Nguyễn Huệ, Quận 1, TP. Hồ Chí Minh', '0901234568', N'Nhân viên phục vụ', 7000000);
GO

--Nhập dữ liệu vào bảng HoaDon:

DECLARE @MaDP INT = (SELECT MaDatPhong FROM DatPhong WHERE MaKH = 15)
INSERT INTO HoaDon (MaDatPhong, TongTien, NgayThanhToan, GhiChu)
VALUES (@MaDP, 2500000, N'2023-03-20', N'Thanh toán tiền phòng và dịch vụ');
GO


--Nhập dữ liệu cho bảng tài khoản
INSERT INTO dbo.Account (UserName, DisplayName, Password, Type)
VALUES ('admin', N'Nguyễn Văn A', '123', 0),
('user', N'Nguyễn Thị Mậu', '123', 1);
INSERT INTO dbo.Account (UserName, DisplayName, Password, Type)
VALUES ('admin1', N'Nguyễn Văn C', '202cb962ac59075b964b07152d234b70', 0)

CREATE PROC USP_GetAccountByUserName
@userName  VARCHAR(100) 
as 
begin
	select *from dbo.Account where UserName = @userName
end
go



