CREATE TABLE [dbo].[Table]
(
	[Id] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY, 
    [КодПоставщика] VARCHAR(50) NULL, 
    [КодПоставки] VARCHAR(50) NULL, 
    [ДатаПоставки] VARCHAR(50) NULL, 
    [ВесГруза] VARCHAR(50) NULL, 
    [ФирмаПодрядчик] VARCHAR(50) NULL, 
    [Подтверждение] VARCHAR(50) NULL
)
