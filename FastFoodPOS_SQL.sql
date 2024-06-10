CREATE DATABASE FastFoodPOS;

USE FastFoodPOS;

CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Birthdate DATE,
    Gmail NVARCHAR(100),
    Gender NVARCHAR(10)
);

CREATE TABLE Orders (
    OrderId INT PRIMARY KEY IDENTITY,
    UserId INT,
    OrderDate DATETIME,
    TotalAmount DECIMAL(18, 2),
    FOREIGN KEY (UserId) REFERENCES Users(Id)
);

CREATE TABLE Payments (
    PaymentId INT PRIMARY KEY IDENTITY,
    OrderId INT,
    PaymentMethod NVARCHAR(50),
    PaymentDate DATETIME,
    Amount DECIMAL(18, 2),
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId)
);
CREATE TABLE Food (
    FoodId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    Price DECIMAL(10, 2) NOT NULL,
    Category NVARCHAR(50)
);
ALTER TABLE Food ADD Size NVARCHAR(10) NULL;

-- Update existing rows to have NULL size (since they are not beverages or sides)
UPDATE Food SET Size = NULL WHERE Category IN ('Main Course', 'Dessert');
UPDATE Food SET Size = NULL WHERE Category IN ('Combo');

INSERT INTO Food (Name, Description, Price, Category, Size) VALUES
('King Burger', 'A delicious two-beef burger', 79000, 'Main Course', NULL),
('Standard Beef Burger', 'A delicious beef burger', 59000, 'Main Course', NULL),
('Standard Chicken Burger', 'A delicious chicken burger', 59000, 'Main Course', NULL),
('Spicy Fried Chicken', 'A delicious fried chicken', 39000, 'Main Course', NULL),
('Normal Fried Chicken', 'A delicious fried chicken', 39000, 'Main Course', NULL),
('Fried Chicken Box', '6 delicious fried chicken', 140000, 'Main Course', NULL),
('Korea sauced Fried Chicken', 'A delicious fried chicken', 43000, 'Main Course', NULL),
('Fries', 'Crispy french fries (Small)', 19000, 'Side', 'S'),
('Fries', 'Crispy french fries (Medium)', 29000, 'Side', 'M'),
('Fries', 'Crispy french fries (Large)', 39000, 'Side', 'L'),
('Coke', 'Refreshing cola drink (Small)', 19000, 'Beverage', 'S'),
('Coke', 'Refreshing cola drink (Medium)', 25000, 'Beverage', 'M'),
('Coke', 'Refreshing cola drink (Large)', 30000.00, 'Beverage', 'L'),
('Orange', 'Refreshing orange drink (Small)', 19000, 'Beverage', 'S'),
('Orange', 'Refreshing orange drink (Medium)', 25000, 'Beverage', 'M'),
('Orange', 'Refreshing orange drink (Large)', 30000.00, 'Beverage', 'L'),
('Sprite', 'Refreshing sprite drink (Small)', 19000, 'Beverage', 'S'),
('Sprite', 'Refreshing sprite drink (Medium)', 25000, 'Beverage', 'M'),
('Sprite', 'Refreshing sprite drink (Large)', 30000.00, 'Beverage', 'L'),
('Chicken Nuggets', 'Juicy chicken nuggets', 44000.50, 'Main Course', NULL),
('Salad', 'Fresh garden salad', 33000, 'Side', NULL),
('Ice Cream', 'Creamy vanilla ice cream', 10000, 'Dessert', NULL),
('Tea', 'Hot green tea (Small)', 29000, 'Beverage', 'S'),
('Tea', 'Hot green tea (Medium)', 35000, 'Beverage', 'M'),
('Tea', 'Hot green tea (Large)', 40000, 'Beverage', 'L'),
('Apple Pie', 'Classic apple pie slice', 3.75, 'Dessert', NULL),
('Combo 1', 'Burger, Fries (M), and Coke (M)', 99000, 'Combo', NULL),
('Combo 2', 'Chicken Nuggets, Fries (M), and Tea (M)', 119000, 'Combo', NULL),
('Combo 3', 'Spicy Fried Chicken, Fries (M), and Tea (M)', 119000, 'Combo', NULL);