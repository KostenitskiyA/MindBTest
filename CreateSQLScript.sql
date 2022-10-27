CREATE TABLE Products (
	Id INT PRIMARY KEY,
	Name varchar(MAX)
);

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	Name varchar(MAX)
);

INSERT INTO Products
VALUES
	(1, 'IPhone 13'),
	(2, 'MacBook Pro 14'),
	(3, 'IPad Air 4'),
	(4, 'IPad Mini'),
	(5, 'IPhone SE'),
	(6, 'MacBook Air'),
	(7, 'HomePod mini');

INSERT INTO Categories
VALUES
	(1, 'Notebook'),
	(2, 'Smartphone'),
	(3, 'Tablet'),
	(4, 'Accessory');

CREATE TABLE ProductsCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductsCategories
VALUES
	(2, 1),
	(6, 1),
	(1, 2),
	(5, 2),
	(3, 3),
	(4, 3);