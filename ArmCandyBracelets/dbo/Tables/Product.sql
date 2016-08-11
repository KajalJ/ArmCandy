CREATE TABLE Product
	(
	ID INT IDENTITY(1,1) NOT NULL,
	ProductType VARCHAR(50),
	ProductPrice MONEY NOT NULL DEFAULT(0),
	ProductDescription NTEXT NULL,
	ProductName VARCHAR(50),
	Inventory INT NOT NULL,
	CONSTRAINT PK_Product PRIMARY KEY (ID)

	)




	