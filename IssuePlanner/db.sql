IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [tblIssue] (
    [Id] int NOT NULL IDENTITY,
    [IssueId] nvarchar(max) NULL,
    [IssueTitle] nvarchar(max) NULL,
    [Assignee] nvarchar(max) NULL,
    CONSTRAINT [PK_tblIssue] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [tblLeft] (
    [Id] int NOT NULL IDENTITY,
    [IssueId] nvarchar(max) NULL,
    CONSTRAINT [PK_tblLeft] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [tblRight] (
    [Id] int NOT NULL IDENTITY,
    [IssueId] nvarchar(max) NULL,
    CONSTRAINT [PK_tblRight] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200507091328_init', N'3.1.3');

GO