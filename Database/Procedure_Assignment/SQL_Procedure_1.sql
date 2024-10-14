--Create a stored procedure to fetch all employees' details from the employees table who are earning more than a specific salary. The salary should be passed as a parameter.

CREATE PROCEDURE GetEmployeesBySalary
    @Salary DECIMAL(18, 2)
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE Salary > @Salary;
END