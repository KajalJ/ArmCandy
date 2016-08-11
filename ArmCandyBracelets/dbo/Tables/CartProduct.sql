CREATE TABLE [dbo].[CartProduct]
(
	OrderId INT NOT NULL,
	ProductId INT NOT NULL, 
    CONSTRAINT [FK_CartProduct_Product] FOREIGN KEY (ProductId) REFERENCES Product(ID), 
    CONSTRAINT [FK_CartProduct_Cart] FOREIGN KEY (OrderId) REFERENCES Cart(OrderId), 
    CONSTRAINT [PK_CartProduct] PRIMARY KEY (OrderId,ProductId)
)
