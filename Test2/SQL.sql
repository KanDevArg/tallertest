-- 2- SQL
-- You have three different tables
-- A Customer Table with FirstName, LastName, Age, Occupation, MartialStatus, PersonID
-- 
-- An Orders Table with OrderID, PersonID, DateCreated, MethodofPurchase
-- 
-- An Orders Details table with OrderID, OrderDetailID, ProductNumber, ProductID, ProductOrigin
-- 
-- Please return a result of the customers who ordered product ID = 1112222333 and return
-- FirstName and LastName as full name, age, orderid, datecreated, MethodOfPurchase as Purchase Method, 
-- ProductNumber and ProductOrigin


SELECT 
    c.FirstName + ' ' + c.LastName AS 'name', 
    c.age AS Age, o.OrderID as 'orderid',  
    o.MethodOfPurchase as 'Purchase Method',
    d.ProductNumber,
    d.ProductOrigin
 FROM Orders_Details d
    INNER JOIN Orders o ON  o.OrderID == d.OrderID 
    INNER JOIN Customer c ON c.PersonID == o.PersonID
where d.ProductID == 1112222333