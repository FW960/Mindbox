USE shop

DECLARE
@resultTable TABLE(name NCHAR(32), categories NCHAR(128));

DECLARE
@categoriesTable TABLE(id INT IDENTITY,value NCHAR(32));

DECLARE
@count INT = 0;

DECLARE
@tableLength INT = 0 ;

DECLARE
@tableCategories NCHAR(128) = '';

DECLARE
@innerCount INT = 0

SELECT @tableLength = COUNT(*)
FROM products;

WHILE
(@count < @tableLength)
BEGIN

SET
@count = @count + 1;

SELECT @tableCategories = products.categories
FROM products
WHERE id = @count;

INSERT INTO @categoriesTable (value)
SELECT categories.name
from categories
where categories.id in (SELECT value FROM STRING_SPLIT(@tableCategories, ','))

DECLARE
@selectedCategoriesTableCount INT = 0;

SELECT @selectedCategoriesTableCount = COUNT(*)
FROM @categoriesTable

DECLARE
@categoryName NCHAR(16) = ''

DECLARE
@resultCategoriesName NCHAR(256) = ''

WHILE(@innerCount < @selectedCategoriesTableCount)
BEGIN

SELECT @categoryName = value
FROM @categoriesTable
WHERE id = @innerCount + 1;

SET
@resultCategoriesName = @categoryName + ',' + @resultCategoriesName;

SET
@innerCount = @innerCount + 1;

END

SELECT @resultCategoriesName = REPLACE(@resultCategoriesName, '  ', '')

DECLARE
@productName NCHAR(128) = ''

SELECT @productName = name
FROM products
WHERE id = @count;

INSERT INTO @resultTable(name, categories)
VALUES (@productName, @resultCategoriesName)

END

SELECT *
FROM @resultTable