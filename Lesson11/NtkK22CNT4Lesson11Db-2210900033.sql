USE [NtkK22CNT4Lesson11Db]
GO
/****** Object:  Table [dbo].[NtkCategory]    Script Date: 7/4/2024 10:49:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NtkCategory](
	[NtkID] [int] IDENTITY(1,1) NOT NULL,
	[NtkCateName] [nvarchar](50) NULL,
	[NtkStatus] [bit] NULL,
 CONSTRAINT [PK_NtkCategory] PRIMARY KEY CLUSTERED 
(
	[NtkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NtkProduct]    Script Date: 7/4/2024 10:49:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NtkProduct](
	[NtkId2210900033] [nvarchar](50) NOT NULL,
	[NtkProName] [nvarchar](50) NULL,
	[NtkQty] [int] NULL,
	[NtkPrice] [float] NULL,
	[NtkCateId] [int] NULL,
	[NtkActive] [bit] NULL,
 CONSTRAINT [PK_NtkProduct] PRIMARY KEY CLUSTERED 
(
	[NtkId2210900033] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NtkCategory] ON 

INSERT [dbo].[NtkCategory] ([NtkID], [NtkCateName], [NtkStatus]) VALUES (1, N'2210900033', 1)
INSERT [dbo].[NtkCategory] ([NtkID], [NtkCateName], [NtkStatus]) VALUES (2, N'Samsung', 0)
SET IDENTITY_INSERT [dbo].[NtkCategory] OFF
GO
INSERT [dbo].[NtkProduct] ([NtkId2210900033], [NtkProName], [NtkQty], [NtkPrice], [NtkCateId], [NtkActive]) VALUES (N'2210900033', N'Nguyễn Trực Kiên', 10, 1003011, 1, 1)
INSERT [dbo].[NtkProduct] ([NtkId2210900033], [NtkProName], [NtkQty], [NtkPrice], [NtkCateId], [NtkActive]) VALUES (N'P001', N'Samsung S22 Ultra', 2, 3011100, 1, 0)
GO
ALTER TABLE [dbo].[NtkProduct]  WITH CHECK ADD  CONSTRAINT [FK_NtkProduct_NtkCategory] FOREIGN KEY([NtkCateId])
REFERENCES [dbo].[NtkCategory] ([NtkID])
GO
ALTER TABLE [dbo].[NtkProduct] CHECK CONSTRAINT [FK_NtkProduct_NtkCategory]
GO
