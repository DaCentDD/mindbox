-- Я если правильно понял, то связь многие ко многим, привел весь свой SQL запрос

CREATE TABLE #Products(Id BIGINT, Name varchar(100))
INSERT INTO #Products VALUES (1, N'Хлеб'),(2, N'Кока-кола'), (3, 'Торт')

CREATE TABLE #Categories(Id BIGINT, Name varchar(100))
INSERT INTO #Categories VALUES (6, N'Сладкое')

CREATE TABLE #ProductToCategory(ProductId BIGINT, CategoryId BIGINT)
INSERT INTO #ProductToCategory VALUES (2, 6), (3, 6)

SELECT p.Name, c.Name
FROM #Products p
LEFT JOIN #ProductToCategory pc ON pc.ProductId = p.Id
LEFT JOIN #Categories c ON c.Id = pc.CategoryId

DROP TABLE #Products
DROP TABLE #Categories
DROP TABLE #ProductToCategory