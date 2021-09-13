CREATE PROC usp_Update(@id AS INT,@name AS VARCHAR(50),@grpName AS VARCHAR(50),@date AS datetime)
AS
BEGIN

	IF @id IS NOT NULL AND @name IS NOT NULL AND @grpName IS NOT NULL AND @date IS NOT NULL
		BEGIN TRY
			UPDATE HumanResources.Department 
			SET Name=@name,GroupName=@grpName,ModifiedDate=@date
			WHERE DepartmentID=@id
		END TRY
		BEGIN CATCH
			RETURN -99
		END CATCH
	ELSE
		RETURN 1
END

EXEC usp_Update 2,'Advertising','Sales','2021-09-13'