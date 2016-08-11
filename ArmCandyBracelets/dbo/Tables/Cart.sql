CREATE TABLE CART
(
OrderId INT IDENTITY(1,1) NOT NULL,
Name NVARCHAR(20),
EmailAddress NVARCHAR(100),
PhoneNumber INT NULL,
ShippingAddress1 NVARCHAR(100),
ShippingAddress2 NVARCHAR(100),
ShippingCity NVARCHAR(100),
ShippingState NVARCHAR(2),
ShippingZipCode NVARCHAR(20),
BillingAddress1 NVARCHAR(100),
BillingAddress2 NVARCHAR(100),
BillingCity NVARCHAR(100),
BillingState NVARCHAR(2),
BillingZipCode NVARCHAR(20),
BillinggState NVARCHAR(2),
CreditCardNumber NVARCHAR(16),
CreditCardExpiration DATETIME NULL,
CVV INT NOT NULL,
Items INT,
TOTAL MONEY NOT NULL,
ShippingCost MONEY,
TAX MONEY,
SubTotal INT NOT NULL,
GrandTotal MONEY NOT NULL
CONSTRAINT PK_CART PRIMARY KEY (OrderId),
)



