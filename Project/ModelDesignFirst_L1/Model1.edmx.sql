
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/12/2020 21:53:22
-- Generated from EDMX file: C:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ModelDesignFirst_L1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [projTsp];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PropertyMovie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Movies] DROP CONSTRAINT [FK_PropertyMovie];
GO
IF OBJECT_ID(N'[dbo].[FK_PropertyPhoto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Photos] DROP CONSTRAINT [FK_PropertyPhoto];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Movies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Movies];
GO
IF OBJECT_ID(N'[dbo].[Photos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Photos];
GO
IF OBJECT_ID(N'[dbo].[PropertyCodes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PropertyCodes];
GO
IF OBJECT_ID(N'[dbo].[Properties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Properties];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Movies'
CREATE TABLE [dbo].[Movies] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FullPath] nvarchar(max)  NOT NULL,
    [MovieName] nvarchar(max)  NOT NULL,
    [CreationDate] datetime  NOT NULL,
    [Event] nvarchar(max)  NOT NULL,
    [TaggedPersons] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [FlgMoved] bit  NOT NULL,
    [Duration] int  NOT NULL
);
GO

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FullPath] nvarchar(max)  NOT NULL,
    [PhotoName] nvarchar(max)  NOT NULL,
    [CreationDate] datetime  NOT NULL,
    [Event] nvarchar(max)  NOT NULL,
    [TaggedPersons] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [FlgMoved] bit  NOT NULL,
    [Height] int  NOT NULL,
    [Weight] int  NOT NULL
);
GO

-- Creating table 'PropertyCodes'
CREATE TABLE [dbo].[PropertyCodes] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Properties'
CREATE TABLE [dbo].[Properties] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [PropertyCodeID] int  NOT NULL,
    [MediaID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Movies'
ALTER TABLE [dbo].[Movies]
ADD CONSTRAINT [PK_Movies]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PropertyCodes'
ALTER TABLE [dbo].[PropertyCodes]
ADD CONSTRAINT [PK_PropertyCodes]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Properties'
ALTER TABLE [dbo].[Properties]
ADD CONSTRAINT [PK_Properties]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PropertyCodeID] in table 'Properties'
ALTER TABLE [dbo].[Properties]
ADD CONSTRAINT [FK_DescToCode]
    FOREIGN KEY ([PropertyCodeID])
    REFERENCES [dbo].[PropertyCodes]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DescToCode'
CREATE INDEX [IX_FK_DescToCode]
ON [dbo].[Properties]
    ([PropertyCodeID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------