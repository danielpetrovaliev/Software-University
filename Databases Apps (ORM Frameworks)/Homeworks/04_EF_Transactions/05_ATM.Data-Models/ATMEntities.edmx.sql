
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/12/2015 00:17:31
-- Generated from EDMX file: C:\Users\petrovaliev95\Documents\Visual Studio 2013\Projects\Databases Apps (ORM Frameworks)\04_EF_Transactions\05_ATM.Data-Models\ATMEntities.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ATM];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CardAccounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CardAccounts];
GO
IF OBJECT_ID(N'[dbo].[TransactionHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TransactionHistory];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CardAccounts'
CREATE TABLE [dbo].[CardAccounts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CardNumber] nvarchar(10)  NOT NULL,
    [CardPIN] nvarchar(4)  NOT NULL,
    [CardCash] decimal(19,4)  NOT NULL
);
GO

-- Creating table 'TransactionHistories'
CREATE TABLE [dbo].[TransactionHistories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CardNumber] nvarchar(10)  NOT NULL,
    [TransactionDate] datetime  NOT NULL,
    [Amount] decimal(19,4)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CardAccounts'
ALTER TABLE [dbo].[CardAccounts]
ADD CONSTRAINT [PK_CardAccounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TransactionHistories'
ALTER TABLE [dbo].[TransactionHistories]
ADD CONSTRAINT [PK_TransactionHistories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------