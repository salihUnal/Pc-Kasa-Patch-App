CREATE TABLE [dbo].[Magazalar] (
    [Mağaza_Kodu] NUMERIC (18) NOT NULL,
    [Mağaza_İsmi] NCHAR (10)   NULL,
    [Telefon_No]  NUMERIC (18) NULL,
    [Adres]       NCHAR (10)   NULL,
    [İlçe]        NCHAR (10)   NULL,
    [İl]          NCHAR (10)   NULL,
    PRIMARY KEY CLUSTERED ([Mağaza_Kodu] ASC)
);

