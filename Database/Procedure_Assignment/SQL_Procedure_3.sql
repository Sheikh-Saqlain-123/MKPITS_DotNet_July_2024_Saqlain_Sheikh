--Develop a stored procedure to insert a new record into the orders table. The procedure should accept all necessary order details as parameters.


CREATE PROCEDURE InsertNewOrder
    @OrderID INT,
    @CustomerID INT,
    @OrderDate DATETIME,
    @TotalAmount DECIMAL(18, 2)
AS
BEGIN
    INSERT INTO Orders (OrderID, CustomerID, OrderDate, TotalAmount)
    VALUES (@OrderID, @CustomerID, @OrderDate, @TotalAmount);
END
