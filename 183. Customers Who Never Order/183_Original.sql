select c.Name as [Customers] from Customers c where not exists (
select id from orders where customerid = c.id)