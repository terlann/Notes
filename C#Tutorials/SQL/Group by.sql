Select KategoriID from Urunler group by KategoriID
Select KategoriID, SUM(Fiyat)'Mehsulun toplam deyeri' from Urunler group by KategoriID
select KategoriID, SUM(Stok) from Urunler group by KategoriID
Select TedarikciID,SUM(TedarikciID) from Urunler group by TedarikciID 
Select PersonelID,MusteriID, Count(*)'SatishMiqdari' from Satislar group by PersonelID,MusteriID
Select * from SatisDetay
Select MusteriID,ShipVia,COUNT(SatisID)'Sifaris sayi' from Satislar group by MusteriID,ShipVia
Select UrunID, SUM(Fiyat*Adet)'Mehsuldan toplam satis' from SatisDetay group by UrunID