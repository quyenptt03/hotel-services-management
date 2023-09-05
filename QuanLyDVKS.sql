CREATE DATABASE QLDVKS
go
use QLDVKS
go

create table Phong
(id INT IDENTITY PRIMARY KEY,
TenPhong nvarchar(50),
GhiChu nvarchar(100) ,
status NVARCHAR(100) NOT NULL DEFAULT N'Trống')

go
create table KhachHang
(id INT IDENTITY PRIMARY KEY,
TenKH nvarchar(50) not null,
CMND_CCCD nvarchar(12) not null,
DiaChi  nvarchar(100),
SDT  nvarchar(100),
LoaiKH INT not null,
MaPhong int references Phong (id),
 ) 
go


create table HoaDon
(id INT IDENTITY PRIMARY KEY,
NgayLapHD Date NOT NULL DEFAULT GETDATE(),
NgayKetThucHD Date  ,
MaPhong int references Phong (id),
TongTien float DEFAULT 0 ,
GiamGia float DEFAULT 0,
ThanhTien float DEFAULT 0,
status INT NOT NULL DEFAULT 0,-- 1: đã thanh toán && 0: chưa thanh toán
) 
go

CREATE TABLE LoaiDichVu
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

create table DSDichVu
(
id INT IDENTITY PRIMARY KEY,
TenDV nvarchar(70) not null,
idLoaiDichVu INT references LoaiDichVu (id),
DonGia float not null,
DVT nvarchar(20)not null,
MoTa nvarchar(100)
)
go

create table ChiTietHD
(
MaHD int references HoaDon(id),
MaDV int references DSDichVu(id),
TenDV nvarchar(70),
SoLuong int  DEFAULT 0 ,
ThanhTien float  DEFAULT 0 ,
GhiChu nvarchar(100),
primary key (MaHD,MaDV) 
)
go


 create table DoanhThu
(
id INT IDENTITY PRIMARY KEY,
NgayLapHD Date NOT NULL ,
NgayKetThucHD Date not null,
MaHD int references HoaDon(id),
TenDV nvarchar(70)  ,
SoLuong int  DEFAULT 0 ,
DonGia int,
ThanhTien float DEFAULT 0,
)
go 



create table TaiKhoan
(
MaTaiKhoan char(6) primary key,
TenTaiKhoan nvarchar(70) not null,
PassWord NVARCHAR(1000) NOT NULL,
Type INT NOT NULL DEFAULT 0	-- 1: admin && 0: staff
)
go
--------=============================NHẬP LIỆU ======================

INSERT INTO dbo.TaiKhoan (MaTaiKhoan, TenTaiKhoan, PassWord, Type)
VALUES 
	(N'dtt', N'TIEU DIEP', N'123', 1),
	(N'da', N'THUY ANH', N'123', 1),
	(N'pt', N'THAO QUYEN', N'123', 0),
	(N'bt', N'THI THUY', N'123', 0)

SELECT * FROM dbo.TaiKhoan
GO
CREATE PROC USP_XemTaiKhoan
AS SELECT * FROM TaiKhoan
GO

--PHONG
--SET IDENTITY_INSERT [dbo].[Phong] ON
INSERT INTO Phong (TenPhong, GhiChu,Status)
VALUES 
		(N'P11', NULL, 0),
       (N'P21', NULL, 1),
       (N'P29', NULL, 1),
       (N'P31', NULL, 0)

SELECT * FROM dbo.Phong
GO
CREATE PROC USP_XemPhong
AS SELECT * FROM Phong
GO

EXEC USP_XemPhong
GO

--LOẠI DỊCH VỤ
INSERT LoaiDichVu(name) 
VALUES
	(N'Ăn uống'),
	(N'Đi lại'),
	(N'Giặt là'),
	(N'Spa'),
	(N'GiaiTri')

select * from LoaiDichVu

CREATE PROC USP_XemLoaiDichVu
AS SELECT * FROM LoaiDichVu
GO

EXEC USP_XemLoaiDichVu
GO
---DANH SÁCH DỊCH VỤ
INSERT DSDichVu(TenDV, idLoaiDichVu, DonGia,DVT,MoTa)
VALUES
	(N'Nhà hàng', 1, 30000,N'Lan',null),
	(N'Quầy bar ', 1, 20000,N'Lan',null),
	(N'Massage - bấm huyệt', 4, 120000,N'Lan',null),
	(N'Chăm sóc da mặt', 4, 50000,N'Lan',null),
	(N'Tắm trắng- tắm dưỡng', 4, 10000,N'Lan',null),
	(N'Xông hơi', 4, 10000,N'Lan',null),
	(N'Đưa đón sân bay', 2, 10000,N'Lan',null),
	(N'Thuê xe tự lái', 2, 10000,N'Lan',null),
	(N'Giặt khô', 3, 10000,N'Cai',null),
	(N'Giặt ướt', 3, 10000,N'Cai',null),
	(N'Sân golf và tennis', 5, 90000,N'Ngay',null),
	(N'Phòng thể hình', 5, 70000,N'Ngay',null),
	(N'Khu vui chơi phức hợp', 5, 70000,N'Ngay',null),
	(N'Phòng karaoke', 5, 90000,N'Ngay',null)
SELECT * FROM dbo.DSDichVu
go

CREATE PROC USP_XemDSDichVu
AS SELECT * FROM DSDichVu
GO

EXEC USP_XemDSDichVu
GO

---HÓA ĐƠN
INSERT INTO HoaDon (NgayLapHD, NgayKetThucHD, MaPhong, TongTien, GiamGia, ThanhTien, status)
VALUES ('2022-01-02', NULL, 1, 200000, 0, 200000, 0),
       ('2022-01-03', '2022-02-02', 2, 410000, 0, 410000, 1),
       ('2022-01-04', '2022-02-03', 3, 40000, 0, 40000, 1),
       ('2022-01-02', NULL, 4, 10000, 0, 10000, 0)

SELECT * FROM dbo.HoaDon
GO
CREATE PROC USP_XemHoaDon
AS SELECT * FROM HoaDon
GO

EXEC USP_XemHoaDon
GO	
--KHÁCH HÀNG
INSERT INTO KhachHang (TenKH, CMND_CCCD, DiaChi, SDT, LoaiKH, MaPhong)
VALUES (N'Nguyễn Thị Huệ', N'251291886', 'P8', N'354454182', 1, 1),
       (N'Nguyễn Thu Linh', N'251291887', 'P9', N'354454111', 0, NULL),
       (N'Trần Văn Hùng', N'251291888', NULL, N'354454222', 0, 4),
       (N'Nguyễn Văn Hưng', N'251291889', NULL, NULL, 1, NULL);

SELECT * FROM dbo.KhachHang
GO
CREATE PROC USP_XemKhachHang
AS SELECT * FROM KhachHang
GO

EXEC USP_XemKhachHang
GO	
-----------------------------------------------CẦN KIỂM TRA
---CHI TIẾT HÓA ĐƠN
INSERT INTO ChiTietHD (MaHD, MaDV, TenDV, SoLuong,  ThanhTien, GhiChu)
VALUES (1, 1, 'Nhà hàng', 2,60000, NULL),
       (1, 2, 'Quầy bar', 1, 20000, NULL),
       (1, 3, 'Massage - bấm huyệt', 1,  120000, NULL),
       (2, 3, 'Massage - bấm huyệt', 3, 360000, NULL),
       (2, 4, 'Chăm sóc da mặt', 1,  50000, NULL),
       (3, 5, 'Tắm trắng- tắm dưỡng', 1,  10000, NULL),
       (3, 6, 'Xông hơi', 1, 10000, NULL),
       (3, 7, 'Đưa đón sân bay', 2, 20000, NULL),
       (4, 5, 'Tắm trắng- tắm dưỡng', 1,  10000, NULL)

SELECT * FROM dbo.ChiTietHD
GO
SELECT * FROM ChiTietHD WHERE ChiTietHD.MaHD=1
SELECT * FROM ChiTietHD WHERE id =1
GO

EXEC USP_XemChiTietHD
GO	
set dateformat dmy
go
 -----DOANH THU
INSERT INTO DoanhThu (NgayLapHD, NgayKetThucHD, MaHD,TenDV, SoLuong, DonGia, ThanhTien)
VALUES ('03/01/2022', '02/02/2022', 2,  N'Massage - bấm huyệt', 3, 120000, 360000),
       ('03/01/2022', '02/02/2022', 2,  N'Chăm sóc da mặt', 1, 50000, 50000),
       ('04/01/2022', '03/02/2022', 3, N'Tắm trắng- tắm dưỡng', 1, 10000, 10000),
       ('04/01/2022', '03/02/2022', 3, N'Xông hơi', 1, 10000, 10000),
       ('03/01/2022', '05/02/2022', 3, N'Đưa đón sân bay', 2, 10000, 20000)
      

SELECT * FROM dbo.DoanhThu
GO
CREATE PROC USP_XemDoanhThu
AS SELECT * FROM DoanhThu
GO

EXEC USP_XemDoanhThu
GO

select * from KhachHang
select * from Phong
SELECT * FROM DSDichVu
SELECT * FROM LoaiDichVu
SELECT * FROM ChiTietHD
SELECT * FROM HoaDon



----------=======================THÊM XÓA SỬA
--PHÒNG
Create PROCEDURE [dbo].[Phong_InsertUpdateDelete]
 @ID int output, 
 @TenPhong nvarchar(200),
 @GhiChu nvarchar(100),
 @status NVARCHAR(100),
 @Action int -- Biến cho biết thêm, xóa, hay sửa
AS
-- Nếu Action = 0, thực hiện thêm dữ liệu
IF @Action = 0
	BEGIN
	INSERT INTO [Phong]( [TenPhong], [GhiChu], [Status])
		VALUES (@TenPhong, @GhiChu, @Status)
	SET @ID = @@identity -- Thiết lập ID tự tăng
	END
-- Nếu Action = 1, thực hiện cập nhật dữ liệu
ELSE IF @Action = 1
	BEGIN
	UPDATE [Phong]
		SET
			[TenPhong] = @TenPhong,
			[GhiChu] = @GhiChu,
			[Status] = @status
		WHERE ID = @ID
	END
-- Nếu Action = 2, thực hiện xóa dữ liệu
ELSE IF @Action = 2
	BEGIN
		DELETE FROM [Phong] WHERE [ID] = @ID
	END

---
---KHÁCH HÀNG
Create PROCEDURE [dbo].[KhachHang_InsertUpdateDelete]
	@ID int output, 
	@TenKH nvarchar(50),
	@CMND_CCCD nvarchar(12),
	@DiaChi NVARCHAR(100) null ,
	@SDT nvarchar(100)null ,
	@LoaiKH int ,
	@MaPhong int null ,
	@Action int -- Biến cho biết thêm, xóa, hay sửa
AS
-- Nếu Action = 0, thực hiện thêm dữ liệu
IF @Action = 0
	BEGIN
	INSERT INTO [KhachHang]( [TenKH], [CMND_CCCD], [DiaChi],[SDT],[LoaiKH],[MaPhong])
	VALUES (@TenKH,@CMND_CCCD,@DiaChi,@SDT,@LoaiKH,@MaPhong)
	SET @ID = @@identity -- Thiết lập ID tự tăng
	END
-- Nếu Action = 1, thực hiện cập nhật dữ liệu
ELSE IF @Action = 1
	BEGIN
		UPDATE [KhachHang]
		SET
			[TenKH] = @TenKH,
			[CMND_CCCD]=@CMND_CCCD,
			[DiaChi]=@DiaChi,
			[SDT]=@SDT,
			[LoaiKH]=@LoaiKH,
			[MaPhong] = @MaPhong
		WHERE ID = @ID
	END
ELSE IF @Action = 2
	BEGIN
		DELETE FROM [KhachHang] WHERE [ID] = @ID
	END




	---Xóa khách hàng

CREATE PROCEDURE sp_delete_KhachHang
@ID INT
AS
BEGIN
	DELETE FROM [KhachHang] WHERE [ID] = @ID
END
GO
---sửa khách hàng
Create PROCEDURE sp_update_KhachHang
	@ID int output, 
	@TenKH nvarchar(50),
	@CMND_CCCD nvarchar(12),
	@DiaChi NVARCHAR(100) null ,
	@SDT nvarchar(100)null ,
	@LoaiKH int ,
	@MaPhong int null	
AS
	BEGIN
		UPDATE [KhachHang]
		SET
			[TenKH] = @TenKH,
			[CMND_CCCD]=@CMND_CCCD,
			[DiaChi]=@DiaChi,
			[SDT]=@SDT,
			[LoaiKH]=@LoaiKH,
			[MaPhong] = @MaPhong
		WHERE ID = @ID
	END
go
--------Dịch vụ 
Create PROCEDURE [dbo].[DichVu_InsertUpdateDelete]
	@ID int output, 
	@TenDV NVARCHAR(70),
    @idLoaiDichVu INT,
    @DonGia FLOAT,
    @DVT NVARCHAR(20),
    @MoTa NVARCHAR(100)=null,
	@Action int -- Biến cho biết thêm, xóa, hay sửa
AS
-- Nếu Action = 0, thực hiện thêm dữ liệu
IF @Action = 0
	BEGIN
			INSERT INTO DSDichVu (TenDV, idLoaiDichVu, DonGia, DVT, MoTa)
			VALUES (@TenDV, @idLoaiDichVu, @DonGia, @DVT, @MoTa)
			SET @ID = @@identity -- Thiết lập ID tự tăng
	END
-- Nếu Action = 1, thực hiện cập nhật dữ liệu
ELSE IF @Action = 1
	BEGIN
		UPDATE DSDichVu
		SET
		TenDV = @TenDV,
		idLoaiDichVu = @idLoaiDichVu,
		DonGia = @DonGia,
		DVT = @DVT,
		MoTa = @MoTa
		WHERE id = @ID
	END
-- Nếu Action = 2, thực hiện xóa dữ liệu
ELSE IF @Action = 2
	BEGIN
	DELETE FROM [DSDichVu] WHERE [ID] = @ID
	END
	
----------Thêm xóa sửa TÀI KHOẢN
CREATE PROCEDURE [dbo].[TaiKhoan_InsertUpdateDelete]
    @MaTaiKhoan CHAR(6),
    @TenTaiKhoan NVARCHAR(70),
    @PassWord NVARCHAR(1000),
    @Type INT,
    @Action INT
AS
BEGIN
    IF @Action = 0
    BEGIN
        INSERT INTO TaiKhoan (MaTaiKhoan, TenTaiKhoan, PassWord, Type)
        VALUES (@MaTaiKhoan, @TenTaiKhoan, @PassWord, @Type)
    END
    ELSE IF @Action = 1
    BEGIN
        UPDATE TaiKhoan
        SET
            TenTaiKhoan = @TenTaiKhoan,
            PassWord = @PassWord,
            Type = @Type
        WHERE MaTaiKhoan = @MaTaiKhoan
    END
    ELSE IF @Action = 2
    BEGIN
        DELETE FROM TaiKhoan
        WHERE MaTaiKhoan = @MaTaiKhoan
    END
	ELSE IF @Action = 3
    BEGIN
       UPDATE TaiKhoan
        SET
            PassWord = @PassWord
        WHERE MaTaiKhoan = @MaTaiKhoan
    END
END



---Thêm xóa sửa LOẠI DỊCH VỤ
CREATE PROCEDURE [dbo].[LoaiDichVu_InsertUpdateDelete]
	@ID int OUTPUT,
	@Name NVARCHAR(100),
	@Action INT
AS
BEGIN
	-- Nếu Action = 0, thực hiện thêm dữ liệu
	IF @Action = 0
	BEGIN
		INSERT INTO LoaiDichVu (name)
		VALUES (@Name)
		SET @ID = SCOPE_IDENTITY() -- Thiết lập giá trị ID tự tăng trả về
	END
	-- Nếu Action = 1, thực hiện cập nhật dữ liệu
	ELSE IF @Action = 1
	BEGIN
		UPDATE LoaiDichVu
		SET name = @Name
		WHERE id = @ID
	END
	-- Nếu Action = 2, thực hiện xóa dữ liệu
	ELSE IF @Action = 2
	BEGIN
		DELETE FROM LoaiDichVu WHERE id = @ID
	END
END
------------------------------------------------------------------------------



---=====================================================CÁC XỬ LÝ
CREATE PROCEDURE USP_InsertIntoDoanhThu
	@ngaylapHD date,
	@ngayketthucHD date,
    @MaHD INT,
    @TenDV NVARCHAR(100),
    @SoLuong INT,
    @DonGia FLOAT,
    @ThanhTien FLOAT
AS
BEGIN
    IF EXISTS (SELECT * FROM ChiTietHD WHERE MaHD = @MaHD)and 
	 EXISTS (SELECT * FROM ChiTietHD WHERE TenDV = @TenDV)and
	EXISTS( SELECT * FROM HoaDOn WHERE HoaDon.status=1)
		BEGIN
			INSERT INTO DoanhThu (NgayLapHD,NgayKetThucHD,MaHD,TenDV,SoLuong, DonGia, ThanhTien)
				VALUES (@ngaylapHD ,@ngayketthucHD,@MaHD, @TenDV, @SoLuong, @DonGia, @ThanhTien)
		END
END


set dateformat dmy
EXECUTE dbo.USP_UpdateDoanhThu
--Thống ke thu nhập mà gôm dịch vụ
CREATE PROCEDURE USP_DoanhThuByDay--( là gom dịch vụ)
    @Ngay Date
AS
BEGIN
   SELECT dt.NgayLapHD,dt.NgayKetThucHD,dt.MaHD,dt.TenDV,sum(dt.ThanhTien) as'Thành tiền'
	FROM DoanhThu dt
	WHERE NgayKetThucHD = @Ngay -- Thay 'yyyy-mm-dd' bằng ngày cụ thể bạn muốn truy vấn
	Group by dt.NgayLapHD,dt.NgayKetThucHD,dt.MaHD,dt.TenDV
END
GO
--Thống kê thu nhập trong ngày từ các dịch vụ

set dateformat dmy
go
EXECUTE dbo.USP_DoanhThuByDay '2/2/2022'
select * from DoanhThu

--Kiểm tra 

---Thống kê doanh thu from day to day
CREATE PROC USP_DoanhThuByDate
@ngaylap Date, @ngayketthuc Date
AS
	
BEGIN
	SELECT *
	FROM DoanhThu
	WHERE  DoanhThu.NgayLapHD >= @ngaylap AND DoanhThu.NgayKetThucHD <= @ngayketthuc
END
GO
EXEC dbo.USP_DoanhThuByDate '3/1/2022', '3/2/2022'
GO
SELECT * FROM HoaDon
------------LIÊN QUAN ĐẾN DỊCH VỤ 
select * from DSDichVu
create proc USP_XemLoaiDV
as 
begin 
	select id from LoaiDichVu 
end 
--xuất ip Phong
create proc USP_XemIPPhong
as 
begin 
	select id 
	from Phong 
end 

EXEC USP_XemIPPhong
GO
CREATE PROCEDURE USP_SapTen
AS
BEGIN
    SELECT *
    FROM DSDichVu
    ORDER BY TenDV ASC
END
GO
EXEC USP_SapGia

--Liệt kê gia theo thứ tự
CREATE PROCEDURE USP_SapGia
AS
BEGIN
    SELECT *
    FROM DSDichVu
    ORDER BY DonGia ASC
END
GO
drop proc USP_SapTen
------------LIÊN QUAN ĐẾN XỦA LỨ PHÒNG
--Ds dich vu theo loai dich vu
Create PROCEDURE [DichVu_LoaiDV]
	@IDLoaiDV int
AS
BEGIN
	select *
	from DSDichVu dv
	where dv.idLoaiDichVu = @IDLoaiDV
END
GO

select * from DSDichVu

execute [dbo].[DichVu_LoaiDV] 2;

Create procedure [Phong_GetSingle]
@ID int
as
begin
	select *
	from Phong p
	where p.id = @ID
end
go

execute [dbo].[Phong_GetSingle] 2;

Create procedure [DichVu_GetSingle]
@ID int
as
begin
	select *
	from DSDichVu dv
	where dv.id = @ID
end
go

execute [dbo].[DichVu_GetSingle] 17;


create procedure getHDChuaThanhToan_TheoPhong
@IDPhong int
as
begin
	select * 
	from HoaDon
	where HoaDon.MaPhong = @IDPhong and HoaDon.status = 0
end
go
execute getHDChuaThanhToan_TheoPhong 11

create proc ChiTietHD_GetSingle
@MaHD int, @MaDV int 
as
begin
	select * 
	from ChiTietHD
	where ChiTietHD.MaHD=@MaHD and ChiTietHD.MaDV=@MaDV
end
go
execute ChiTietHD_GetSingle 1,17;


create procedure GetKhachHang_Phong
@IDPhong int
as
begin
	select *
	from Phong p, KhachHang kh 
	where p.id =@IDPhong and p.id=kh.MaPhong 
end
go

execute GetKhachHang_Phong 4

select * from KhachHang
create procedure [GetDSDichVu_Phong]
@IDPhong int
as
begin
	select hd.id as MaHD, dv.id as MaDV, dv.TenDV, dv.DonGia, SoLuong, DVT, cthd.ThanhTien, cthd.GhiChu
	from  Phong p
	inner join HoaDon hd on p.id=hd.MaPhong
	inner join ChiTietHD cthd on cthd.MaHD=hd.id
	inner join DSDichVu dv on dv.id = cthd.MaDV
	where p.id = @IDPhong and hd.status=0
end
go

execute [GetDSDichVu_Phong] 4

CREATE PROCEDURE [dbo].[HoaDon_InsertUpdateDelete]
	@ID int OUTPUT,
	@NgayLapHD DateTime,
	@NgayKetThucHD DateTime,
	@MaPhong int,
	@TongTien float,
	@GiamGia float,
	@ThanhTien float,
	@Status INT,
	@Action INT
AS
BEGIN
	-- Nếu Action = 0, thực hiện thêm dữ liệu
	IF @Action = 0
	BEGIN
		INSERT INTO HoaDon (NgayLapHD, NgayKetThucHD, MaPhong, TongTien, GiamGia, ThanhTien, Status)
		VALUES (@NgayLapHD, @NgayKetThucHD, @MaPhong, @TongTien, @GiamGia, @ThanhTien, @Status)
		SET @ID = SCOPE_IDENTITY() -- Thiết lập giá trị ID tự tăng trả về
	END
	-- Nếu Action = 1, thực hiện cập nhật dữ liệu
	ELSE IF @Action = 1
	BEGIN
		UPDATE HoaDon
		SET
			NgayLapHD = @NgayLapHD,
			NgayKetThucHD = @NgayKetThucHD,
			MaPhong = @MaPhong,
			TongTien = @TongTien,
			GiamGia = @GiamGia,
			ThanhTien = @ThanhTien,
			Status = @Status
		WHERE id = @ID
	END
	-- Nếu Action = 2, thực hiện xóa dữ liệu
	ELSE IF @Action = 2
	BEGIN
		DELETE FROM HoaDon WHERE id = @ID
	END
END

---------------------------------LIÊN QUAN ĐẾN TÀI KHOẢN
CREATE PROC USP_DangNhapByTenTK
@TenTaiKhoan NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan
END
GO

EXEC USP_DangNhapByTenTK @TenTaiKhoan = N'THUY ANH'
GO

CREATE PROC USP_Login
@TenTaiKhoan NVARCHAR(100),
@password NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan AND PassWord = @password
END
GO



CREATE PROCEDURE [dbo].[ChiTietHD_InsertUpdateDelete]
	@MaHD INT,
	@MaDV INT,
	@SoLuong INT,
	@ThanhTien FLOAT,
	@GhiChu NVARCHAR(100),
	@Action INT
AS
BEGIN
	-- Nếu Action = 0, thực hiện thêm dữ liệu
	IF @Action = 0
	BEGIN
		INSERT INTO ChiTietHD (MaHD, MaDV, SoLuong, ThanhTien, GhiChu)
		VALUES (@MaHD, @MaDV, @SoLuong, @ThanhTien, @GhiChu)
	END
	-- Nếu Action = 1, thực hiện cập nhật dữ liệu
	ELSE IF @Action = 1
	BEGIN
		UPDATE ChiTietHD
		SET
			SoLuong = @SoLuong,
			ThanhTien = @ThanhTien,
			GhiChu = @GhiChu
		WHERE MaHD = @MaHD AND MaDV = @MaDV
	END
	-- Nếu Action = 2, thực hiện xóa dữ liệu
	ELSE IF @Action = 2
	BEGIN
		DELETE FROM ChiTietHD WHERE MaHD = @MaHD AND MaDV = @MaDV
	END
END
