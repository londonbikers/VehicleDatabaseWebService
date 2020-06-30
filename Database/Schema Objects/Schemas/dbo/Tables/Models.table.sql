CREATE TABLE [dbo].[Models] (
    [ID]             INT           IDENTITY (1, 1) NOT NULL,
    [ManufacturerID] INT           NOT NULL,
    [Name]           VARCHAR (255) NOT NULL,
    [VariantName]    VARCHAR (100) NULL,
    [WikipediaID]    VARCHAR (255) NULL,
    [YearIntroduced] INT           NULL,
    [YearStopped]    INT           NULL,
    [TypeID]         INT           NOT NULL,
    [EngineSizeCC]   INT           NULL,
    [Status]         INT           NOT NULL
);



