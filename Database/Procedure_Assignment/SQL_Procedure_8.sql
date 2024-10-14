--Create a stored procedure that accepts an employee ID and a percentage, then increases that employee’s salary by that percentage.


CREATE PROCEDURE IncreaseEmployeeSalary
    @EmployeeID INT,
    @PercentageIncrease DECIMAL(5, 2)
AS
BEGIN
    UPDATE Employees
    SET Salary = Salary + (Salary * @PercentageIncrease / 100)
    WHERE EmployeeID = @EmployeeID;
END
    