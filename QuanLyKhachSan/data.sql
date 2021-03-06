USE [master]
GO
/****** Object:  Database [QLKS_BuiNga]    Script Date: 2020-09-15 3:53:52 CH ******/
CREATE DATABASE [QLKS_BuiNga]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKS_BuiNga', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLKS_BuiNga.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLKS_BuiNga_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLKS_BuiNga_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLKS_BuiNga] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKS_BuiNga].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKS_BuiNga] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKS_BuiNga] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKS_BuiNga] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLKS_BuiNga] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKS_BuiNga] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLKS_BuiNga] SET  MULTI_USER 
GO
ALTER DATABASE [QLKS_BuiNga] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKS_BuiNga] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKS_BuiNga] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKS_BuiNga] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLKS_BuiNga] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLKS_BuiNga] SET QUERY_STORE = OFF
GO
USE [QLKS_BuiNga]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[tenDN] [varchar](30) NOT NULL,
	[matKhau] [varchar](30) NOT NULL,
	[hoTen] [nvarchar](30) NULL,
	[email] [varchar](30) NULL,
	[phanquyen] [char](1) NULL,
	[trangThai] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[tenDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[maNV] [varchar](30) NOT NULL,
	[hoTenNV] [nvarchar](30) NOT NULL,
	[ngaySinh] [date] NULL,
	[namLamViec] [int] NULL,
	[gioiTinh] [nvarchar](10) NULL,
	[luong] [int] NULL,
	[maPB] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[maPB] [varchar](30) NOT NULL,
	[tenPB] [nvarchar](30) NOT NULL,
	[emailPB] [varchar](30) NULL,
	[dienThoai] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[maPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DangNhap] ([tenDN], [matKhau], [hoTen], [email], [phanquyen], [trangThai]) VALUES (N'admin1', N'12345', N'Lê văn chiến', N'chienLe92@gmail.com', N'1', N'0')
INSERT [dbo].[DangNhap] ([tenDN], [matKhau], [hoTen], [email], [phanquyen], [trangThai]) VALUES (N'admin2', N'1234', N'Lê Thị Dung', N'DungLe97@gmail.com', N'1', N'0')
INSERT [dbo].[DangNhap] ([tenDN], [matKhau], [hoTen], [email], [phanquyen], [trangThai]) VALUES (N'admin3', N'1234', N'Lê Hoàng Nam', N'HoangNam89@gmail.com', N'1', N'0')
INSERT [dbo].[DangNhap] ([tenDN], [matKhau], [hoTen], [email], [phanquyen], [trangThai]) VALUES (N'nhanvien1', N'12345', N'Hoàng Văn Lan', N'VanLam11@gmail.com', N'0', N'0')
INSERT [dbo].[DangNhap] ([tenDN], [matKhau], [hoTen], [email], [phanquyen], [trangThai]) VALUES (N'nhanvien2', N'12346', N'Lê Đức Long', N'DucLong87@gmail.com', N'0', N'0')
INSERT [dbo].[DangNhap] ([tenDN], [matKhau], [hoTen], [email], [phanquyen], [trangThai]) VALUES (N'nhanvien3', N'12345', N'Danh Quốc Chiến', N'QuocChien96@gmail.com', N'0', N'0')
INSERT [dbo].[DangNhap] ([tenDN], [matKhau], [hoTen], [email], [phanquyen], [trangThai]) VALUES (N'nhanvien4', N'12345', N'Lê Huỳnh Bá', N'HuynhBa12@gmail.com', N'0', N'0')
INSERT [dbo].[DangNhap] ([tenDN], [matKhau], [hoTen], [email], [phanquyen], [trangThai]) VALUES (N'nhanvien5', N'12345', N'Hoàng Thu Thủy', N'ThuThuy98@gmail.com', N'0', N'0')
INSERT [dbo].[NhanVien] ([maNV], [hoTenNV], [ngaySinh], [namLamViec], [gioiTinh], [luong], [maPB]) VALUES (N'NV1', N'Hoàng Thu Thủy', CAST(N'1998-02-09' AS Date), 2018, N'Nữ', 9000000, N'PB1')
INSERT [dbo].[NhanVien] ([maNV], [hoTenNV], [ngaySinh], [namLamViec], [gioiTinh], [luong], [maPB]) VALUES (N'NV10', N'Danh Đức Thọ', CAST(N'1989-05-11' AS Date), 2019, N'Nam', 15000000, N'PB5')
INSERT [dbo].[NhanVien] ([maNV], [hoTenNV], [ngaySinh], [namLamViec], [gioiTinh], [luong], [maPB]) VALUES (N'NV11', N'Hoàng Thị Thảo Trang', CAST(N'1997-02-07' AS Date), 2020, N'Nữ', 3000000, N'PB5')
INSERT [dbo].[NhanVien] ([maNV], [hoTenNV], [ngaySinh], [namLamViec], [gioiTinh], [luong], [maPB]) VALUES (N'NV12', N'Hồ Thanh Linh', CAST(N'1996-01-08' AS Date), 2018, N'Nữ', 1200000, N'PB5')
INSERT [dbo].[NhanVien] ([maNV], [hoTenNV], [ngaySinh], [namLamViec], [gioiTinh], [luong], [maPB]) VALUES (N'NV14', N'Lữ Lan Anh', CAST(N'1999-02-11' AS Date), 2019, N'Nữ', 8000000, N'PB2')
INSERT [dbo].[NhanVien] ([maNV], [hoTenNV], [ngaySinh], [namLamViec], [gioiTinh], [luong], [maPB]) VALUES (N'NV2', N'Lý văn Đức', CAST(N'1993-05-05' AS Date), 2019, N'Nam', 8000000, N'PB1')
INSERT [dbo].[NhanVien] ([maNV], [hoTenNV], [ngaySinh], [namLamViec], [gioiTinh], [luong], [maPB]) VALUES (N'NV3', N'Hoàng Cửu Long', CAST(N'1994-04-05' AS Date), 2019, N'Nam', 7000000, N'PB2')
INSERT [dbo].[NhanVien] ([maNV], [hoTenNV], [ngaySinh], [namLamViec], [gioiTinh], [luong], [maPB]) VALUES (N'NV4', N'Danh Nam Trung', CAST(N'1995-01-05' AS Date), 2020, N'Nam', 8500000, N'PB2')
INSERT [dbo].[NhanVien] ([maNV], [hoTenNV], [ngaySinh], [namLamViec], [gioiTinh], [luong], [maPB]) VALUES (N'NV5', N'Lý Danh Hồng', CAST(N'1992-06-06' AS Date), 2017, N'Nam', 6000000, N'PB3')
INSERT [dbo].[NhanVien] ([maNV], [hoTenNV], [ngaySinh], [namLamViec], [gioiTinh], [luong], [maPB]) VALUES (N'NV6', N'Hoàng Văn Chiến', CAST(N'1991-03-03' AS Date), 2019, N'Nam', 5000000, N'PB3')
INSERT [dbo].[NhanVien] ([maNV], [hoTenNV], [ngaySinh], [namLamViec], [gioiTinh], [luong], [maPB]) VALUES (N'NV8', N'Hoàng Thị Thu', CAST(N'1993-01-03' AS Date), 2016, N'Nam', 6500000, N'PB2')
INSERT [dbo].[PhongBan] ([maPB], [tenPB], [emailPB], [dienThoai]) VALUES (N'PB1', N'Phòng tiếp tân', N'phongtieptan@gmail.com', N'0987123432')
INSERT [dbo].[PhongBan] ([maPB], [tenPB], [emailPB], [dienThoai]) VALUES (N'PB2', N'Phòng kế hoạch', N'phongkehoach@gmail.com', N'0987123433')
INSERT [dbo].[PhongBan] ([maPB], [tenPB], [emailPB], [dienThoai]) VALUES (N'PB3', N'Phòng hậu cần', N'phonghaucan@gmail.com', N'0987123434')
INSERT [dbo].[PhongBan] ([maPB], [tenPB], [emailPB], [dienThoai]) VALUES (N'PB4', N'Phòng tài vụ', N'phongtaichinh@gmail.com', N'987123435')
INSERT [dbo].[PhongBan] ([maPB], [tenPB], [emailPB], [dienThoai]) VALUES (N'PB5', N'Phòng đối ngoại', N'phongdoingoai@gmail.com', N'0987123436')
INSERT [dbo].[PhongBan] ([maPB], [tenPB], [emailPB], [dienThoai]) VALUES (N'PB6', N'Phòng giao dịch', N'phonggiaodich@gmail.com', N'0987123437')
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [fk_htk_maPB] FOREIGN KEY([maPB])
REFERENCES [dbo].[PhongBan] ([maPB])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [fk_htk_maPB]
GO
/****** Object:  StoredProcedure [dbo].[checkDangNhap]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[checkDangNhap](
@userName varchar(30),
@pass varchar(30))
AS
BEGIN
	Select *From DangNhap WHERE tenDN = @userName and matKhau = @pass
END
GO
/****** Object:  StoredProcedure [dbo].[DanhSachNV]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachNV]
AS
BEGIN
	SELECT *FROM NhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[DanhSachPB]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachPB]
AS
BEGIN
	SELECT *FROM PhongBan
END
GO
/****** Object:  StoredProcedure [dbo].[DOiMK]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DOiMK]
(@TenDN varchar(30),
@MK varchar(30))
AS
BEGIN
	UPDATE DangNhap SET matKhau = @MK WHERE tenDN = @TenDN
END
GO
/****** Object:  StoredProcedure [dbo].[DSTenDN]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSTenDN]
AS
BEGIN
	SELECT *FROM DangNhap
END
GO
/****** Object:  StoredProcedure [dbo].[HienThiNV]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HienThiNV]
AS
BEGIN
	Select maNV, hoTenNV, ngaySinh, gioiTinh, namLamViec,luong, NV.maPB, PB.tenPB FROM NhanVien NV, PhongBan PB 
	WHERE NV.maPB = PB.maPB
END
GO
/****** Object:  StoredProcedure [dbo].[NhanVienDK]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[NhanVienDK](
@MaNV varchar(30))
AS
BEGIN
	Select *From NhanVien WHERE maNV  = @MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[PBDK]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PBDK](
@maPB nvarchar(30))
AS
BEGIN
	SELECT tenPB FROM PhongBan WHERE maPB = @maPB
END
GO
/****** Object:  StoredProcedure [dbo].[PhongBanDK]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PhongBanDK](
@MaPB varchar(30))
AS
BEGIN
	SELECT *FROM PhongBan WHERE maPB = @MaPB
END
GO
/****** Object:  StoredProcedure [dbo].[SapXepLuong]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SapXepLuong]
AS
BEGIN
	SELECT *FROM NhanVien ORDER BY luong DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SapXepPB]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SapXepPB]
AS
BEGIN
	SELECT *FROM PhongBan ORDER BY tenPB
END
GO
/****** Object:  StoredProcedure [dbo].[SuaNV]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaNV](
@MaNV varchar(30),
@HoTen nvarchar(30),
@NgaySinh Date,
@namLamViec int,
@GioiTinh nvarchar(10),
@Luong int,
@MaPB varchar(30) )
AS
BEGIN
	UPDATE NhanVien set hoTenNV = @HoTen, ngaySinh = @NgaySinh, namLamViec = @namLamViec, gioiTinh = @GioiTinh,
	luong = @Luong, maPB = @MaPB WHERE maNV = @MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[SuaPB]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaPB](
@maPB varchar(30),
@tenPB nvarchar(30),
@emailPB varchar(30),
@dienThoai int)
AS
BEGIN
	 UPDATE PhongBan set tenPB = @tenPB, emailPB = @emailPB, dienThoai = @dienThoai WHERE maPB = @maPB
END
GO
/****** Object:  StoredProcedure [dbo].[SuaTK]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaTK](
@TenTK varchar(30),
@MK varchar(30),
@hoTen nvarchar(30),
@email varchar(30),
@phanQuyen char(1),
@trangThai char(1))
AS
BEGIN
	 UPDATE DangNhap set matKhau = @MK, hoTen = @hoTen, email = @email, phanquyen = @phanQuyen, trangThai = @trangThai WHERE  tenDN = @TenTK 
END
GO
/****** Object:  StoredProcedure [dbo].[TaiKhoanDK]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[TaiKhoanDK](
@TenTK varchar(30))
AS
BEGIN
	Select *From DangNhap WHERE tenDN = @TenTK
END
GO
/****** Object:  StoredProcedure [dbo].[ThemNV]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemNV](
@MaNV varchar(30),
@HoTen nvarchar(30),
@NgaySinh Date,
@namLamViec int,
@GioiTinh nvarchar(10),
@Luong int,
@MaPB varchar(30) )
AS
BEGIN
	Insert into NhanVien values(@MaNV,@HoTen,@NgaySinh,@namLamViec,@GioiTinh,@Luong,@MaPB)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemPB]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemPB](
@maPB varchar(30),
@tenPB nvarchar(30),
@emailPB varchar(30),
@dienThoai int)
AS
BEGIN
	Insert into PhongBan values(@maPB,@tenPB,@emailPB,@dienThoai)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemTK]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemTK](
@TenTK varchar(30),
@MK varchar(30),
@hoTen varchar(30),
@email varchar(30),
@phanQuyen char(1),
@trangThai char(1))
AS
BEGIN
	Insert into DangNhap values(@TenTK,@MK,@hoTen,@email,@phanQuyen,@trangThai)
END
GO
/****** Object:  StoredProcedure [dbo].[XoaNV]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaNV](
@MaNV varchar(30))
AS
BEGIN
	DELETE NhanVien WHERE maNV = @MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[XoaPB]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaPB](
@maPB varchar(30))
AS
BEGIN
	DELETE PhongBan WHERE maPB = @maPB
END
GO
/****** Object:  StoredProcedure [dbo].[XoaTK]    Script Date: 2020-09-15 3:53:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaTK](
@TenTK varchar(30))
AS
BEGIN
	DELETE DangNhap WHERE tenDN = @TenTK
END
GO
USE [master]
GO
ALTER DATABASE [QLKS_BuiNga] SET  READ_WRITE 
GO
