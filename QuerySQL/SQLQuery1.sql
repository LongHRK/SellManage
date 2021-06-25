Create database SellManage;
GO
USE SellManage;
GO
Create table tblMaterial(
	IDMaterial nVarchar(20) Not null,
	NameMaterial nVarchar(250) Not null,
	Primary key clustered (IDMaterial ASC)
);
GO
Create table tblCustomer(
	IDCustomer nVarchar(20) Not null,
	NameCustomer nVarchar(250) Not null,
	AddressCustomer nVarchar(250) Not null,
	PhoneCustomer nVarchar(50) Not null,
	Primary key clustered (IDCustomer ASC)
);
GO
Create table tblItems(
	IDItems nVarchar(20) Not null,
	NameItems nVarchar(250) Not null,
	IDMaterial nVarchar(20) Not null,
	Amount Float(50) Not null,
	Billpriceimport Float(50) Not null,
	Billprice Float(50) Not null,
	Picture nVarchar(250) Not null,
	Note nVarchar(max),
	Primary key clustered (IDItems ASC),
	Constraint FK_IDM Foreign key (IDMaterial) References tblMaterial(IDMaterial)
); 
GO
Create table tblStaff(
	IDStaff nVarchar(20) Not null,
	NameStaff nVarchar(250) Not null,
	SexStaff nVarchar(10) Not null,
	AddressStaff nVarchar(250) Not null,
	PhoneStaff nVarchar(15) Not null,
	BirthdayStaff Datetime Not null,
	Primary key clustered (IDStaff ASC)
);
GO
Create table tblBillSell(
	IDBillSell nVarchar(20) Not null,
	IDStaff nVarchar(20) Not null,
	SellTime Datetime Not null,
	IDCustomer nVarchar(20) Not null,
	Total Float(50) Not null,
	Primary key clustered (IDBillSell ASC),
	Constraint FK_IDS Foreign key (IDStaff) References tblStaff(IDStaff),
	Constraint FK_IDC Foreign key (IDCustomer) References tblCustomer(IDCustomer)
);
Go
Create table tblDetailBill(
	IDBillSell nVarchar(20) Not null,
	IDItems nVarchar(20) Not null,
	Amount Float(50) Not null,
	BillPrice Float(50) Not null,
	Discount Float(50) Not null,
	TotalMoney Float(50) Not null,
	Primary key clustered (IDBillSell ASC),
	Constraint FK_IDBS Foreign key (IDBillSell) References tblBillSell(IDBillSell),
	Constraint FK_IDI Foreign key (IDItems) References tblItems(IDItems)
);