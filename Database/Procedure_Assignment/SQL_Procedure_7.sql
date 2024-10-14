--Develop a stored procedure that takes a customer ID and returns the list of orders placed by that customer, including order details such as order date, product names, and quantities.


CREATE PROCEDURE GetCustomerOrders
    @CustomerID INT
AS
BEGIN
    SELECT 
        o.OrderID,
        o.OrderDate,
        p.ProductName,
        od.Quantity
    FROM 
        Orders o
    JOIN 
        OrderDetails od ON o.OrderID = od.OrderID
    JOIN 
        Products p ON od.ProductID = p.ProductID
    WHERE 
        o.CustomerID = @CustomerID;
END
