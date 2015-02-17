CREATE TABLE Users (
  UserID int IDENTITY(1, 1),
  UserName nvarchar(100) NOT NULL UNIQUE,
  Password nvarchar(100) NOT NULL,
  FullName nvarchar(100) NOT NULL,
  LastLogin DATETIME NOT NULL DEFAULT(GETDATE()), 
  CONSTRAINT PK_Users PRIMARY KEY(UserID),
  CONSTRAINT Chk_Password CHECK (LEN(Password) >= 5)
)
GO