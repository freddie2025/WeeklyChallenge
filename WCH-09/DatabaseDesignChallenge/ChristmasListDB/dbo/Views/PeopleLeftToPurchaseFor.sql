CREATE VIEW [dbo].[PeopleLeftToPurchaseFor]
	AS 
	SELECT		Person.FirstName, 
				Person.LastName,
				Person.BudgetAmount,
				PurchaseSubQuery.TotalSpend,
				(Person.BudgetAmount - COALESCE(PurchaseSubQuery.TotalSpend, 0)) AS [AmountLeftToSpend]
	FROM		[dbo].[Person]
	LEFT JOIN	(
					SELECT Purchase.PurchaseForId, SUM(Purchase.Price) AS [TotalSpend]
					FROM [dbo].[Purchase] 
					GROUP BY Purchase.PurchaseForId 
				) 
	AS			PurchaseSubQuery
	ON			PurchaseSubQuery.PurchaseForId = Person.Id
	WHERE		Person.BudgetAmount - COALESCE(PurchaseSubQuery.TotalSpend, 0) > 0;
