CREATE TABLE [dbo].[Korpa] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Korisnik_Id] INT             NOT NULL,
    [racun]       DECIMAL (18, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

