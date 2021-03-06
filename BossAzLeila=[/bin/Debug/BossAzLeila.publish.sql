﻿/*
Deployment script for DB_A50752_programming

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "DB_A50752_programming"
:setvar DefaultFilePrefix "DB_A50752_programming"
:setvar DefaultDataPath "H:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\Data\"
:setvar DefaultLogPath "H:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\Data\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creating [BossLeila]...';


GO
CREATE SCHEMA [BossLeila]
    AUTHORIZATION [dbo];


GO
PRINT N'Creating [BossLeila].[Education]...';


GO
CREATE TABLE [BossLeila].[Education] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [name]          NVARCHAR (200) NOT NULL,
    [CreatedDate]   DATETIME       NOT NULL,
    [CreatedUserId] INT            NOT NULL,
    [UpdatedDate]   DATETIME       NULL,
    [UpdatedUserId] INT            NOT NULL,
    [DeletedDate]   DATETIME       NULL,
    [DeletedUserId] INT            NULL,
    CONSTRAINT [Pk_BossLeila_Education] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [BossLeila].[City]...';


GO
CREATE TABLE [BossLeila].[City] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [name]          NVARCHAR (200) NOT NULL,
    [CreatedDate]   DATETIME       NOT NULL,
    [CreatedUserId] INT            NOT NULL,
    [UpdatedDate]   DATETIME       NULL,
    [UpdatedUserId] INT            NOT NULL,
    [DeletedDate]   DATETIME       NULL,
    [DeletedUserId] INT            NULL,
    CONSTRAINT [Pk_BossLeila_City] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating unnamed constraint on [BossLeila].[Education]...';


GO
ALTER TABLE [BossLeila].[Education]
    ADD DEFAULT SYSDATETIME() FOR [CreatedDate];


GO
PRINT N'Creating unnamed constraint on [BossLeila].[City]...';


GO
ALTER TABLE [BossLeila].[City]
    ADD DEFAULT SYSDATETIME() FOR [CreatedDate];


GO
PRINT N'Update complete.';


GO
