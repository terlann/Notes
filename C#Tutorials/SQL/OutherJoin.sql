--Otuer join: Elaqeli tablolarda null qeydlerde daxil olmaqla butun qeydleri getirir:
--3 nov outer join vardir:  Left outer join/Right outer join/ full outher join

--1.Left outer join: Left tablo sol terefde ilk(Left join'a catmamis) yazilan tablodur. Sol tablonun butun qeydlerini getirir null olsa bele, amma sag tablodaki ilisgili qeydleri getirir.
Select * from Urunler u
left outer join Kategoriler k
on u.KategoriID=k.KategoriID where k.KategoriID is not null

--2.Right outer join:Sagdaki tablo right tablodur.Sagdaki qeydler null daxil butun qeydler getirilir sol tablodaki ise yalniz elaqeli qeydler getirilir.

Select * from Urunler u
right outer join Kategoriler k
on u.KategoriID=k.KategoriID

--3.Full outer join: Hem sagdaki hemde soldaki butun qeydleri getirir null olsa bele.

Select* from Urunler u
full outer join Kategoriler k
on u.KategoriID=k.KategoriID

