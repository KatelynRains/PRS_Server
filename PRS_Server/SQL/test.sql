use PrsDb;
--user data
INSERT into Users (Username, Password, Firstname, Lastname, Phone, Email, IsReviewer, IsAdmin)

VALUES('krains', 'password1','Katelyn', 'Rains', '952-738-1597', 'krains@uwalumni.com', 1, 1);
go
 
Insert into Vendors (Code, Name, Address, City, State, Zip, PHone, Email)
VALUES('AMAZ', 'Amazon', '1 Amazon Way', 'Seattle', 'WA', '911', 'info@amazon.com');
go

declare @amazon varchar(10);
Select @amazon = Id from Vendors where Code = 'AMAZ';
Insert into Products (PartNbr, Name, Price, Unit, Photopath, VendorId)
VALUES ('ECHO', 'Amazon Echo', 100, 'Each', null, @amazon);
go