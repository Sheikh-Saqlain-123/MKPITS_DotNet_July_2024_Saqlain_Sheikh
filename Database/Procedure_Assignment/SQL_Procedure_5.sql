--Create a stored procedure that deletes all records from a logs table that are older than a given date. The date should be passed as a parameter.


CREATE PROCEDURE DeleteOldLogs
    @CutoffDate DATETIME
AS
BEGIN
    DELETE FROM Logs
    WHERE LogDate < @CutoffDate;
END
