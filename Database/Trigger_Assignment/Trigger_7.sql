--Create a trigger that automatically updates the total order amount in the orders table whenever a new item is added or removed from the order_items table.

--For Removing the item
CREATE TRIGGER trgAfterDeleteOrderItems
ON Order_Items
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Orders
    SET TotalAmount = TotalAmount - (SELECT SUM(Price * Quantity) FROM deleted)
    WHERE OrderID IN (SELECT DISTINCT OrderID FROM deleted);
END;
