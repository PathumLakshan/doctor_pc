USE [master]
CREATE DATABASE [DOCTERDB] 
USE [DOCTERDB] 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Login] (
    [UserName] VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NOT NULL
);
GO
CREATE TABLE [dbo].[Patient_Details] (
    [Patient_ID]     INT           IDENTITY (1, 1) NOT NULL,
    [Patient_Name]   NVARCHAR (50) NOT NULL,
    [Age]            INT           NOT NULL,
    [P_Number]       NVARCHAR (50) NULL,
    [Patient_Gender] NVARCHAR (6)  NULL,
    [Patient_NIC]    NVARCHAR (10) NULL,
    [P_Address]      NVARCHAR (50) NULL,
 CONSTRAINT [PK_Patient_Details] PRIMARY KEY CLUSTERED ([Patient_ID] ASC)
);
GO

CREATE TABLE [dbo].[Treatment] (
    [Treatment_ID] INT           IDENTITY (1, 1) NOT NULL,
    [Patient_ID]   INT           NOT NULL,
    [Patient_Name] NVARCHAR (50) NOT NULL,
    [Disease]      NVARCHAR (50) NOT NULL,
    [Prescription] NVARCHAR (50) NOT NULL,
    [Date]         NVARCHAR (50) NOT NULL,
    [Rs]           FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_Tretment] PRIMARY KEY CLUSTERED ([Treatment_ID] ASC),
    CONSTRAINT [FK_Tretment_Patient_Details] FOREIGN KEY ([Patient_ID]) REFERENCES [dbo].[Patient_Details] ([Patient_ID])
);
GO

