--Write a trigger to automatically update the stock quantity in the products table when a new order is placed, reducing the stock by the ordered quantity.


CREATE TRIGGER trgAfterInsertOrderItems
ON Order_Items
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Products
    SET StockQuantity = StockQuantity - i.Quantity
    FROM Products p
    INNER JOIN inserted i ON p.ProductID = i.ProductID;
END;
