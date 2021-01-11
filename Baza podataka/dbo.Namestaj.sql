CREATE TABLE [dbo].[Namestaj] (
    [Id]       INT           NOT NULL,
    [Naziv]    NVARCHAR (50) NOT NULL,
    [Velicina] DECIMAL(18, 2)    NOT NULL,
    [Cena]     DECIMAL(18, 2)    NOT NULL,
    [Stanje]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

