USE [NtkK22CNT4Lesson10Db]
GO
/****** Object:  Table [dbo].[NtkAccount]    Script Date: 7/3/2024 2:55:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NtkAccount](
	[NtkID] [int] IDENTITY(1,1) NOT NULL,
	[NtkUserName] [nvarchar](50) NULL,
	[NtkPassword] [nvarchar](50) NULL,
	[NtkFullName] [nvarchar](50) NULL,
	[NtkEmail] [nvarchar](50) NULL,
	[NtkPhone] [nvarchar](50) NULL,
	[NtkActive] [bit] NULL,
 CONSTRAINT [PK_NtkAccount] PRIMARY KEY CLUSTERED 
(
	[NtkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NtkAccount] ON 

INSERT [dbo].[NtkAccount] ([NtkID], [NtkUserName], [NtkPassword], [NtkFullName], [NtkEmail], [NtkPhone], [NtkActive]) VALUES (1, N'TrucKien', N'2210900033', N'Nguyễn Trực Kiên', N'wwwkienmario123@gmail.com', N'0363789548', 1)
SET IDENTITY_INSERT [dbo].[NtkAccount] OFF
GO
