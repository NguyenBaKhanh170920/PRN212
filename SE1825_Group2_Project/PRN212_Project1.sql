--Create database PRN212_Project
--Use PRN212_Project

--Use master
-- alter database PRN212_Project set single_user with rollback immediate
-- drop database PRN212_Project

CREATE TABLE [User](
	id INT NOT NULL IDENTITY(1,1),
	Role INT NOT NULL,
	fullName NVARCHAR(50) DEFAULT NULL,
	Password NVARCHAR(50),
	Address VARCHAR(200),
);
ALTER TABLE [User] ADD CONSTRAINT pk_userId PRIMARY KEY(id);
CREATE TABLE Book (
	id INT NOT NULL IDENTITY(1, 1),
	title NVARCHAR(50) NOT NULL,
	Quantity INT NOT NULL,
	publisher VARCHAR(20),
	Price INT,
	categoryId int NOT NULL,
);
ALTER TABLE Book ADD CONSTRAINT pk_bookId PRIMARY KEY(id);
CREATE TABLE BorrowRecord (
	id INT NOT NULL IDENTITY(1, 1),
	bookId INT NOT NULL,
	borrowerId INT NOT NULL,
	startDate DATETIME NOT NULL,
	endDate DATETIME,
	returnDate DATETIME,
	quantity INT NOT NULL,
	status VARCHAR(20) NOT NULL
);
ALTER TABLE BorrowRecord ADD CONSTRAINT pk_brId PRIMARY KEY(id);
ALTER TABLE BorrowRecord ADD CONSTRAINT fk_borrowerId FOREIGN KEY(borrowerId) REFERENCES [User](id);
ALTER TABLE BorrowRecord ADD CONSTRAINT fk_bookBorrowId FOREIGN KEY(bookId) REFERENCES Book(id);
CREATE TABLE Category (
	id INT NOT NULL IDENTITY(1, 1),
	Name NVARCHAR(50),
);
ALTER TABLE Category ADD CONSTRAINT pk_cateId PRIMARY KEY(id);
ALTER TABLE Book ADD CONSTRAINT fk_categoryId FOREIGN KEY(categoryId) REFERENCES Category(id);

INSERT INTO Category
VALUES ('Novel'),('Science fiction'),('Romance');
--select*from Category
INSERT INTO [User]
VALUES (0,'admin1','123','Ha Noi'),(1,'user1','123','Ho Chi Minh'),(1,'user2','123','Nha Trang')
--0 la admin, 1 la staff
--select*from [User]
INSERT INTO Book
VALUES ('Book ABC', 5, 'Publisher XYZ', 1000, 1),('Book X', 5, 'Publisher No2', 2000, 2),
 ('Book Y', 5, 'Publisher No2', 3000, 1),('Book Z', 5, 'Publisher OldTime', 500, 3);
--select*from Book