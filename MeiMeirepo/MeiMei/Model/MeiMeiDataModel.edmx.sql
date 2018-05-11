
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/11/2018 08:31:33
-- Generated from EDMX file: D:\ForJob\MeiMei BuetySalon\Relize\MeiMeirepo\MeiMei\Model\MeiMeiDataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [C:\USERS\KIRILL\DOCUMENTS\MEIMEIDB.MDF];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TypeOfServiceService]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Services] DROP CONSTRAINT [FK_TypeOfServiceService];
GO
IF OBJECT_ID(N'[dbo].[FK_CustomersHistory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Histories] DROP CONSTRAINT [FK_CustomersHistory];
GO
IF OBJECT_ID(N'[dbo].[FK_TypeOfGoodsGoods]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Goods] DROP CONSTRAINT [FK_TypeOfGoodsGoods];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeTableShedule]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Shedules] DROP CONSTRAINT [FK_EmployeeTableShedule];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeTableEmployeeHistory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeHistories] DROP CONSTRAINT [FK_EmployeeTableEmployeeHistory];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TypeOfServices]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeOfServices];
GO
IF OBJECT_ID(N'[dbo].[Services]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Services];
GO
IF OBJECT_ID(N'[dbo].[EmployeeTables]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeTables];
GO
IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Histories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Histories];
GO
IF OBJECT_ID(N'[dbo].[TypeOfGoods]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeOfGoods];
GO
IF OBJECT_ID(N'[dbo].[Goods]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Goods];
GO
IF OBJECT_ID(N'[dbo].[Shedules]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Shedules];
GO
IF OBJECT_ID(N'[dbo].[SheduleTimes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SheduleTimes];
GO
IF OBJECT_ID(N'[dbo].[SheduleColumns]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SheduleColumns];
GO
IF OBJECT_ID(N'[dbo].[GoodHistories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GoodHistories];
GO
IF OBJECT_ID(N'[dbo].[EmployeeHistories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeHistories];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TypeOfServices'
CREATE TABLE [dbo].[TypeOfServices] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TypeService] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Services'
CREATE TABLE [dbo].[Services] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ServiceName] nvarchar(max)  NOT NULL,
    [ServicePrice] nvarchar(max)  NOT NULL,
    [TypeOfServiceId] int  NOT NULL
);
GO

-- Creating table 'EmployeeTables'
CREATE TABLE [dbo].[EmployeeTables] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FIO] nvarchar(max)  NOT NULL,
    [Post] nvarchar(max)  NOT NULL,
    [Birthday] nvarchar(max)  NOT NULL,
    [Contacts] nvarchar(max)  NOT NULL,
    [PersonalData] nvarchar(max)  NOT NULL,
    [Salary] nvarchar(max)  NOT NULL,
    [Photo] varbinary(max)  NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FIO] nvarchar(max)  NOT NULL,
    [Contakts] nvarchar(max)  NULL,
    [Birthday] nvarchar(max)  NULL,
    [Notes] nvarchar(max)  NULL,
    [Photo] varbinary(max)  NULL
);
GO

-- Creating table 'Histories'
CREATE TABLE [dbo].[Histories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CustomersId] int  NOT NULL,
    [ServiceName] nvarchar(max)  NOT NULL,
    [ServiceCost] nvarchar(max)  NOT NULL,
    [Data] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TypeOfGoods'
CREATE TABLE [dbo].[TypeOfGoods] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TypeGoods] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Goods'
CREATE TABLE [dbo].[Goods] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GoodName] nvarchar(max)  NOT NULL,
    [GoodPrice] nvarchar(max)  NOT NULL,
    [TypeOfGoodsId] int  NOT NULL,
    [Count] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Shedules'
CREATE TABLE [dbo].[Shedules] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ServicePrice] nvarchar(max)  NOT NULL,
    [ServiceName] nvarchar(max)  NOT NULL,
    [Data] datetime  NULL,
    [Time] nvarchar(max)  NULL,
    [CustomerName] nvarchar(max)  NOT NULL,
    [EmployeeTableId] int  NOT NULL,
    [Size] nvarchar(max)  NULL,
    [Column] nvarchar(max)  NOT NULL,
    [Room] nvarchar(max)  NULL
);
GO

-- Creating table 'SheduleTimes'
CREATE TABLE [dbo].[SheduleTimes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Time] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SheduleColumns'
CREATE TABLE [dbo].[SheduleColumns] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ColumnName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'GoodHistories'
CREATE TABLE [dbo].[GoodHistories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Data] datetime  NOT NULL,
    [Price] nvarchar(max)  NOT NULL,
    [GoodName] nvarchar(max)  NOT NULL,
    [Customer] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EmployeeHistories'
CREATE TABLE [dbo].[EmployeeHistories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Data] datetime  NULL,
    [ServiceName] nvarchar(max)  NOT NULL,
    [Cost] nvarchar(max)  NOT NULL,
    [EmployeeTableId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'TypeOfServices'
ALTER TABLE [dbo].[TypeOfServices]
ADD CONSTRAINT [PK_TypeOfServices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Services'
ALTER TABLE [dbo].[Services]
ADD CONSTRAINT [PK_Services]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmployeeTables'
ALTER TABLE [dbo].[EmployeeTables]
ADD CONSTRAINT [PK_EmployeeTables]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Histories'
ALTER TABLE [dbo].[Histories]
ADD CONSTRAINT [PK_Histories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypeOfGoods'
ALTER TABLE [dbo].[TypeOfGoods]
ADD CONSTRAINT [PK_TypeOfGoods]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Goods'
ALTER TABLE [dbo].[Goods]
ADD CONSTRAINT [PK_Goods]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Shedules'
ALTER TABLE [dbo].[Shedules]
ADD CONSTRAINT [PK_Shedules]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SheduleTimes'
ALTER TABLE [dbo].[SheduleTimes]
ADD CONSTRAINT [PK_SheduleTimes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SheduleColumns'
ALTER TABLE [dbo].[SheduleColumns]
ADD CONSTRAINT [PK_SheduleColumns]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GoodHistories'
ALTER TABLE [dbo].[GoodHistories]
ADD CONSTRAINT [PK_GoodHistories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmployeeHistories'
ALTER TABLE [dbo].[EmployeeHistories]
ADD CONSTRAINT [PK_EmployeeHistories]
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
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TypeOfServiceService'
CREATE INDEX [IX_FK_TypeOfServiceService]
ON [dbo].[Services]
    ([TypeOfServiceId]);
GO

-- Creating foreign key on [CustomersId] in table 'Histories'
ALTER TABLE [dbo].[Histories]
ADD CONSTRAINT [FK_CustomersHistory]
    FOREIGN KEY ([CustomersId])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomersHistory'
CREATE INDEX [IX_FK_CustomersHistory]
ON [dbo].[Histories]
    ([CustomersId]);
GO

-- Creating foreign key on [TypeOfGoodsId] in table 'Goods'
ALTER TABLE [dbo].[Goods]
ADD CONSTRAINT [FK_TypeOfGoodsGoods]
    FOREIGN KEY ([TypeOfGoodsId])
    REFERENCES [dbo].[TypeOfGoods]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TypeOfGoodsGoods'
CREATE INDEX [IX_FK_TypeOfGoodsGoods]
ON [dbo].[Goods]
    ([TypeOfGoodsId]);
GO

-- Creating foreign key on [EmployeeTableId] in table 'Shedules'
ALTER TABLE [dbo].[Shedules]
ADD CONSTRAINT [FK_EmployeeTableShedule]
    FOREIGN KEY ([EmployeeTableId])
    REFERENCES [dbo].[EmployeeTables]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeTableShedule'
CREATE INDEX [IX_FK_EmployeeTableShedule]
ON [dbo].[Shedules]
    ([EmployeeTableId]);
GO

-- Creating foreign key on [EmployeeTableId] in table 'EmployeeHistories'
ALTER TABLE [dbo].[EmployeeHistories]
ADD CONSTRAINT [FK_EmployeeTableEmployeeHistory]
    FOREIGN KEY ([EmployeeTableId])
    REFERENCES [dbo].[EmployeeTables]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeTableEmployeeHistory'
CREATE INDEX [IX_FK_EmployeeTableEmployeeHistory]
ON [dbo].[EmployeeHistories]
    ([EmployeeTableId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------