Select * from Satislar where PersonelID=(Select PersonelID from Personeller where Adi='nancy')
Select COUNT(SatisID) from Satislar where PersonelID in(Select PersonelID from Personeller where Adi='nancy' or Adi='Janet')
Select * from Personeller where Adi='nancy' or Adi='janet'
Select * from Satislar
Select * from Satislar where PersonelID=(Select PersonelID from Personeller where Adi='nancy') and 
ShipVia=(Select NakliyeciID from Nakliyeciler where SirketAdi='Speedy Express')
Select SUM(Fiyat*Adet*(1-Indirim)) from SatisDetay where UrunID=(Select UrunID from Urunler where UrunAdi='Chai')
Select * from Satislar where SatisTarihi between '1997.01.01' and '1997.12.31'
Select SUM(Fiyat*Adet*(1-Indirim)) from SatisDetay where SatisID in(Select SatisID from Satislar 
where SatisTarihi between '1997.01.01' and '1997.12.31')
Select * from Satislar where MusteriID=(Select MusteriID from Musteriler where MusteriAdi='Maria Anders')
Select SUM(Fiyat*Adet*(1-Indirim))'Toplam Satis Miqdari' from SatisDetay where SatisID 
in(Select SatisID from Satislar where MusteriID=(Select MusteriID from Musteriler where MusteriAdi='Maria Anders'))
Select ShipVia from Satislar s where MusteriID=(Select MusteriID from Musteriler where MusteriAdi='Maria Anders')
Select * from Kategoriler where KategoriID 
in(Select ShipVia from Satislar where MusteriID=(Select MusteriID from Musteriler where MusteriAdi='Maria Anders'))