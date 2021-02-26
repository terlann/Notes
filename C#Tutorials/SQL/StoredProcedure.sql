--Procedure: View'nun parametre alan versiyasi kimi tesevvur etmek olar.
Create procedure MehsulListele
as
Select * from Urunler
exec MehsulListele

go

Create proc MehsulElaveEt
@Adi nvarchar(50),
@Qiymeti decimal(18,2),
@Eded int
as
Insert into Urunler(UrunAdi,Fiyat,Stok) Values(@Adi,@Qiymeti,@Eded)
Select * from Urunler

exec MehsulElaveEt 'Qarpiz',1.95,25

go

Alter proc MehsulElaveEt
@Adi nvarchar(50),
@Qiymeti decimal(18,2),
@Eded int
as
declare @trimli nvarchar(100)=trim(@Adi)
if(exists(Select * from Urunler where UrunAdi=@trimli))
begin
print 'Bu mehsul artiq movcuddur!'
end
else
begin
Insert into Urunler(UrunAdi,Fiyat,Stok) Values(@trimli,@Qiymeti,@Eded)
print 'Mehsul elave edildi'
end

exec MehsulElaveEt 'Pesok',18.52,20
Select * from Urunler

go
Create proc MehsulSil
@paramMehsulAdi nvarchar(50)
as
Delete from Urunler where UrunAdi=@paramMehsulAdi
Select * from Urunler
go
exec MehsulSil 'pesok'

go

Alter proc StokArtir
@Stok int,
@UrunId int
as
Update Urunler set Stok+=@Stok where UrunID=@UrunId
Select * from Urunler
go
exec StokArtir 10,92