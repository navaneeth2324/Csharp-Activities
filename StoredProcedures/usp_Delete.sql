CREATE PROC usp_Delete(@name AS VARCHAR(50))
AS
BEGIN	
	IF @name IS NOT NULL
	BEGIN TRY
		DELETE FROM HumanResources.Department 
		WHERE Name=@name
	END TRY
	BEGIN CATCH
		RETURN -99
	END CATCH
	ELSE 
		RETURN 1

END

EXEC usp_Delete 'Coaching'