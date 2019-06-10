﻿CREATE TABLE [dbo].[proprietati] (
    [Id]                  INT           IDENTITY (1, 1) NOT NULL,
    [numeproiect]         VARCHAR (50)  NULL,
    [numeproprietate]     VARCHAR (50)  NULL,
    [pretlista]           VARCHAR (50)  NULL,
    [moneda]              VARCHAR (50)  NULL,
    [data_ora]            DATETIME      NULL,
    [suprafatatotala]     VARCHAR (50)  NULL,
    [clasaenergetica]     VARCHAR (50)  NULL,
    [tipproprietate]      VARCHAR (50)  NULL,
    [numarbai]            INT           NULL,
    [suprafataconstruita] INT           NULL,
    [suprafatautila]      INT           NULL,
    [suprafatabalcon]     INT           NULL,
    [numarapartament]     INT           NULL,
    [etaj]                varchar(50)           NULL,
    [finisaje]            VARCHAR (50)  NULL,
    [compartimente]       VARCHAR (50)  NULL,
    [parcare]             VARCHAR (50)  NULL,
    [utilitati]           VARCHAR (50)  NULL,
    [descriere]           VARCHAR (200) NULL,
    [img1]                IMAGE         NULL,
    [img2]                IMAGE         NULL,
    [img3]                IMAGE         NULL,
    [numeagent]           VARCHAR (50)  NULL,
    [id_proiecte]         INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_proprietati_proiecte] FOREIGN KEY ([id_proiecte]) REFERENCES [dbo].[proiecte] ([id_proiecte])
);
