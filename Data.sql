CREATE DATABASE TheRelaxingKoala
GO

USE TheRelaxingKoala
GO

-- Table
-- MenuItems
-- MenuItemCategory
-- Invoice
-- InvoiceItems
-- Order
-- Account
-- Reservation


-- Creating the tables
CREATE TABLE TableList
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'No name',
	stats NVARCHAR(100) NOT NULL DEFAULT N'Vacant', -- Occupied | Vacant | Reserved |
)
GO

CREATE TABLE Account
(
	username NVARCHAR(100) PRIMARY KEY,
	displayName NVARCHAR(100) NOT NULL DEFAULT N'Admin',
	password NVARCHAR(1000) NOT NULL DEFAULT 1,
)
GO

CREATE TABLE MenuItemCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'No name',
)
GO

CREATE TABLE MenuItems
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'No name',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY (idCategory) REFERENCES MenuItemCategory(id)
)
GO

ALTER TABLE MenuItems ADD keyword NVARCHAR(100) NOT NULL
GO

CREATE TABLE Invoice
(
	id INT IDENTITY PRIMARY KEY,
	idTable INT NOT NULL,
	stats INT NOT NULL -- 1: paid && 0: not paid

	FOREIGN KEY (idTable) REFERENCES TableList(id)
)
GO

ALTER TABLE Invoice 
ADD dateCheckin DATETIME NOT NULL DEFAULT GETDATE(), dateCheckOut DATETIME NOT NULL,  totalPrice FLOAT

CREATE TABLE InvoiceItems
(
	id INT IDENTITY PRIMARY KEY,
	idInvoice INT NOT NULL,
	idMenuItem INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idInvoice) REFERENCES Invoice(id),
	FOREIGN KEY (idMenuItem) REFERENCES MenuItems(id)
)
GO

CREATE TABLE Reservations
(
	id INT IDENTITY PRIMARY KEY,
	idTable INT NOT NULL,
	customerName NVARCHAR(100) NOT NULL,
	customerPhone NVARCHAR(100) NOT NULL,
	date DATETIME NOT NULL,
	time NVARCHAR(100) NOT NULL,
	seats INT NOT NULL,
	email NVARCHAR(100) DEFAULT ''

	FOREIGN KEY (idTable) REFERENCES TableList(id)
)
GO

ALTER TABLE Reservations ALTER COLUMN date NVARCHAR(100) NOT NULL
GO

-- Procedure to get list of accounts by username
CREATE PROC USP_GetListAccountByUserName
@username nvarchar(100)
AS
BEGIN
	SELECT * FROM Account WHERE username = @username
END
GO

-- Procedure to Login
CREATE PROC USP_Login
@username nvarchar(100), @password nvarchar(100)
AS
BEGIN
	SELECT * FROM Account WHERE username = @username AND password = @password
END
GO

-- Add table
DECLARE @i INT = 1

WHILE @i <= 10
BEGIN
	INSERT TableList (name) VALUES (N'Table ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END

SELECT * FROM TableList
GO

-- Procedure to get table list
CREATE PROC USP_GetTableList
AS SELECT * FROM TableList
GO

-- Add categories
INSERT MenuItemCategory (name) VALUES (N'Main Courses')
INSERT MenuItemCategory (name) VALUES (N'Drinks')
GO


-- Add menu items
INSERT MenuItems (name, idCategory, price, keyword) VALUES (N'Traditional Cheese Pizza', 1, 16.76, N'cheese pizza')
INSERT MenuItems (name, idCategory, price, keyword) VALUES (N'Traditional Pepperoni Pizza', 1, 17.99, N'pepperoni pizza')
INSERT MenuItems (name, idCategory, price, keyword) VALUES (N'Spaghetti Bolognese', 1, 7.99, N'bolognese')
INSERT MenuItems (name, idCategory, price, keyword) VALUES (N'Latte', 2, 3.25, N'latte')
INSERT MenuItems (name, idCategory, price, keyword) VALUES (N'Cappuccino', 2, 4.5, N'cappuccino')
INSERT MenuItems (name, idCategory, price, keyword) VALUES (N'Espresso', 2, 3.5, N'espresso')
GO

-- Procedure to get Invoices with tableId and Stats
CREATE PROC USP_GetInvoice
@idTable INT, @stats INT
AS
BEGIN
	SELECT * FROM Invoice WHERE idTable = @idTable AND stats = @stats
END
GO

-- Procedure to Insert new invoice
CREATE PROC USP_InsertInvoice
@idTable INT
AS
BEGIN
	INSERT Invoice (idTable, stats, dateCheckIn, dateCheckOut) VALUES (@idTable, 0, GETDATE(), NULL)
END
GO

-- Procedure to Insert new invoice items
CREATE PROC USP_InsertInvoiceItem
@idInvoice INT, @idMenuItem INT, @count INT
AS
BEGIN
	DECLARE @isExistedInvoiceItem INT
	DECLARE @quantity INT = 1

	SELECT @isExistedInvoiceItem = id, @quantity = iItems.count 
	FROM InvoiceItems AS iItems 
	WHERE idInvoice = @idInvoice AND idMenuItem = @idMenuItem

	IF(@isExistedInvoiceItem > 0)
	BEGIN
		DECLARE @newQuantity INT = @quantity + @count

		IF (@newQuantity > 0)
			UPDATE InvoiceItems SET count = @quantity + @count
		ELSE 
			DELETE InvoiceItems WHERE idInvoice = @idInvoice AND idMenuItem = @idMenuItem
	END
	ELSE
	BEGIN
		IF (@count > 0)
			INSERT InvoiceItems (idInvoice, idMenuItem, count) VALUES (@idInvoice, @idMenuItem, @count)
	END
END
GO

-- Trigger to change the status of the tables
CREATE TRIGGER UTG_UpdateInvoiceItems
ON InvoiceItems FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idInvoice INT

	SELECT @idInvoice = idInvoice from Inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM Invoice WHERE id = @idInvoice AND stats = 0 

	UPDATE TableList SET stats = N'Occupied' WHERE id = @idTable
END
GO
CREATE TRIGGER UTG_UpdateInvoice
ON Invoice FOR UPDATE
AS
BEGIN
	DECLARE @idInvoice INT

	SELECT @idInvoice = id FROM Inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM Invoice WHERE id = @idInvoice

	DECLARE @count INT = 0

	SELECT @count = COUNT(*) FROM Invoice WHERE idTable = @idTable AND stats = 0

	IF (@count = 0) 
		UPDATE TableList SET stats = N'Vacant' WHERE id = @idTable
END
GO
CREATE TRIGGER UTG_DeleteInvoiceItems
ON InvoiceItems FOR DELETE
AS
BEGIN
	DECLARE @idInvoiceItem INT
	DECLARE @idInvoice INT
	SELECT @idInvoiceItem = deleted.id, @idInvoice = deleted.idInvoice FROM deleted

	DECLARE @idTable INT
	SELECT @idTable = idTable FROM Invoice WHERE id = @idInvoice

	DECLARE @count INT
	SELECT @count = COUNT(*) FROM InvoiceItems as iItems, Invoice as i WHERE i.id = iItems.idInvoice AND i.id = @idInvoice AND i.stats = 0

	IF (@count >= 0) 
	BEGIN
		UPDATE TableList SET stats = N'Vacant' WHERE id = @idTable
	END
END
GO
CREATE TRIGGER UTG_InsertReservation
ON Reservations AFTER INSERT
AS
BEGIN
	DECLARE @currentDate DATE = CAST(GETDATE() as DATE)

	DECLARE @idTable INT 
	SELECT @idTable = idTable FROM inserted

	DECLARE @reserveDate DATETIME
	SELECT @reserveDate = r.date FROM Reservations as r WHERE idTable = @idTable

	UPDATE TableList SET stats = N'Reserved' FROM TableList as t, Reservations as r WHERE t.id = @idTable AND r.idTable = t.id AND CAST(r.date AS DATE) = @currentDate
END
GO
CREATE TRIGGER UTG_DeleteReservation
ON Reservations FOR DELETE
AS
BEGIN
	DECLARE @currentDate DATE = CAST(GETDATE() as DATE)
	DECLARE @idTable INT
	SELECT @idTable = deleted.idTable from deleted

	DECLARE @reserveDate DATETIME
	SELECT @reserveDate = date FROM deleted WHERE idTable = @idTable

	if (CAST(@reserveDate AS DATE) = @currentDate)
		UPDATE TableList SET stats = N'Vacant' FROM TableList as t WHERE t.id = @idTable
END
GO


-- Procedure to get invoices by date
CREATE PROC USP_GetListOfInvoiceByDate
@dateCheckIn DATE, @dateCheckOut DATE
AS
BEGIN
	SELECT tb.name as [Table], i.totalPrice as [Total], dateCheckIn as [Check In], dateCheckOut as [Check Out]
	FROM Invoice as i, TableList as tb
	WHERE dateCheckIn >= @dateCheckIn AND dateCheckOut <= @dateCheckOut AND i.stats = 1
	AND tb.id = i.idTable 
END
GO

-- Procedure to check the current password by username
CREATE PROC USP_CheckPasswordByUsername
@username nvarchar(100)
AS
BEGIN
	SELECT password FROM Account WHERE username = @username
END
GO

-- Procedure to update password
CREATE PROCEDURE USP_UpdatePassword
    @username NVARCHAR(100),
    @newPassword NVARCHAR(100) 
AS
BEGIN
    UPDATE Account
    SET password = @newPassword
    WHERE username = @username;
END
GO

-- Procedure to change the display name of a username
CREATE PROC USP_ChangeDisplayName
@username nvarchar(100), @displayName nvarchar(100)
AS
BEGIN
	UPDATE Account SET displayName = @displayName WHERE username = @username
END
GO

-- Procedure to add accounts
CREATE PROC USP_AddAccount
@username nvarchar(100), @displayName nvarchar(100)
AS
BEGIN
	INSERT INTO Account (username, displayName, password) VALUES (@username, @displayName, N'1962026656160185351301320480154111117132155')
END
GO

-- Procedure to delete accounts
CREATE PROC USP_DeleteAccount
@username nvarchar(100)
AS
BEGIN
	DELETE Account WHERE username = @username
END
GO

-- Procedure to obtain list of menu items with alternative names for displaying
CREATE PROC USP_GetListOfMenuItems
AS 
BEGIN
	SELECT mItems.id AS [ID],
			mItems.name AS [Name],
			mItems.idCategory AS [Category],
			mItems.price AS [Price],
			mItems.keyword AS [Keyword]
	FROM MenuItems AS mItems;
END
GO

SELECT * FROM Account
SELECT * FROM Invoice
SELECT * FROM InvoiceItems
SELECT * FROM MenuItemCategory
SELECT * FROM MenuItems
SELECT * FROM TableList
SELECT * FROM Reservations








