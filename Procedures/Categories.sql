USE AdventureWorks2022;
GO

-- --------- --
-- Kategorie --
-- --------- --

-- Znajdowanie wszystkich kategorii
CREATE OR ALTER PROCEDURE dbo.uspGetCategories
AS
BEGIN
	SELECT
		ProductCategoryID as CategoryID,
		Name AS CategoryName
	FROM
		Production.ProductCategory
	ORDER BY
		CategoryName;
END
GO

-- Znajdowanie konkretnej kategorii po nazwie
-- Zak³adaj¹c, ¿e nazwy maj¹ byæ unikalne
CREATE OR ALTER PROCEDURE dbo.uspGetCategoryByName
(
	@CategoryName NVARCHAR(50)
)
AS
BEGIN
	SELECT
		ProductCategoryID AS CategoryID,
		Name AS CategoryName
	FROM
		Production.ProductCategory
	WHERE
		Name = @CategoryName;
END
GO

-- Dodawanie kategorii
CREATE OR ALTER PROCEDURE dbo.uspCreateCategory
(
	@Name NVARCHAR(50)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF LEN(@Name) < 3
		BEGIN
			;THROW 50013, 'Category name must be at least 3 characters long!', 1;
		END

		IF EXISTS (
			SELECT 1
			FROM Production.ProductCategory
			WHERE Name = @Name
		)
		BEGIN
			;THROW 50014, 'Another Category already has that name!', 1;
		END

		INSERT INTO Production.ProductCategory (Name)
		VALUES (@Name);

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
		;THROW;
	END CATCH
END
GO

-- Aktualizowanie kategorii
CREATE OR ALTER PROCEDURE dbo.uspUpdateCategory
(
	@CategoryID INT,
	@NewName NVARCHAR(50)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (
            SELECT 1
            FROM Production.ProductCategory
            WHERE Name = @NewName AND ProductCategoryID != @CategoryID
        )
		BEGIN
			;THROW 50012, 'Another Category already has that name!', 1;
		END

		UPDATE Production.ProductCategory
		SET
			Name = @NewName
		WHERE
			ProductCategoryID = @CategoryID;

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
		;THROW;
	END CATCH
END
GO

-- Usuwanie kategorii
CREATE OR ALTER PROCEDURE dbo.uspDeleteCategory
(
	@CategoryID INT
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (
			SELECT 1
			FROM Production.ProductSubcategory
			WHERE ProductCategoryID = @CategoryID
		)
		BEGIN
			;THROW 50011, 'Cannot delete a Category which has associated Subcategories!', 1;
		END

		DELETE FROM Production.ProductCategory
		WHERE ProductCategoryID = @CategoryID;

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
		;THROW;
	END CATCH
END
GO

-- ------------ --
-- Podkategorie --
-- ------------ --

-- Szukanie podkategorii po nazwie kategorii
-- Jeœli wybrana zostanie opcja 'All', znajdzie wszystkie kategorie
CREATE OR ALTER PROCEDURE dbo.uspGetSubcategoriesByCategoryName
(
	@CategoryName NVARCHAR(50)
)
AS
BEGIN
	IF @CategoryName = 'All'
	BEGIN
		SELECT
			pps.ProductSubcategoryID AS SubcategoryID,
			pps.Name AS SubcategoryName,
			ppc.Name AS CategoryName
		FROM
			Production.ProductSubcategory pps
			INNER JOIN Production.ProductCategory ppc
				ON pps.ProductCategoryID = ppc.ProductCategoryID
		ORDER BY
			CategoryName,
			SubcategoryName;
	END
	ELSE
	BEGIN
		SELECT
			pps.ProductSubcategoryID AS SubcategoryID,
			pps.Name AS SubcategoryName,
			ppc.Name AS CategoryName
		FROM
			Production.ProductSubcategory pps
			INNER JOIN Production.ProductCategory ppc
				ON pps.ProductCategoryID = ppc.ProductCategoryID
		WHERE
			ppc.Name = @CategoryName
		ORDER BY
			CategoryName,
			SubcategoryName;
	END
END
GO

-- Znalezienie podkategorii po nazwie
-- Zak³adaj¹c, ¿e wszysktie podkategorie musz¹ siê inaczej nazywaæ
CREATE OR ALTER PROCEDURE dbo.uspGetSubcategoryByName
(
	@SubcategoryName NVARCHAR(50)
)
AS
BEGIN
	SELECT
		pps.ProductSubcategoryID AS SubcategoryID,
		pps.Name AS SubcategoryName,
		ppc.ProductCategoryID AS CategoryID,
		ppc.Name AS CategoryName
	FROM
		Production.ProductCategory ppc
		INNER JOIN Production.ProductSubcategory pps
			ON ppc.ProductCategoryID = pps.ProductCategoryID
	WHERE
		pps.Name = @SubcategoryName
	ORDER BY
		CategoryName,
		SubcategoryName;
END
GO

-- Dodawanie podkategorii
CREATE OR ALTER PROCEDURE dbo.uspCreateSubcategory
(
	@CategoryID INT,
	@Name NVARCHAR(50)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF NOT EXISTS (
			SELECT 1
			FROM Production.ProductCategory
			WHERE ProductCategoryID = @CategoryID
		)
		BEGIN
			;THROW 50025, 'Given Category does not exist!', 1;
		END

		IF LEN(@Name) < 3
		BEGIN
			;THROW 50023, 'Subcategory name must be at least 3 characters long!', 1;
		END

		IF EXISTS (
			SELECT 1
			FROM Production.ProductSubcategory
			WHERE Name = @Name
		)
		BEGIN
			;THROW 50024, 'Another Subcategory already has that name!', 1;
		END

		INSERT INTO Production.ProductSubcategory (Name, ProductCategoryID)
		VALUES (@Name, @CategoryID);

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
		;THROW;
	END CATCH
END
GO

-- Aktualizowanie podkategorii
CREATE OR ALTER PROCEDURE dbo.uspUpdateSubcategory
(
	@SubcategoryID INT,
	@NewCategoryID INT,
	@NewName NVARCHAR(50)
)
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		IF EXISTS (
            SELECT 1
            FROM Production.ProductSubcategory
            WHERE Name = @NewName AND ProductSubcategoryID != @SubcategoryID
        )
		BEGIN
			;THROW 50022, 'Another Subcategory already has that name!', 1;
		END
		
		UPDATE Production.ProductSubcategory
		SET
			Name = @NewName,
			ProductCategoryID = @NewCategoryID
		WHERE
			ProductSubcategoryID = @SubcategoryID;

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
		;THROW;
	END CATCH
END
GO

-- Usuwanie podkategorii
CREATE OR ALTER PROCEDURE dbo.uspDeleteSubcategory
(
	@SubcategoryID INT
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (
			SELECT 1
			FROM Production.Product
			WHERE ProductSubcategoryID = @SubcategoryID
		)
		BEGIN
			;THROW 50021, 'Cannot delete a Subcategory which has associated Products!', 1;
		END

		DELETE FROM Production.ProductSubcategory
		WHERE ProductSubcategoryID = @SubcategoryID;

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
		;THROW;
	END CATCH
END
GO
