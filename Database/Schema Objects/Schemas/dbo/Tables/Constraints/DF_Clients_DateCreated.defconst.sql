ALTER TABLE [dbo].[Clients]
    ADD CONSTRAINT [DF_Clients_DateCreated] DEFAULT (getutcdate()) FOR [DateCreated];

