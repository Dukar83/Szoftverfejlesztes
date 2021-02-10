CREATE TABLE Gyartouzem.dbo.Vevok (
  ID_Vevok bigint IDENTITY,
  Nev nchar(50) NOT NULL,
  Helyseg nchar(25) NOT NULL,
  Cim nchar(100) NOT NULL,
  IRSZ int NOT NULL,
  PRIMARY KEY CLUSTERED (ID_Vevok),
  UNIQUE (Nev)
)
ON [PRIMARY]
GO