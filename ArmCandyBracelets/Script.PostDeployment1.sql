/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

SET IDENTITY_INSERT dbo.Product ON;  


	INSERT INTO Product(ID, ProductType, ProductPrice, ProductDescription, ProductName, Inventory)
	Values(01,'Bracelet', 14.99, 'Beautiful multi bronze bracelet01', 'Bracelet01', 100),
	(02,'Bracelet', 10.99, 'Modern leather black and brown braceket with golden highlight', 'Bracelet02', 100),
	(03,'Bracelet', 20.99, 'Beautiful white and beaded bracelet', 'Bracelet03', 100),
	(04,'Bracelet', 17.99, 'Classic gold multi string bracelet', 'Bracelet04', 100),
	(05,'Bracelet', 20.99, 'Beautiful owl with leather strap', 'Bracelet05', 100),
	(06,'Bracelet', 15.99, 'Silver and gold multi bracelet', 'Bracelet06', 100),
	(07,'Bracelet', 10.99, 'Blue and Gold multi string', 'Bracelet07', 100),
	(08,'Bracelet', 10.99, 'Classic white and gold multi string', 'Bracelet08', 100),
	(09,'Bracelet', 7.99, 'Simple pink and gold wrap around bracelet', 'Bracelet09', 100),
	(010,'Bracelet', 17.99, 'Beautiful snake rhinestone', 'Bracelet010', 100),
	(011,'Bracelet', 19.99, 'Multi colored Bracelet', 'Bracelet011', 100),
	(012,'Bracelet', 13.99, 'Brown boho bracelet', 'Bracelet012', 100),
	(013,'Bracelet', 13.99, 'Turquoise boho bracelet', 'Bracelet013', 100),
	(014,'Bracelet', 17.99, 'Classic multi pearls', 'Bracelet014', 100),
	(015,'Bracelet', 10.99, 'Multi blue sparkle rhinestone', 'Bracelet015', 100),
	(016,'Clutch', 24.99, 'Coral with bronze chain', 'Clutch01', 100),
	(017,'Clutch', 30.99, 'Classic black clutchw with gold sequence', 'Clutch02', 100),
	(018,'Clutch', 39.99, 'Snake print', 'Clutch03', 100),
	(019,'Clutch', 25.49, 'Classic royal blue with zip lining', 'Clutch04', 100),
	(020,'Clutch', 19.99, 'Yellow clutch with silver stones', 'Clutch05', 100),	
	(021,'Clutch', 29.99, 'Party peacock sequence', 'Clutch06', 100),	
	(022,'Clutch', 29.99, 'Classic black clutch with cheetah print', 'Clutch07', 100),
	(023,'Clutch', 31.99, 'Magazine print', 'Clutch08', 100),
	(024,'Clutch', 41.99, 'Tribal style coin clutch', 'Clutch09', 100),
	(025,'Clutch', 41.99, 'Bracelet clutch with colorful snake print', 'Clutch010', 100),
	(026,'Clutch', 24.99, 'African Print flip clutch', 'Clutch012', 100),
	(027,'Clutch', 24.49, 'Trible coin flip clutch', 'Clutch013', 100),
	(028,'Clutch', 34.49, 'Gold sequece with turquoise button', 'Clutch014', 100),
	(029,'Clutch', 45.49, 'Taupe flip zipper bag', 'Clutch015', 100)


	INSERT INTO ProductImage(ImageFileName, AltText, ProductID)
	VALUES('bracelet1.jpg', 'bracelet awesome', 01),
	('bracelet2.jpg', 'bracelet awesome', 02),
	('bracelet3.jpg', 'bracelet awesome', 03),
	('bracelet4.jpg', 'bracelet awesome', 04),
	('bracelet5.jpg', 'bracelet awesome', 05),
	('bracelet6.jpg', 'bracelet awesome', 06),
	('bracelet7.jpg', 'bracelet awesome', 07),
	('bracelet8.jpg', 'bracelet awesome', 08),
	('bracelet9.jpg', 'bracelet awesome', 09),
	('bracelet10.jpg', 'bracelet awesome', 010),
	('bracelet11.jpg', 'bracelet awesome', 011),
	('bracelet12.jpg', 'bracelet awesome', 012),
	('bracelet13.jpg', 'bracelet awesome', 013),
	('bracelet14.jpg', 'bracelet awesome', 014),
	('bracelet15.jpg', 'bracelet awesome', 015),
	('clutch1.jpe', 'Coral clutch', 016),
	('clutch2.jpg', 'Classic black with sequence', 017),
	('clutch3.jpg', 'Snake print', 018),
	('clutch4.jpe', 'Classic royal blue', 019),
	('clutch5.jpeg', 'Yello with rhinestones', 020),
	('clutch6.jpg', 'Peacock sequence', 021),
	('clutch7.jpg', 'leopord flap black', 022),
	('clutch8.jpg', 'Magazine print', 023),
	('clutch9.jpg', 'Ethnic print with coins', 024),
	('clutch10.jpg', 'Bracelet clutch with colorful snake print', 025),
	('clutch12.jpg', 'African Print flip clutch', 026),
	('clutch13.jpg', 'Trible coin flip clutch', 027),
	('clutch14.jpg', 'Gold sequece with turquoise button', 028),
	('clutch15.jpg', 'Taupe flip zipper bag', 029)

SET IDENTITY_INSERT dbo.Product OFF;