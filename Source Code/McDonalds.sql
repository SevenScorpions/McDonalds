﻿USE master
SET DATEFORMAT DMY
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
	HO NVARCHAR(30) NOT NULL,
	TEN NVARCHAR(30) NOT NULL,
	GIOITINH VARCHAR(1) NOT NULL,
	NGAYSINH DATETIME NOT NULL,
	SDT VARCHAR(10) NOT NULL,
	PASSWORD VARCHAR(18) NOT NULL,
	EMAIL NVARCHAR(50),
	DIACHI NVARCHAR(100) NOT NULL,
	THUHANG NVARCHAR(10),
	DIEMTHUONG INT,
	PRIMARY KEY(IDKH)
)
GO

--INSERT TÀI KHOẢN KHÁCH HÀNG
INSERT INTO TAIKHOANKH VALUES('KH0349780959', N'Đoàn',N'Thị Kim Yến','F','14/7/2002', '0349780959', 'kyen1407', 'doankimyen1407@gmail.com', N'Đại học Tôn Đức Thắng', N'Đồng', 0)
INSERT INTO TAIKHOANKH VALUES('KH0834695543', N'Trần',N'Thị Ngọc Ánh','F','24/6/2002', '0834695543', 'ant2406', 'tranngocanh2406@gmail.com', N'Đại học Tôn Đức Thắng', N'Bạc', 0)
INSERT INTO TAIKHOANKH VALUES('KH0337550422', N'Hoàng',N'Thị Mai Hoa','F','7/9/2002', '0337550422', 'maihoa792002', 'maihoa792002@gmail.com', N'Đại học Tôn Đức Thắng', N'Vàng', 0)
INSERT INTO TAIKHOANKH VALUES('KH0917185388', N'Trần',N'Triều Huy','M','29/10/2002', '0914722882', '0914722862aA', 'trantrieunhuy@gmail.com', N'Đại học Tôn Đức Thắng', N'Kim Cương', 0)

SELECT * FROM TAIKHOANKH
GO
CREATE TABLE VOUCHER(
	IDVOUCHER VARCHAR(12) NOT NULL,
	TENVOUCHER NVARCHAR(50) NOT NULL,
	SOTIENGIAM INT NOT NULL,
	TGBATDAU DATETIME NOT NULL,
	TGKETTHUC DATETIME,
	DONVI NVARCHAR(3) NOT NULL,
	DKGIATIEN INT,
	DKDIEMTHUONG INT,
	DKTHUHANG NVARCHAR(10),
	TOIDA INT,
	PRIMARY KEY(IDVOUCHER)
)
GO

--INSERT VOUCHER
INSERT INTO VOUCHER VALUES('VC0000000001',N'GIẢM GIÁ THÁNG 11', 25000, '01/11/2022', '01/12/2022', 'VND', 0, 0, N'Tất cả', 25000)
INSERT INTO VOUCHER VALUES('VC0000000002',N'GIẢM GIÁ THÁNG 12', 50000, '01/11/2022', '01/12/2022', 'VND', 100000, 0, N'Tất cả', 50000)
INSERT INTO VOUCHER VALUES('VC0000000003',N'GIẢM GIÁ THÁNG 11/11', 10, '01/11/2022', '01/12/2022', 'PER', 100000, 10, N'Tất cả', 100000)
INSERT INTO VOUCHER VALUES('VC0000000004',N'GIẢM GIÁ THÁNG 11', 15, '01/11/2022', '01/12/2022', 'PER', 150000, 15, N'Tất cả', 150000)
INSERT INTO VOUCHER VALUES('VC0000000005',N'ƯU ĐÃI MUA 2 TẶNG 1', 100000, '01/11/2022', '01/12/2022', 'VND', 50000, 10, N'Đồng', 100000)
INSERT INTO VOUCHER VALUES('VC0000000006',N'COMBO NỬA GIÁ', 200000, '01/11/2022', '01/12/2022', 'VND', 150000, 20, N'Bạc', 200000)
INSERT INTO VOUCHER VALUES('VC0000000007',N'ƯU ĐÃI KHÁCH HÀNG THÂN THIẾT 2', 10, '01/11/2022', '01/12/2022', 'PER', 50000, 10, N'Vàng', 150000)
INSERT INTO VOUCHER VALUES('VC0000000008',N'ƯU ĐÃI KHÁCH HÀNG THÂN THIẾT 1', 15, '01/11/2022', '01/12/2022', 'PER', 50000, 15, N'Kim cương', 300000)
INSERT INTO VOUCHER VALUES('VC0000000009',N'GIẢM 5% TỔNG HÓA ĐƠN', 5, '01/11/2022', '01/12/2022', 'PER', 50000, 10, N'TẤT CẢ', 50000)
INSERT INTO VOUCHER VALUES('VC0000000010',N'TẶNG 100K CHO HÓA ĐƠN 300K', 100000, '01/11/2022', '01/12/2022', 'VND', 300000, 20, N'TẤT CẢ', 100000)
SELECT * FROM VOUCHER
go
CREATE TABLE HOADON(
	IDHD VARCHAR(9),
	TGLAP DATETIME NOT NULL,
	TONGTIEN INT NOT NULL,
	SOBOT INT NOT NULL,
	STT INT NOT NULL,
	GIAGOC INT NOT NULL,
	IDKH VARCHAR(12),
	IDVOUCHER VARCHAR(12),
	TIENNHAN INT,
	TIENTRA INT,
	PRIMARY KEY(IDHD),
	FOREIGN KEY(IDKH) REFERENCES TAIKHOANKH(IDKH),
	FOREIGN KEY(IDVOUCHER) REFERENCES VOUCHER(IDVOUCHER)
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
INSERT INTO MON VALUES('MN0000001', N'1 MIẾNG GÀ RÁN - 183 KCAL', 39000, N'CÒN HÀNG')
INSERT INTO MON VALUES('MN0000002', N'6 MIẾNG CÁNH GÀ', 125000, N'CÒN HÀNG')
INSERT INTO MON VALUES('MN0000003', N'3 MIẾNG CÁNH GÀ MCWINGS', 69000, N'CÒN HÀNG')
INSERT INTO MON VALUES('MN0000004', N'PHẦN ĂN CƠM THỊT NƯỚNG', 46000, N'HẾT HÀNG')
INSERT INTO MON VALUES('MN0000005', N'CƠM GÀ RÁN', 42000, N'CÒN HÀNG')
INSERT INTO MON VALUES('MN0000006', N'PHẦN ĂN CƠM THỊT NƯỚNG ỐP LA', 66000, N'HẾT HÀNG')
INSERT INTO MON VALUES('MN0000007', N'BURGERS BÒ PHÔ MAI ĐẶT BIỆT', 49000, N'CÒN HÀNG')
INSERT INTO MON VALUES('MN0000008', N'BURGERS BIG MAC', 75000, N'CÒN HÀNG')
INSERT INTO MON VALUES('MN0000009', N'COCA-COLA', 20000, N'CÒN HÀNG')
INSERT INTO MON VALUES('MN0000010', N'KEM ỐC QUẾ', 10000, N'CÒN HÀNG')
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

CREATE TABLE COMBO(
	IDCOMBO VARCHAR(9) NOT NULL,
	TENCOMBO NVARCHAR(50) NOT NULL,
	GIACOMBO INT NOT NULL,
	TRANGTHAI NVARCHAR(10),
	PRIMARY KEY(IDCOMBO)
)
GO

--INSERT COMBO
INSERT INTO COMBO VALUES('CB0000001', N'COMBO 2A', 129000, N'CÒN HÀNG')
INSERT INTO COMBO VALUES('CB0000002', N'COMBO 2B', 175000, N'CÒN HÀNG')
INSERT INTO COMBO VALUES('CB0000003', N'COMBO 2C', 185000, N'CÒN HÀNG')
INSERT INTO COMBO VALUES('CB0000004', N'COMBO 81K', 81000, N'CÒN HÀNG')
INSERT INTO COMBO VALUES('CB0000005', N'COMBO 3A', 279000, N'CÒN HÀNG')
INSERT INTO COMBO VALUES('CB0000006', N'COMBO 3B', 289000, N'CÒN HÀNG')
GO

CREATE TABLE CTCOMBO(
	IDCOMBO VARCHAR(9) NOT NULL,
	IDCTMON VARCHAR(12) NOT NULL,
	SOLUONG INT,
	PRIMARY KEY(IDCOMBO, IDCTMON),
	FOREIGN KEY(IDCOMBO) REFERENCES COMBO(IDCOMBO),
	FOREIGN KEY(IDCTMON) REFERENCES CTMON(IDCTMON)
)
GO

--INSERT CHI TIẾT COMBO
--INSERT INTO CTCOMBO VALUES('CB0000001', 'MN00003', 1)
--INSERT INTO CTCOMBO VALUES('CB0000001', 'MN00008', 1)
--INSERT INTO CTCOMBO VALUES('CB0000002', 'MN00002', 1)
--INSERT INTO CTCOMBO VALUES('CB0000002', 'MN00007', 1)
--INSERT INTO CTCOMBO VALUES('CB0000002', 'MN00009', 1)
--INSERT INTO CTCOMBO VALUES('CB0000003', 'MN00002', 1)
--INSERT INTO CTCOMBO VALUES('CB0000003', 'MN00007', 1)
--INSERT INTO CTCOMBO VALUES('CB0000003', 'MN00009', 2)
--INSERT INTO CTCOMBO VALUES('CB0000004', 'MN00001', 2)
--INSERT INTO CTCOMBO VALUES('CB0000004', 'MN00010', 1)
--INSERT INTO CTCOMBO VALUES('CB0000005', 'MN00002', 1)
--INSERT INTO CTCOMBO VALUES('CB0000005', 'MN00008', 1)
--INSERT INTO CTCOMBO VALUES('CB0000005', 'MN00007', 1)
--INSERT INTO CTCOMBO VALUES('CB0000005', 'MN00009', 2)
--INSERT INTO CTCOMBO VALUES('CB0000006', 'MN00002', 1)
--INSERT INTO CTCOMBO VALUES('CB0000006', 'MN00008', 1)
--INSERT INTO CTCOMBO VALUES('CB0000006', 'MN00007', 1)
--INSERT INTO CTCOMBO VALUES('CB0000006', 'MN00009', 2)
--INSERT INTO CTCOMBO VALUES('CB0000006', 'MN00010', 2)

CREATE TABLE HDCOMBO(
	IDHD VARCHAR(9),
	IDCOMBO VARCHAR(9),
	SOLUONG FLOAT,
	PRIMARY KEY(IDHD, IDCOMBO),
	FOREIGN KEY(IDHD) REFERENCES HOADON(IDHD),
	FOREIGN KEY(IDCOMBO) REFERENCES COMBO(IDCOMBO)
)
GO

--INSERT CHI TIẾT MÓN
--INSERT INTO CTMON VALUES('CTM0001'

go
CREATE TABLE HDMON(
	IDHD VARCHAR(9),
	IDMON VARCHAR(9),
	SOLUONG FLOAT,
	PRIMARY KEY(IDHD, IDMON),
	FOREIGN KEY(IDHD) REFERENCES HOADON(IDHD),
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
	HO NVARCHAR(30) NOT NULL,
	TEN NVARCHAR(30) NOT NULL,
	GIOITINH VARCHAR(1) NOT NULL,
	NGAYSINH DATETIME NOT NULL,
	EMAIL NVARCHAR(50),
	SDT VARCHAR(10) NOT NULL,
	PHANLOAINV VARCHAR(10) NOT NULL,
	DIACHI NVARCHAR(100) NOT NULL,
	CHUCVU NVARCHAR(30) NOT NULL,
	PRIMARY KEY(IDNV)
)
GO

--INSERT NHÂN VIÊN
INSERT INTO NHANVIEN VALUES('NV0000000001', N'Đoàn',N'Thị Kim Yến','F','14/7/2002', 'Doankimyen1407@gmail.com', '0349780959', 'Fulltime', N'Đại học Tôn Đức Thắng', N'Nhân viên bán hàng')
INSERT INTO NHANVIEN VALUES('NV0000000002', N'Trần',N'Thị Ngọc Ánh','F','24/6/2002', 'Ngocanh2406@gmail.com', '0834695543', 'Fulltime', N'Đại học Tôn Đức Thắng', N'Bếp trưởng')
INSERT INTO NHANVIEN VALUES('NV0000000003', N'Hoàng',N'Thị Mai Hoa','F','7/9/2002', 'Maihoa792002@gmail.com', '0337550422', 'Fulltime', N'Đại học Tôn Đức Thắng', N'Nhân viên kho')
INSERT INTO NHANVIEN VALUES('NV0000000004', N'Tô',N'Ngọc Huyền','F','1/6/2002', 'Ngochuyen0106@gmail.com', '0917185399', 'Parttime', N'Đại học Tôn Đức Thắng', N'Nhân viên bếp')
INSERT INTO NHANVIEN VALUES('NV0000000005', N'Trần',N'Triều Huy','M','29/10/2002', 'Trantrieuhuy@gmail.com', '0917185366', 'Fulltime', N'Đại học Tôn Đức Thắng', N'Quản lý')

CREATE TABLE TAIKHOAN(
	USERNAME VARCHAR(18),
	PASSWORD VARCHAR(18) NOT NULL,
	CHUCVU NVARCHAR(30) NOT NULL,
	PRIMARY KEY(USERNAME)
)
GO
INSERT INTO TAIKHOAN VALUES('admin', '12345678', N'Quản lý')
INSERT INTO TAIKHOAN VALUES('kiemkho', '12345678', N'Nhân viên kho')
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
INSERT INTO NHAPHANG VALUES('NH2010220001', '20/10/2022', N'CÔNG TY CP FAMFOOD VIỆT NAM')
INSERT INTO NHAPHANG VALUES('NH2010220002', '20/10/2022', N'CÔNG TY TNHH BEL VIỆT NAM')
INSERT INTO NHAPHANG VALUES('NH2010220003', '20/10/2022', N'CÔNG TY TNHH THỰC PHẨM TAKI')
INSERT INTO NHAPHANG VALUES('NH2010220004', '20/10/2022', N'NHÀ PHÂN PHỐI TRỨNG GÀ HỒNG GÒ VẤP')
INSERT INTO NHAPHANG VALUES('NH2010220005', '20/10/2022', N'CÔNG TY CP DẦU THỰC VẬT TRƯỜNG AN')
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
INSERT INTO LOHANG VALUES('LH20102200010001', 200, '20/10/2022', 'NL0000001', 'NH2010220001')
INSERT INTO LOHANG VALUES('LH20102200010002', 500, '20/10/2022', 'NL0000004', 'NH2010220001')
INSERT INTO LOHANG VALUES('LH20102200010003', 500, '20/10/2022', 'NL0000005', 'NH2010220001')
INSERT INTO LOHANG VALUES('LH20102200010004', 200, '20/10/2022', 'NL0000010', 'NH2010220001')
INSERT INTO LOHANG VALUES('LH20102200020001', 50, '20/10/2022', 'NL0000009', 'NH2010220002')
INSERT INTO LOHANG VALUES('LH20102200030001', 100, '20/10/2022', 'NL0000006', 'NH2010220003')
INSERT INTO LOHANG VALUES('LH20102200030002', 100, '20/10/2022', 'NL0000007', 'NH2010220003')
INSERT INTO LOHANG VALUES('LH20102200040001', 500, '20/10/2022', 'NL0000003', 'NH2010220004')
INSERT INTO LOHANG VALUES('LH20102200050001', 100, '20/10/2022', 'NL0000008', 'NH2010220005')
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
INSERT INTO KIEMKHO VALUES('KK2010220001', '20/10/2022', 200, 'LH20102200010001')
INSERT INTO KIEMKHO VALUES('KK2010220002', '20/10/2022', 500, 'LH20102200010002')
INSERT INTO KIEMKHO VALUES('KK2010220003', '20/10/2022', 500, 'LH20102200010003')
INSERT INTO KIEMKHO VALUES('KK2010220004', '20/10/2022', 200, 'LH20102200010004')
INSERT INTO KIEMKHO VALUES('KK2010220005', '20/10/2022', 50, 'LH20102200020001')
INSERT INTO KIEMKHO VALUES('KK2010220006', '20/10/2022', 100, 'LH20102200030001')
INSERT INTO KIEMKHO VALUES('KK2010220007', '20/10/2022', 100, 'LH20102200030002')
INSERT INTO KIEMKHO VALUES('KK2010220008', '20/10/2022', 500, 'LH20102200040001')
INSERT INTO KIEMKHO VALUES('KK2010220009', '20/10/2022', 100, 'LH20102200050001')
