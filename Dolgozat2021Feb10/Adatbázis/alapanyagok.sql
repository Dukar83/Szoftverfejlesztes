CREATE TABLE Gyartouzem.dbo.Alapanyagok (
  ID_Alapanyagok bigint IDENTITY,
  Megnevezes nchar(100) NOT NULL,
  TermekID bigint NOT NULL,
  PRIMARY KEY NONCLUSTERED (ID_Alapanyagok, TermekID),
  UNIQUE (Megnevezes)
)
ON [PRIMARY]
GO

ALTER TABLE Gyartouzem.dbo.Alapanyagok
  ADD CONSTRAINT FK_Alapanyagok_Termekek_ID_Termekek FOREIGN KEY (TermekID) REFERENCES dbo.Termekek (ID_Termekek)
GO