USE AdventureWorks2019

-- 1. How many products can you find in the Production.Product table?
SELECT COUNT(*) AS NumOfProduct
FROM Production.Product

-- 2. Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.
SELECT COUNT(ProductSubcategoryID)
FROM Production.Product

-- 3. How many Products reside in each SubCategory? Write a query to display the results with the following titles.
SELECT ProductSubcategoryID, COUNT(ProductSubcategoryID) AS CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL
GROUP BY ProductSubcategoryID

-- 4. How many products that do not have a product subcategory.
SELECT COUNT(ProductID) AS NoSubcategory 
FROM Production.Product
WHERE ProductSubcategoryID IS NULL

-- 5. Write a query to list the sum of products quantity in the Production.ProductInventory table.
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
GROUP BY ProductID

-- 6. Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100.
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100

-- 7. Write a query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100
SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY Shelf, ProductID
HAVING SUM(Quantity) < 100

-- 8. Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.
SELECT AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE LocationID = 10

-- 9. Write query to see the average quantity of products by shelf from the table Production.ProductInventory
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY ProductID, Shelf

-- 10. Write query to see the average quantity of products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf != 'N/A'
GROUP BY ProductID, Shelf

-- 11. List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null.
SELECT Color, Class, COUNT(Color) AS TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class

-- 12. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following.
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion c
JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode

-- 13. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion c
JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.Name IN ('Germany', 'Canada')


-- Using Northwnd Database: (Use aliases for all the Joins)
USE Northwind

-- 14. List all Products that has been sold at least once in last 25 years.
SELECT DISTINCT p.ProductID, p.ProductName
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID
JOIN Orders o ON od.OrderID = o.OrderID
WHERE o.OrderDate >= '1997-04-13'

-- 15. List top 5 locations (Zip Code) where the products sold most.
SELECT TOP 5 c.PostalCode, SUM(od.Quantity) AS ProductsSold
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID
JOIN Orders o ON od.OrderID = o.OrderID
JOIN Customers c ON o.CustomerID = c.CustomerID					-- In Question 15 and 16, I used PostalCode of customers to calculate sales
WHERE c.PostalCode IS NOT NULL
GROUP BY c.PostalCode
ORDER BY ProductsSold DESC

-- 16. List top 5 locations (Zip Code) where the products sold most in last 25 years.
SELECT TOP 5 c.PostalCode, SUM(od.Quantity) AS ProductsSold
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID
JOIN Orders o ON od.OrderID = o.OrderID
JOIN Customers c ON o.CustomerID = c.CustomerID
WHERE c.PostalCode IS NOT NULL AND o.OrderDate >= '1997-04-13'
GROUP BY c.PostalCode
ORDER BY ProductsSold DESC

-- 17.List all city names and number of customers in that city.
SELECT City, COUNT(CustomerID) AS NumberOfCustomers
FROM Customers
GROUP BY City

-- 18. List city names which have more than 2 customers, and number of customers in that city
SELECT City, COUNT(CustomerID) AS NumberOfCustomers
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) > 2

-- 19. List the names of customers who placed orders after 1/1/98 with order date.
SELECT c.CompanyName, o.OrderDate
FROM Orders o
JOIN Customers c ON o.CustomerID = c.CustomerID
WHERE o.OrderDate > '1998-01-01'

-- 20. List the names of all customers with most recent order dates
SELECT c.CompanyName, MAX(o.OrderDate) AS MostRecentOrder
FROM Orders o
JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY c.CompanyName

-- 21. Display the names of all customers  along with the  count of products they bought
SELECT c.CompanyName, SUM(od.Quantity) AS CountOfProducts
FROM Customers c
JOIN Orders o ON o.CustomerID = c.CustomerID
JOIN [Order Details] od ON od.OrderID = o.OrderID
GROUP BY c.CompanyName

-- 22. Display the customer ids who bought more than 100 Products with count of products.
SELECT c.CustomerID, SUM(od.Quantity) AS CountOfProducts
FROM Customers c
JOIN Orders o ON o.CustomerID = c.CustomerID
JOIN [Order Details] od ON od.OrderID = o.OrderID
GROUP BY c.CustomerID
HAVING SUM(od.Quantity) > 100

-- 23. List all of the possible ways that suppliers can ship their products. Display the results as below
SELECT s.CompanyName AS  [Supplier Company Name], sh.CompanyName AS [Shipper Company Name]
FROM Suppliers s
CROSS JOIN Shippers sh

-- 24. Display the products order each day. Show Order date and Product Name.
SELECT o.OrderDate, p.ProductName
FROM Orders o
JOIN [Order Details] od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID
ORDER BY o.OrderDate

-- 25. Displays pairs of employees who have the same job title.
SELECT e1.FirstName + ' ' + e1.LastName AS Employee1, e2.FirstName + ' ' + e2.LastName AS Employee2
FROM Employees e1
JOIN Employees e2 ON e1.Title = e2.Title
WHERE e1.EmployeeID != e2.EmployeeID

-- 26. Display all the Managers who have more than 2 employees reporting to them.
SELECT dt.Manager
FROM
	(SELECT e.FirstName + ' ' + e.LastName AS Employee, ISNull(m.FirstName + ' ' + m.LastName, 'N/A') AS Manager
	FROM Employees e
	LEFT JOIN Employees m ON e.ReportsTo = m.EmployeeID) dt
GROUP BY dt.Manager
HAVING COUNT(dt.Employee) > 2

/* Alternative Solution
SELECT ISNull(m.FirstName + ' ' + m.LastName, 'N/A') AS Manager
FROM Employees e
LEFT JOIN Employees m ON e.ReportsTo = m.EmployeeID
GROUP BY m.EmployeeID, m.FirstName, m.LastName
HAVING COUNT(e.EmployeeID) > 2
*/

-- 27. Display the customers and suppliers by city. The results should have the following columns
-- City, Name, Contact Name, Type (Customer or Supplier)
SELECT City, CompanyName AS Name, ContactName AS [Contact Name], 'Customer' AS Type
FROM Customers
UNION 
SELECT City, CompanyName AS Name, ContactName AS [Contact Name], 'Supplier'
FROM Suppliers














