
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/09/2020 20:45:28
-- Generated from EDMX file: C:\Faculty\tspnet\projStandard\ModelDesignFirst_L1\Model1.edmx
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


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
    [Duration] int  NOT NULL,
    [PropertyID] int  NOT NULL
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
    [Weight] int  NOT NULL,
    [PropertyID] int  NOT NULL
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
    [ID] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'PropertyPropertyCode'
CREATE TABLE [dbo].[PropertyPropertyCode] (
    [Properties_ID] int  NOT NULL,
    [PropertyCodes_ID] int  NOT NULL
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

-- Creating primary key on [Properties_ID], [PropertyCodes_ID] in table 'PropertyPropertyCode'
ALTER TABLE [dbo].[PropertyPropertyCode]
ADD CONSTRAINT [PK_PropertyPropertyCode]
    PRIMARY KEY CLUSTERED ([Properties_ID], [PropertyCodes_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PropertyID] in table 'Movies'
ALTER TABLE [dbo].[Movies]
ADD CONSTRAINT [FK_PropertyMovie]
    FOREIGN KEY ([PropertyID])
    REFERENCES [dbo].[Properties]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PropertyMovie'
CREATE INDEX [IX_FK_PropertyMovie]
ON [dbo].[Movies]
    ([PropertyID]);
GO

-- Creating foreign key on [PropertyID] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [FK_PropertyPhoto]
    FOREIGN KEY ([PropertyID])
    REFERENCES [dbo].[Properties]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PropertyPhoto'
CREATE INDEX [IX_FK_PropertyPhoto]
ON [dbo].[Photos]
    ([PropertyID]);
GO

-- Creating foreign key on [Properties_ID] in table 'PropertyPropertyCode'
ALTER TABLE [dbo].[PropertyPropertyCode]
ADD CONSTRAINT [FK_PropertyPropertyCode_Property]
    FOREIGN KEY ([Properties_ID])
    REFERENCES [dbo].[Properties]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PropertyCodes_ID] in table 'PropertyPropertyCode'
ALTER TABLE [dbo].[PropertyPropertyCode]
ADD CONSTRAINT [FK_PropertyPropertyCode_PropertyCode]
    FOREIGN KEY ([PropertyCodes_ID])
    REFERENCES [dbo].[PropertyCodes]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PropertyPropertyCode_PropertyCode'
CREATE INDEX [IX_FK_PropertyPropertyCode_PropertyCode]
ON [dbo].[PropertyPropertyCode]
    ([PropertyCodes_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------