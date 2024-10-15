--Develop a trigger that ensures an employee’s email is always stored in lowercase in the employees table, regardless of how it is input during insert or update operations.

--For Update Trigger
CREATE TRIGGER trgBeforeUpdateEmployees
ON Employees
INSTEAD OF UPDATE
AS
BEGIN
    UPDATE Employees
    SET Email = LOWER(i.Email), ...
    FROM Employees e
    INNER JOIN inserted i ON e.EmployeeID = i.EmployeeID;
END;
