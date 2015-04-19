CREATE PROCEDURE dbo.AddNewEmployee
	(
@Name nvarchar(30),
@EmpID nvarchar(10),
@EmpPass nvarchar(10),
@Rank INT,       
@DateHired nvarchar(10)
)
AS
	INSERT INTO [Employees] (EmpID,EmpPass,Name,[Rank],DateHired)
	VALUES (@EmpID,@EmpPass,@Name,@Rank,@DateHired)