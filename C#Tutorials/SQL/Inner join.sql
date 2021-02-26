--Inner join: elaqeli tablolar null olmayan qeydleri listeler
Select UrunAdi,KategoriAdi from Urunler u
inner join Kategoriler k
on u.KategoriID=k.KategoriID
Select u.*,t.* from Urunler u
inner join Tedarikciler t
on u.TedarikciID=t.TedarikciID

Select sd.UrunID,u.UrunAdi, m.MusteriAdi+' '+SoyAdi'Musteri',p.Adi+' '+p.SoyAdi'Personal'
from Satislar s
inner join Musteriler m
on m.MusteriID=s.MusteriID
inner join Personeller p
on s.PersonelID=p.PersonelID
inner join SatisDetay sd
on sd.SatisID=s.SatisID
inner join Urunler u
on u.UrunID=sd.UrunID

Select p.Adi,u.UrunAdi,SUM(sd.Fiyat*sd.Adet*(1-sd.Indirim))'Satis miqdari' from SatisDetay sd
inner join Urunler u
on sd.UrunID=sd.UrunID
inner join Satislar s
on s.SatisID=sd.SatisID
inner join Personeller p
on p.PersonelID=s.PersonelID
where u.UrunAdi='Chai'
group by u.UrunAdi,p.Adi

Select p.Adi,k.KategoriAdi,SUM(Adet)'Toplam mehsul sayi' from Satislar s
inner join Kategoriler k
on s.ShipVia=k.KategoriID
inner join Personeller p
on s.PersonelID=p.PersonelID
inner join SatisDetay sd
on sd.SatisID=s.SatisID
group by k.KategoriAdi,p.Adi


Select * from Satislar