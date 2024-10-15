--Create a trigger that prevents the insertion of duplicate records in the customers table based on the email address.


CREATE TRIGGER trgBeforeInsertCustomers
ON Customers
INSTEAD OF INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1 
        FROM Customers
        WHERE Email IN (SELECT Email FROM inserted)
    )
    BEGIN
        RAISERROR ('Duplicate email address is not allowed.', 16, 1);
    END
    ELSE
    BEGIN
        INSERT INTO Customers (CustomerID, Name, Email, ...)
        SELECT CustomerID, Name, Email, ...
        FROM inserted;
    END
END;
