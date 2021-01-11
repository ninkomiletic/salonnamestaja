CREATE TABLE [dbo].[Korisnik] (
    [Id]       INT           NOT NULL,
    [Ime]      NVARCHAR (20) NOT NULL,
    [Prezime]  NVARCHAR (30) NOT NULL,
    [JMBG]     NVARCHAR(13)           NOT NULL,
    [Adresa]   NVARCHAR (50) NOT NULL,
    [Telefon]  INT           NOT NULL,
    [Username] NVARCHAR (50) NOT NULL,
    [Password] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

