ALTER PROC UserAdd
@username varchar(50),
@password varchar(50)
AS
 INSERT INTO [Table](username,password)
 VALUES (@username,@password)