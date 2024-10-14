--Write a stored procedure to calculate and return the total sales for a specific product. The product ID should be passed as a parameter.


CREATE PROCEDURE GetTotalSalesByProduct
    @ProductID INT
AS
BEGIN
    SELECT SUM(Amount) AS TotalSales
    FROM Sales
    WHERE ProductID = @ProductID;
END
