CREATE PROCEDURE [dbo].[spSystemUser_Get]
AS
begin
	select [Id], [FirstName], [LastName]	 
	from dbo.SystemUser;
end
