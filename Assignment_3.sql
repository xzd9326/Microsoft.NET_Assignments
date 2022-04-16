USE Northwind

-- 1. List all cities that have both Employees and Customers.
SELECT DISTINCT e.City
FROM Customers c
JOIN Employees e ON c.city = e.city

--2.   List all cities that have Customers but no Employee. a. Use sub-query b. Do not use sub-query
SELECT DISTINCT City
FROM Customers
WHERE City NOT IN
	(SELECT DISTINCT City
	FROM Employees)

SELECT DISTINCT c.City
FROM Customers c
LEFT JOIN Employees e ON c.City = e.City
WHERE e.EmployeeID IS NULL

-- 3. List all products and their total order quantities throughout all orders.
SELECT p.ProductName, SUM(od.Quantity) AS TotalOrderQuantity
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName

-- 4. List all Customer Cities and total products ordered by that city.
SELECT c.City, SUM(od.Quantity) AS TotalProductsOrdered
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City

-- 5. List all Customer Cities that have at least two customers. a. Use union   b. Use sub-query and no union
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) = 2
UNION
SELECT City 
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) > 2

SELECT DISTINCT City 
FROM Customers
WHERE City NOT IN
	(
		SELECT City 
		FROM Customers 
		GROUP BY City 
		HAVING Count(CustomerID) <= 1 
	)

-- 6. List all Customer Cities that have ordered at least two different kinds of products.
SELECT c.City AS CustomerCity
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID
GROUP BY c.City
HAVING COUNT(DISTINCT p.CategoryID) >= 2


-- 7. List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.
SELECT DISTINCT c.CompanyName AS CustomerName, c.City AS CustomerCity, o.ShipCity
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
WHERE c.City != o.ShipCity

--8. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
SELECT dt.ProductName, dt.AvgPrice, dt.CustomerCity
FROM
	(
		SELECT p.ProductName, p.AvgPrice, c.City AS CustomerCity, SUM(Quantity) AS TotalQuantity, RANK() OVER(PARTITION BY p.ProductName ORDER BY SUM(Quantity) DESC) AS RNK
		FROM Customers c
		JOIN Orders o ON c.CustomerID = o.CustomerID
		JOIN [Order Details] od ON o.OrderID = od.OrderID
		JOIN (
				SELECT TOP 5 p.ProductID, p.ProductName, AVG(od.UnitPrice) AS AvgPrice
				FROM [Order Details] od
				JOIN Products p ON od.ProductID = p.ProductID
				GROUP BY p.ProductID, p.ProductName
				ORDER BY SUM(od.Quantity) DESC
			 ) p ON od.ProductID = p.ProductID 
		GROUP BY p.ProductName, p.AvgPrice, c.City
	) dt
WHERE dt.RNK = 1

-- 9. List all cities that have never ordered something but we have employees there.  a. Use sub-query  b. Do not use sub-query
SELECT DISTINCT City
FROM Employees
WHERE City NOT IN
	(
		SELECT DISTINCT ShipCity
		FROM Orders
	)

SELECT e.City
FROM Employees e
LEFT JOIN Orders o ON e.City = o.ShipCity
WHERE o.ShipCity IS NULL

-- 10. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
SELECT dt1.EmployeeCity, dt1.NumOfOrders, dt1.RNK AS OrderRNK, dt2.RNK AS QuantityRNK
FROM
	(
		SELECT e.City AS EmployeeCity, COUNT(o.OrderID) AS NumOfOrders, RANK() OVER(ORDER BY COUNT(o.OrderID) DESC) AS RNK
		FROM Orders o
		JOIN Employees e ON o.EmployeeID = e.EmployeeID
		GROUP BY e.City
	) dt1
JOIN 
	(
		SELECT e.City AS EmployeeCity, SUM(od.Quantity) AS TotalQuantity, RANK() OVER(ORDER BY SUM(od.Quantity) DESC) AS RNK
		FROM Orders o
		JOIN Employees e ON o.EmployeeID = e.EmployeeID
		JOIN [Order Details] od ON o.OrderID = od.OrderID
		JOIN Products p ON od.ProductID = p.ProductID
		GROUP BY e.City
	) dt2 ON dt1.EmployeeCity = dt2.EmployeeCity
WHERE dt1.RNK = 1 AND dt2.RNK = 1

-- 11. How do you remove the duplicates record of a table?
-- Answer: I can first label each record with ROW_NUMBER() Function PARTITION BY each row, then DELETE all records with RowNumber > 1









