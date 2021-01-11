CREATE TABLE [dbo].[Stavke_korpe]
(
	[id_korpe] INT NOT NULL , 
    [id_namestaja] int NOT NULL, 
    [kolicina] INT NOT NULL, 
    PRIMARY KEY ([id_korpe], [id_namestaja]),
	CONSTRAINT [FK_Namestaj] FOREIGN KEY ([id_namestaja]) REFERENCES [Namestaj]([Id]),
	CONSTRAINT [FK_Korpa] FOREIGN KEY ([id_korpe]) REFERENCES [Korpa]([Id])
)
