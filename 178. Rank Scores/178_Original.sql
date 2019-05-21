/* Write your T-SQL query statement below */
select b.Score, b.Rank from 
 Scores c left join 
(select a.Score , row_number() over (order by a.Score desc) as Rank from 
(select distinct Score from Scores) a ) b
on b.Score = c.Score
order by c.Score desc
