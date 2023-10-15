
use assignment2

--Write a T-SQL Program to find the factorial of a given number.
begin
declare @fact int=1,@i int =1 ,@n int=7
while(@i<=@n)
begin
 set @fact=@fact*@i
 set @i=@i+1
 end
 print 'factorial of the given number is'+' '+cast(@fact as varchar(15))
 end

-- Create a stored procedure to generate multiplication tables up to a given number.

create or alter proc getmul  @Mul int
as
begin
    declare @r int = 1;
    declare @c int;

    while @r <= @mul
    begin
        set @c = 1;
        while @c <= @mul
        begin
            --To Calculate and display the product
            PRint @r * @c;
            set @c = @c + 1;
        end

        --To Move to the next row
        set @r = @r + 1;
    end
end

execute getmul @mul =7

--3. Create a trigger to restrict data manipulation on EMP table during General holidays.
--Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali",
--you cannot manupulate" 

create table holiday
(holiday_date Date Primary Key, holiday_name varchar(30));
insert into holiday values
('24-oct-2023','Dussehra'),
('27-nov-2023','Diwali'),
('25-dec-2023','Christmas'),
('15-aug-2023','Independence Day')

Create trigger RestrictDataMani
ON Emp
FOR INSERT, UPDATE, DELETE 
AS 
begin    
declare @holiday_name VARCHAR(50), @holiday_date DATE
set @holiday_date = CONVERT(DATE, GETDATE())
select @holiday_name = holiday_name     
from Holiday  
where holiday_date = @holiday_date 
If @holiday_name IS NOT NULL     
begin       
ROLLBACK TRANSACTION        
RAISERROR('Due to %s, you cannot manipulate data', 16, 1, @holiday_name)     
end
end 

insert into Emp values(7232,'VEENA','analyst',7826,'2012-07-24',3400,1000,10);


delete from emp where empno=7369
update Emp
set sal = sal*1.10;

select *from emp

