--Develop a trigger that inserts a record into an audit_log table every time a record is deleted from the customers table. The log should include the customer ID and the timestamp of the deletion.


CREATE TRIGGER LogCustomerDeletion
ON Customers
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO audit_log (CustomerID, DeletionTimestamp)
    SELECT d.CustomerID, GETDATE()
    FROM deleted d;
END;
