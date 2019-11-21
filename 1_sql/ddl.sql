use master;
GO

--create; creating a database; this is a default database, it grabbed the model database and took a copy of that
create DATABASE PizzaBox;
GO

--creating schemas
create SCHEMA "Order";
GO

create SCHEMA Account;
GO

--a column name and then a set of constraint
--tinyint: 16; probably good for toppings
--smallint: ~200
--INT: 4bill
--bigint: 
--the not so great way of connecting tables
-- create table "Order"."Order"
-- (
--     OrderId int not NULL identity(1,2) primary key
--     ,UserId int not NULL foreign key references Account.User.UserId
--     ,StoreId int not NULL --foreign key
--     ,TotalCost decimal(3,2) not NULL --foreign key
--     ,OrderDate datetime2(7) not NULL --computed
--     ,Active bit not NULL --a boolean which says whether or not something is deleted
-- );

--not so great either, but a little bit better
-- create table "Order"."Order"
-- (
--     OrderId int not NULL identity(1,2) --primary key
--     ,UserId int not NULL --foreign key
--     ,StoreId int not NULL --foreign key
--     ,TotalCost decimal(3,2) not NULL --foreign key
--     ,OrderDate datetime2(7) not NULL --computed
--     ,Active bit not NULL --a boolean which says whether or not something is deleted
--     ,CONSTRAINT PK_Order_OrderId primary key (OrderId)
--     ,Constraint FK_Order_UserId foreign key (UserId) references Account.User(UserId)
-- );

create table "Order"."Order"
(
    OrderId int not NULL identity(1,2) --primary key
    ,UserId int not NULL --foreign key
    ,StoreId int not NULL 
    ,TotalCost decimal(3,2) not NULL 
    ,OrderDate datetime2(7) not NULL --checked
    ,Active bit not NULL --a boolean which says whether or not something is deleted
);

create table "Order"."OrderPizza" --proxy table for order.order and order.pizza
(
    OrderPizzaId int not null IDENTITY(1,2)
    ,OrderId int not NULL
    ,PizzaId int not NULL
)

create table "Order".Pizza
(
    PizzaId int not NULL identity(1,2) --primary key
    ,SizeId int not NULL 
    ,CrustId int not NULL 
    ,Price decimal(3,2) not NULL
    ,Active bit not NULL
);

--best way to control the proxy table connecting:
--allows you to add whatever constraints whenever you need to rather than setting up keys throughout the tables
alter table "Order"."Order"
    add CONSTRAINT PK_Order_OrderId primary key (OrderId);
alter table "Order"."OrderPizza"
    add constraint PK_OrderPizza_OrderId primary key (OrderPizzaId);
alter table "Order"."Pizza"
    add constraint PK_Pizza_PizzaId primary key (PizzaId);

alter table "Order"."OrderPizza"
    add constraint FK_OrderPizza_OrderId foreign key (OrderId) references "Order"."Order"(OrderId);
alter table "Order"."OrderPizza"
    add constraint FK_OrderPizza_PizzaId foreign key (PizzaId) references "Order"."Pizza"(PizzaId);

alter table "Order"."Order"
    add constraint DF_Order_Active default (1) for Active;
alter table "Order"."Pizza"
    add constraint DF_Pizza_Active default (1) for Active;

--god example of checked constraint
alter table "Order"."Order"
    add CONSTRAINT CK_Order_OrderDate check (OrderDate > '2019-11-11');
--bad example of checked constriant
alter table "Order.Order"
    add CONSTRAINT CK_Order_TotalCost check (TotalCost < 500);

alter table "Order"."Order"
    drop constraint CK_Order_TotalCost;
alter table "Order"."Order"
    add TipAmount decimal(2,2) null;
alter table "Order"."Order"
    drop column TipAmount;


--drop: delete stuff, get rid of information and all the structures of that information
drop table "Order"."OrderPizza";

--truncate: a drop could be recovered from an audit/backup by the dba; a truncate cannot come back with the info but it can come back with the structure
truncate table "Order"."OrderPizza";




