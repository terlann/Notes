--Function procedurun geriye deyer donderen formasidir.
--Functionlar 3 yere ayrilir:
--1.Scalar-valued functionlar// Geriye bir tip deyer donderen ve selectle from arasinda yazilan funksiyalardir.
--2.Table-valued functionlar
--3.Aggregate functionlar


--Scalar valued function
Create Function EDVHesabla(@Qiymet money)
returns money
as
begin
declare @edv money
set @edv=@Qiymet*0.18
return @edv
end

go

Select UrunAdi, Fiyat,dbo.EDVHesabla(Fiyat)'EDV-li Qiymet' from Urunler

go

--Scalar valued function
Alter function EDVliQiymet(@Qiymet money, @EdvFaiz decimal(3,2))
returns money
as
begin
declare @EDVQiymet money
set @EDVQiymet=@Qiymet+(@Qiymet*@EdvFaiz)
return @EDVQiymet
end

Select UrunAdi,Fiyat,dbo.EDVliQiymet(Fiyat,0.18)'Edvli Qiymet' from Urunler

go


--Table valued function: Geriye table tipinde deyer donderen funksiyalardir
create function	KategoriyayaGoreMehsullar(@Kid int)
returns table
as
return Select * from Urunler where KategoriID=@Kid

Select * from dbo.KategoriyayaGoreMehsullar(5)

declare @test table(clmStok int)  -- bu ne demekdir? @test adinda bir table yaratdim ve bu table-in clmStok adinda ve int tipinde bir stunu oldugunu gosterdim.

--Aggregate Funksiyalar ise bildiyimiz Count(),SUM(),MAX(),MIN() ve. funksiyalardir