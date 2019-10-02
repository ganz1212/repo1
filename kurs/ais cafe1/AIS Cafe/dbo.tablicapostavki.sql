CREATE TABLE [dbo].[Table] (
    [Id]             INT           NOT NULL,
    [КодПоставщика]  NVARCHAR (50) NULL,
    [КодПоставки]    NVARCHAR (50) NULL,
    [ДатаПоставки]   NVARCHAR (50) NULL,
    [ВесГруза]       NVARCHAR (50) NULL,
    [ФирмаПодрядчик] NVARCHAR (50) NULL,
    [Подтверждение]  NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

