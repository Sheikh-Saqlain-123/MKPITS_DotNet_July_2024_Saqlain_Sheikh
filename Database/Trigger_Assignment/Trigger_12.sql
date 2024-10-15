--Develop a trigger that automatically calculates and updates the total_amount column in the invoices table whenever any item is added or removed from the invoice_items table.


--For Adding an Item
CREATE TRIGGER trgAfterInsertInvoiceItems
ON Invoice_Items
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Invoices
    SET total_amount = total_amount + (SELECT SUM(price * quantity) FROM inserted)
    WHERE InvoiceID IN (SELECT DISTINCT InvoiceID FROM inserted);
END;


--For Removing an Item
-- CREATE TRIGGER trgAfterDeleteInvoiceItems
-- ON Invoice_Items
-- AFTER DELETE
-- AS
-- BEGIN
--     SET NOCOUNT ON;

--     UPDATE Invoices
--     SET total_amount = total_amount - (SELECT SUM(price * quantity) FROM deleted)
--     WHERE InvoiceID IN (SELECT DISTINCT InvoiceID FROM deleted);
-- END;
