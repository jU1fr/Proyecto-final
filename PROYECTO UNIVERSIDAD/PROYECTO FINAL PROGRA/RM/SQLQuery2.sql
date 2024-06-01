
USE RM;

Create table tblMain
(
MainID int primary key identity,
aDate date,
aTime varchar(15),
TableName varchar(10),
WaiterName varchar(15),
status varchar(15),
orderType varchar(15),
total float,
received float,
change float
)


Create Table tblDetails
(
DetailID int primary key identity,
MainID int,
proID int,
qty int,
price float,
amount float,
)

truncate table tblDetails;
truncate table tblMain;


select * from tblMain m
inner join tblDetails d on m.MainID = d.MainID

DROP TABLE tblMain


SELECT 
    m.MainID,
    m.aDate,
    m.aTime,
    m.TableName,
    m.WaiterName,
    m.status,
    m.orderType,
    m.total,
    m.received,
    m.change,
    d.DetailID,
    d.proID,
    p.pName,
    d.qty,
    d.price,
    d.amount
FROM 
    tblMain m
INNER JOIN 
    tblDetails d ON m.MainID = d.MainID
INNER JOIN 
    products p ON d.proID = p.pID
WHERE 
    m.status = 'Pending';
