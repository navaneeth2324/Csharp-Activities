CREATE PROC usp_Insert(@id AS SMALLINT ,@name AS VARCHAR(50),@grpName AS VARCHAR(50),@date AS datetime)
AS
BEGIN
	SET IDENTITY_INSERT HumanResources.Department ON
	IF @id IS NOT NULL AND @name IS NOT NULL AND @grpName IS NOT NULL AND @date IS NOT NULL
	BEGIN TRY
		INSERT INTO HumanResources.Department (DepartmentID,Name,GroupName,ModifiedDate) VALUES (@id,@name,@grpName,@date)
	END TRY
	BEGIN CATCH
		RETURN -99
	END CATCH
	ELSE
		RETURN 1
END

EXEC usp_Insert 17,'Management','GEA','2021-09-13'
