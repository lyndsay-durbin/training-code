use AdventureWorks2017;
go

--views
create view vw_Person
as 
select firstname, lastname
from Person.Person;
GO

--select * from vw_Person;
--writing a view thsi way ^ is unsafe; if firstname or lastname column changes name, the view no longer works;
--rather write it using schema binding
alter view vw_Person with schemabinding 
AS
select firstname, lastname
FROM Person.Person;
GO

select * from vw_Person;
GO

--FUNCTION
--tabular
create function fn_Person(@first nvarchar(50))
returns table 
AS
RETURN
select firstname, lastname
from Person.Person
where FirstName = @first;
go

create function fn_FullName(@first nvarchar(50), @middle nvarchar(50), @last nvarchar(50))
returns nvarchar(152)
as 
begin 
--    return @first + ' ' + @middle + ' ' @last
    return @first + COALESCE(' ' + @middle, '', null, null) + ' ' + @last
    --if the middle name is nont null, use the middle name, if it is null then dont use it
    --RETURN @first + isnull(' ' + @middle, '') + ' ' + @last
    --same thing but this is a tsql thing
end;
go

--dbo means database owner; the current database you're in
select dbo.fn_FullName(FirstName, null, LastName) as full_name from fn_Person('joshua');
GO

--stored procedures/aka "proc" or "procedures"
--the content of a stored procedure is cached
--content isn't the code of a stored procedure, the actually results
--it won't run everytime; it will only run when the cached version is outdated

create procedure sp_InsertName(@first nvarchar(50), @middle nvarchar(50), @last nvarchar(50))
as
begin
    begin transaction
        begin try
            declare @mname nvarchar(50) = @middle

            if(@mname is null)
            begin 
                set @mname = '' 
            end

            checkpoint 
    
            insert into Person.Person(FirstName, LastName, MiddleName)
            values (@first, @last, @mname)

            commit transaction
        end try

        begin catch 
            print error_message()
            print error_line()
            print error_severity()
            print error_state()
            print error_number()
            rollback transaction
        end catch  
end;

execute sp_InsertName 'fred', null, 'belotte';
go

--triggers
create trigger tr_InsertName 
on Person.Person
instead of insert 
as
update pp
set firstname = inserted.firstname
from Person.Person as pp
where pp.BusinessEntityID = inserted.BusinessEntityID;