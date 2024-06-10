ALTER TABLE Users
ADD Points INT DEFAULT 0, -- Default to 0 if not specified
    UsedVoucher NVARCHAR(MAX) DEFAULT '', -- Default to empty string if not specified
    Password NVARCHAR(100) NOT NULL; -- Assuming this is a required field
