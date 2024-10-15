--Create a trigger that automatically updates the last_updated date column in the employees table whenever an employee's record is updated.

CREATE TRIGGER UpdateLastUpdated
ON Employees
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Employees
    SET last_updated = GETDATE()
    FROM Employees e
    INNER JOIN inserted i ON e.EmployeeID = i.EmployeeID;
END;
