CREATE DATABASE McDonalds

CREATE TABLE Orders
(
OrderID int PRIMARY KEY NOT NULL IDENTITY (1,1),
NumBurger int,
NumChips int,
NumNuggets int,
NumDrinks int,
TotalPrice int,
)

INSERT INTO Orders VALUES 

(1,2,4,5,450),
(4,4,10,6,230),
(3,6,1,5,423),
(4,5,9,4,274)

SELECT * FROM Orders
