CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
    RETURN (
        /* Write your T-SQL query statement below. */
        select b.Salary from (select a.Salary, Rank() over(order by a.Salary desc) as Rank 
        from (select distinct Salary from Employee) a) b
        where b.Rank = @N
    );
END