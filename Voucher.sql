CREATE TABLE Vouchers (
    VoucherId INT IDENTITY(1,1) PRIMARY KEY,
    VoucherCode NVARCHAR(50) UNIQUE,
    Valuess INT,
    Description NVARCHAR(255)
);

-- Insert predefined vouchers
INSERT INTO Vouchers (VoucherCode, Valuess, Description) VALUES
('BUY100K_GET10K', 10000, 'Buy 100000 VND get 10000 VND discount'),
('BUY150K_GET15K', 15000, 'Buy 150000 VND get 15000 VND discount'),
('BUY200K_GET30K', 30000, 'Buy 200000 VND get 30000 VND discount'),
('COMBO_GET_ICECREAM', 10000, 'Buy two foods in combo category, get one ice cream for free'),
('BUY50K_GET5K', 5000, 'Buy 50000 VND get 5000 VND discount');

CREATE TABLE UserVouchers (
    UserVoucherId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT,
    VoucherId INT,
    FOREIGN KEY (UserId) REFERENCES Users(Id),
    FOREIGN KEY (VoucherId) REFERENCES Vouchers(VoucherId),
    UsedDate DATETIME
);
