-- Select
Select ContactName Adi ,CompanyName Sirketadi,City  Sehir from Customers

Select * from Customers where City = 'Berlin'

Select * from Products where CategoryID = 1 or CategoryID = 3

Select * from Products where CategoryID = 1 and UnitPrice <10

select * from Products where CategoryID = 1 order by UnitPrice desc

select count(*)  from Products where CategoryID = 2

select count(*) Adet from Products

select CategoryID,count(*) from Products where UnitPrice > 20 group by CategoryID having count(*)<10

select Products,ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10


select * from Products left join [Order Details] od 
on p.ProductID = od.ProductID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID