delete from Person where Id not in (select MIN(a.Id) from (select * from Person) as a Group by Email);

select * from Person;
