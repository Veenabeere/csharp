create database codetest
--a. Create a table called Code_Employee(empno int primary key,
 --empname varchar(35), (is a required field)
 -- empsal numeric(10,2) - (check empsal >=25000)
 -- emptype char(1) ) (either 'F' for fulltime or 'P' part time) (Empty Table)
 create table Code_employee(
 empno int primary key,
 empname varchar(35),
 empsal decimal(10,2) check (empsal >=25000),
 emptype char(1))


   --Create a stored procedure to add new employee records. The procedure should accept all the employee details
   --as input parameters, except empno. Generate the new employee no in the procedure and then insert the record
   create  or alter procedure Addnewemp(
    @empname varchar(25),
    @empsal decimal(10, 2),
    @emptype char(1))
	as
	begin
	declare @new_empno int;
   select @new_empno=isnull(max(empno),0)+1 from Code_employee
    INSERT INTO Code_employee(empno, empname,empsal, emptype)
    VALUES(@new_empno, @empname, @empsal, @emptype)
	

select * from Code_employee where empno=@new_empno


end
select *from Code_employee

--2nd
--used assignment2 database

DECLARE @empno NUMERIC(4);

DECLARE @sal INT;
DECLARE employee_cursors CURSOR FOR

SELECT empno, sal

FROM emp

WHERE deptno = 10;
OPEN employee_cursors;
FETCH NEXT FROM employee_cursors INTO @empno, @sal;
WHILE @@FETCH_STATUS = 0

BEGIN
 UPDATE emp

    SET sal= sal * 1.15

    WHERE empno = @empno;
 FETCH NEXT FROM employee_cursors INTO @empno, @sal;

END
CLOSE employee_cursors;

DEALLOCATE employee_cursors;
SELECT * FROM Emp WHERE deptno = 10;


    
  
   

   
 

 
 
