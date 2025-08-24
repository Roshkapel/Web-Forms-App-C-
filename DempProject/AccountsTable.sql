CREATE TABLE [dbo].[AccountsTable]
(
	[AccountNo] INT NOT NULL PRIMARY KEY, 
    [AccountHolder] INT NOT NULL, 
    [HolderAddress] NVARCHAR(50) NOT NULL, 
    [PremiseNo] NVARCHAR(50) NOT NULL, 
    [Balance] FLOAT NOT NULL, 
    [CurrentCharges] FLOAT NOT NULL, 
    [AmountDue] FLOAT NOT NULL, 
    [DueDate] DATE NOT NULL, 
    [PaymentDue] DATE NOT NULL
)
