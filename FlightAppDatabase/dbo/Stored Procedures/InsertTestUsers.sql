CREATE PROCEDURE InsertTestUsers
AS
BEGIN
    -- User1
    DECLARE @Password1 NVARCHAR(50) = 'password1';
    INSERT INTO [dbo].[User] ([UserId], [Username], [Email], [PasswordSha])
    VALUES (1, 'user1', 'user1@example.com', HASHBYTES('SHA2_256', @Password1)); 
    
    -- User2
    DECLARE @Password2 NVARCHAR(50) = 'password2';
    INSERT INTO [dbo].[User] ([UserId], [Username], [Email], [PasswordSha])
    VALUES (2, 'user2', 'user2@example.com', HASHBYTES('SHA2_256', @Password2));
    
    -- User3
    DECLARE @Password3 NVARCHAR(50) = 'password3';
    INSERT INTO [dbo].[User] ([UserId], [Username], [Email], [PasswordSha])
    VALUES (3, 'user3', 'user3@example.com', HASHBYTES('SHA2_256', @Password3));
END;
