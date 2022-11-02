﻿USE master
GO
IF EXISTS( SELECT * FROM sysdatabases WHERE NAME='MCDONALDS')
	DROP DATABASE MCDONALDS
GO
CREATE DATABASE MCDONALDS
GO
USE MCDONALDS
GO
--BẢNG CHO LIÊN QUAN ĐẾN ĐẶT MÓN
CREATE TABLE TAIKHOANKH(
	IDKH VARCHAR(12),
	SDT VARCHAR(10) NOT NULL,
	EMAIL NVARCHAR(50),
	PASSWORD VARCHAR(18) NOT NULL,
	HOTEN NVARCHAR(50) NOT NULL,
	DIACHI NVARCHAR(100) NOT NULL,
	THUHANG INT,
	PRIMARY KEY(IDKH)
)
GO

--INSERT TÀI KHOẢN KHÁCH HÀNG
INSERT INTO TAIKHOANKH VALUES('KH0349780959', '0349780959', 'doankimyen1407@gmail.com', 'kyen1407', N'Đoàn Thị Kim Yến', N'Đại học Tôn Đức Thắng', 1)
INSERT INTO TAIKHOANKH VALUES('KH0834695543', '0834695543', 'tranngocanh2406@gmail.com', 'ant2406', N'Trần Thị Ngọc Ánh', N'Đại học Tôn Đức Thắng', 1)
INSERT INTO TAIKHOANKH VALUES('KH0337550422', '0337550422', 'maihoa792002@gmail.com', 'maihoa792002', N'Hoàng Thị Mai Hoa', N'Đại học Tôn Đức Thắng', 1)
INSERT INTO TAIKHOANKH VALUES('KH0917185388', '0917185388', 'trantrieunhuy@gmail.com', 'trieuhuy123', N'Đoagn Thị Kim Yến', N'Đại học Tôn Đức Thắng', 1)

GO
CREATE TABLE VOUCHER(
	IDVOUCHER VARCHAR(12),
	SOTIENGIAM INT NOT NULL,
	TGBATDAU DATETIME NOT NULL,
	TGKETTHUC DATETIME,
	DONVI NVARCHAR(3) NOT NULL,
	DK INT NOT NULL,
	TOIDA INT NOT NULL,
	PRIMARY KEY(IDVOUCHER)
)
GO

--INSERT VOUCHER
--INSERT INTO VOUCHER VALUES('VC0111220001', 50000, '01/11/2022', '11/11/2022', 'VIỆT NAM ĐỒNG', 0, 50000)

--TẠO HÀM TÍNH GIÁ TIỀN GIẢM CỦA VOUCHER
--GO
--CREATE TRIGGER TINHGIATIENVOUCHER ON VOUCHER
--FOR INSERT
--AS
--BEGIN
	--DECLARE @IDVOUCHER VARCHAR(12)
	--SET @IDVOUCHER = INSERTED.IDVOUCHER FROM INSERTED
	--DECLARE @GIAGOC INT
	--SET @GIAGOC = SELECT GIAGOC FROM HOADON WHERE IDVOUCHER = @IDVOUCHER
--END

CREATE TABLE SOHUU(
	IDKH VARCHAR(12),
	IDVOUCHER VARCHAR(12),
	SOLANSD INT,
	PRIMARY KEY(IDKH, IDVOUCHER),
	FOREIGN KEY(IDKH) REFERENCES TAIKHOANKH(IDKH),
	FOREIGN KEY(IDVOUCHER) REFERENCES VOUCHER(IDVOUCHER)
)
GO

CREATE TABLE HOADON(
	IDHD VARCHAR(9),
	TGLAP DATETIME NOT NULL,
	TONGTIEN INT NOT NULL,
	SOBOT INT NOT NULL,
	STT INT NOT NULL,
	GIAGOC INT NOT NULL,
	IDKH VARCHAR(12),
	IDVOUCHER VARCHAR(12),
	PRIMARY KEY(IDHD),
	FOREIGN KEY(IDKH) REFERENCES TAIKHOANKH(IDKH),
	FOREIGN KEY(IDVOUCHER) REFERENCES VOUCHER(IDVOUCHER)
)
GO

CREATE TABLE COMBO(
	IDCOMBO VARCHAR(9),
	TENCOMBO NVARCHAR(50) NOT NULL,
	GIACOMBO INT NOT NULL,
	TRANGTHAI NVARCHAR(10),
	PRIMARY KEY(IDCOMBO)
)
GO

--INSERT COMBO
INSERT INTO COMBO VALUES('COMBO0001', N'COMBO 2A', 129000, N'CÒN HÀNG')
INSERT INTO COMBO VALUES('COMBO0002', N'COMBO 2B', 175000, N'CÒN HÀNG')
INSERT INTO COMBO VALUES('COMBO0003', N'COMBO 2C', 185000, N'CÒN HÀNG')
INSERT INTO COMBO VALUES('COMBO0004', N'COMBO 81K', 81000, N'CÒN HÀNG')
INSERT INTO COMBO VALUES('COMBO0005', N'COMBO 3A', 279000, N'CÒN HÀNG')
INSERT INTO COMBO VALUES('COMBO0006', N'COMBO 3B', 289000, N'CÒN HÀNG')
GO

CREATE TABLE HDCOMBO(
	IDHD VARCHAR(9),
	IDCOMBO VARCHAR(9),
	SOLUONG FLOAT,
	PRIMARY KEY(IDHD, IDCOMBO),
	FOREIGN KEY(IDHD) REFERENCES HOADON(IDHD),
	FOREIGN KEY(IDCOMBO) REFERENCES COMBO(IDCOMBO)
)
GO

CREATE TABLE MON(
	IDMON VARCHAR(9),
	TENMON NVARCHAR(50) NOT NULL,
	GIAMON INT NOT NULL,
	TRANGTHAI NVARCHAR(10),
	PRIMARY KEY(IDMON)
)
GO

--INSERT MÓN ĂN
INSERT INTO MON VALUES('MON0001', N'1 MIẾNG GÀ RÁN - 183 KCAL', 39000, N'CÒN MÓN')
INSERT INTO MON VALUES('MON0002', N'6 MIẾNG CÁNH GÀ', 125000, N'CÒN MÓN')
INSERT INTO MON VALUES('MON0003', N'3 MIẾNG CÁNH GÀ MCWINGS', 69000, N'CÒN MÓN')
INSERT INTO MON VALUES('MON0004', N'PHẦN ĂN CƠM THỊT NƯỚNG', 46000, N'TẠM HẾT HÀNG')
INSERT INTO MON VALUES('MON0005', N'CƠM GÀ RÁN', 42000, N'CÒN MÓN')
INSERT INTO MON VALUES('MON0006', N'PHẦN ĂN CƠM THỊT NƯỚNG ỐP LA', 66000, N'TẠM HẾT HÀNG')
INSERT INTO MON VALUES('MON0007', N'BURGERS BÒ PHÔ MAI ĐẶT BIỆT', 49000, N'CÒN MÓN')
INSERT INTO MON VALUES('MON0008', N'BURGERS BIG MAC', 75000, N'CÒN MÓN')
INSERT INTO MON VALUES('MON0009', N'COCA-COLA', 20000, N'CÒN MÓN')
INSERT INTO MON VALUES('MON0010', N'KEM ỐC QUẾ', 10000, N'CÒN MÓN')
GO

CREATE TABLE HDMON(
	IDHD VARCHAR(9),
	IDMON VARCHAR(9),
	SOLUONG FLOAT,
	PRIMARY KEY(IDHD, IDMON),
	FOREIGN KEY(IDHD) REFERENCES HOADON(IDHD),
	FOREIGN KEY(IDMON) REFERENCES MON(IDMON)
)
GO

CREATE TABLE CTMON(
	IDCTMON VARCHAR(12),
	TIENTHEM INT NOT NULL,
	TRANGTHAI NVARCHAR(10),
	TENCTM NVARCHAR(50) NOT NULL,
	IDMON VARCHAR(9),
	PRIMARY KEY(IDCTMON),
	FOREIGN KEY(IDMON) REFERENCES MON(IDMON)
)
GO

CREATE TABLE HDCTMON(
	IDHD VARCHAR(9),
	IDCTMON VARCHAR(12),
	SOLUONG FLOAT,
	PRIMARY KEY(IDHD, IDCTMON),
	FOREIGN KEY(IDHD) REFERENCES HOADON(IDHD),
	FOREIGN KEY(IDCTMON) REFERENCES CTMON(IDCTMON)
)
GO

CREATE TABLE CTCOMBO(
	IDCOMBO VARCHAR(9),
	IDCTMON VARCHAR(12),
	SOLUONG FLOAT,
	PRIMARY KEY(IDCOMBO, IDCTMON),
	FOREIGN KEY(IDCOMBO) REFERENCES COMBO(IDCOMBO),
	FOREIGN KEY(IDCTMON) REFERENCES CTMON(IDCTMON)
)
GO

CREATE TABLE GIAMGIACB(
	IDGGCOMBO VARCHAR(12),
	GIABAN INT NOT NULL,
	TGBATDAU DATETIME NOT NULL,
	TGKETTHUC DATETIME,
	IDCOMBO VARCHAR(9),
	PRIMARY KEY(IDGGCOMBO),
	FOREIGN KEY(IDCOMBO) REFERENCES COMBO(IDCOMBO)
)
GO

CREATE TABLE GIAMGIAMON(
	IDGGMON VARCHAR(12),
	GIABAN INT NOT NULL,
	TGBATDAU DATETIME NOT NULL,
	TGKETTHUC DATETIME,
	IDMON VARCHAR(9),
	PRIMARY KEY(IDGGMON),
	FOREIGN KEY(IDMON) REFERENCES MON(IDMON)
)
GO

--BẢNG CHO NHÂN VIÊN VÀ TÀI KHOẢN
CREATE TABLE NHANVIEN(
	IDNV VARCHAR(12),
	HOTEN NVARCHAR(50) NOT NULL,
	EMAIL NVARCHAR(50),
	SDT VARCHAR(10) NOT NULL,
	PHANLOAINV NVARCHAR(10) NOT NULL,
	DIACHI NVARCHAR(100) NOT NULL,
	CHUCVU NVARCHAR(10) NOT NULL,
	PASSWORD VARCHAR(18),
	PRIMARY KEY(IDNV)
)
GO

CREATE TABLE TAIKHOAN(
	USERNAME VARCHAR(18),
	PASSWORD VARCHAR(18) NOT NULL,
	CHUCVU NVARCHAR(10) NOT NULL,
	PRIMARY KEY(USERNAME)
)
GO
INSERT INTO TAIKHOAN VALUES('admin',12345678,'QUAN LY')
INSERT INTO TAIKHOAN VALUES('kiemkho',12345678,'KIEM KHO')
GO

--BẢNG CHO QUẢN LÝ KHO
CREATE TABLE NGUYENLIEU(
	IDNL VARCHAR(9),
	TENNL NVARCHAR(50) NOT NULL,
	DONVI NVARCHAR(10) NOT NULL,
	PRIMARY KEY(IDNL)
)
GO

--INSERT NGUYÊN LIỆU
INSERT INTO NGUYENLIEU VALUES('NL0000001', N'THỊT BÒ ÚC', 'KG')
INSERT INTO NGUYENLIEU VALUES('NL0000002', N'KHOAI TÂY RUSSET BURBANK', 'KG')
INSERT INTO NGUYENLIEU VALUES('NL0000003', N'TRỨNG GÀ', 'TRỨNG')
INSERT INTO NGUYENLIEU VALUES('NL0000004', N'ĐÙI GÀ', 'KG')
INSERT INTO NGUYENLIEU VALUES('NL0000005', N'CÁNH GÀ', 'KG')
INSERT INTO NGUYENLIEU VALUES('NL0000006', N'BỘT CHIÊN GIÒN TAKI', 'THÙNG')
INSERT INTO NGUYENLIEU VALUES('NL0000007', N'BỘT CHIÊN XÙ TAKI', 'THÙNG')
INSERT INTO NGUYENLIEU VALUES('NL0000008', N'DẦU ĂN TRƯỜNG AN', 'THÙNG')
INSERT INTO NGUYENLIEU VALUES('NL0000009', N'PHÔ MAI LAVACHE QUIRIT', 'THÙNG')
INSERT INTO NGUYENLIEU VALUES('NL0000010', N'THỊT XÔNG KHÓI CANADA', 'KG')
GO

CREATE TABLE NHAPHANG(
	IDNH VARCHAR(12),
	TGNHAP DATETIME NOT NULL,
	NCC NVARCHAR(50) NOT NULL,
	PRIMARY KEY(IDNH)
)
GO

--INSERT NHẬP HÀNG
INSERT INTO NHAPHANG VALUES('NH2010220001', '2022-10-20', N'CÔNG TY CP FAMFOOD VIỆT NAM')
INSERT INTO NHAPHANG VALUES('NH2010220002', '2022-10-20', N'CÔNG TY TNHH BEL VIỆT NAM')
INSERT INTO NHAPHANG VALUES('NH2010220003', '2022-10-20', N'CÔNG TY TNHH THỰC PHẨM TAKI')
INSERT INTO NHAPHANG VALUES('NH2010220004', '2022-10-20', N'NHÀ PHÂN PHỐI TRỨNG GÀ HỒNG GÒ VẤP')
INSERT INTO NHAPHANG VALUES('NH2010220005', '2022-10-20', N'CÔNG TY CP DẦU THỰC VẬT TRƯỜNG AN')
GO

CREATE TABLE LOHANG(
	IDLH VARCHAR(18),
	SOLUONG FLOAT NOT NULL,
	HANSD DATETIME NOT NULL,
	IDNL VARCHAR(9),
	IDNH VARCHAR(12),
	PRIMARY KEY(IDLH),
	FOREIGN KEY(IDNL) REFERENCES NGUYENLIEU(IDNL),
	FOREIGN KEY(IDNH) REFERENCES NHAPHANG(IDNH)
)
GO

--INSERT LÔ HÀNG
INSERT INTO LOHANG VALUES('LH20102200010001', 200, '2022-11-20', 'NL0000001', 'NH2010220001')
INSERT INTO LOHANG VALUES('LH20102200010002', 500, '2022-11-20', 'NL0000004', 'NH2010220001')
INSERT INTO LOHANG VALUES('LH20102200010003', 500, '2022-11-20', 'NL0000005', 'NH2010220001')
INSERT INTO LOHANG VALUES('LH20102200010004', 200, '2022-11-20', 'NL0000010', 'NH2010220001')
INSERT INTO LOHANG VALUES('LH20102200020001', 50, '2022-11-20', 'NL0000009', 'NH2010220002')
INSERT INTO LOHANG VALUES('LH20102200030001', 100, '2022-11-20', 'NL0000006', 'NH2010220003')
INSERT INTO LOHANG VALUES('LH20102200030002', 100, '2022-11-20', 'NL0000007', 'NH2010220003')
INSERT INTO LOHANG VALUES('LH20102200040001', 500, '2022-11-20', 'NL0000003', 'NH2010220004')
INSERT INTO LOHANG VALUES('LH20102200050001', 100, '2022-11-20', 'NL0000008', 'NH2010220005')
GO

CREATE TABLE KIEMKHO(
	IDKK VARCHAR(12),
	TGKIEMTRA DATETIME NOT NULL,
	SOLUONG FLOAT NOT NULL,
	IDLH VARCHAR(18),
	PRIMARY KEY(IDKK),
	FOREIGN KEY(IDLH) REFERENCES LOHANG(IDLH)
)

--INSERT KIỂM KHO
INSERT INTO KIEMKHO VALUES('KK2010220001', '2022-10-20', 200, 'LH20102200010001')
INSERT INTO KIEMKHO VALUES('KK2010220002', '2022-10-20', 500, 'LH20102200010002')
INSERT INTO KIEMKHO VALUES('KK2010220003', '2022-10-20', 500, 'LH20102200010003')
INSERT INTO KIEMKHO VALUES('KK2010220004', '2022-10-20', 200, 'LH20102200010004')
INSERT INTO KIEMKHO VALUES('KK2010220005', '2022-10-20', 50, 'LH20102200020001')
INSERT INTO KIEMKHO VALUES('KK2010220006', '2022-10-20', 100, 'LH20102200030001')
INSERT INTO KIEMKHO VALUES('KK2010220007', '2022-10-20', 100, 'LH20102200030002')
INSERT INTO KIEMKHO VALUES('KK2010220008', '2022-10-20', 500, 'LH20102200040001')
INSERT INTO KIEMKHO VALUES('KK2010220009', '2022-10-20', 100, 'LH20102200050001')

