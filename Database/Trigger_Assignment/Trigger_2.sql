--Write a trigger that prevents the deletion of any rows from the products table if the product is associated with any orders in the orders table.


CREATE TRIGGER PreventProductDeletion
ON Products
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM deleted d
        JOIN OrderDetails od ON d.ProductID = od.ProductID
    )
    BEGIN
        RAISERROR ('Cannot delete product as it is associated with an order.', 16, 1);
    END
    ELSE
    BEGIN
        DELETE FROM Products
        WHERE ProductID IN (SELECT ProductID FROM deleted);
    END
END;
