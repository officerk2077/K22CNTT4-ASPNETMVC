USE [NtkK22CNT4Lesson07Db]
GO
/****** Object:  Table [dbo].[ntkKhoa]    Script Date: 12/06/2024 3:23:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ntkKhoa](
	[NtkMaKH] [nchar](10) NOT NULL,
	[NtkTenKH] [nvarchar](50) NULL,
	[NtkTrangThai] [bit] NULL,
 CONSTRAINT [PK_ntkKhoa] PRIMARY KEY CLUSTERED 
(
	[NtkMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NtkSinhVien]    Script Date: 12/06/2024 3:23:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NtkSinhVien](
	[NtkMaSV] [nvarchar](50) NOT NULL,
	[NtkHoSV] [nvarchar](50) NULL,
	[NtkTenSV] [nvarchar](50) NULL,
	[NtkNgaySinh] [date] NULL,
	[TvcPhai] [bit] NULL,
	[TvcPhone] [nchar](10) NULL,
	[NtkEmail] [nvarchar](50) NULL,
	[NtkMaKH] [nchar](10) NULL,
 CONSTRAINT [PK_NtkSinhVien] PRIMARY KEY CLUSTERED 
(
	[NtkMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ntkKhoa] ([NtkMaKH], [NtkTenKH], [NtkTrangThai]) VALUES (N'K22CNT4   ', N'K22CNT4', 1)
GO
INSERT [dbo].[NtkSinhVien] ([NtkMaSV], [NtkHoSV], [NtkTenSV], [NtkNgaySinh], [TvcPhai], [TvcPhone], [NtkEmail], [NtkMaKH]) VALUES (N'222210900033', N'Nguyễn Trực ', N'Kiên', CAST(N'2004-03-10' AS Date), 1, N'0363789548', N'wwwkienmario123@gmail.com', N'K22CNT4   ')
GO
