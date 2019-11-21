use AdventureWorks2017;
go

-- select this would print "2"
select 1+1;

--select is a horizontal filter here, select filters on columns, would never really actually run this
select *
from Person.Person;

--getting just the names, this just masks the things we don't need, it doesn't get rid of them
select firstname, lastname, middlename
from Person.Person;

--filtering vertically
select firstname, lastname, middlename
from Person.Person
where firstname = 'robert';

--a report for any robert and philip in our roster; the 'and' here really means 'or' in a coding point of vieww
select firstname, lastname, middlename
from Person.Person
where FirstName = 'robert' or FirstName = 'john';

--not greater than and not less than; these are the symbols for 'not'; != will run in tsql but <> will work on all sql; the 'not' keyword could also work, both of these would work the same way
select firstname, lastname, middlename
from Person.Person
where FirstName <> 'robert' and FirstName <> 'john';

select firstname, lastname, middlename
from Person.Person
where not FirstName = 'robert' and not FirstName = 'john';

--ways to find a 'robert something' or some sort of variation; 
select firstname, lastname, middlename
from Person.Person
where FirstName like '%robert%';

select firstname, lastname, middlename
from Person.Person
where FirstName like '%r%' or FirstName like 'robert_' or FirstName like 'r[aeoui]%';   --%r% any name with an r in it; r% any name that starts with r; %r any name that ends in r; %r%e starts with anything, theres an r somewhere but it ends with an e
                                                                                        --means exactly one; will give the robertos and robertas but not a robert; _robert_ has one character before robert and one character after robert
                                                                                        --without the % at the end, this would only look for re, ra, ru,ri, ro, with the % at the end, it will look for any name that has a ra, ro, ri, ru, re start 

--will take all the roberts that have the same last name and put them in the same bucket; get rid of entries that have the same first name and last name combo
select firstname, lastname
from Person.Person
where FirstName = 'robert' or FirstName = 'john'
group by FirstName, LastName;

--shows of the number of how many duplicates there were; using 'as' to give the column an alias
select count(*) as "amount of", firstname, lastname
from Person.Person
where FirstName = 'robert' or FirstName = 'john'
group by FirstName, LastName;

--i want only the groupings that have more than one robert or more than one john
select count(*) as "amount of", firstname, lastname
from Person.Person
where FirstName = 'robert' or FirstName = 'john'
group by FirstName, LastName
having count(*) > 1;

--reformatting! formatting it by last name alphabetical, and first name descending
select count(*) as "amount of", firstname, lastname
from Person.Person
where FirstName = 'robert' or FirstName = 'john'
group by FirstName, LastName
having count(*) > 1
order by lastname asc, firstname desc;



--mode(method) of execution
/*
FROM
WHERE
GROUP BY
HAVING BY
SELECT
ORDER BY
*/

--insert
select * from Person.Address; --to grab a record and copy the row into the value area

insert into Person.Address --this is terrible becuase this needs to be so specific
values ('UT', NULL, 'Arlington', 79, '76010'); --actually inserting it into the table

select *
from Person.Address
where AddressLine1 = 'UT'; 

insert into Person.Address(AddressLine1, AddressLine2, City, StateprovinceID, PostalCode, SpatialID) --this is the better way to do it becasue you dont have to match the order of the column names here versus the order of the column names in the table
values ('UT', NULL, 'Arlington', 79, '76010', NULL); --plus this way will allow anyone else to understand what each value is and where it corresponds to

--table inserts are an easier way to write multiple value lines to insert
bulk insert Person.Address from 'data.csv' with (rowterminator = '\n', fieldterminator = ',');

--update: you're going to change something that's there; use a select statement first so you know that you're doing th eright thing
select firstname
from Person.Person
where firstname = 'robert';
--then change things:
update Person.Person
set firstname = 'john'
where firstname = 'robert';
--this should be done mentally

update pp
set firstname = 'robert'
from Person.Person as pp
where pp.firstname = 'john';
--or
update pp
set firstname = 'robert'
from Person.Person as pp
where pp.LastName = 'jones';


--delete
DELETE
from Person.Person
where MiddleName is null and FirstName = 'xavier';

--join
select pp.firstname, pp.lastname, pa.AddressLine1, pa.city, pa.PostalCode
from Person.Person as pp
inner join person.BusinessEntityAddress as pbea on pbea.BusinessEntityID = pp.BusinessEntityID
inner join person.address as pa on pa.AddressID = pbea.AddressID
where pp.FirstName = 'jimmy';

select pp.firstname, pp.lastname, ppt.Name
from Person.Person as pp
inner join person.BusinessEntityAddress as pbea on pbea.BusinessEntityID = pp.BusinessEntityID
inner join person.address as pa on pa.AddressID = pbea.AddressID
inner join Sales.Customer as sc on sc.CustomerID = pp.BusinessEntityID
inner join Sales.SalesOrderHeader as ssoh on ssoh.CustomerID = sc.CustomerID
inner join Sales.SalesOrderDetail as ssod on ssod.SalesOrderID = ssoh.SalesOrderID
inner join Production.Product as ppt on ppt.ProductID = ssod.ProductID
where pp.FirstName = 'jimmy';

select pp.firstname, pp.lastname, ppt.Name
from Person.Person as pp
inner join person.BusinessEntityAddress as pbea on pbea.BusinessEntityID = pp.BusinessEntityID
inner join person.address as pa on pa.AddressID = pbea.AddressID
inner join Sales.Customer as sc on sc.CustomerID = pp.BusinessEntityID
inner join Sales.SalesOrderHeader as ssoh on ssoh.CustomerID = sc.CustomerID
inner join Sales.SalesOrderDetail as ssod on ssod.SalesOrderID = ssoh.SalesOrderID
inner join Production.Product as ppt on ppt.ProductID = ssod.ProductID
where pp.FirstName = 'jimmy' and datepart(month, ssoh.OrderDate) = 7 and ppt.Name like '%tire%';


select pp.firstname, pp.lastname, ppt.Name
from Person.Person as pp
inner join person.BusinessEntityAddress as pbea on pbea.BusinessEntityID = pp.BusinessEntityID
inner join person.address as pa on pa.AddressID = pbea.AddressID
inner join Sales.Customer as sc on sc.CustomerID = pp.BusinessEntityID
inner join 
()
    select CustomerID, salesOrderID
    from Sales.SalesOrderHeader
    where datepart(month, OrderDate) = 7   
) as ssoh on ssoh.CustomerID = sc.CustomerID
inner join Sales.SalesOrderDetail as ssod on ssod.SalesOrderID = ssoh.SalesOrderID
inner join 
(
    select productID
    from Production.Product
    where Name like '%tire%'
) as ppt on ppt.ProductID = ssod.ProductID
where pp.FirstName = 'jimmy';



with OrderHeader As
(
    select salesorderid, customerid
    from Sales.SalesOrderHeader
    where datepart(month,OrderDate) = 7
),
product as
(
    select productid, name
    from Production.Product
    where Name like '%tire%'
)
select pp.firstname, pp.lastname, ppt.name
from person.person as pp
inner join person.BusinessEntityAddress as pbea on pbea.BusinessEntityID = pp.BusinessEntityID
inner join person.address as pa on pa.AddressID = pbea.AddressID
inner join Sales.Customer as sc on sc.CustomerID = pp.BusinessEntityID
inner join Sales.SalesOrderHeader as ssoh on ssoh.CustomerID = sc.CustomerID
inner join Sales.SalesOrderDetail as ssod on ssod.SalesOrderID = ssoh.SalesOrderID
inner join Production.Product as ppt on ppt.ProductID = ssod.ProductID
where pp.FirstName = 'jimmy';


--let me know all of the first names that are last names
select pp1.firstname, pp2.lastname
from Person.Person as pp1
inner join Person.Person as pp2 on pp2.LastName = pp1.FirstName;

--same thing
select firstname
from Person.Person
UNION
SELECT lastname
from Person.Person;
