use master;
GO

create database PizzaBox;
GO

create schema "Account";
go 

create schema "Address";
go 

create schema "Order";
GO

create schema "Store";
go 

create schema "Pizza";
GO

create table "Account"."User"
(
    UserID int not null identity(1,2) --pk
    , FirstName nvarchar not NULL
    , LastName nvarchar not NULL
    , UserTypeID int not null --fk
    , AddID int not null --fk
);

alter table "Account"."User"
    add constraint PK_User_UserID primary key (UserID);

create table "Account"."UserType"
(
    UserTypeID int not null identity(1,2) --pk
    , UserType nvarchar not null --customer/manager, if not specified default to customer
);

alter table "Account"."UserType"
    add constraint PK_UserType_UserTypeID primary key (UserTypeID);

create table "Account"."Account"
(
    AccountID int not null identity(1,2) --pk
    , UserName nvarchar not NULL
    , Passw nvarchar not NULL
    , UserAccID int not null --fk
);

alter table "Account"."Account"
    add constraint PK_Account_AccountID primary key (AccountID);

create table "Account"."UserAccount"
(
    UserAccID int not null identity(1,2)
    , UserID int not null --fk
    , AccountID int not null --fk
);

alter table "Account"."UserAccount"
    add constraint PK_UserAccount_UserAccID primary key (UserAccID);

create table "Address"."Address"
(
    AddID int not null identity(1,2) --pk
    , Street nvarchar not NULL
    , AddType nvarchar not null
);

alter table "Address"."Address"
    add constraint PK_Address_AddID primary key (AddID);

create table "Store"."Store"
(
    StoreID int not null identity(1,2) --pk
    , StoreName nvarchar not NULL
    , Sales decimal(6,2) not NULL
    , AddID int not null --fk
);

alter table "Store"."Store"
    add constraint PK_Store_StoreID primary key (StoreID);

create table "Store"."StoreEmploy"
(
    EmployID int not null identity(1,2) --pk
    , EmployTypeID int not null --fk
    , StoreID int not null --fk
    , UserID int not null --fk
);

alter table "Store"."StoreEmploy"
    add constraint PK_StoreEmploy_EmployID primary key (EmployID);

create table "Store"."EmployType"
(
    EmployTypeID int not null identity(1,2) --pk
    , EmployType nvarchar not null --manager,employee
);

alter table "Store"."EmployType"
    add constraint PK_EmployType_EmployTypeID primary key (EmployTypeID);

create table "Order"."Order"
(
    OrderID int not null identity(1,2) --pk
    , UserID int not null --fk
    , StoreID int not null --fk
    , TotalCost decimal(3,2) not null 
    , OrderDate datetime2(7) not null --checked
    , Active bit not null --boolean checking whether or not its deleted
    --, OrderPizzaID int not null --fk
);

alter table "Order"."Order"
    add constraint PK_Order_OrderID primary key (OrderID);

create table "Order"."Pizza"
(
    PizzaID int not null identity(1,2) --pk
    , SizeID int not null 
    , CrustID int not null
    , PresetID int not NULL
    , Price decimal(3,2) not NULL
    , Active bit not null 
);

alter table "Order"."Pizza"
    add constraint PK_Pizza_PizzaID primary key (PizzaID);

create table "Order"."OrderPizza"
(
    OrderPizzaID int not null identity(1,2) --pk
    , OrderID int not null --fk
    , PizzaID int not null --fk
);

alter table "Order"."OrderPizza"
    add constraint PK_OrderPizza_OrderPizzaID primary key (OrderPizzaID);


--setting up the connections
alter table "Order"."OrderPizza"
    add constraint FK_OrderPizza_OrderID foreign key (OrderID) references "Order"."Order"(OrderID);
alter table "Order"."OrderPizza"
    add constraint FK_OrderPizza_PizzaID foreign key (PizzaID) references "Order"."Pizza"(PizzaID);

alter table "Order"."Order"
    add constraint FK_Order_UserID foreign key (UserID) references "Account"."User"(UserID);
alter table "Order"."Order"
    add constraint FK_Order_StoreID foreign key (StoreID) references "Store"."Store"(StoreID);

alter table "Store"."StoreEmploy"
    add constraint FK_StoreEmploy_EmployTypeID foreign key (EmployTypeID) references "Store"."EmployType"(EmployTypeID);
alter table "Store"."StoreEmploy"
    add constraint FK_StoreEmploy_StoreID foreign key (StoreID) references "Store"."Store"(StoreID);
alter table "Store"."StoreEmploy"
    add constraint FK_StoreEmploy_UserID foreign key (UserID) references "Account"."User"(UserID);

alter table "Store"."Store"
    add constraint FK_Store_AddID foreign key (AddID) references "Address"."Address"(AddID);

alter table "Account"."UserAccount"
    add constraint FK_UserAccount_UserID foreign key (UserID) references "Account"."User"(UserID);
alter table "Account"."UserAccount"
    add constraint FK_UserAccount_AccountID foreign key (AccountID) references "Account"."Account"(AccountID);

alter table "Account"."Account"
    add constraint FK_Account_UserAccID foreign key (UserAccID) references "Account"."UserAccount"(UserAccID);

alter table "Account"."User"
    add constraint FK_User_UserTypeID foreign key (UserTypeID) references "Account"."UserType"(UserTypeID);
alter table "Account"."User"
    add constraint FK_User_AddID foreign key (AddID) references "Address"."Address"(AddID);


alter table "Order"."Order"
    add constraint CK_Order_OrderDate check (OrderDate > '2019-11-20');
alter table "Order"."Pizza"
    add constraint CK_Pizza_Price check (Price < 10);

alter table "Order"."Pizza"
    add constraint DF_Pizza_Active default (1) for Active;
alter table "Order"."Order"
    add constraint DF_Order_Active default (1) for Active;