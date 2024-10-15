--Write a trigger that prevents an employee's salary from being updated to a value lower than their current salary in the employees table.


CREATE TRIGGER PreventSalaryReduction
ON Employees
BEFORE UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN deleted d ON i.EmployeeID = d.EmployeeID
        WHERE i.Salary < d.Salary
    )
    BEGIN
        RAISERROR ('Cannot reduce salary to a value lower than the current salary.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
