USE [master]
GO
/****** Object:  Database [QLBH]    Script Date: 12/21/2018 6:22:49 PM ******/
CREATE DATABASE [QLBH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DATA_BANHANG', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QLBH.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DATA_BANHANG_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QLBH_log.ldf' , SIZE = 3456KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLBH] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBH] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBH] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLBH] SET  MULTI_USER 
GO
ALTER DATABASE [QLBH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBH] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLBH] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLBH', N'ON'
GO
ALTER DATABASE [QLBH] SET QUERY_STORE = OFF
GO
USE [QLBH]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [QLBH]
GO
/****** Object:  Table [dbo].[CONG_NO]    Script Date: 12/21/2018 6:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONG_NO](
	[ID_CN] [int] IDENTITY(1,1) NOT NULL,
	[ID_SOHD] [int] NULL,
	[NGAY_HD] [datetime] NULL,
	[TONGTIEN] [int] NULL,
	[TRATRUOC] [int] NULL,
	[NO] [int] NULL,
	[NGAYTRA] [datetime] NULL,
	[GHICHU] [nvarchar](250) NULL,
	[XORN] [nchar](10) NULL,
	[STATUS] [bit] NULL,
 CONSTRAINT [PK_CONG_NO] PRIMARY KEY CLUSTERED 
(
	[ID_CN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DM_HANG]    Script Date: 12/21/2018 6:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_HANG](
	[MA_HANG] [nvarchar](50) NOT NULL,
	[TEN_HANG] [nvarchar](250) NULL,
	[DVT] [nvarchar](50) NULL,
	[DON_GIA] [decimal](18, 2) NULL,
	[DON_GIA_BAN] [decimal](18, 2) NULL,
	[MA_ST] [nvarchar](50) NULL,
	[GHI_CHU] [nvarchar](250) NULL,
 CONSTRAINT [PK_DM_HANG] PRIMARY KEY CLUSTERED 
(
	[MA_HANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOI_TAC]    Script Date: 12/21/2018 6:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOI_TAC](
	[MA_ST] [nvarchar](50) NOT NULL,
	[TEN_DT] [nvarchar](250) NULL,
	[DIA_CHI] [nvarchar](250) NULL,
	[NGUOI_LH] [nvarchar](250) NULL,
	[SDT] [nvarchar](50) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[WECHAT] [nvarchar](50) NULL,
	[TAI_KHOAN] [nvarchar](50) NULL,
	[GHI_CHU] [nvarchar](250) NULL,
	[STATUS] [bit] NULL,
 CONSTRAINT [PK_DOITAC] PRIMARY KEY CLUSTERED 
(
	[MA_ST] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGHI_PHEP]    Script Date: 12/21/2018 6:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGHI_PHEP](
	[ID_NGHIPHEP] [int] IDENTITY(1,1) NOT NULL,
	[MA_NV] [nvarchar](50) NULL,
	[TEN_NV] [nvarchar](50) NULL,
	[NGAY_BD] [datetime] NULL,
	[NGAY_KT] [datetime] NULL,
	[SO_NGAY] [float] NULL,
	[LY_DO] [nvarchar](250) NULL,
 CONSTRAINT [PK_NGHI_PHEP] PRIMARY KEY CLUSTERED 
(
	[ID_NGHIPHEP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAN_VIEN]    Script Date: 12/21/2018 6:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAN_VIEN](
	[MA_NV] [nvarchar](50) NOT NULL,
	[TEN_NV] [nvarchar](50) NULL,
	[GIOI_TINH] [bit] NULL,
	[DIA_CHI] [nvarchar](250) NULL,
	[SDT] [nvarchar](50) NULL,
	[GHI_CHU] [nvarchar](250) NULL,
 CONSTRAINT [PK_NHAN_VIEN] PRIMARY KEY CLUSTERED 
(
	[MA_NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEU_BH]    Script Date: 12/21/2018 6:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEU_BH](
	[ID_PBH] [int] NOT NULL,
	[NGAY_BAN] [datetime] NULL,
	[MA_ST] [nvarchar](50) NULL,
	[TEN_CTY] [nvarchar](250) NULL,
	[DIA_CHI] [nvarchar](250) NULL,
	[SDT] [nvarchar](50) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[TONG_TIEN_HANG] [int] NULL,
	[SO_TIEN_VND] [nvarchar](350) NULL,
 CONSTRAINT [PK_PHIEU_BH] PRIMARY KEY CLUSTERED 
(
	[ID_PBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEU_BH_CT]    Script Date: 12/21/2018 6:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEU_BH_CT](
	[ID_PBH_CT] [int] IDENTITY(1,1) NOT NULL,
	[ID_PBH] [int] NULL,
	[STT] [int] NULL,
	[MA_HANG] [nvarchar](50) NULL,
	[TEN_HANG] [nvarchar](250) NULL,
	[DVT] [nvarchar](50) NULL,
	[SL] [decimal](18, 2) NULL,
	[DON_GIA] [decimal](18, 2) NULL,
	[PTKM] [decimal](18, 2) NULL,
	[TIEN_KM] [decimal](18, 2) NULL,
	[THANH_TIEN] [decimal](18, 2) NULL,
 CONSTRAINT [PK_PHIEU_BH_CT] PRIMARY KEY CLUSTERED 
(
	[ID_PBH_CT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEU_MH]    Script Date: 12/21/2018 6:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEU_MH](
	[ID_PMH] [int] NOT NULL,
	[NGAY_MUA] [datetime] NULL,
	[MA_ST] [nvarchar](50) NULL,
	[TEN_CTY] [nvarchar](250) NULL,
	[DIA_CHI] [nvarchar](250) NULL,
	[SDT] [nvarchar](50) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[TONG_TIEN_HANG] [int] NULL,
	[SO_TIEN_VND] [nvarchar](350) NULL,
 CONSTRAINT [PK_PHIEU_MH_CT] PRIMARY KEY CLUSTERED 
(
	[ID_PMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEU_MH_CT]    Script Date: 12/21/2018 6:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEU_MH_CT](
	[ID_PMH_CT] [int] IDENTITY(1,1) NOT NULL,
	[ID_PMH] [int] NULL,
	[STT] [int] NULL,
	[MA_HANG] [nvarchar](50) NULL,
	[TEN_HANG] [nvarchar](250) NULL,
	[DVT] [nvarchar](50) NULL,
	[SL] [decimal](18, 2) NULL,
	[DON_GIA] [decimal](18, 2) NULL,
	[PTKM] [decimal](18, 2) NULL,
	[TIEN_KM] [decimal](18, 2) NULL,
	[THANH_TIEN] [decimal](18, 2) NULL,
 CONSTRAINT [PK_PHIEU_MH_CT_1] PRIMARY KEY CLUSTERED 
(
	[ID_PMH_CT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/21/2018 6:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](500) NULL,
	[role] [nvarchar](50) NULL,
 CONSTRAINT [PK_NSD] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CONG_NO] ON 

INSERT [dbo].[CONG_NO] ([ID_CN], [ID_SOHD], [NGAY_HD], [TONGTIEN], [TRATRUOC], [NO], [NGAYTRA], [GHICHU], [XORN], [STATUS]) VALUES (26, 1, CAST(N'2018-09-26T00:00:00.000' AS DateTime), 5090000, 2500000, 2590000, CAST(N'2018-10-16T00:00:00.000' AS DateTime), N'', N'Mua vào   ', 0)
INSERT [dbo].[CONG_NO] ([ID_CN], [ID_SOHD], [NGAY_HD], [TONGTIEN], [TRATRUOC], [NO], [NGAYTRA], [GHICHU], [XORN], [STATUS]) VALUES (27, 2, CAST(N'2018-10-15T00:00:00.000' AS DateTime), 6500000, 5000000, 1500000, CAST(N'2018-10-16T00:00:00.000' AS DateTime), N'', N'Bán ra    ', 0)
SET IDENTITY_INSERT [dbo].[CONG_NO] OFF
INSERT [dbo].[DM_HANG] ([MA_HANG], [TEN_HANG], [DVT], [DON_GIA], [DON_GIA_BAN], [MA_ST], [GHI_CHU]) VALUES (N'HH001', N'Hàng hóa các loại nhập từ trung quốc', N'M2', CAST(50000.00 AS Decimal(18, 2)), CAST(60000.00 AS Decimal(18, 2)), N'unknown_ncc', N'')
INSERT [dbo].[DM_HANG] ([MA_HANG], [TEN_HANG], [DVT], [DON_GIA], [DON_GIA_BAN], [MA_ST], [GHI_CHU]) VALUES (N'HH02', N'Hàng hóa các loại nhập từ trung quốc 2', N'Cái chiếc', CAST(60000.00 AS Decimal(18, 2)), CAST(65000.00 AS Decimal(18, 2)), N'unknown_ncc', N'')
INSERT [dbo].[DM_HANG] ([MA_HANG], [TEN_HANG], [DVT], [DON_GIA], [DON_GIA_BAN], [MA_ST], [GHI_CHU]) VALUES (N'VN001', N'Mì tôm Omachi', N'Gói', CAST(7000.00 AS Decimal(18, 2)), CAST(7500.00 AS Decimal(18, 2)), N'as', N'test')
INSERT [dbo].[DM_HANG] ([MA_HANG], [TEN_HANG], [DVT], [DON_GIA], [DON_GIA_BAN], [MA_ST], [GHI_CHU]) VALUES (N'VN02', N'Cam', N'Trái', CAST(20000.00 AS Decimal(18, 2)), CAST(25000.00 AS Decimal(18, 2)), N'unknown_ncc', N'1')
INSERT [dbo].[DM_HANG] ([MA_HANG], [TEN_HANG], [DVT], [DON_GIA], [DON_GIA_BAN], [MA_ST], [GHI_CHU]) VALUES (N'VN03', N'Nước suối', N'chai', CAST(4500.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), N'as', N'1')
INSERT [dbo].[DOI_TAC] ([MA_ST], [TEN_DT], [DIA_CHI], [NGUOI_LH], [SDT], [EMAIL], [WECHAT], [TAI_KHOAN], [GHI_CHU], [STATUS]) VALUES (N'as', N'aaa', N's', N'd', N'f', N'f', N'f', N'f', N'a', 1)
INSERT [dbo].[DOI_TAC] ([MA_ST], [TEN_DT], [DIA_CHI], [NGUOI_LH], [SDT], [EMAIL], [WECHAT], [TAI_KHOAN], [GHI_CHU], [STATUS]) VALUES (N'MST11', N'Công ty TNHH A', N'Xóm 1', N'Nguyễn Văn A', N'113', N'', N'', N'BIDV', N'sss', 0)
INSERT [dbo].[DOI_TAC] ([MA_ST], [TEN_DT], [DIA_CHI], [NGUOI_LH], [SDT], [EMAIL], [WECHAT], [TAI_KHOAN], [GHI_CHU], [STATUS]) VALUES (N'unknown_kh', N'Không xác định', N'Không xác định', N'Không xác định', N'0888177119', N'tungnt.mr2016@gmail.com', N'Không', N'Không', N'', 0)
INSERT [dbo].[DOI_TAC] ([MA_ST], [TEN_DT], [DIA_CHI], [NGUOI_LH], [SDT], [EMAIL], [WECHAT], [TAI_KHOAN], [GHI_CHU], [STATUS]) VALUES (N'unknown_ncc', N'Không xác định', N'Không xác định', N'Không xác định', N'0888177119', N'tungnt.mr2016@gmail.com', N'Không', N'Không', N'', 1)
INSERT [dbo].[NHAN_VIEN] ([MA_NV], [TEN_NV], [GIOI_TINH], [DIA_CHI], [SDT], [GHI_CHU]) VALUES (N'NV001', N'Ngô Thanh Tùng', 1, N'Trực Thanh, Trực Ninh, Nam Định', N'0888177119', NULL)
INSERT [dbo].[NHAN_VIEN] ([MA_NV], [TEN_NV], [GIOI_TINH], [DIA_CHI], [SDT], [GHI_CHU]) VALUES (N'NV002', N'Ngô Tùng', 1, N'Trực Thanh, Trực Ninh, Nam Định', N'0388830369', NULL)
INSERT [dbo].[PHIEU_MH] ([ID_PMH], [NGAY_MUA], [MA_ST], [TEN_CTY], [DIA_CHI], [SDT], [EMAIL], [TONG_TIEN_HANG], [SO_TIEN_VND]) VALUES (1, CAST(N'2018-10-17T00:00:00.000' AS DateTime), N'unknown_ncc', N'Không xác định', N'Không xác định', N'0888177119', N'tungnt.mr2016@gmail.com', 16000000, N'mười sáu triệu   đồng chẵn')
INSERT [dbo].[PHIEU_MH] ([ID_PMH], [NGAY_MUA], [MA_ST], [TEN_CTY], [DIA_CHI], [SDT], [EMAIL], [TONG_TIEN_HANG], [SO_TIEN_VND]) VALUES (2, CAST(N'2018-12-21T15:52:25.707' AS DateTime), N'as', N'aaa', N's', N'f', N'f', 25500, N'')
INSERT [dbo].[PHIEU_MH] ([ID_PMH], [NGAY_MUA], [MA_ST], [TEN_CTY], [DIA_CHI], [SDT], [EMAIL], [TONG_TIEN_HANG], [SO_TIEN_VND]) VALUES (3, CAST(N'2018-12-21T16:14:26.490' AS DateTime), N'as', N'aaa', N's', N'f', N'f', 11500, N'')
INSERT [dbo].[PHIEU_MH] ([ID_PMH], [NGAY_MUA], [MA_ST], [TEN_CTY], [DIA_CHI], [SDT], [EMAIL], [TONG_TIEN_HANG], [SO_TIEN_VND]) VALUES (4, CAST(N'2018-12-21T16:16:30.497' AS DateTime), N'unknown_ncc', N'Không xác định', N'Không xác định', N'0888177119', N'tungnt.mr2016@gmail.com', 50000, N'')
SET IDENTITY_INSERT [dbo].[PHIEU_MH_CT] ON 

INSERT [dbo].[PHIEU_MH_CT] ([ID_PMH_CT], [ID_PMH], [STT], [MA_HANG], [TEN_HANG], [DVT], [SL], [DON_GIA], [PTKM], [TIEN_KM], [THANH_TIEN]) VALUES (41, 1, 1, N'HH02', N'Hàng hóa các loại nhập từ trung quốc 2', N'Cái chiếc', CAST(200.00 AS Decimal(18, 2)), CAST(60000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(12000000.00 AS Decimal(18, 2)))
INSERT [dbo].[PHIEU_MH_CT] ([ID_PMH_CT], [ID_PMH], [STT], [MA_HANG], [TEN_HANG], [DVT], [SL], [DON_GIA], [PTKM], [TIEN_KM], [THANH_TIEN]) VALUES (42, 1, 2, N'HH001', N'Hàng hóa các loại nhập từ trung quốc', N'M2', CAST(100.00 AS Decimal(18, 2)), CAST(50000.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(1000000.00 AS Decimal(18, 2)), CAST(4000000.00 AS Decimal(18, 2)))
INSERT [dbo].[PHIEU_MH_CT] ([ID_PMH_CT], [ID_PMH], [STT], [MA_HANG], [TEN_HANG], [DVT], [SL], [DON_GIA], [PTKM], [TIEN_KM], [THANH_TIEN]) VALUES (43, 3, 1, N'VN001', N'Mì tôm Omachi', N'Gói', CAST(1.00 AS Decimal(18, 2)), CAST(7000.00 AS Decimal(18, 2)), NULL, NULL, CAST(7000.00 AS Decimal(18, 2)))
INSERT [dbo].[PHIEU_MH_CT] ([ID_PMH_CT], [ID_PMH], [STT], [MA_HANG], [TEN_HANG], [DVT], [SL], [DON_GIA], [PTKM], [TIEN_KM], [THANH_TIEN]) VALUES (44, 3, 2, N'VN03', N'Nước suối', N'chai', CAST(1.00 AS Decimal(18, 2)), CAST(4500.00 AS Decimal(18, 2)), NULL, NULL, CAST(4500.00 AS Decimal(18, 2)))
INSERT [dbo].[PHIEU_MH_CT] ([ID_PMH_CT], [ID_PMH], [STT], [MA_HANG], [TEN_HANG], [DVT], [SL], [DON_GIA], [PTKM], [TIEN_KM], [THANH_TIEN]) VALUES (45, 3, 3, NULL, NULL, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL, CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[PHIEU_MH_CT] ([ID_PMH_CT], [ID_PMH], [STT], [MA_HANG], [TEN_HANG], [DVT], [SL], [DON_GIA], [PTKM], [TIEN_KM], [THANH_TIEN]) VALUES (46, 4, 1, N'HH001', N'Hàng hóa các loại nhập từ trung quốc', N'M2', CAST(1.00 AS Decimal(18, 2)), CAST(50000.00 AS Decimal(18, 2)), NULL, NULL, CAST(50000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[PHIEU_MH_CT] OFF
INSERT [dbo].[Users] ([username], [password], [role]) VALUES (N'admin', N'c4ca4238a0b923820dcc509a6f75849b', NULL)
INSERT [dbo].[Users] ([username], [password], [role]) VALUES (N'admin2', N'c4ca4238a0b923820dcc509a6f75849b', N'admin')
ALTER TABLE [dbo].[DM_HANG]  WITH CHECK ADD  CONSTRAINT [FK_DM_HANG_DOITAC] FOREIGN KEY([MA_ST])
REFERENCES [dbo].[DOI_TAC] ([MA_ST])
GO
ALTER TABLE [dbo].[DM_HANG] CHECK CONSTRAINT [FK_DM_HANG_DOITAC]
GO
ALTER TABLE [dbo].[NGHI_PHEP]  WITH CHECK ADD  CONSTRAINT [FK_NGHI_PHEP_NHAN_VIEN] FOREIGN KEY([MA_NV])
REFERENCES [dbo].[NHAN_VIEN] ([MA_NV])
GO
ALTER TABLE [dbo].[NGHI_PHEP] CHECK CONSTRAINT [FK_NGHI_PHEP_NHAN_VIEN]
GO
ALTER TABLE [dbo].[PHIEU_BH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEU_BH_DOITAC] FOREIGN KEY([MA_ST])
REFERENCES [dbo].[DOI_TAC] ([MA_ST])
GO
ALTER TABLE [dbo].[PHIEU_BH] CHECK CONSTRAINT [FK_PHIEU_BH_DOITAC]
GO
ALTER TABLE [dbo].[PHIEU_BH_CT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEU_BH_CT_DM_HANG] FOREIGN KEY([MA_HANG])
REFERENCES [dbo].[DM_HANG] ([MA_HANG])
GO
ALTER TABLE [dbo].[PHIEU_BH_CT] CHECK CONSTRAINT [FK_PHIEU_BH_CT_DM_HANG]
GO
ALTER TABLE [dbo].[PHIEU_BH_CT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEU_BH_CT_PHIEU_BH] FOREIGN KEY([ID_PBH])
REFERENCES [dbo].[PHIEU_BH] ([ID_PBH])
GO
ALTER TABLE [dbo].[PHIEU_BH_CT] CHECK CONSTRAINT [FK_PHIEU_BH_CT_PHIEU_BH]
GO
ALTER TABLE [dbo].[PHIEU_MH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEU_MH_DOITAC] FOREIGN KEY([MA_ST])
REFERENCES [dbo].[DOI_TAC] ([MA_ST])
GO
ALTER TABLE [dbo].[PHIEU_MH] CHECK CONSTRAINT [FK_PHIEU_MH_DOITAC]
GO
ALTER TABLE [dbo].[PHIEU_MH_CT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEU_MH_CT_DM_HANG] FOREIGN KEY([MA_HANG])
REFERENCES [dbo].[DM_HANG] ([MA_HANG])
GO
ALTER TABLE [dbo].[PHIEU_MH_CT] CHECK CONSTRAINT [FK_PHIEU_MH_CT_DM_HANG]
GO
ALTER TABLE [dbo].[PHIEU_MH_CT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEU_MH_CT_PHIEU_MH] FOREIGN KEY([ID_PMH])
REFERENCES [dbo].[PHIEU_MH] ([ID_PMH])
GO
ALTER TABLE [dbo].[PHIEU_MH_CT] CHECK CONSTRAINT [FK_PHIEU_MH_CT_PHIEU_MH]
GO
/****** Object:  StoredProcedure [dbo].[CHAM_CONG]    Script Date: 12/21/2018 6:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHAM_CONG]
@NGAY_BD DATETIME,
@NGAY_KT DATETIME
AS
BEGIN
	select MA_NV,TEN_NV,SUM(SO_NGAY) AS NGAY_NGHI from NGHI_PHEP 
	where (NGAY_BD BETWEEN @NGAY_BD AND @NGAY_KT) AND ( NGAY_KT 
	BETWEEN @NGAY_BD AND @NGAY_KT )
	GROUP BY MA_NV,TEN_NV
	ORDER BY MA_NV
END
GO
/****** Object:  StoredProcedure [dbo].[CHITIET_TON]    Script Date: 12/21/2018 6:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIET_TON]
@MA_HANG NVARCHAR(50)
AS
BEGIN
	SELECT pmh.ID_PMH as SO_HD,pmh.NGAY_MUA AS NGAY,pmh.TEN_CTY as TEN_CTY,SUM(SL) AS MUA_VAO, 0 AS BAN_RA
	FROM PHIEU_MH_CT as pmh_ct, PHIEU_MH as pmh WHERE pmh.ID_PMH=pmh_ct.ID_PMH and MA_HANG =@MA_HANG GROUP BY pmh.ID_PMH,pmh.NGAY_MUA,pmh.TEN_CTY
	UNION SELECT pbh.ID_PBH as SO_HD, pbh.NGAY_BAN as NGAY,pbh.TEN_CTY as TEN_CTY, 0 AS MUA_VAO,SUM(SL) AS BAN_RA
	FROM PHIEU_BH_CT as pbh_ct, PHIEU_BH as pbh WHERE pbh.ID_PBH=pbh_ct.ID_PBH and MA_HANG =@MA_HANG GROUP BY pbh.ID_PBH,pbh.NGAY_BAN,pbh.TEN_CTY
END
GO
/****** Object:  StoredProcedure [dbo].[PRD_DOANHTHU]    Script Date: 12/21/2018 6:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PRD_DOANHTHU]
@TUNGAY DATETIME
AS
BEGIN
	SELECT  MA_HANG,TEN_HANG,DVT,ROUND(SUM(DON_GIA_MUA),2) as DON_GIA_MUA,SUM(DON_GIA_BAN) as DON_GIA_BAN,
	SUM(SL) as SL,ROUND(SUM(DON_GIA_MUA)*SUM(SL),2) AS TIEN_MUA, ROUND(SUM(DON_GIA_BAN)*SUM(SL),2) AS TIEN_BAN
	FROM (select ma_hang, ten_hang,dvt,avg(don_gia) as DON_GIA_MUA,0 AS DON_GIA_BAN,0 AS SL
	from phieu_mh_ct as a,phieu_mh as b
	where a.id_pmh= b.id_pmh
	group by ma_hang,ten_hang,dvt
	UNION 
	SELECT ma_hang,ten_hang,dvt,0 AS DON_GIA_MUA, DON_GIA AS DON_GIA_BAN, SUM(SL) AS SL
	FROM PHIEU_BH_CT AS A , PHIEU_BH AS B
	WHERE A.ID_PBH = B.ID_PBH and b.ngay_ban = @TUNGAY
	group by ma_hang,ten_hang,dvt,DON_GIA) AS ABC
	GROUP BY ma_hang,ten_hang,dvt
END
GO
/****** Object:  StoredProcedure [dbo].[PRD_DOANHTHU_THANG]    Script Date: 12/21/2018 6:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PRD_DOANHTHU_THANG]
@TUNGAY DATETIME,
@DENNGAY DATETIME
AS
BEGIN
	SELECT  MA_HANG,TEN_HANG,DVT,ROUND(SUM(DON_GIA_MUA),2) as DON_GIA_MUA,SUM(DON_GIA_BAN) as DON_GIA_BAN,
	SUM(SL) as SL,ROUND(SUM(DON_GIA_MUA)*SUM(SL),2) AS TIEN_MUA, ROUND(SUM(DON_GIA_BAN)*SUM(SL),2) AS TIEN_BAN
	FROM (select ma_hang, ten_hang,dvt,avg(don_gia) as DON_GIA_MUA,0 AS DON_GIA_BAN,0 AS SL
	from phieu_mh_ct as a,phieu_mh as b
	where a.id_pmh= b.id_pmh
	group by ma_hang,ten_hang,dvt
	UNION 
	SELECT ma_hang,ten_hang,dvt,0 AS DON_GIA_MUA, DON_GIA AS DON_GIA_BAN, SUM(SL) AS SL
	FROM PHIEU_BH_CT AS A , PHIEU_BH AS B
	WHERE A.ID_PBH = B.ID_PBH and b.ngay_ban between @TUNGAY and @DENNGAY
	group by ma_hang,ten_hang,dvt,DON_GIA) AS ABC
	GROUP BY ma_hang,ten_hang,dvt
END
GO
/****** Object:  StoredProcedure [dbo].[TON_HANG]    Script Date: 12/21/2018 6:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TON_HANG]
AS
BEGIN
	SELECT MA_HANG,TEN_HANG,DVT,SUM(MUA_VAO) AS MUA_VAO,SUM(BAN_RA) AS BAN_RA,SUM(MUA_VAO-BAN_RA) AS TON_KHO
	FROM (SELECT MA_HANG,TEN_HANG,DVT,SUM(SL) AS MUA_VAO, 0 AS BAN_RA
	FROM PHIEU_MH_CT as N GROUP BY MA_HANG,TEN_HANG,DVT
	UNION SELECT MA_HANG,TEN_HANG,DVT, 0 AS MUA_VAO,SUM(SL) AS BAN_RA
	FROM PHIEU_BH_CT GROUP BY MA_HANG,TEN_HANG,DVT) as B
	GROUP BY MA_HANG,TEN_HANG,DVT
	END
GO
USE [master]
GO
ALTER DATABASE [QLBH] SET  READ_WRITE 
GO
