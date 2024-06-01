create table users
(
userID int primary key identity,
username varchar(50) not null,
upass varchar(10) not null,
uName varchar(50) not null,
uphone varchar(20)
)

insert into users values('admin', 123, 'User-1', '3143-4501')

USE RM;


create table category(

catID int primary key identity,
catName varchar(50)

)

create table tables(
tid int primary key identity,
tname varchar(15)

)

create table staff(
staffID int primary key identity,
sName varchar(50),
sPhone varchar(50),
sRole varchar(50)
)

create table products(
pID int primary key identity,
pName varchar(50),
pPrice float,
CategoryID int,
pImage image
)

select pID,pName,pPrice,CategoryID,catName from products p inner join category c on c.catID = p.CategoryID


INSERT INTO staff (sName, sPhone, sRole)
VALUES ('Cristofer', '123-456-7890', 'Waiter');


DROP TABLE category;


