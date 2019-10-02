CREATE PROC UserAdd
@loginid int,
@username varchar(50),
@password varchar(50)
AS
 INSERT INTO [Table](username,password)
 VALUES (@username,@password)