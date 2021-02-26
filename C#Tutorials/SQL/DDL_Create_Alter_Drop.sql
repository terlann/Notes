--DDL(Data Definition Language) icerisinde Create, Alte drop komutlari olur. Bu komandalar sayesinde databasede view, procedura,function,trigger ve.s kimi elemanlar elave ede biler, deyisdirile ve sile bilerik.

Create table Kisiler(
KisiId int primary key identity(1,1),
Adi nvarchar(50) not null, --notnull bos kecile bilmez demekdir
Soyad nvarchar(50) not null,
DogumTarixi date not null
)
go
Insert into Kisiler Values('Terlan','Qurbanov','1993.04.21')
Select * from Kisiler

--Drop: Var olan bir nesneyi silmek ucundur
Drop table Kisiler

go --go bir seperatordur(ayiricidir)
--Alter Table ve ya diger nesneler uzerinde deyisiklik etmek ucundur
Alter table Kisiler
drop column Adi
go
Select * from Kisiler