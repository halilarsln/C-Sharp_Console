--DML KOMUTLARI-->Data Manýpulatýon Language
--Select
--Insert
--Update
--Delete

--Select listeleme iþlemleri
--Select *From Table_Name

--*=all

--Select * From TblPerson
--select city from TblPerson
--select name,city from TblPerson
--select *from TblPerson
--where þartlý sorgu için kullanýlýyor.
--select * from TblPerson where City='Ýstanbul'
--Select * From TblPerson where Id>=2

--insert
--insert into (column1,column2...) values (d1,d2,d3...)
--insert into TblCountry (CountryName,CountryCapital) values ('Mýsýr','Kahire')

--insert into TblPerson(Name,city) values ('Þevval Koç','Manisa')
Select * From TblPerson