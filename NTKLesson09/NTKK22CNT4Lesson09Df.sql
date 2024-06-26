USE [NtkK22CNT4Lesson09Db]
GO
/****** Object:  Table [dbo].[ntkKetqua]    Script Date: 6/26/2024 3:35:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ntkKetqua](
	[ntkMaSV] [nvarchar](50) NOT NULL,
	[ntkMaMH] [nvarchar](50) NULL,
	[ntkDiem] [decimal](18, 0) NULL,
	[ntkStt] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_ntkKetqua] PRIMARY KEY CLUSTERED 
(
	[ntkStt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ntkKhoa]    Script Date: 6/26/2024 3:35:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ntkKhoa](
	[ntkMaKH] [nchar](10) NOT NULL,
	[ntkTenKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_ntkKhoa] PRIMARY KEY CLUSTERED 
(
	[ntkMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ntkMonHoc]    Script Date: 6/26/2024 3:35:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ntkMonHoc](
	[ntkMaMH] [nvarchar](50) NOT NULL,
	[ntkTenMH] [nvarchar](50) NULL,
	[ntkSotiet] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ntkMonHoc] PRIMARY KEY CLUSTERED 
(
	[ntkMaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ntkSinhVien]    Script Date: 6/26/2024 3:35:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ntkSinhVien](
	[ntkMaSV] [nvarchar](50) NOT NULL,
	[ntkHoSV] [nvarchar](50) NULL,
	[ntkTenSV] [nvarchar](50) NULL,
	[ntkPhai] [bit] NULL,
	[ntkNgaySinh] [date] NULL,
	[ntkNoiSinh] [nvarchar](50) NULL,
	[ntkMaKH] [nchar](10) NULL,
	[ntkHocBong] [decimal](18, 0) NULL,
	[ntkDiemTrungBinh] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ntkSinhVien] PRIMARY KEY CLUSTERED 
(
	[ntkMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ntkKhoa] ([ntkMaKH], [ntkTenKH]) VALUES (N'K22CNT4   ', N'CNTT')
GO
INSERT [dbo].[ntkMonHoc] ([ntkMaMH], [ntkTenMH], [ntkSotiet]) VALUES (N'K22CNT4', N'ASPNET', CAST(10 AS Decimal(18, 0)))
GO
INSERT [dbo].[ntkSinhVien] ([ntkMaSV], [ntkHoSV], [ntkTenSV], [ntkPhai], [ntkNgaySinh], [ntkNoiSinh], [ntkMaKH], [ntkHocBong], [ntkDiemTrungBinh]) VALUES (N'2210900033', N'Nguyễn Trực ', N'Kiên', 1, CAST(N'2004-03-10' AS Date), N'Phúc Yên', N'K22CNT4   ', CAST(123 AS Decimal(18, 0)), CAST(321 AS Decimal(18, 0)))
GO
ALTER TABLE [dbo].[ntkKetqua]  WITH CHECK ADD  CONSTRAINT [FK_ntkKetqua_ntkMonHoc] FOREIGN KEY([ntkMaMH])
REFERENCES [dbo].[ntkMonHoc] ([ntkMaMH])
GO
ALTER TABLE [dbo].[ntkKetqua] CHECK CONSTRAINT [FK_ntkKetqua_ntkMonHoc]
GO
ALTER TABLE [dbo].[ntkKetqua]  WITH CHECK ADD  CONSTRAINT [FK_ntkKetqua_ntkSinhVien] FOREIGN KEY([ntkMaSV])
REFERENCES [dbo].[ntkSinhVien] ([ntkMaSV])
GO
ALTER TABLE [dbo].[ntkKetqua] CHECK CONSTRAINT [FK_ntkKetqua_ntkSinhVien]
GO
ALTER TABLE [dbo].[ntkSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_ntkSinhVien_ntkKhoa] FOREIGN KEY([ntkMaKH])
REFERENCES [dbo].[ntkKhoa] ([ntkMaKH])
GO
ALTER TABLE [dbo].[ntkSinhVien] CHECK CONSTRAINT [FK_ntkSinhVien_ntkKhoa]
GO
