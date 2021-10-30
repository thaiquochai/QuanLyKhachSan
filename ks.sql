CREATE DATABASE QuanLyKS
GO

USE QuanLyKS
GO

CREATE TABLE loaiphong
(
	maLphong NVARCHAR(20) PRIMARY KEY NOT NULL,
	tenLphong NVARCHAR(50) NOT NULL,
	dongia FLOAT NOT NULL
)

CREATE TABLE phong
(
	maphong NVARCHAR(20) PRIMARY KEY NOT NULL,
	tenphong NVARCHAR(50) NOT NULL,
	tinhtrang NVARCHAR(100) NOT NULL,
	maLphong NVARCHAR(20) NOT NULL
	FOREIGN KEY  (maLphong) REFERENCES dbo.loaiphong(maLphong) 
)

CREATE TABLE khachhang
(
	makh NVARCHAR(20) PRIMARY KEY NOT NULL,
	tenkh NVARCHAR(50) NOT NULL,
	ngaysinhkh DATE NOT NULL,
	gioitinhkh NVARCHAR(20) NOT NULL,
	diachikh NVARCHAR(200),
	sdtkh NVARCHAR(20),
	cmnd NVARCHAR(20),
	quoctich NVARCHAR(50),
	ngaydangky DATE,
	ngaynhan DATE NOT NULL,
	ngaytra DATE NOT NULL,
	maphong NVARCHAR(20) NOT NULL,
	FOREIGN KEY (maphong) REFERENCES dbo.phong(maphong)
)
CREATE TABLE nhanvien
(
	manv NVARCHAR(20) PRIMARY KEY NOT NULL,
	tennv NVARCHAR(50) NOT NULL,
	ngaysinhnv DATE,
	gioitinhnv NVARCHAR(20),
	diachinv NVARCHAR(200),
	sdtnv NVARCHAR(20),
	email NVARCHAR(100),
	chucvu NVARCHAR(100)
)
CREATE TABLE hoadon
(
	mahd NVARCHAR(20) PRIMARY KEY NOT NULL,
	makh NVARCHAR(20) NOT NULL,
	ngaylap DATE NOT NULL,
	songaytro INT NOT NULL,
	tienphong FLOAT NOT NULL,
	thanhtien FLOAT NOT NULL,
	maphong NVARCHAR(20) NOT NULL
	FOREIGN KEY (makh) REFERENCES dbo.khachhang(makh),
	FOREIGN KEY (maphong) REFERENCES dbo.phong(maphong)
	
)
CREATE TABLE taikhoan
(
	tentk NVARCHAR(50) PRIMARY KEY NOT NULL,
	matkhau NVARCHAR(200) NOT NULL,
	quyen INT,
	manv NVARCHAR(20) NOT NULL,
	FOREIGN KEY (manv) REFERENCES dbo.nhanvien(manv)
)

INSERT INTO dbo.loaiphong
        ( maLphong, tenLphong, dongia )
VALUES  ( N'T1', 
          N'THƯỜNG ĐƠN',
          250000  
          )
INSERT INTO dbo.loaiphong
        ( maLphong, tenLphong, dongia )
VALUES  ( N'T2', 
          N'THƯỜNG ĐÔI', 
          300000  
          )
INSERT INTO dbo.loaiphong
        ( maLphong, tenLphong, dongia )
VALUES  ( N'V1', 
          N'VIP ĐƠN', 
          300000 
          )                    
INSERT INTO dbo.loaiphong
        ( maLphong, tenLphong, dongia )
VALUES  ( N'V2', 
          N'VIP ĐÔI', 
          450000  
          )
 
 
 INSERT INTO dbo.phong
         ( maphong ,
           tenphong ,
           tinhtrang ,
           maLphong
         )
 VALUES  ( N'P01' , 
           N'Phòng 1' , 
           N'Trống' , 
           N'T1'  
         )     
---Thêm khach hang
INSERT INTO dbo.khachhang
        ( makh ,
          tenkh ,
          ngaysinhkh ,
          gioitinhkh ,
          diachikh ,
          sdtkh ,
          cmnd ,
          quoctich ,
          ngaydangky ,
          ngaynhan ,
          ngaytra ,
          maphong
        )
VALUES  ( N'KH01' , 
          N'Trần Văn Tèo' , 
          GETDATE() , 
          N'Nam' , 
          N'An Giang' , 
          N'01982323' , 
          N'398230' , -
          N'Việt Nam' , 
          GETDATE() , 
          GETDATE() , 
          GETDATE() , 
          N'P01' 
        )  
---Thêm nhân viên
INSERT INTO dbo.nhanvien
        ( manv ,
          tennv ,
          ngaysinhnv ,
          gioitinhnv ,
          diachinv ,
          sdtnv ,
          email ,
          chucvu
        )
VALUES  ( N'NV01' , 
          N'Nguyễn Quốc Nam' , 
          GETDATE() , 
          N'Nam' , 
          N'An Giang' , 
          N'018392992' , 
          N'nam@gmail.com' ,
          N'Giám đốc' 
        ) 
--Thêm hóa đơn
INSERT INTO dbo.hoadon
        ( mahd ,
          makh ,
          ngaylap ,
          songaytro ,
          tienphong ,
          thanhtien ,
          maphong
        )
VALUES  ( N'HD01' , 
          N'KH01' , 
          GETDATE() , 
          3 ,
          250000 , 
          750000, 
          N'P01'  

INSERT INTO dbo.taikhoan
        ( tentk, matkhau, quyen, manv )
VALUES  ( N'admin', 
          N'admin', 
          1, 
          N'NV01' 
          )  
UPDATE dbo.taikhoan SET matkhau=N'admin' WHERE tentk=N'admin' 
ALTER TABLE dbo.khachhang ADD tinhtrang NVARCHAR(50)  
SELECT * FROM dbo.taikhoan    
SELECT dbo.phong.tinhtrang FROM dbo.khachhang,dbo.phong     
WHERE khachhang.maphong=phong.maphong 

INSERT INTO dbo.taikhoan
        ( tentk, matkhau, quyen, manv )
VALUES  ( N'nv02', 
          N'NV02',
          2, 
          N'NV02'  
          )     
          
SELECT maphong FROM dbo.khachhang WHERE makh='KH04'
SELECT ngaynhan,ngaytra FROM dbo.khachhang WHERE maphong='P01'
SELECT * FROM dbo.khachhang 
SELECT dbo.loaiphong.dongia
FROM dbo.loaiphong,dbo.phong
WHERE loaiphong.maLphong=phong.maLphong AND maphong=N'P01'
SELECT * FROM dbo.phong
SELECT * FROM dbo.loaiphong

select * from hoadon where MONTH(ngaylap)=4 AND YEAR(ngaylap)=2018

