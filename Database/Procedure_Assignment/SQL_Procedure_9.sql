--Write a stored procedure to transfer funds between two accounts in a banking application. The procedure should accept source account ID, destination account ID, and the amount as parameters, and ensure that the source account has sufficient funds before proceeding with the transfer.


CREATE PROCEDURE TransferFunds
    @SourceAccountID INT,
    @DestinationAccountID INT,
    @Amount DECIMAL(18, 2)
AS
BEGIN
    -- Start a transaction
    BEGIN TRANSACTION;

    -- Check if the source account has sufficient funds
    IF EXISTS (SELECT 1 FROM Accounts WHERE AccountID = @SourceAccountID AND Balance >= @Amount)
    BEGIN
        -- Deduct the amount from the source account
        UPDATE Accounts
        SET Balance = Balance - @Amount
        WHERE AccountID = @SourceAccountID;

        -- Add the amount to the destination account
        UPDATE Accounts
        SET Balance = Balance + @Amount
        WHERE AccountID = @DestinationAccountID;

        -- Commit the transaction
        COMMIT TRANSACTION;

        PRINT 'Transfer successful';
    END
    ELSE
    BEGIN
        -- Rollback the transaction if there are insufficient funds
        ROLLBACK TRANSACTION;

        PRINT 'Insufficient funds in the source account';
    END
END;
