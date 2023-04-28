CREATE DATABASE SupplementFactsManagement;
GO

USE SupplementFactsManagement;
GO

CREATE TABLE WarehouseReceipt
(
  ReceiptID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  TotalWarehouseQuantity INT NOT NULL,
  TotalWarehousePrice INT NOT NULL,
  CreatedDate DATE NOT NULL,
);

CREATE TABLE Product
(
  ProductID VARCHAR(10) NOT NULL PRIMARY KEY,
  ProductName NVARCHAR(50) NOT NULL,
  ProductPrice INT NOT NULL,
  ProductQuantity INT NOT NULL,
);

CREATE TABLE Agent
(
  AgentID VARCHAR(10) NOT NULL PRIMARY KEY,
  AgentName NVARCHAR(50) NOT NULL,
);

CREATE TABLE OrderReceipt
(
  OrderID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  TotalOrderPrice INT NOT NULL,
  TotalOrderQuantity INT NOT NULL,
  OrderedDate DATE NOT NULL,
  Status NVARCHAR(50) NOT NULL,
  AgentID VARCHAR(10) NOT NULL,
  CONSTRAINT FkOrderReceipt_AgentID FOREIGN KEY (AgentID) REFERENCES Agent(AgentID) 
);

CREATE TABLE IncludeOrderProducts
(
  TotalProductQuantity INT NOT NULL,
  TotalProductPrice INT NOT NULL,
  OrderID INT NOT NULL,
  ProductID VARCHAR(10) NOT NULL,
  CONSTRAINT PkIncludeOrderProducts_OrderID_ProductID PRIMARY KEY (OrderID, ProductID),
  CONSTRAINT FkIncludeOrderProducts_OrderID FOREIGN KEY (OrderID) REFERENCES OrderReceipt(OrderID),
  CONSTRAINT FkIncludeOrderProducts_ProductID FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

CREATE TABLE IncludeImportedProducts
(
  TotalProductQuantity INT NOT NULL,
  TotalProductPrice INT NOT NULL,
  ReceiptID INT NOT NULL,
  ProductID VARCHAR(10) NOT NULL,
  CONSTRAINT PkIncludeImportedProducts PRIMARY KEY (ReceiptID, ProductID),
  CONSTRAINT FkIncludeImportedProducts_ReceiptID FOREIGN KEY (ReceiptID) REFERENCES WarehouseReceipt(ReceiptID),
  CONSTRAINT FkIncludeImportedProducts_ProductID FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

-- Add data to the product
GO
CREATE PROC spProductCreate
(
	@productId VARCHAR(10),
	@productName NVARCHAR(50),
	@productPrice INT,
	@productQuantity INT
)
AS
BEGIN
	IF EXISTS (SELECT * FROM Product p WHERE p.ProductID = @productId)
		BEGIN
			UPDATE Product
			SET ProductQuantity = ProductQuantity + @productQuantity
			WHERE ProductID = @productId
		END
	ELSE
		BEGIN
			INSERT INTO Product
			VALUES
			(@productId, @productName, @productPrice, @productQuantity)
		END
END;
GO

-- Add receipt
GO
CREATE PROC spWarehouseReceipt
(
	@totalWarehouseQuantity INT,
	@totalWarehousePrice INT,
	@createdDate DATE
)
AS
BEGIN
	INSERT INTO WarehouseReceipt
	VALUES
	(@totalWarehouseQuantity, @totalWarehousePrice, @createdDate);
	BEGIN
		SELECT SCOPE_IDENTITY()
	END
END
GO

-- Add receipt details
GO
CREATE PROC spIncludeImportedProducts
(
	@totalProductQuantity INT,
	@totalProductPrice INT,
	@receiptId INT,
	@productId VARCHAR(10)
)
AS
BEGIN
	INSERT INTO IncludeImportedProducts
	VALUES
	(@totalProductQuantity, @totalProductPrice, @receiptId, @productId);
END;
GO

INSERT INTO Product
VALUES
('P001', 'Immune++', 39000, 500),
('P002', 'Anica Phytextra', 517000, 100),
('P003', 'Multi Vitas Lab', 319000, 700),
('P004', 'Natural Vitamin E', 200000, 1000),
('P005', 'ColosMaxQ10 Gold QD-Meliphar', 158000, 700),
('P006', 'Vitamin D', 50000, 2000),
('P007', 'Vitamin F', 70000, 1500)

INSERT INTO Agent
VALUES
('A001', 'Super Fire'),
('A002', 'Super Blue'),
('A003', 'Super Yellow'),
('A004', 'Super Black'),
('A005', 'Super Green'),
('A006', 'Super Purple'),
('A007', 'Supa Hot Fire')
