USE [master]
GO
/****** Object:  Database [QuanLyTracNghiemHocSinh-LTQLUD]    Script Date: 06/01/2020 14:29:03 ******/
CREATE DATABASE [QuanLyTracNghiemHocSinh-LTQLUD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyTracNghiemHocSinh-LTQLUD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyTracNghiemHocSinh-LTQLUD.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyTracNghiemHocSinh-LTQLUD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyTracNghiemHocSinh-LTQLUD_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyTracNghiemHocSinh-LTQLUD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLyTracNghiemHocSinh-LTQLUD]
GO
/****** Object:  Table [dbo].[CauHoi]    Script Date: 06/01/2020 14:29:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauHoi](
	[MaCauHoi] [int] IDENTITY(1,1) NOT NULL,
	[NoiDung] [nvarchar](200) NULL,
	[CauA] [nvarchar](50) NULL,
	[CauB] [nvarchar](50) NULL,
	[CauC] [nvarchar](50) NULL,
	[CauD] [nvarchar](50) NULL,
	[CauDung] [nchar](5) NULL,
	[MaKhoi] [int] NULL,
	[HocSinhDongGop] [bit] NULL,
	[DoKho] [int] NULL,
 CONSTRAINT [PK_CauHoi] PRIMARY KEY CLUSTERED 
(
	[MaCauHoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CauHoiTrongDeNao]    Script Date: 06/01/2020 14:29:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauHoiTrongDeNao](
	[MaCauHoi] [int] NOT NULL,
	[MaDe] [nchar](10) NOT NULL,
	[MaKhoi] [int] NOT NULL,
 CONSTRAINT [PK_CauHoiTrongDeNao] PRIMARY KEY CLUSTERED 
(
	[MaCauHoi] ASC,
	[MaDe] ASC,
	[MaKhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[De]    Script Date: 06/01/2020 14:29:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[De](
	[MaDe] [nchar](10) NOT NULL,
	[TenDe] [nvarchar](50) NULL,
	[MaKhoi] [int] NOT NULL,
	[DoKho] [nvarchar](20) NULL,
 CONSTRAINT [PK_De] PRIMARY KEY CLUSTERED 
(
	[MaDe] ASC,
	[MaKhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DeOnTap]    Script Date: 06/01/2020 14:29:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeOnTap](
	[MaDeOnTap] [int] IDENTITY(1,1) NOT NULL,
	[MaHocSinh] [nchar](10) NOT NULL,
	[MaDe] [nchar](10) NOT NULL,
	[MaKhoi] [int] NOT NULL,
	[NgayGioiHan] [date] NULL,
	[Diem] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDeOnTap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DeVaKhoiTrongKyThi]    Script Date: 06/01/2020 14:29:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DeVaKhoiTrongKyThi](
	[MaDeVaKhoiTrongKyThi] [nchar](10) NOT NULL,
	[MaDe] [nchar](10) NULL,
	[MaKhoi] [int] NOT NULL,
	[MaKyThi] [varchar](10) NULL,
 CONSTRAINT [PK_DeVaKhoiTrongKyThi] PRIMARY KEY CLUSTERED 
(
	[MaDeVaKhoiTrongKyThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DoKho]    Script Date: 06/01/2020 14:29:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoKho](
	[maDoKho] [int] NOT NULL,
	[TenDoKho] [nvarchar](50) NULL,
 CONSTRAINT [PK_DoKho] PRIMARY KEY CLUSTERED 
(
	[maDoKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 06/01/2020 14:29:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGiaVien] [nchar](10) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[SDT] [nchar](10) NULL,
	[MaKhoi] [int] NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[MaGiaVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 06/01/2020 14:29:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HocSinh](
	[MaHocSinh] [nchar](10) NOT NULL,
	[Password] [nvarchar](1000) NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[MaLop] [nchar](10) NULL,
	[SoilPass] [varchar](5) NULL,
 CONSTRAINT [PK_HocSinh] PRIMARY KEY CLUSTERED 
(
	[MaHocSinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HocSinhTrongKiThi]    Script Date: 06/01/2020 14:29:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinhTrongKiThi](
	[MaHocSinh] [nchar](10) NOT NULL,
	[MaDeVaKhoiTrongKiThi] [nchar](10) NOT NULL,
	[Diem] [float] NULL,
 CONSTRAINT [PK_HocSinhTrongKiThi] PRIMARY KEY CLUSTERED 
(
	[MaHocSinh] ASC,
	[MaDeVaKhoiTrongKiThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khoi]    Script Date: 06/01/2020 14:29:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoi](
	[MaKhoi] [int] NOT NULL,
	[TenKhoi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Khoi] PRIMARY KEY CLUSTERED 
(
	[MaKhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KyThi]    Script Date: 06/01/2020 14:29:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KyThi](
	[MaKyThi] [varchar](10) NOT NULL,
	[TenKyThi] [nvarchar](150) NULL,
	[NgayThi] [date] NULL,
 CONSTRAINT [PK_KyThi] PRIMARY KEY CLUSTERED 
(
	[MaKyThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 06/01/2020 14:29:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [nchar](10) NOT NULL,
	[TenLop] [nvarchar](50) NULL,
	[MaKhoi] [int] NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[CauHoi] ON 

INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (1, N'Hello là gì ', N'Xin chào ', N'Xin lỗi', N'Xin ăn', N'Xin sự', N'A    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (2, N'1 + 1 = ?', N'2', N'3', N'4', N'5', N'A    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (3, N'Trong tập N* số chẵn nhỏ nhất là', N'0', N'2', N'4', N'6', N'B    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (4, N'Bình phương của 11 la', N'111', N'101', N'121', N'91', N'C    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (5, N'C++ là gì', N'Ngôn ngữ lập trình', N'C++', N'Ngôn ngữ tư duy', N'Ngôn ngữ thể hiện', N'A    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (6, N'C# là gì', N'Ngôn ngữ lập trình', N'C#', N'Ngôn ngữ tư duy', N'Ngôn ngữ thể hiện', N'A    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (7, N'Nếu tồn tại 2 đường thẳng song song thì có điểm chung hay không ?', N'Không có tồn tại điểm chung ', N'Tồn tại 1 điểm chung ', N'Tồn tại vô số điểm chung', N'Tồn tại 2 điểm chung', N'A    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (8, N'X + 2 = 3 -> X = ?', N'-3', N'3', N'-1', N'1', N'D    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (9, N'X*2 + 46 = 0 -> X= ?', N'-25', N'-23', N'23', N'25', N'B    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (10, N'Html là gì ', N'Ngôn ngữ lập trình', N'Html', N'Ngôn ngữ tư duy', N'Ngôn ngữ thể hiên', N'D    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (11, N'2,4,6,8,10,? số tiếp theo là ', N'14', N'12', N'10', N'8', N'B    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (12, N'3 * 15 = ?', N'44', N'46', N'45', N'43', N'C    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (13, N'45 / 5 = ?', N'9', N'10', N'11', N'12', N'A    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (14, N'X - 6 = 2 -> X = ?', N'6', N'7', N'8', N'9', N'C    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (15, N'X + 8 + X = 12', N'4', N'3', N'2', N'1', N'C    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (16, N'Nước có diện tích lớn nhất Đông Nam Á', N'Việt Nam', N'Malaysia', N'Indonesia', N'Đông Ti Mo', N'C    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (17, N'Việt Nam trải qua bao nhiêu triều đại chính thức', N'8 triều đại', N'9 triều đại', N'11 triều đại', N'10 triều đại', N'D    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (18, N'Hình trên tờ tiền 50000 vnd là địa danh nào', N'Nghênh Lương Đình - Phu Văn Lâu', N'Chùa một cột', N'Quốc Tử Giám', N'Thành nhà Hồ', N'A    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (19, N'Hà Nội có bao nhiêu phố phường', N'35', N'36', N'37', N'38', N'B    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (20, N'Hồ Con Rùa còn có tên gọi khác là gì', N'Công trường tháng chín', N'Công trường quốc tế', N'Công trường thủ đô', N'Công trường khởi nghĩa', N'B    ', 10, 0, 1)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (21, N'Vùng nào trên Trái Đất quanh năm không có tia nắng Mặt Trời chiếu vuông góc', N'vĩ tuyến 20 đến 30', N'vĩ tuyến 30 đến 40', N'xích đạo', N'từ vòng cực đến địa cực', N'D    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (22, N'Tứ linh trong văn hóa dân gian Việt Nam là gì', N'Long, Lân, Quy, Mã', N'Long, Hổ, Quy, Mã', N'Long, Lân, Quy, Phụng', N'Long, Hổ, Quy, Phụng', N'C    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (23, N'Trong văn hóa dân gian Việt Nam, thì người Việt được sinh ra từ', N'Bọc trăm trứng', N'Quả dưa hấu', N'Trái mướp', N'Sọ Dừa', N'A    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (24, N'Cả Lương là loại hình văn hóa của vùng nào ở nước ta', N'Tây Nguyên', N'Tây Bắc', N'Tây Nam Bộ', N'Hà Tây', N'C    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (25, N'Địa danh nào sau đây được in trên tờ tiền Việt Nam', N'Chùa một cột', N'Đập thủy điện Hòa Bình', N'Thành nhà Hồ', N'Đập thủy điện Trị An', N'D    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (26, N'Trong lịch sử Việt Nam, nhân vật họ Lê nào được gọi là Lưỡng quốc trạng nguyên', N'Lê Thánh Tông', N'Lê Quý Đôn', N'Lê Hoàn', N'Lê Lợi', N'B    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (27, N'Sách Đại Việt Sử Ký Toàn Thư gồm bao nhiêu quyển', N'2 quyển', N'3 quyển', N'4 quyển', N'5 quyển', N'A    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (28, N'Chiến Tranh Thế Giới thứ Hai kết thúc sau bao lâu kể từ ngày Đức nổ súng xâm lược Ba Lan', N'6 năm', N'6 năm 1 ngày', N'6 năm 2 ngày', N'6 năm 3 ngày', N'B    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (29, N'Vị vua có nhiều con nhất lịch sử Việt Nam là ai', N'Khải Định', N'Thành Thái', N'Minh Mạng', N'Gia Long', N'C    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (30, N'Thời Tam quốc của Trung Quốc, nước ta bị thế lực nào đô hộ', N'Đông Ngô', N'Thục Hán', N'Tào Ngụy', N'Tây Tấn', N'A    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (31, N'Nếu A bằng 5 thì B bằng 10, vậy khi A bằng 10 thì B bằng bao nhiêu', N'10', N'12', N'14', N'15', N'D    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (32, N'Có tất cả bao nhiêu số nguyên tố là số chẵn', N'2 số', N'1 số', N'3 số', N'4 số', N'B    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (33, N'Diệp lục có màu gì', N'Lục', N'Lam', N'Không màu', N'Chàm', N'C    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (34, N'Số nào trong các số sau đây bình phương bằng chính nó', N'-1', N'-2', N'1', N'2', N'C    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (35, N'Đại thi hào Nguyễn Du là tác giả của tác phẩm nào sau đây', N'Lục Vân Tiên', N'Phú sông Bạch Đằng', N'Bình Ngô Đại Cáo', N'Truyện Kiều', N'D    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (36, N'Danh sách nào sau đây là những thể cổ văn của Việt Nam', N'Phú, Cáo, Bình', N'Truyện, Cáo, Bình', N'Phú, Truyện, Cáo', N'Phú, Truyện, Bình', N'A    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (37, N'Quân đội nhân dân Việt Nam được tổ chức đến cấp cao nhất hiện tại là gì', N'Trung Đoàn', N'Quân Đoàn', N'Lữ Đoàn', N'Sư Đoàn', N'B    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (38, N'Tiểu truyện Hạnh Phúc Của Một Tang Gia thuộc tác phẩm văn học nào', N'Chị Dậu', N'Chí Phèo', N'Số Đỏ', N'Cánh Đồng Hoang', N'C    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (39, N'Ai là người đánh đuổi giặc Ân ra khỏi bờ cỏi nước ta', N'Ngô Quyền', N'Đinh Bộ Lĩnh', N'Lê Lợi', N'Thánh Giống', N'D    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (40, N'Lê Trung Tông có quan hệ như thế nào với Lê Long Đỉnh', N'là cha của Lê Long Đỉnh', N'là anh của Lê Long Đỉnh', N'là chú của Lê Long Đỉnh', N'là em của Lê Long Đỉnh', N'B    ', 11, 0, 2)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (41, N'Lý Bí sau khi băng hà có hiệu là gì', N'Lý Thái tổ', N'Lý Nam Đế', N'Lý Thái Tông', N'Lý Nhân Tông', N'B    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (42, N'Cực bắc của nước ta thuộc địa phận tỉnh nào', N'Hà Gian', N'Cao Bằng', N'Bắc Cạn', N'Lạng Sơn', N'A    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (43, N'Chiến tranh biên giới 1979 kéo dài bao nhiên năm', N'1 năm', N'5 năm', N'10 năm', N'15 năm', N'C    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (44, N'Máy bay chở hai quả bom nguyên tử thả xuống Hirosima và Nagasaki của Nhật Bản là máy bay gì', N'Tiêm Kích F5', N'Pháo đài bay B52', N'Pháo đài bay B29', N'Cường kích P51', N'C    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (45, N'Quân đoàn 4 quân đội nhân dân Việt Nam có tên gọi khác là gì', N'Binh Đoàn Quyết Thắng', N'Binh Đoàn Sông Hương', N'Binh Đoàn Tây Nguyên', N'Binh Đoàn Cửu Long', N'D    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (46, N'Tính đến Seagame 30 bóng đá Nữ Việt Nam đã bao nhiêu lần vô địch', N'4 lần', N'5 lần', N'7 lần', N'6 lần', N'D    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (47, N'Ai là người đầu tiên được trao giải "Nobel Toán Học" của Việt Nam', N'GS Bùi Hiền', N'GS Ngô Bảo Châu', N'GS Trần Linh Thước', N'GS Trần Đan Thư', N'B    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (48, N'Trong thời phong kiến, Mẹ của Vua gọi là Thái Hậu, vậy Phi tần của vua trước gọi là gì', N'Hoàng Hậu', N'Hoàng Phi', N'Thái Hoàng Thái Hậu', N'Thái Phi', N'D    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (49, N'Trữ quân là từ dùng để chỉ ai trong thời phong kiến', N'Thái tử', N'Hoàng tử', N'Công tử', N'Thế tử', N'A    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (50, N'Việt Nam có vùng biển rộng gấp mấy lần đất liền', N'khoảng 3 lần', N'khoảng 2 lần', N'khoảng 4 lần', N'khoảng 5 lần', N'A    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (52, N'Việt nam gia nhập WTO năm nào', N'2007', N'2008', N'2006', N'2009', N'C    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (53, N'Rừng quốc gia Nam Cát Tiên thuộc tỉnh nào', N'Phú Thọ', N'Hòa Bình', N'Đồng Nai', N'Tiền Giang', N'C    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (54, N'Đâu là loại vật đặc hữu của Việt Nam', N'Hưu Sao', N'Sếu đầu đỏ', N'Voọc đen', N'Cáo', N'B    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (55, N'Trong hệ Mặt Trời, hành tinh lớn thứ 2 về kích thước là hành tinh nào', N'Sao Thổ', N'Sao Hỏa', N'Sao Kim', N'Sao Mộc', N'D    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (56, N'"Ta thà làm ma nước Nam còn hơn làm vương đất Bắc" là câu nói nổi tiếng của ai', N'Lê Lợi', N'Trần Bình Trọng', N'Nguyễn Trung Trực', N'Phan Huy Ích', N'B    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (57, N'Vị vua cuối cùng của Việt Nam là ai', N'Bảo Đại', N'Tự Đức', N'Thiệu Trị', N'Minh Mạng', N'A    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (58, N'Lê Đại Hành tên thật là', N'Lê Long Việt', N'Lê Lai', N'Lê Hoàn', N'Lê Như Hổ', N'C    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (59, N'Thạch tín là một loại chất kịch độc, vậy thành phần hóa học chính của nó là gì', N'Asalumin', N'Asen', N'Aselaum', N'Asetium', N'B    ', 12, 0, 3)
INSERT [dbo].[CauHoi] ([MaCauHoi], [NoiDung], [CauA], [CauB], [CauC], [CauD], [CauDung], [MaKhoi], [HocSinhDongGop], [DoKho]) VALUES (60, N'Trong Truyện Kiều của Nguyễn Du, Kiều đã đính ước với ai', N'Kim Trọng', N'Lục Vân Tiên', N'Đặng Ngải', N'Phan Phụng', N'A    ', 12, 0, 3)
SET IDENTITY_INSERT [dbo].[CauHoi] OFF
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (1, N'D123      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (1, N'D456      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (1, N'MA20200000', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (2, N'D123      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (2, N'D456      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (2, N'MA20200000', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (3, N'D123      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (3, N'D456      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (3, N'MA20200000', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (4, N'D123      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (4, N'D456      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (4, N'MA20200000', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (5, N'D123      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (5, N'D456      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (5, N'MA20200000', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (6, N'D123      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (6, N'D456      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (6, N'MA20200000', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (7, N'D123      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (7, N'D456      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (7, N'MA20200000', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (8, N'D123      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (8, N'D456      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (8, N'MA20200000', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (9, N'D123      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (9, N'D456      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (9, N'MA20200000', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (10, N'D123      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (10, N'D456      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (10, N'MA20200000', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (11, N'D123      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (11, N'D456      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (11, N'MA20200000', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (12, N'D123      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (12, N'D456      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (12, N'MA20200000', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (13, N'D123      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (13, N'D456      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (13, N'MA20200000', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (14, N'D123      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (14, N'D456      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (14, N'MA20200000', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (15, N'D123      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (15, N'D456      ', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (15, N'MA20200000', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (16, N'MA20200002', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (17, N'MA20200002', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (18, N'MA20200002', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (19, N'MA20200002', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (20, N'MA20200002', 10)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (21, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (22, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (23, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (24, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (25, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (26, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (27, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (28, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (29, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (30, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (31, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (32, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (33, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (34, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (35, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (36, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (37, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (38, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (39, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (40, N'MA20200003', 11)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (41, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (42, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (43, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (44, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (45, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (46, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (47, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (48, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (49, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (50, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (52, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (53, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (54, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (55, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (56, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (57, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (58, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (59, N'MA20200004', 12)
INSERT [dbo].[CauHoiTrongDeNao] ([MaCauHoi], [MaDe], [MaKhoi]) VALUES (60, N'MA20200004', 12)
INSERT [dbo].[De] ([MaDe], [TenDe], [MaKhoi], [DoKho]) VALUES (N'D123      ', N'Đề 123', 10, N'dễ')
INSERT [dbo].[De] ([MaDe], [TenDe], [MaKhoi], [DoKho]) VALUES (N'D456      ', N'Đề 456', 10, N'trung bình')
INSERT [dbo].[De] ([MaDe], [TenDe], [MaKhoi], [DoKho]) VALUES (N'MA20200000', N'Khối 10 - 0', 10, N'dễ')
INSERT [dbo].[De] ([MaDe], [TenDe], [MaKhoi], [DoKho]) VALUES (N'MA20200000', N'Khối 11 - 1', 11, N'dễ')
INSERT [dbo].[De] ([MaDe], [TenDe], [MaKhoi], [DoKho]) VALUES (N'MA20200001', N'Khối 10 - 1', 10, N'dễ')
INSERT [dbo].[De] ([MaDe], [TenDe], [MaKhoi], [DoKho]) VALUES (N'MA20200001', N'Khối 11 - 2', 11, N'dễ')
INSERT [dbo].[De] ([MaDe], [TenDe], [MaKhoi], [DoKho]) VALUES (N'MA20200002', N'Khối 10 - 03', 10, N'dễ')
INSERT [dbo].[De] ([MaDe], [TenDe], [MaKhoi], [DoKho]) VALUES (N'MA20200003', N'Khối 11 - 03', 11, N'dễ')
INSERT [dbo].[De] ([MaDe], [TenDe], [MaKhoi], [DoKho]) VALUES (N'MA20200004', N'Khối 12 - 01 ', 12, N'dễ')
SET IDENTITY_INSERT [dbo].[DeOnTap] ON 

INSERT [dbo].[DeOnTap] ([MaDeOnTap], [MaHocSinh], [MaDe], [MaKhoi], [NgayGioiHan], [Diem]) VALUES (1, N'HS20190001', N'D123      ', 10, CAST(N'2020-01-06' AS Date), 9.9999999999999982)
INSERT [dbo].[DeOnTap] ([MaDeOnTap], [MaHocSinh], [MaDe], [MaKhoi], [NgayGioiHan], [Diem]) VALUES (2, N'HS20190001', N'D123      ', 10, CAST(N'2020-01-06' AS Date), 9.3333333333333321)
SET IDENTITY_INSERT [dbo].[DeOnTap] OFF
INSERT [dbo].[DeVaKhoiTrongKyThi] ([MaDeVaKhoiTrongKyThi], [MaDe], [MaKhoi], [MaKyThi]) VALUES (N'1201201520', N'MA20200000', 10, N'KT20201501')
INSERT [dbo].[DeVaKhoiTrongKyThi] ([MaDeVaKhoiTrongKyThi], [MaDe], [MaKhoi], [MaKyThi]) VALUES (N'1201201521', N'MA20200001', 10, N'KT20201501')
INSERT [dbo].[DoKho] ([maDoKho], [TenDoKho]) VALUES (1, N'dễ')
INSERT [dbo].[DoKho] ([maDoKho], [TenDoKho]) VALUES (2, N'trung binh')
INSERT [dbo].[DoKho] ([maDoKho], [TenDoKho]) VALUES (3, N'kho')
INSERT [dbo].[GiaoVien] ([MaGiaVien], [Password], [HoTen], [DiaChi], [Email], [SDT], [MaKhoi]) VALUES (N'GV0001    ', N'Hello', N'ádadasda', N'Hồ Chí Minh', N'Email@gmail.com', N'0123456789', 10)
INSERT [dbo].[GiaoVien] ([MaGiaVien], [Password], [HoTen], [DiaChi], [Email], [SDT], [MaKhoi]) VALUES (N'GV0002    ', N'Hello', N'Nguyễn Văn B', N'Hồ Chí Minh', N'Email@gmail.com', N'0123456789', 12)
INSERT [dbo].[HocSinh] ([MaHocSinh], [Password], [HoTen], [NgaySinh], [DiaChi], [MaLop], [SoilPass]) VALUES (N'HS20190001', N'17024513870237185141524142191242121884980', N'Lê Trung Trực', CAST(N'1997-12-02' AS Date), N'Tp.HCM', N'10CK1     ', N'26935')
INSERT [dbo].[HocSinh] ([MaHocSinh], [Password], [HoTen], [NgaySinh], [DiaChi], [MaLop], [SoilPass]) VALUES (N'HS20190002', NULL, N'ABC1', NULL, NULL, N'10CK2     ', NULL)
INSERT [dbo].[HocSinh] ([MaHocSinh], [Password], [HoTen], [NgaySinh], [DiaChi], [MaLop], [SoilPass]) VALUES (N'HS20190003', NULL, N'ABC2', NULL, NULL, N'10CK3     ', NULL)
INSERT [dbo].[HocSinhTrongKiThi] ([MaHocSinh], [MaDeVaKhoiTrongKiThi], [Diem]) VALUES (N'HS20190001', N'1201201520', 9.9999999999999982)
INSERT [dbo].[Khoi] ([MaKhoi], [TenKhoi]) VALUES (10, N'Khối 10')
INSERT [dbo].[Khoi] ([MaKhoi], [TenKhoi]) VALUES (11, N'Khối 11')
INSERT [dbo].[Khoi] ([MaKhoi], [TenKhoi]) VALUES (12, N'Khối 12')
INSERT [dbo].[KyThi] ([MaKyThi], [TenKyThi], [NgayThi]) VALUES (N'KT20201500', N'Thi 15 phút', CAST(N'2020-01-03' AS Date))
INSERT [dbo].[KyThi] ([MaKyThi], [TenKyThi], [NgayThi]) VALUES (N'KT20201501', N'Thi 15 phút', CAST(N'2020-01-03' AS Date))
INSERT [dbo].[KyThi] ([MaKyThi], [TenKyThi], [NgayThi]) VALUES (N'KT20201502', N'Thi 15 phút', CAST(N'2020-01-03' AS Date))
INSERT [dbo].[KyThi] ([MaKyThi], [TenKyThi], [NgayThi]) VALUES (N'KT20201503', N'Thi 15 phút', CAST(N'2020-01-03' AS Date))
INSERT [dbo].[KyThi] ([MaKyThi], [TenKyThi], [NgayThi]) VALUES (N'KT20201504', N'Thi 15 phút', CAST(N'2020-01-03' AS Date))
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoi]) VALUES (N'10CK1     ', N'10CK1', 10)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoi]) VALUES (N'10CK2     ', N'10CK2', 10)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoi]) VALUES (N'10CK3     ', N'10CK3', 10)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoi]) VALUES (N'11CK1     ', N'11CK1', 11)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoi]) VALUES (N'11CK2     ', N'11CK2', 11)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoi]) VALUES (N'12CK1     ', N'12CK1', 12)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoi]) VALUES (N'12CK2     ', N'12CK2', 12)
ALTER TABLE [dbo].[CauHoi]  WITH CHECK ADD  CONSTRAINT [FK_CauHoi_DoKho] FOREIGN KEY([DoKho])
REFERENCES [dbo].[DoKho] ([maDoKho])
GO
ALTER TABLE [dbo].[CauHoi] CHECK CONSTRAINT [FK_CauHoi_DoKho]
GO
ALTER TABLE [dbo].[CauHoi]  WITH CHECK ADD  CONSTRAINT [FK_CauHoi_Khoi] FOREIGN KEY([MaKhoi])
REFERENCES [dbo].[Khoi] ([MaKhoi])
GO
ALTER TABLE [dbo].[CauHoi] CHECK CONSTRAINT [FK_CauHoi_Khoi]
GO
ALTER TABLE [dbo].[CauHoiTrongDeNao]  WITH CHECK ADD  CONSTRAINT [FK_CauHoiTrongDeNao_CauHoi] FOREIGN KEY([MaCauHoi])
REFERENCES [dbo].[CauHoi] ([MaCauHoi])
GO
ALTER TABLE [dbo].[CauHoiTrongDeNao] CHECK CONSTRAINT [FK_CauHoiTrongDeNao_CauHoi]
GO
ALTER TABLE [dbo].[CauHoiTrongDeNao]  WITH CHECK ADD  CONSTRAINT [FK_CauHoiTrongDeNao_De] FOREIGN KEY([MaDe], [MaKhoi])
REFERENCES [dbo].[De] ([MaDe], [MaKhoi])
GO
ALTER TABLE [dbo].[CauHoiTrongDeNao] CHECK CONSTRAINT [FK_CauHoiTrongDeNao_De]
GO
ALTER TABLE [dbo].[De]  WITH CHECK ADD  CONSTRAINT [FK_De_Khoi] FOREIGN KEY([MaKhoi])
REFERENCES [dbo].[Khoi] ([MaKhoi])
GO
ALTER TABLE [dbo].[De] CHECK CONSTRAINT [FK_De_Khoi]
GO
ALTER TABLE [dbo].[DeOnTap]  WITH CHECK ADD  CONSTRAINT [FK_DeOnTap_De] FOREIGN KEY([MaDe], [MaKhoi])
REFERENCES [dbo].[De] ([MaDe], [MaKhoi])
GO
ALTER TABLE [dbo].[DeOnTap] CHECK CONSTRAINT [FK_DeOnTap_De]
GO
ALTER TABLE [dbo].[DeOnTap]  WITH CHECK ADD  CONSTRAINT [FK_DeOnTap_HocSinh] FOREIGN KEY([MaHocSinh])
REFERENCES [dbo].[HocSinh] ([MaHocSinh])
GO
ALTER TABLE [dbo].[DeOnTap] CHECK CONSTRAINT [FK_DeOnTap_HocSinh]
GO
ALTER TABLE [dbo].[DeVaKhoiTrongKyThi]  WITH CHECK ADD  CONSTRAINT [FK_DeVaKhoiTrongKyThi_De] FOREIGN KEY([MaDe], [MaKhoi])
REFERENCES [dbo].[De] ([MaDe], [MaKhoi])
GO
ALTER TABLE [dbo].[DeVaKhoiTrongKyThi] CHECK CONSTRAINT [FK_DeVaKhoiTrongKyThi_De]
GO
ALTER TABLE [dbo].[DeVaKhoiTrongKyThi]  WITH CHECK ADD  CONSTRAINT [FK_DeVaKhoiTrongKyThi_KyThi] FOREIGN KEY([MaKyThi])
REFERENCES [dbo].[KyThi] ([MaKyThi])
GO
ALTER TABLE [dbo].[DeVaKhoiTrongKyThi] CHECK CONSTRAINT [FK_DeVaKhoiTrongKyThi_KyThi]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_Khoi] FOREIGN KEY([MaKhoi])
REFERENCES [dbo].[Khoi] ([MaKhoi])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_Khoi]
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_Lop]
GO
ALTER TABLE [dbo].[HocSinhTrongKiThi]  WITH CHECK ADD  CONSTRAINT [FK_HocSinhTrongKiThi_DeVaKhoiTrongKyThi] FOREIGN KEY([MaDeVaKhoiTrongKiThi])
REFERENCES [dbo].[DeVaKhoiTrongKyThi] ([MaDeVaKhoiTrongKyThi])
GO
ALTER TABLE [dbo].[HocSinhTrongKiThi] CHECK CONSTRAINT [FK_HocSinhTrongKiThi_DeVaKhoiTrongKyThi]
GO
ALTER TABLE [dbo].[HocSinhTrongKiThi]  WITH CHECK ADD  CONSTRAINT [FK_HocSinhTrongKiThi_HocSinh] FOREIGN KEY([MaHocSinh])
REFERENCES [dbo].[HocSinh] ([MaHocSinh])
GO
ALTER TABLE [dbo].[HocSinhTrongKiThi] CHECK CONSTRAINT [FK_HocSinhTrongKiThi_HocSinh]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_Khoi] FOREIGN KEY([MaKhoi])
REFERENCES [dbo].[Khoi] ([MaKhoi])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_Khoi]
GO
USE [master]
GO
ALTER DATABASE [QuanLyTracNghiemHocSinh-LTQLUD] SET  READ_WRITE 
GO
