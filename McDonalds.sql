USE master
GO
if exists( select * from sysdatabases where name='MCDONALDS')
	drop database MCDONALDS
go
create database MCDONALDS
go
use MCDONALDS
go
CREATE TABLE NHANVIEN(
	ID NVARCHAR(12) PRIMARY KEY,
	HOTEN NVARCHAR(50) NOT NULL,
	NGAYSINH DATE NOT NULL,
	NGAYBATDAU DATE NOT NULL,
	NGAYKETTHUC DATE,
	HINHTHUC NVARCHAR(8) NOT NULL
)
GO