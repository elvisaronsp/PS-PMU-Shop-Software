CREATE PROCEDURE [dbo].[DeleteEmployee]
(
@EmpID nvarchar(10)
)
AS
	DELETE FROM [Employees] WHERE EmpID = @EmpID
