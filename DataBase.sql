USE [DOCTER]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 16/02/2018 12:12:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient_Details]    Script Date: 16/02/2018 12:12:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient_Details](
	[Patient_ID] [int] IDENTITY(1,1) NOT NULL,
	[Patient_Name] [nvarchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[P_Number] [nvarchar](50) NULL,
	[Patient_Gender] [nvarchar](6) NULL,
	[Patient_NIC] [nvarchar](10) NULL,
	[P_Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_Patient_Details] PRIMARY KEY CLUSTERED 
(
	[Patient_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Treatment]    Script Date: 16/02/2018 12:12:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Treatment](
	[Treatment_ID] [int] IDENTITY(1,1) NOT NULL,
	[Patient_ID] [int] NOT NULL,
	[Patient_Name] [nvarchar](50) NOT NULL,
	[Disease] [nvarchar](50) NOT NULL,
	[Prescription] [nvarchar](50) NOT NULL,
	[Date] [nvarchar](50) NOT NULL,
	[Rs] [float] NOT NULL,
 CONSTRAINT [PK_Tretment] PRIMARY KEY CLUSTERED 
(
	[Treatment_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Treatment]  WITH NOCHECK ADD  CONSTRAINT [FK_Tretment_Patient_Details] FOREIGN KEY([Patient_ID])
REFERENCES [dbo].[Patient_Details] ([Patient_ID])
GO
ALTER TABLE [dbo].[Treatment] CHECK CONSTRAINT [FK_Tretment_Patient_Details]
GO
