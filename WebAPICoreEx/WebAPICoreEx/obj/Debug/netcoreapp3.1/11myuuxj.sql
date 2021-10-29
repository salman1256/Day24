IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Customer] (
    [CId] nvarchar(450) NOT NULL,
    [CName] nvarchar(50) NOT NULL,
    [CCity] nvarchar(50) NOT NULL,
    [CODLimit] float NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY ([CId])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211029050636_CustMig', N'3.1.20');

GO

