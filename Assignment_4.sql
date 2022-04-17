USE Northwind

-- 1. Create a view named “view_product_order_[your_last_name]”, list all products and total ordered quantity for that product.
CREATE VIEW view_product_order_Wang
AS
SELECT p.ProductID, p.ProductName, SUM(od.Quantity) AS TotalOrderedQuantity
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductID, p.ProductName

-- 2. Create a stored procedure "sp_product_order_quantity_[your_last_name]" that accept product id as an input and total quantities of order as output parameter.
CREATE PROC sp_product_order_quantity_Wang
@productID INT,
@totalQuantity INT OUT
AS
BEGIN
SELECT @totalQuantity = TotalOrderedQuantity
FROM view_product_order_Wang
WHERE productID = @productID
END

	-- Test
	BEGIN
	DECLARE @tq INT
	EXEC sp_product_order_quantity_Wang 5, @tq OUT
	PRINT @tq
	END

-- 3. Create a stored procedure “sp_product_order_city_[your_last_name]” that accept product name as an input and top 5 cities that ordered most that product combined with the total quantity of that product ordered from that city as output.
CREATE PROC sp_product_order_city_Wang
@product_name VARCHAR(20)
AS
BEGIN
SELECT dt.CustomerCity, dt.TotalQuantity
FROM
	(
		SELECT p.ProductName, c.City AS CustomerCity, SUM(od.Quantity) AS TotalQuantity, ROW_NUMBER() OVER(PARTITION BY p.ProductName ORDER BY SUM(od.Quantity) DESC) AS RowNum
		FROM Customers c
		JOIN Orders o ON c.CustomerID = o.CustomerID
		JOIN [Order Details] od ON o.OrderID = od.OrderID
		JOIN Products p ON od.ProductID = p.ProductID
		WHERE p.ProductName = @product_name
		GROUP BY p.ProductName, c.City
	) dt
WHERE dt.ProductName = @product_name AND dt.RowNum BETWEEN 1 AND 5
END

	-- Test
	BEGIN
	EXEC sp_product_order_city_Wang 'Alice Mutton'
	END

-- 4. 
-- Create Two Tables
CREATE TABLE City_Wang(
id INT PRIMARY KEY,
City VARCHAR(20) NOT NULL
)

CREATE TABLE People_Wang(
id INT PRIMARY KEY,
Name VARCHAR(20) NOT NULL,
City INT FOREIGN KEY REFERENCES city_Wang(id) ON DELETE SET NULL
)

-- Insert Records
INSERT INTO City_Wang
VALUES 
	(1, 'Seattle'), 
	(2, 'Green Bay')

INSERT INTO People_Wang
VALUES
	(1, 'Aaron Rogers', 2),
	(2, 'Russell Wilson', 1),
	(3, 'Jody Nelson', 2)

-- Remove Seattle from City
DELETE City_Wang
WHERE City = 'Seattle'

-- Put people in Seattle into Madison
INSERT INTO City_Wang
VALUES (3, 'Madison')

UPDATE People_Wang
SET City = 3
WHERE City IS NULL

-- Create view
CREATE VIEW Packers_Wang
AS
SELECT p.Name
FROM People_Wang p
JOIN City_Wang c ON p.City = c.id
WHERE c.City = 'Green Bay'

-- test
SELECT * FROM City_Wang
SELECT * FROM People_Wang
SELECT * FROM Packers_Wang

-- Drop Tables and View
DROP TABLE People_Wang
DROP TABLE City_Wang
DROP VIEW Packers_Wang

-- 5. Create a stored procedure “sp_birthday_employees_[you_last_name]” that creates a new table “birthday_employees_your_last_name” and fill it with all employees that have a birthday on Feb. (Make a screen shot) drop the table. Employee table should not be affected.
CREATE PROC sp_birthday_employees_Wang
AS
BEGIN
SELECT * INTO birthday_employees_Wang
FROM Employees
WHERE MONTH(BirthDate) = 2
END
	-- test
	EXEC sp_birthday_employees_Wang
	SELECT *
	FROM birthday_employees_Wang

-- 6. How do you make sure two tables have the same data?
-- UNION two tables, then check the COUNT of rows. If the merged table does not have the same number of rows with either table, then the two tables doesn't have the same data.

