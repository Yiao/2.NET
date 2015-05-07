
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/07/2015 16:16:57
-- Generated from EDMX file: C:\Users\Yiao\Desktop\SupermarcheGRUPcategrieFini\Supermarche\SuperMarcheDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MarcketDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CheckoutEmployees_Checkout]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CheckoutEmployees] DROP CONSTRAINT [FK_CheckoutEmployees_Checkout];
GO
IF OBJECT_ID(N'[dbo].[FK_CheckoutEmployees_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CheckoutEmployees] DROP CONSTRAINT [FK_CheckoutEmployees_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductsCheckout_Checkout]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductsCheckout] DROP CONSTRAINT [FK_ProductsCheckout_Checkout];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductsCheckout_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductsCheckout] DROP CONSTRAINT [FK_ProductsCheckout_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductsSections_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductsSections] DROP CONSTRAINT [FK_ProductsSections_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductsSections_Sections]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductsSections] DROP CONSTRAINT [FK_ProductsSections_Sections];
GO
IF OBJECT_ID(N'[dbo].[FK_SectionsEmployees_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SectionsEmployees] DROP CONSTRAINT [FK_SectionsEmployees_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_SectionsEmployees_Sections]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SectionsEmployees] DROP CONSTRAINT [FK_SectionsEmployees_Sections];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CheckoutEmployees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CheckoutEmployees];
GO
IF OBJECT_ID(N'[dbo].[Checkouts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Checkouts];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[ProductsCheckout]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductsCheckout];
GO
IF OBJECT_ID(N'[dbo].[ProductsSections]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductsSections];
GO
IF OBJECT_ID(N'[dbo].[Sections]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sections];
GO
IF OBJECT_ID(N'[dbo].[SectionsEmployees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SectionsEmployees];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Price] int  NOT NULL,
    [Quantity] int  NOT NULL,
    [Status] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Sections'
CREATE TABLE [dbo].[Sections] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Categorie] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [Fonction] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Checkouts'
CREATE TABLE [dbo].[Checkouts] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'SectionsEmployees'
CREATE TABLE [dbo].[SectionsEmployees] (
    [Sections_Id] int  NOT NULL,
    [Employees_Id] int  NOT NULL
);
GO

-- Creating table 'ProductsSections'
CREATE TABLE [dbo].[ProductsSections] (
    [Products_Id] int  NOT NULL,
    [Sections_Id] int  NOT NULL
);
GO

-- Creating table 'ProductsCheckout'
CREATE TABLE [dbo].[ProductsCheckout] (
    [Products_Id] int  NOT NULL,
    [Checkouts_Id] int  NOT NULL
);
GO

-- Creating table 'CheckoutEmployees'
CREATE TABLE [dbo].[CheckoutEmployees] (
    [Checkouts_Id] int  NOT NULL,
    [Employees_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sections'
ALTER TABLE [dbo].[Sections]
ADD CONSTRAINT [PK_Sections]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Checkouts'
ALTER TABLE [dbo].[Checkouts]
ADD CONSTRAINT [PK_Checkouts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Sections_Id], [Employees_Id] in table 'SectionsEmployees'
ALTER TABLE [dbo].[SectionsEmployees]
ADD CONSTRAINT [PK_SectionsEmployees]
    PRIMARY KEY CLUSTERED ([Sections_Id], [Employees_Id] ASC);
GO

-- Creating primary key on [Products_Id], [Sections_Id] in table 'ProductsSections'
ALTER TABLE [dbo].[ProductsSections]
ADD CONSTRAINT [PK_ProductsSections]
    PRIMARY KEY CLUSTERED ([Products_Id], [Sections_Id] ASC);
GO

-- Creating primary key on [Products_Id], [Checkouts_Id] in table 'ProductsCheckout'
ALTER TABLE [dbo].[ProductsCheckout]
ADD CONSTRAINT [PK_ProductsCheckout]
    PRIMARY KEY CLUSTERED ([Products_Id], [Checkouts_Id] ASC);
GO

-- Creating primary key on [Checkouts_Id], [Employees_Id] in table 'CheckoutEmployees'
ALTER TABLE [dbo].[CheckoutEmployees]
ADD CONSTRAINT [PK_CheckoutEmployees]
    PRIMARY KEY CLUSTERED ([Checkouts_Id], [Employees_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Sections_Id] in table 'SectionsEmployees'
ALTER TABLE [dbo].[SectionsEmployees]
ADD CONSTRAINT [FK_SectionsEmployees_Sections]
    FOREIGN KEY ([Sections_Id])
    REFERENCES [dbo].[Sections]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Employees_Id] in table 'SectionsEmployees'
ALTER TABLE [dbo].[SectionsEmployees]
ADD CONSTRAINT [FK_SectionsEmployees_Employees]
    FOREIGN KEY ([Employees_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SectionsEmployees_Employees'
CREATE INDEX [IX_FK_SectionsEmployees_Employees]
ON [dbo].[SectionsEmployees]
    ([Employees_Id]);
GO

-- Creating foreign key on [Products_Id] in table 'ProductsSections'
ALTER TABLE [dbo].[ProductsSections]
ADD CONSTRAINT [FK_ProductsSections_Products]
    FOREIGN KEY ([Products_Id])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Sections_Id] in table 'ProductsSections'
ALTER TABLE [dbo].[ProductsSections]
ADD CONSTRAINT [FK_ProductsSections_Sections]
    FOREIGN KEY ([Sections_Id])
    REFERENCES [dbo].[Sections]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductsSections_Sections'
CREATE INDEX [IX_FK_ProductsSections_Sections]
ON [dbo].[ProductsSections]
    ([Sections_Id]);
GO

-- Creating foreign key on [Products_Id] in table 'ProductsCheckout'
ALTER TABLE [dbo].[ProductsCheckout]
ADD CONSTRAINT [FK_ProductsCheckout_Products]
    FOREIGN KEY ([Products_Id])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Checkouts_Id] in table 'ProductsCheckout'
ALTER TABLE [dbo].[ProductsCheckout]
ADD CONSTRAINT [FK_ProductsCheckout_Checkout]
    FOREIGN KEY ([Checkouts_Id])
    REFERENCES [dbo].[Checkouts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductsCheckout_Checkout'
CREATE INDEX [IX_FK_ProductsCheckout_Checkout]
ON [dbo].[ProductsCheckout]
    ([Checkouts_Id]);
GO

-- Creating foreign key on [Checkouts_Id] in table 'CheckoutEmployees'
ALTER TABLE [dbo].[CheckoutEmployees]
ADD CONSTRAINT [FK_CheckoutEmployees_Checkout]
    FOREIGN KEY ([Checkouts_Id])
    REFERENCES [dbo].[Checkouts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Employees_Id] in table 'CheckoutEmployees'
ALTER TABLE [dbo].[CheckoutEmployees]
ADD CONSTRAINT [FK_CheckoutEmployees_Employees]
    FOREIGN KEY ([Employees_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CheckoutEmployees_Employees'
CREATE INDEX [IX_FK_CheckoutEmployees_Employees]
ON [dbo].[CheckoutEmployees]
    ([Employees_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------