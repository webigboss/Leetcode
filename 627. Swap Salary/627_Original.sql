update salary 
set sex = 
(Case 
    when sex = 'm' then 'f'
    else 'm'
End)