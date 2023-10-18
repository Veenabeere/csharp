select *from emp

 
create or alter procedure empPayslip (@empno int)
as
begin
declare @SAL decimal
declare @HRA decimal
declare @DA decimal
declare @PF decimal
declare @IT decimal
declare @DEDUCTIONS decimal
declare @GROSS_sal decimal
declare @NET_sal decimal
 
select @SAL = sal from emp where empno = @empno
-- a)	HRA  as 10% Of sal
select @HRA = @sal * 0.10
--b)	DA as  20% of sal
select @DA = @sal * 0.20
--c)	PF as 8% of sal
select @PF = @sal * 0.08
--d)	IT as 5% of sal
select @IT = @sal * 0.05
 
--e)	Deductions as sum of PF and IT
select @DEDUCTIONS = @PF + @IT
 
--f)	Gross Salary as sum of SAL,HRA,DA 
select @GROSS_sal = @sal + @HRA + @DA
 
--g)	Net salary as  Gross salary- Deduction
select @NET_sal = @GROSS_sal - @DEDUCTIONS
 
  select @empno, ename, @sal as sal, @HRA as HRA, @DA as DA, @PF as PF, @IT as IT,
@DEDUCTIONS as Deductions, @GROSS_sal as 'Gross sal', @NET_sal as 'Netsal' from emp where empno = @EMPNO
END
 
execute empPayslip @EMPNO = 7232