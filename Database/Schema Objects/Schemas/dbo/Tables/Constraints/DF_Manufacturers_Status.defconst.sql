ALTER TABLE [dbo].[Manufacturers]
    ADD CONSTRAINT [DF_Manufacturers_Status] DEFAULT ((0)) FOR [Status];

