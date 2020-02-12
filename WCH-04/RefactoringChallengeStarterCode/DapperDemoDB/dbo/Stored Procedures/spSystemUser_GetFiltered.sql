CREATE PROCEDURE [dbo].[spSystemUser_GetFiltered]
	@Filter VARCHAR(50)
AS
begin
	select [Id], [FirstName], [LastName] 
	from dbo.SystemUser
	WHERE FirstName LIKE @Filter 
		OR LastName LIKE @Filter;
end
