CREATE TABLE Gyartouzem.dbo.Tetelsorok (
  ID_Tetelsorok bigint IDENTITY,
  TermekID bigint NOT NULL,
  Mennyiseg bigint NOT NULL,
  [Mennyisegi egyseg] bigint NOT NULL,
  PRIMARY KEY NONCLUSTERED (ID_Tetelsorok, TermekID)
)
ON [PRIMARY]
GO

ALTER TABLE Gyartouzem.dbo.Tetelsorok
  ADD CONSTRAINT FK_Tetelsorok_Termekek_ID_Termekek FOREIGN KEY (TermekID) REFERENCES dbo.Termekek (ID_Termekek)
GO