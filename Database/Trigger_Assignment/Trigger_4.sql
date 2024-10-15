--Create a trigger that automatically inserts a new row into the employee_history table whenever a new employee is added to the employees table. The trigger should include details such as the employee ID, name, and hire date.


CREATE TRIGGER InsertEmployeeHistory
ON Employees
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO employee_history (EmployeeID, Name, HireDate)
    SELECT i.EmployeeID, i.Name, i.HireDate
    FROM inserted i;
END;
