--Create a stored procedure that logs any failed login attempts into a login_attempts table. The procedure should accept parameters for the user ID and the attempt timestamp.


CREATE PROCEDURE LogFailedLoginAttempt
    @UserID INT,
    @AttemptTimestamp DATETIME
AS
BEGIN
    INSERT INTO login_attempts (UserID, AttemptTimestamp)
    VALUES (@UserID, @AttemptTimestamp);
END
