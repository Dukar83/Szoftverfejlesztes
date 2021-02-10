CREATE TABLE Gyartouzem.dbo.Termekek (
  ID_Termekek bigint IDENTITY,
  Megnevezes nchar(100) NOT NULL,
  [Mennyisegi egyseg] bigint NOT NULL,
  Keszlet int NULL,
  PRIMARY KEY CLUSTERED (ID_Termekek),
  UNIQUE (Megnevezes),
  UNIQUE ([Mennyisegi egyseg])
)
ON [PRIMARY]
GO