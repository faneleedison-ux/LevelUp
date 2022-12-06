
CREATE TABLE Customers (
    CustomerID uniqueidentifier PRIMARY KEY default newid(),
    FirstName varchar(255),
  	LastName varchar(255),
    UserName varchar(255),
    EmailAddress varchar(255),
  	DateOfBirth date,
  	Age int,
  	DateCreated datetime,
  	DateEdited timestamp,
  	IsDeleted varchar(255)
);


