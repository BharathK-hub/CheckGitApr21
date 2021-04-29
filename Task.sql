use pubs
--1) Print the city name and the count of authors from every city
select * from authors
select city,count(au_lname) as Count_Of_Authors from authors group by city

--2) Print the authors who are not from the city in which the publisher 'New Moon Books' is from.

select * from publishers
select * from authors

select au_fname as First_Name,au_lname as Last_Name from authors where city not in(
select city from publishers where pub_name='New Moon Books')

--3) Create a procudure that will take the author first name and last name and new price 
--The procedure should update teh price of the books written by the author with the give name 
select * from titles
select * from titleauthor
select * from authors

create proc proc_UpdateByPrice(@fname varchar(50), @lname varchar(50), @price float)
as
begin
   Update titles set price=@price
   where title_id=(
   select title_id from titleauthor where au_id=(
   select au_id from authors 
   where au_lname=@lname and au_fname=@fname))
end
exec proc_UpdateByPrice 'Ann','Dull',10.26

select * from titles --To check the updated price
--The price of "Secrets of Silicon Valley" will be updated from 20 to 10.26.

--4) Create a function that will calculate tax for the sale of every book
--If quantity <10 tax is 2%
--10 -20 tax is 5%
--20 - 50 tax is 6%
--above 30 tax is 7.5%
--The function should take quantity and return tax
select * from sales
select * from titles

alter function fn_taxCal(@count int)
returns float
as 
begin
declare 
	@tax float
if(@count>0 and @count< 10)
	set @tax = 2
else if(@count >= 10 and @count <20)
	set @tax = 5
else if(@count >=20 and @count < 30)
	set @tax = 6
else
	set @tax = 7.5
	
return @tax
end

select title_id,qty as Quantity,dbo.fn_taxCal(qty) as Tax_Payable from sales
