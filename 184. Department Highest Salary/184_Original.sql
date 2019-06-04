select d.Name as Department, e.Name as Employee, e.Salary from Employee e inner join Department d on e.DepartmentId = d.Id
inner join (
select Max(Salary) as MaxSalary, DepartmentId from Employee group by DepartmentId ) a
on e.DepartmentId = a.DepartmentId and e.Salary = a.MaxSalary