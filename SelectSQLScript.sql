SELECT p.Name, c.Name FROM [MindBoxTest].[dbo].[ProductsCategories] AS pc
LEFT JOIN [MindBoxTest].[dbo].[Products] AS p
ON pc.ProductId = p.Id
FULL OUTER JOIN [MindBoxTest].[dbo].[Categories] AS c
ON pc.CategoryId = c.Id

SELECT p.Name, c.Name FROM [MindBoxTest].[dbo].[Products] AS p
LEFT JOIN [MindBoxTest].[dbo].[ProductsCategories] AS pc
ON pc.ProductId = p.Id
LEFT JOIN [MindBoxTest].[dbo].[Categories] AS c
ON c.Id = pc.CategoryId