select d.Name as Department, e.Name as Employee, e.Salary from employee e 
inner join Department d on e.DepartmentId = d.Id
where e.Salary in (
    select top 3 e2.Salary from (select distinct Salary from Employee e3 where e3.departmentid = e.departmentid) e2 order by e2.Salary desc
)
order by d.Name