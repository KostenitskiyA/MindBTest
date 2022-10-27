SELECT p.Name, c.Name FROM [MindBoxTest].[dbo].[ProductsCategories] AS pc
FULL OUTER JOIN [MindBoxTest].[dbo].[Products] AS p
ON pc.ProductId = p.Id
FULL OUTER JOIN [MindBoxTest].[dbo].[Categories] AS c
ON pc.CategoryId = c.Id