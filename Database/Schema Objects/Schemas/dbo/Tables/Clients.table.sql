CREATE TABLE [dbo].[Clients] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (255) NOT NULL,
    [CallbackUrl] VARCHAR (512) NULL,
    [Password]    VARCHAR (255) NOT NULL,
    [DateCreated] DATETIME      NOT NULL
);

