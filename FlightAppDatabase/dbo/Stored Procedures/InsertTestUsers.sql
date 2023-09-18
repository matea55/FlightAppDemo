CREATE PROCEDURE InsertTestUsers
AS
BEGIN
    -- User1
    DECLARE @Password1 NVARCHAR(50) = 'password1';
    INSERT INTO [dbo].[User] ([UserId], [Username], [Email], [PasswordSha])
    VALUES (1, 'user1', 'user1@example.com', '0b14d501a594442a01c6859541bcb3e8164d183d32937b851835442f69d5c94e'); 
    
    -- User2
    DECLARE @Password2 NVARCHAR(50) = 'password2';
    INSERT INTO [dbo].[User] ([UserId], [Username], [Email], [PasswordSha])
    VALUES (2, 'user2', 'user2@example.com', '6cf615d5bcaac778352a8f1f3360d23f02f34ec182e259897fd6ce485d7870d4');
    
    -- User3
    DECLARE @Password3 NVARCHAR(50) = 'password3';
    INSERT INTO [dbo].[User] ([UserId], [Username], [Email], [PasswordSha])
    VALUES (3, 'user3', 'user3@example.com', '5906ac361a137e2d286465cd6588ebb5ac3f5ae955001100bc41577c3d751764');
END;
