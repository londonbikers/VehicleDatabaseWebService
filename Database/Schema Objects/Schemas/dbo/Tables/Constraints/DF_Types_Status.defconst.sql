ALTER TABLE [dbo].[Types]
    ADD CONSTRAINT [DF_Types_Status] DEFAULT ((0)) FOR [Status];

