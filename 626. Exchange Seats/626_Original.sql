select s1.id, IFNULL(s2.student, s1.student) as student from seat s1
left join (
select student, 
    Case 
        when MOD(id, 2) = 0 then id - 1
        when MOD(id, 2) = 1 then id + 1
    End as id
from seat ) s2 on s1.id = s2.id
order by s1.id
