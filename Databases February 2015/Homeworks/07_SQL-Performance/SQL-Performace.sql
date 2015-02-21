-- =================================================
--	Problem 1.	Create a table in SQL Server
-- =================================================
USE master
GO

CREATE DATABASE PerformanceDB
GO

USE PerformanceDB
GO

CREATE TABLE Messages(
  MsgId int NOT NULL IDENTITY,
  AuthorId int NOT NULL,
  MsgText nvarchar(300),
  MsgDate datetime,
  MsgPrice int,
  CONSTRAINT PK_Messages_MsgId PRIMARY KEY (MsgId)
)

ALTER TABLE Messages ADD CONSTRAINT FK_Messages_Authors
FOREIGN KEY (AuthorId) REFERENCES Authors(AuthorId)

SET NOCOUNT ON
DECLARE @AuthorsCount int = (SELECT COUNT(*) FROM Authors)
DECLARE @RowCount int = 10000
WHILE @RowCount > 0
BEGIN
  DECLARE @Text nvarchar(100) = 
    'Text ' + CONVERT(nvarchar(100), @RowCount) + ': ' +
    CONVERT(nvarchar(100), newid())
  DECLARE @Date datetime = 
	DATEADD(month, CONVERT(varbinary, newid()) % (50 * 12), getdate())
  DECLARE @Price int = RAND() * 1000000
  DECLARE @Author int = 1 + (RAND() * @AuthorsCount)
  INSERT INTO Messages(MsgText, AuthorId, MsgDate, MsgPrice)
  VALUES(@Text, @Author, @Date, @Price)
  SET @RowCount = @RowCount - 1
END
SET NOCOUNT OFF

WHILE (SELECT COUNT(*) FROM Messages) < 10000001
BEGIN
  INSERT INTO Messages(MsgText, AuthorId, MsgDate, MsgPrice)
  SELECT MsgText, AuthorId, MsgDate, MsgPrice FROM Messages
END

-- ====================================================================
--	Problem 2.	Add an index to speed-up the search by date 
-- ====================================================================

-- Before index key
SELECT * FROM Messages
WHERE MsgDate > '31-Dec-2011' and MsgDate < '1-Jan-2014'

CREATE INDEX IDX_Messages_MsgDate
ON Messages(MsgDate)

-- After index key
SELECT * FROM Messages
WHERE MsgDate > '31-Dec-2011' and MsgDate < '1-Jan-2014'


-- ====================================================================
--	Problem 3.	Create the same table in MySQL
-- ====================================================================

CREATE DATABASE PartitioningDB;

USE PartitioningDB;

CREATE TABLE Messages(
  MsgId int NOT NULL AUTO_INCREMENT,
  MsgText nvarchar(300),
  MsgDate datetime,
  PRIMARY KEY (MsgId, MsgDate)
) PARTITION BY RANGE(YEAR(MsgDate)) (
    PARTITION p0 VALUES LESS THAN (1990),
    PARTITION p1 VALUES LESS THAN (2000),
    PARTITION p2 VALUES LESS THAN (2010),
    PARTITION p3 VALUES LESS THAN MAXVALUE
);

SET @count = 0;
 DELIMITER $$
 DROP PROCEDURE IF EXISTS InsertRows$$
 CREATE PROCEDURE InsertRows()
       BEGIN
		   WHILE(@count < 110000) DO
			INSERT INTO Messages(MsgText, MsgDate) VALUES
			  ('Some text', '2003-8-11'),
			  ('Some text', '1985-7-25'),
			  ('Some text', '2011-3-31'),
			  ('Some text', '1992-1-1'),
			  ('Some text', '1994-9-21'),
			  ('Some text', '2013-1-31'),
			  ('Some text', '2012-1-31'),
			  ('Some text', '2004-7-27'),
			  ('Some text', '2008-1-24');
			SET @count = @count + 1;
			END WHILE;
       END$$
   DELIMITER ;
CALL InsertRows();

SELECT * FROM Messages PARTITION (p0);
SELECT * FROM Messages PARTITION (p1);
SELECT * FROM Messages PARTITION (p2);
SELECT * FROM Messages PARTITION (p3);

-- Select count from all partitions
SELECT COUNT(*) FROM Messages;

-- Select from a single partition
SELECT * FROM Messages WHERE YEAR(MsgDate) > 2005;
