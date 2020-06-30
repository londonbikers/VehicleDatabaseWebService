ALTER TABLE [dbo].[Models]
    ADD CONSTRAINT [FK_Models_Manufacturers] FOREIGN KEY ([ManufacturerID]) REFERENCES [dbo].[Manufacturers] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION;

