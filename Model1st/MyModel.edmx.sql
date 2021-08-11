
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/10/2021 20:25:09
-- Generated from EDMX file: C:\Users\YL\Desktop\Tutorials\C#\EF6\CodeSemantic\2\Model1st\Model1st\MyModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyDb];
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

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [CourseID] int IDENTITY(1,1) NOT NULL,
    [CourseName] nvarchar(max)  NOT NULL,
    [Duration] int  NOT NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [Rollno] int IDENTITY(1,1) NOT NULL,
    [StudentName] nvarchar(max)  NOT NULL,
    [Contact] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [CourseID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CourseID] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([CourseID] ASC);
GO

-- Creating primary key on [Rollno] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([Rollno] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CourseID] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_CourseStudent]
    FOREIGN KEY ([CourseID])
    REFERENCES [dbo].[Courses]
        ([CourseID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseStudent'
CREATE INDEX [IX_FK_CourseStudent]
ON [dbo].[Students]
    ([CourseID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------