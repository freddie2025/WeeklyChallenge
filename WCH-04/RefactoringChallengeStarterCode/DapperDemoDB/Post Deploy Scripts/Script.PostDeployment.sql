/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
IF NOT EXISTS (SELECT 1 FROM dbo.SystemUser)
BEGIN
	INSERT INTO dbo.SystemUser (FirstName, LastName)
	VALUES ('Tim', 'Corey'),
	('Mary', 'Smith'),
	('Jill', 'Bower'),
	('Matt', 'Stone');
end