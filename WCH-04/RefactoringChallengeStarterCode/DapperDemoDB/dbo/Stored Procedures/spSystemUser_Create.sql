CREATE PROCEDURE [dbo].[spSystemUser_Create]
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50)
AS
begin
	insert into dbo.SystemUser (FirstName, LastName)
	values (@FirstName, @LastName);
end
