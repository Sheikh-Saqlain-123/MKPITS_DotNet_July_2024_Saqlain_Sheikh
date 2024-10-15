--Create a trigger that automatically updates the total order amount in the orders table whenever a new item is added or removed from the order_items table.


--For Adding the Item
CREATE TRIGGER trgAfterInsertOrderItems
ON Order_Items
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Orders
    SET TotalAmount = TotalAmount + (SELECT SUM(Price * Quantity) FROM inserted)
    WHERE OrderID IN (SELECT DISTINCT OrderID FROM inserted);
END;


