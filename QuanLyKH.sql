CREATE DATABASE QuanLyKH
ON PRIMARY 
(NAME=QuanLyKH_Data,
FILENAME='D:\ATVBMTT\QuanLyKH_Data.mdf',
SIZE=100MB,
MAXSIZE=unlimited,
FILEGROWTH=10%)

USE QuanLyKH
GO
CREATE TABLE QuanLyTK
(SoDienThoai nvarchar(20),
MatKhau nvarchar(20),
BiKhoan bit,
CONSTRAINT RB PRIMARY KEY (SoDienThoai))
