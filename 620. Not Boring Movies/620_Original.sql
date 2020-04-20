# Write your MySQL query statement below
select * from cinema where Mod(id, 2) = 1 and description != 'boring' 
order by rating desc