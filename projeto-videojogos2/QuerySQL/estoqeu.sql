CREATE TABLE [dbo].[Estoque] (
    [ID]                   INT             IDENTITY (1, 1) NOT NULL,
    [NomeJogo]             NVARCHAR (255)  NULL,
    [Categoria]            NVARCHAR (100)  NULL,
    [Preco]                DECIMAL (10, 2) NULL,
    [QuantidadeDisponivel] INT             NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);