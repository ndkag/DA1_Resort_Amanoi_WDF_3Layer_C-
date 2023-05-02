create database QL_Resort_DA1
go
use QL_Resort_DA1
go
--1.Bảng tài khoản
CREATE TABLE Account
(
    UserName VARCHAR(100) PRIMARY KEY,
	DisplayName nvarchar(100),
    Password VARCHAR(100) NOT NULL,
	Type int default 1 --User =1 and Admin =0.
);



--7. Bảng nhân viên
CREATE TABLE NhanVien (
  MaNV varchar(10) PRIMARY KEY ,
  TenNV NVARCHAR(100) NOT NULL,
  DiaChi NVARCHAR(100),
  SoDienThoai NVARCHAR(10),
  ViTri NVARCHAR(50) NOT NULL,
  Luong DECIMAL(18, 0) NOT NULL
);
CREATE SEQUENCE SEQ_MaNV
AS INT
START WITH 1
INCREMENT BY 1
MINVALUE 1
MAXVALUE 99999
CYCLE;
ALTER TABLE NhanVien
ADD CONSTRAINT DF_NhanVien_MaNV
DEFAULT ('NV' + FORMAT(NEXT VALUE FOR SEQ_MaNV, '00000')) FOR MaNV;




CREATE TABLE KhachHang (
  MaKH varchar(10) PRIMARY KEY,
  TenKH NVARCHAR(100) NOT NULL,
  DiaChi NVARCHAR(100),
  SoDienThoai NVARCHAR(20),
  NgayTao date DEFAULT GETDATE()
);
CREATE SEQUENCE SEQ_MaKH
AS INT
START WITH 1
INCREMENT BY 1
MINVALUE 1
MAXVALUE 99999
CYCLE;
ALTER TABLE KhachHang
ADD CONSTRAINT DF_KhachHang_MaKH
DEFAULT ('KH' + FORMAT(NEXT VALUE FOR SEQ_MaKH, '00000')) FOR MaKH;



CREATE TABLE DichVu (
  MaDV varchar(10) PRIMARY KEY,
  TenDV NVARCHAR(100) NOT NULL,
  GiaTien DECIMAL(18, 0) NOT NULL
);
CREATE SEQUENCE SEQ_MaDV
AS INT
START WITH 1
INCREMENT BY 1
MINVALUE 1
MAXVALUE 99999
CYCLE;
ALTER TABLE DichVu
ADD CONSTRAINT DF_DichVu_MaDV
DEFAULT ('DV' + FORMAT(NEXT VALUE FOR SEQ_MaDV, '00000')) FOR MaDV;


CREATE TABLE Phong (
  MaPhong varchar(10) PRIMARY KEY,
  TenPhong NVARCHAR(50) NOT NULL,
  TrangThaiPhong NVARCHAR(20) NOT NULL, --VD: trống, sửa chữa, nâng cấp
  GiaTien Decimal NOT NULL check (GiaTien>0),
  SoLuongNguoi INT NOT NULL default 1 ,
  KhaNangDatPhong INT NOT NULL default 1 --Là số ngày khách có thể thuê phòng
);
CREATE SEQUENCE SEQ_MaPhong
AS INT
START WITH 1
INCREMENT BY 1
MINVALUE 1
MAXVALUE 99999
CYCLE;
ALTER TABLE Phong
ADD CONSTRAINT DF_Phong_MaPhong
DEFAULT ('P' + FORMAT(NEXT VALUE FOR SEQ_MaPhong, '00000')) FOR MaPhong;


CREATE TABLE DatPhong (
  MaDatPhong varchar(10) PRIMARY KEY,
  MaKH varchar(10) not null ,
  MaPhong varchar(10) NOT NULL,
  NgayDen date NOT NULL default getdate(),
  NgayDi date NOT NULL,
  GhiChu NVARCHAR(100),
  constraint FK_MaKH_DP  FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) on delete cascade on update cascade,
  constraint FK_MaPhong_DP  FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)on delete cascade on update cascade
);
CREATE SEQUENCE SEQ_MaDatPhong
AS INT
START WITH 1
INCREMENT BY 1
MINVALUE 1
MAXVALUE 99999
CYCLE;
ALTER TABLE DatPhong
ADD CONSTRAINT DF_DatPhong_MaDatPhong
DEFAULT ('DP' + FORMAT(NEXT VALUE FOR SEQ_MaDatPhong, '00000')) FOR MaDatPhong;


-- Bảng chi tiết chi tiết dịch vụ
CREATE TABLE ChiTietDichVu (
  MaDatPhong varchar(10)NOT NULL, 
  MaDV varchar(10) NOT NULL,
  TenDV nvarchar(100) not null,
  SoLuong DECIMAL NOT NULL, --Số lượng dịch vụ
  TongTien DECIMAL(18, 0) NOT NULL , --GiaTien của Dịch vụ * SoLuong
   constraint FK_MaDatPhong_CTDV FOREIGN KEY (MaDatPhong) REFERENCES DatPhong(MaDatPhong) on delete cascade on update cascade,
  constraint FK_MaDV_CTDV FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV) on delete cascade on update cascade
);
---------------------------------------------------------------------

select*from ChiTietDichVu
--8. Bảng hoá đơn
CREATE TABLE HoaDon (
  MaHD varchar(10) PRIMARY KEY NOT NULL,
  MaKH varchar(10) not null,
  MaNV varchar(10) NOT NULL,
  MaDatPhong varchar(10) NOT NULL,
  TongTien DECIMAL(18, 0) NOT NULL,
  NgayThanhToan date not null default getdate(),
  GhiChu NVARCHAR(100),
	constraint FK_MaDatPhong_HD FOREIGN KEY (MaDatPhong) REFERENCES DatPhong(MaDatPhong),
	constraint FK_NhanVien_HD FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) ,
		constraint FK_KhachHang_MaKH FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) 
);
CREATE SEQUENCE SEQ_MaHDB
AS INT
START WITH 1
INCREMENT BY 1
MINVALUE 1
MAXVALUE 99999
CYCLE;
ALTER TABLE HoaDon
ADD CONSTRAINT DF_HoaDon_MaHD
DEFAULT ('HD' + FORMAT(NEXT VALUE FOR SEQ_MaHDB, '00000')) FOR MaHD;

drop SEQUENCE SEQ_MaHDB

select *from HoaDon
SELECT DatPhong.MaDatPhong, DatPhong.MaKH, Phong.MaPhong, Phong.GiaTien ,DatPhong.GhiChu, DatPhong.NgayDen,DatPhong.NgayDi
FROM DatPhong
JOIN Phong ON DatPhong.MaPhong = Phong.MaPhong
WHERE DatPhong.MaDatPhong = 'DP2'

select DatPhong.MaKH,KhachHang.TenKH,KhachHang.SoDienThoai,KhachHang.DiaChi FROM KhachHang JOIN DatPhong ON DatPhong.MaKH = KhachHang.MaKH WHERE DatPhong.MaDatPhong = 'DP2'

SELECT *FROM HoaDon WHERE MaDatPhong = 'DP2'


SELECT MaDatPhong FROM DatPhong WHERE MaPhong = 'P1'

SELECT MAX(CAST(SUBSTRING(MaDatPhong, 5, LEN(MaDatPhong)-2) AS INT)) as MaxID FROM DatPhong
SELECT MAX(CAST(SUBSTRING(MaDatPhong, 3, LEN(MaDatPhong)-2) AS INT)) as MaxID FROM DatPhong
 
SELECT MAX(CAST(MaDatPhong AS INT)) FROM DatPhong
drop table HoaDon

SELECT MAX(CAST(SUBSTRING(MaDatPhong, 3, LEN(MaDatPhong)-2) AS INT)) as MaDatPhong FROM DatPhong WHERE MaPhong = '" + maPhong + "' GROUP BY MaPhong
select *from DatPhong

SELECT MAX(MaDatPhong) as MaDatPhong FROM DatPhong WHERE MaPhong = '" + maPhong + "' GROUP BY MaPhong

SELECT MONTH(NgayTao) AS Thang, COUNT(*) AS SoKhachHang
FROM KhachHang
WHERE NgayTao BETWEEN DATEADD(month, -12, GETDATE()) AND GETDATE()
GROUP BY MONTH(NgayTao)
ORDER BY MONTH(NgayTao) ASC
select *from KhachHang
SELECT 
    MONTH(NgayTao) AS Thang, 
    COUNT(*) AS SoKhachHang 
FROM KhachHang 
WHERE NgayTao BETWEEN DATEADD(month, -12, GETDATE()) AND GETDATE() 
GROUP BY MONTH(NgayTao) 
ORDER BY MONTH(NgayTao) ASC



SELECT MONTH(NgayTao) AS Thang, COUNT(*) AS SoLuong FROM KhachHang WHERE YEAR(NgayTao) = '2022' GROUP BY MONTH(NgayTao)


drop SEQUENCE SEQ_MaNV
ALTER TABLE NhanVien
DROP CONSTRAINT DF_NhanVien_MaNV;
delete from NhanVien
exec sp_helpconstraint DatPhong
select*from HoaDon


select dp.MaDatPhong,dp.MaPhong,p.TenPhong,dp.NgayDen,dp.NgayDi from DatPhong dp inner join Phong p on dp.MaPhong = p.MaPhong where month(dp.NgayDen)='4' and YEAR(dp.NgayDen)='2023'


SELECT DAY(NgayThanhToan) AS Ngay, SUM(TongTien) AS DoanhThu FROM HoaDon WHERE YEAR(NgayThanhToan) = '2023' AND MONTH(NgayThanhToan) = '4' GROUP BY DAY(NgayThanhToan)


SELECT DAY(NgayThanhToan) AS Ngày, SUM(TongTien) AS DoanhThu FROM HoaDon WHERE MONTH(NgayThanhToan) = '4' and YEAR(NgayThanhToan) = '2023' GROUP BY DAY(NgayThanhToan)