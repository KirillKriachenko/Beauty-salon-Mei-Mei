
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/10/2014 17:08:48
-- Generated from EDMX file: C:\Users\Kriachenko-ka\Documents\Visual Studio 2012\Projects\MeiMeirepo\MeiMei\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MeiMeiDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cart]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cart];
GO
IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Employee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employee];
GO
IF OBJECT_ID(N'[dbo].[Goods]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Goods];
GO
IF OBJECT_ID(N'[dbo].[History]', 'U') IS NOT NULL
    DROP TABLE [dbo].[History];
GO
IF OBJECT_ID(N'[dbo].[Schedule]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Schedule];
GO
IF OBJECT_ID(N'[dbo].[Services]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Services];
GO
IF OBJECT_ID(N'[dbo].[TypeOfService]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeOfService];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Carts'
CREATE TABLE [dbo].[Carts] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FIOCustomer] nvarchar(50)  NULL,
    [Contacts] nvarchar(50)  NULL,
    [Birthday] datetime  NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FIO] nvarchar(50)  NULL,
    [Birthday] datetime  NULL,
    [Post] nvarchar(50)  NULL,
    [Salary] nvarchar(50)  NULL,
    [Contacts] nvarchar(50)  NULL
);
GO

-- Creating table 'Goods'
CREATE TABLE [dbo].[Goods] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NULL,
    [Price] int  NULL,
    [Count] int  NULL
);
GO

-- Creating table 'Histories'
CREATE TABLE [dbo].[Histories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NULL
);
GO

-- Creating table 'Schedules'
CREATE TABLE [dbo].[Schedules] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NULL,
    [Time] datetime  NULL
);
GO

-- Creating table 'Services'
CREATE TABLE [dbo].[Services] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ServiceName] nvarchar(50)  NULL,
    [ServiceCost] nvarchar(50)  NULL,
    [TypeOfServiceId] int  NOT NULL
);
GO

-- Creating table 'TypeOfServices'
CREATE TABLE [dbo].[TypeOfServices] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TypeService] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Carts'
ALTER TABLE [dbo].[Carts]
ADD CONSTRAINT [PK_Carts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Goods'
ALTER TABLE [dbo].[Goods]
ADD CONSTRAINT [PK_Goods]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Histories'
ALTER TABLE [dbo].[Histories]
ADD CONSTRAINT [PK_Histories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Schedules'
ALTER TABLE [dbo].[Schedules]
ADD CONSTRAINT [PK_Schedules]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Services'
ALTER TABLE [dbo].[Services]
ADD CONSTRAINT [PK_Services]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypeOfServices'
ALTER TABLE [dbo].[TypeOfServices]
ADD CONSTRAINT [PK_TypeOfServices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TypeOfServiceId] in table 'Services'
ALTER TABLE [dbo].[Services]
ADD CONSTRAINT [FK_TypeOfServiceService]
    FOREIGN KEY ([TypeOfServiceId])
    REFERENCES [dbo].[TypeOfServices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TypeOfServiceService'
CREATE INDEX [IX_FK_TypeOfServiceService]
ON [dbo].[Services]
    ([TypeOfServiceId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------