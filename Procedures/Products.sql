USE AdventureWorks2022;
GO

-- -------- --
-- Produkty --
-- -------- --

-- Szukanie wszystkich kodów jednostek rozmiaru
CREATE OR ALTER PROCEDURE dbo.uspGetSizeUnitMeasureCodes
AS
BEGIN
	SELECT SizeUnitMeasureCode
	FROM Production.Product
	GROUP BY SizeUnitMeasureCode
END
GO

-- Szukanie wszystkich kodów jednostek masy
CREATE OR ALTER PROCEDURE dbo.uspGetWeightUnitMeasureCodes
AS
BEGIN
	SELECT WeightUnitMeasureCode
	FROM Production.Product
	GROUP BY WeightUnitMeasureCode
END
GO

-- Szukanie wszystkich produktów po podkategorii
CREATE OR ALTER PROCEDURE dbo.uspGetProductsBySubcategoryName
(
	@SubcategoryName NVARCHAR(50),
	@CategoryName NVARCHAR(50) = 'All'
)
AS
BEGIN
	IF @SubcategoryName = 'All'
	BEGIN
		IF @CategoryName = 'All'
		BEGIN
			SELECT
				pp.ProductID AS ProductID,
				pp.Name AS ProductName,
				pp.ProductNumber AS ProductNumber,
				ppc.ProductCategoryID AS CategoryID,
				ppc.Name AS CategoryName,
				pps.ProductSubcategoryID AS SubcategoryID,
				pps.Name AS SubcategoryName,
				pp.Color AS ProductColor,
				pp.SafetyStockLevel AS ProductSafetyStockLevel,
				pp.ReorderPoint AS ProductReorderPoint,
				pp.StandardCost AS ProductStandardCost,
				pp.ListPrice AS ProductListPrice,
				pp.Weight AS ProductWeight,
				pp.WeightUnitMeasureCode AS ProductWeightUnit,
				pp.Size AS ProductSize,
				pp.SizeUnitMeasureCode AS ProductSizeUnit,
				pp.SellStartDate AS ProductSellStartDate
			FROM
				Production.Product pp
				INNER JOIN Production.ProductSubcategory pps
					ON pp.ProductSubcategoryID = pps.ProductSubcategoryID
				INNER JOIN Production.ProductCategory ppc
					ON pps.ProductCategoryID = ppc.ProductCategoryID
			ORDER BY
				ProductNumber,
				ProductName;
		END
		ELSE
		BEGIN
			SELECT
				pp.ProductID AS ProductID,
				pp.Name AS ProductName,
				pp.ProductNumber AS ProductNumber,
				ppc.ProductCategoryID AS CategoryID,
				ppc.Name AS CategoryName,
				pps.ProductSubcategoryID AS SubcategoryID,
				pps.Name AS SubcategoryName,
				pp.Color AS ProductColor,
				pp.SafetyStockLevel AS ProductSafetyStockLevel,
				pp.ReorderPoint AS ProductReorderPoint,
				pp.StandardCost AS ProductStandardCost,
				pp.ListPrice AS ProductListPrice,
				pp.Weight AS ProductWeight,
				pp.WeightUnitMeasureCode AS ProductWeightUnit,
				pp.Size AS ProductSize,
				pp.SizeUnitMeasureCode AS ProductSizeUnit,
				pp.SellStartDate AS ProductSellStartDate
			FROM
				Production.Product pp
				INNER JOIN Production.ProductSubcategory pps
					ON pp.ProductSubcategoryID = pps.ProductSubcategoryID
				INNER JOIN Production.ProductCategory ppc
					ON pps.ProductCategoryID = ppc.ProductCategoryID
			WHERE
				ppc.Name = @CategoryName
			ORDER BY
				ProductNumber,
				ProductName;
		END
	END
	ELSE
	BEGIN
		SELECT
			pp.ProductID AS ProductID,
			pp.Name AS ProductName,
			pp.ProductNumber AS ProductNumber,
			ppc.ProductCategoryID AS CategoryID,
			ppc.Name AS CategoryName,
			pps.ProductSubcategoryID AS SubcategoryID,
			pps.Name AS SubcategoryName,
			pp.Color AS ProductColor,
			pp.SafetyStockLevel AS ProductSafetyStockLevel,
			pp.ReorderPoint AS ProductReorderPoint,
			pp.StandardCost AS ProductStandardCost,
			pp.ListPrice AS ProductListPrice,
			pp.Weight AS ProductWeight,
			pp.WeightUnitMeasureCode AS ProductWeightUnit,
			pp.Size AS ProductSize,
			pp.SizeUnitMeasureCode AS ProductSizeUnit,
			pp.SellStartDate AS ProductSellStartDate
		FROM
			Production.Product pp
			INNER JOIN Production.ProductSubcategory pps
				ON pp.ProductSubcategoryID = pps.ProductSubcategoryID
			INNER JOIN Production.ProductCategory ppc
				ON pps.ProductCategoryID = ppc.ProductCategoryID
		WHERE
			pps.Name = @SubcategoryName
		ORDER BY
			ProductNumber,
			ProductName;
	END
END
GO

-- Szukanie produktu po nazwie
-- Zak³adaj¹c, ¿e nazwa jest unikalna
CREATE OR ALTER PROCEDURE dbo.uspGetProductByName
(
	@ProductName NVARCHAR(50)
)
AS
BEGIN
	SELECT
		pp.ProductID AS ProductID,
		pp.Name AS ProductName,
		pp.ProductNumber AS ProductNumber,
		ppc.ProductCategoryID AS CategoryID,
		ppc.Name AS CategoryName,
		pps.ProductSubcategoryID AS SubcategoryID,
		pps.Name AS SubcategoryName,
		pp.Color AS ProductColor,
		pp.SafetyStockLevel AS ProductSafetyStockLevel,
		pp.ReorderPoint AS ProductReorderPoint,
		pp.StandardCost AS ProductStandardCost,
		pp.ListPrice AS ProductListPrice,
		pp.Weight AS ProductWeight,
		pp.WeightUnitMeasureCode AS ProductWeightUnit,
		pp.Size AS ProductSize,
		pp.SizeUnitMeasureCode AS ProductSizeUnit,
		pp.SellStartDate AS ProductSellStartDate
	FROM
		Production.Product pp
		INNER JOIN Production.ProductSubcategory pps
			ON pp.ProductSubcategoryID = pps.ProductSubcategoryID
		INNER JOIN Production.ProductCategory ppc
			ON pps.ProductCategoryID = ppc.ProductCategoryID
	WHERE
		pp.Name = @ProductName;
END
GO

-- Dodawanie nowego produtku do bazy danych
CREATE OR ALTER PROCEDURE dbo.uspCreateProduct
(
	@Name NVARCHAR(50) = NULL,
	@ProductNumber NVARCHAR(25) = NULL,
	@CategoryID INT = NULL,
	@SubcategoryID INT = NULL,
	@Color NVARCHAR(15) = NULL,
	@SafetyStockLevel SMALLINT,
	@ReorderPoint SMALLINT,
	@StandardCost MONEY,
	@ListPrice MONEY,
	@Weight DECIMAL(8,2) = NULL,
	@WeightUnit NCHAR(3) = NULL,
	@Size NVARCHAR(5) = NULL,
	@SizeUnit NCHAR(3) = NULL,
	@SellStartDate DATETIME
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (SELECT 1 FROM Production.Product WHERE ProductNumber = @ProductNumber)
			THROW 50101, 'Product with that number already exists!', 1;
		IF EXISTS (SELECT 1 FROM Production.Product WHERE Name = @Name)
			THROW 50102, 'Product with that name already exists!', 1;
		IF @ProductNumber IS NULL
			THROW 50103, 'Product number is required!', 1;
		IF @Name IS NULL
			THROW 50104, 'Name is required!', 1;
		IF LEN(@ProductNumber) < 2
			THROW 50105, 'Product number must be at least 2 characters long!', 1;
		IF LEN(@Name) < 6
			THROW 50103, 'Name must be at least 6 characters long!', 1;

		INSERT INTO Production.Product
		(
			Name,
			ProductNumber,
			ProductSubcategoryID,
			Color,
			SafetyStockLevel,
			ReorderPoint,
			StandardCost,
			ListPrice,
			Weight,
			WeightUnitMeasureCode,
			Size,
			SizeUnitMeasureCode,
			SellStartDate,
			DaysToManufacture
		)
		VALUES
		(
			@Name,
			@ProductNumber,
			@SubcategoryID,
			@Color,
			@SafetyStockLevel,
			@ReorderPoint,
			@StandardCost,
			@ListPrice,
			@Weight,
			@WeightUnit,
			@Size,
			@SizeUnit,
			@SellStartDate,
			1
		);

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
		;THROW;
	END CATCH
END
GO
