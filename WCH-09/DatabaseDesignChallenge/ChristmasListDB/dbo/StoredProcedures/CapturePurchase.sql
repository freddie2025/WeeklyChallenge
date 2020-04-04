CREATE PROCEDURE [dbo].[CapturePurchase]
	@ItemName varchar(50),
	@Price money,
	@PurchaseForId int
AS
BEGIN 
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Purchase] (ItemName, Price, PurchaseForId)
	VALUES (@ItemName, @Price, @PurchaseForId);

END