--Write a stored procedure that accepts a department ID and returns the number of employees in that department.

CREATE PROCEDURE GetEmployeeCountByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT COUNT(*) AS EmployeeCount
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END
