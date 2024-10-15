--Develop a trigger that ensures an employee’s email is always stored in lowercase in the employees table, regardless of how it is input during insert or update operations.

--For Insert Trigger
CREATE TRIGGER trgBeforeInsertEmployees
ON Employees
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO Employees (EmployeeID, Name, Email, ...)
    SELECT EmployeeID, Name, LOWER(Email), ...
    FROM inserted;
END;
