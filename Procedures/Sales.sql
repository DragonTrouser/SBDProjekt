USE AdventureWorks2022;
GO

-- ----- --
-- Osoby --
-- ----- --

-- Szukanie wszytkich nazwisk
CREATE OR ALTER PROCEDURE dbo.uspGetPeopleLastNames
AS
BEGIN
	SELECT LastName AS PersonLastName
	FROM Person.Person
	GROUP BY LastName
	ORDER BY LastName;
END
GO

-- Znajdowanie wszystkich unikalnych imion po nazwisku
CREATE OR ALTER PROCEDURE dbo.uspGetPeopleFirstNamesByLastName
(
	@LastName NVARCHAR(50) = NULL
)
AS
BEGIN
	IF @LastName IS NULL
	BEGIN
		SELECT FirstName AS PersonFirstName
		FROM Person.Person
		GROUP BY FirstName;
	END
	ELSE
	BEGIN
		SELECT FirstName AS PersonFirstName
		FROM Person.Person
		WHERE LastName = @LastName
		GROUP BY FirstName;
	END
END
GO

-- ---------- --
-- Zamówienia --
-- ---------- --

-- Znajdowanie wszystkich zamówieñ
CREATE OR ALTER PROCEDURE dbo.uspGetOrders
(
	@OrderDateFrom DATETIME = NULL,
	@OrderDateTo DATETIME = NULL,
	@ProductCategoryName NVARCHAR(50) = 'All',
	@ProductSubcategoryName NVARCHAR(50) = 'All',
	@ProductName NVARCHAR(50) = 'All',
	@PersonLastName NVARCHAR(50) = NULL,
	@PersonFirstName NVARCHAR(50) = NULL
)
AS
BEGIN
	IF @OrderDateFrom IS NULL
		SET @OrderDateFrom = SYSDATETIME()
	IF @OrderDateTo IS NULL
		SET @OrderDateTo = SYSDATETIME()
	IF @PersonLastName IS NULL
		SET @PersonLastName = '%'
	IF @PersonFirstName IS NULL
		SET @PersonFirstName = '%'

	IF @ProductName = 'All'
	BEGIN
		IF @ProductSubcategoryName = 'All'
		BEGIN
			IF @ProductCategoryName = 'All'
			BEGIN
				SELECT DISTINCT
					head.SalesOrderNumber AS OrderNumber,
					head.PurchaseOrderNumber AS PurchaseOrderNumber,
					head.OrderDate AS OrderDate
				FROM
					Sales.SalesOrderDetail det
					INNER JOIN Sales.SalesOrderHeader head
						ON det.SalesOrderID = head.SalesOrderID
					INNER JOIN Sales.Customer cust
						ON head.CustomerID = cust.CustomerID
					INNER JOIN Person.Person per
						ON cust.PersonID = per.BusinessEntityID
					INNER JOIN Production.Product prod
						ON det.ProductID = prod.ProductID
					INNER JOIN Production.ProductSubcategory subcat
						ON prod.ProductSubcategoryID = subcat.ProductSubcategoryID
					INNER JOIN Production.ProductCategory cat
						ON subcat.ProductCategoryID = cat.ProductCategoryID
				WHERE
					head.OrderDate BETWEEN @OrderDateFrom AND @OrderDateTo
					AND per.LastName LIKE @PersonLastName
					AND per.FirstName LIKE @PersonFirstName
				ORDER BY
					head.OrderDate;
			END
			ELSE
			BEGIN
				SELECT DISTINCT
					head.SalesOrderNumber AS OrderNumber,
					head.PurchaseOrderNumber AS PurchaseOrderNumber,
					head.OrderDate AS OrderDate
				FROM
					Sales.SalesOrderDetail det
					INNER JOIN Sales.SalesOrderHeader head
						ON det.SalesOrderID = head.SalesOrderID
					INNER JOIN Sales.Customer cust
						ON head.CustomerID = cust.CustomerID
					INNER JOIN Person.Person per
						ON cust.PersonID = per.BusinessEntityID
					INNER JOIN Production.Product prod
						ON det.ProductID = prod.ProductID
					INNER JOIN Production.ProductSubcategory subcat
						ON prod.ProductSubcategoryID = subcat.ProductSubcategoryID
					INNER JOIN Production.ProductCategory cat
						ON subcat.ProductCategoryID = cat.ProductCategoryID
				WHERE
					head.OrderDate BETWEEN @OrderDateFrom AND @OrderDateTo
					AND per.LastName LIKE @PersonLastName
					AND per.FirstName LIKE @PersonFirstName
					AND cat.Name = @ProductCategoryName
				ORDER BY
					head.OrderDate;
			END
		END
		ELSE
		BEGIN
			SELECT DISTINCT
				head.SalesOrderNumber AS OrderNumber,
				head.PurchaseOrderNumber AS PurchaseOrderNumber,
				head.OrderDate AS OrderDate
			FROM
				Sales.SalesOrderDetail det
				INNER JOIN Sales.SalesOrderHeader head
					ON det.SalesOrderID = head.SalesOrderID
				INNER JOIN Sales.Customer cust
					ON head.CustomerID = cust.CustomerID
				INNER JOIN Person.Person per
					ON cust.PersonID = per.BusinessEntityID
				INNER JOIN Production.Product prod
					ON det.ProductID = prod.ProductID
				INNER JOIN Production.ProductSubcategory subcat
					ON prod.ProductSubcategoryID = subcat.ProductSubcategoryID
				INNER JOIN Production.ProductCategory cat
					ON subcat.ProductCategoryID = cat.ProductCategoryID
			WHERE
				head.OrderDate BETWEEN @OrderDateFrom AND @OrderDateTo
				AND per.LastName LIKE @PersonLastName
				AND per.FirstName LIKE @PersonFirstName
				AND subcat.Name = @ProductSubcategoryName
			ORDER BY
				head.OrderDate;
		END
	END
	ELSE
	BEGIN
		SELECT DISTINCT
			head.SalesOrderNumber AS OrderNumber,
			head.PurchaseOrderNumber AS PurchaseOrderNumber,
			head.OrderDate AS OrderDate
		FROM
			Sales.SalesOrderDetail det
			INNER JOIN Sales.SalesOrderHeader head
				ON det.SalesOrderID = head.SalesOrderID
			INNER JOIN Sales.Customer cust
				ON head.CustomerID = cust.CustomerID
			INNER JOIN Person.Person per
				ON cust.PersonID = per.BusinessEntityID
			INNER JOIN Production.Product prod
				ON det.ProductID = prod.ProductID
			INNER JOIN Production.ProductSubcategory subcat
				ON prod.ProductSubcategoryID = subcat.ProductSubcategoryID
			INNER JOIN Production.ProductCategory cat
				ON subcat.ProductCategoryID = cat.ProductCategoryID
		WHERE
			head.OrderDate BETWEEN @OrderDateFrom AND @OrderDateTo
			AND per.LastName LIKE @PersonLastName
			AND per.FirstName LIKE @PersonFirstName
			AND prod.Name = @ProductName
		ORDER BY
			head.OrderDate;
	END
END
GO

-- Znajduje konkretne zamówienie po numerze zamówienia
CREATE OR ALTER PROCEDURE dbo.uspGetOrderDetails
(
	@OrderNumber NVARCHAR(25)
)
AS
BEGIN
	SELECT
		head.SalesOrderNumber AS OrderNumber,
		head.OrderDate AS OrderDate,
		head.DueDate AS DueDate,
		head.OnlineOrderFlag AS OnlineOrderFlag,
		head.PurchaseOrderNumber AS PurchaseNumber,
		CONCAT(per.FirstName, ' ', per.LastName) AS CustomerName,
		billaddr.AddressLine1 AS BillingAddress,
		billaddr.AddressLine2 AS BillingAddressL2,
		billaddr.City AS BillingCityName,
		billstat.Name AS BillingStateName,
		billcountry.Name AS BillingCountryName,
		shipaddr.AddressLine1 AS ShippingAddress,
		shipaddr.AddressLine2 AS ShippingAddressL2,
		shipaddr.City AS ShippingCityName,
		shipstat.Name AS ShippingStateName,
		shipcountry.Name AS ShippingCountryName,
		head.TotalDue AS TotalDue
	FROM
		Sales.SalesOrderDetail det
		INNER JOIN Sales.SalesOrderHeader head
			ON det.SalesOrderID = head.SalesOrderID
		INNER JOIN Sales.Customer cust
			ON head.CustomerID = cust.CustomerID
		INNER JOIN Person.Person per
			ON cust.PersonID = per.BusinessEntityID
		INNER JOIN Production.Product prod
			ON det.ProductID = prod.ProductID
		INNER JOIN Production.ProductSubcategory subcat
			ON prod.ProductSubcategoryID = subcat.ProductSubcategoryID
		INNER JOIN Production.ProductCategory cat
			ON subcat.ProductCategoryID = cat.ProductCategoryID
		INNER JOIN Person.Address billaddr
			ON head.BillToAddressID = billaddr.AddressID
		INNER JOIN Person.StateProvince billstat
			ON billaddr.StateProvinceID = billstat.StateProvinceID
		INNER JOIN Person.CountryRegion billcountry
			ON billstat.CountryRegionCode = billcountry.CountryRegionCode
		INNER JOIN Person.Address shipaddr
			ON head.ShipToAddressID = shipaddr.AddressID
		INNER JOIN Person.StateProvince shipstat
			ON shipaddr.StateProvinceID = shipstat.StateProvinceID
		INNER JOIN Person.CountryRegion shipcountry
			ON shipstat.CountryRegionCode = shipcountry.CountryRegionCode
	WHERE
		head.SalesOrderNumber = @OrderNumber;
END
GO

-- Znajdowanie produktów w zamówieniu
CREATE OR ALTER PROCEDURE dbo.uspGetProductsInOrder
(
	@OrderNumber NVARCHAR(25)
)
AS
BEGIN
	SELECT DISTINCT
		head.SalesOrderID AS OrderID,
		prod.Name AS ProductName,
		det.OrderQty AS Quantity,
		det.LineTotal AS LineTotal
	FROM
		Sales.SalesOrderHeader head
		INNER JOIN Sales.SalesOrderDetail det
			ON head.SalesOrderID = det.SalesOrderID
		INNER JOIN Production.Product prod
			ON det.ProductID = prod.ProductID
	WHERE
		head.SalesOrderNumber = @OrderNumber
	ORDER BY
		prod.Name,
		det.OrderQty;
END
GO