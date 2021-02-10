CREATE TABLE Gyartouzem.dbo.Fejlec (
  ID_Fejlec bigint IDENTITY,
  [Megrendeles szama] bigint NOT NULL,
  [Rendeles datuma] date NOT NULL,
  [Szallitas napja] date NOT NULL,
  VevoID bigint NOT NULL,
  PRIMARY KEY NONCLUSTERED (ID_Fejlec, VevoID, [Megrendeles szama]),
  UNIQUE ([Megrendeles szama])
)
ON [PRIMARY]
GO

ALTER TABLE Gyartouzem.dbo.Fejlec
  ADD CONSTRAINT FK_Fejlec_Vevok_ID_Vevok FOREIGN KEY (VevoID) REFERENCES dbo.Vevok (ID_Vevok)
GO