Select UrunAdi ,(Select KategoriAdi from Kategoriler k where k.KategoriID=u.UrunID)'Kategoriyalar' from Urunler u
Select *,(select SirketAdi from Tedarikciler where Tedarikciler.TedarikciID=Urunler.TedarikciID)'Tedarickiler' from Urunler
Select * from Urunler
Select UrunAdi,Fiyat,Stok,(Select SirketAdi from Tedarikciler t where t.TedarikciID=u.TedarikciID)'Tedarikciler',
(Select KategoriAdi from Kategoriler k where k.KategoriID=u.KategoriID)'Kategoriler' 
from Urunler u
Select (Select MusteriAdi+' - '+MusteriUnvani from Musteriler m where m.MusteriID=s.MusteriID)'Musteri melumatlari',
(Select Adi+'  '+SoyAdi from Personeller p where p.PersonelID=s.PersonelID )'Personallar' 
from Satislar s

Select UrunAdi,(Select MAX(SUM(Fiyat*Fiyat*(1-Indirim))) from SatisDetay s where s.UrunID=u.UrunID)'Toplam Satis' from Urunler u
Select * from SatisDetay