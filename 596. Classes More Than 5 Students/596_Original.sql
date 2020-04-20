# Write your MySQL query statement below
select a.class from (select class, count(distinct student) amount from courses group by class
having amount >= 5) a
