--Trigger(Tetikleyici): Bir islemden sonra basqa bir islem yapa bilmeyi ve ya bir islemin yerine basqa bir islem qoya bilmeyi saglar.   
--Istifadeci triggeri ele ise sala bilmez.
--Triggerin diger yapilardan ferqi calisma zamanini ozu qeyd eder.
--2 cur trigger var
--After(sonra) trigger ve instead(yerine) of trigger
--Trigger islemlerinde istifade olunan iki dene sanal tablo vardir
--Inserted ve Deleted
--Eklenmeye calisan kayit inserted tablosunda , silinmeye calisan kayit ise deleted tablosunda tutulur.

--YADDA SAXLA: Instead of trigger bir sorgunu engelleyib yerine basqa sorgu icra edir, After trigger ise bir sorgunu engellemeden yəni sorgu bitdikden sonra novbeti sorgunu icra edir 

 --Urunler tablosuna delete komutu geldiyde delete komutu yerine update komutunu calisdiraq.
-- Instead of trigger: Her hansi bir emeliyyat yerine basqa bir emeliyyatin gorulmesidir
 Create trigger trg_MehsulSil
 on Urunler--Hansi tablede calisdigini gosteririk
 instead of--Triggerin novunu gosteririk
 Delete--Hansi komanda cagrildiginda triggerimiz calishsin
 as
 declare @id int
Select @id = UrunID from deleted       -- 1ci atama yontemi
set @id=(Select UrunID from deleted)   -- 2 ciatama islemi
Update Urunler set Sonlandi=1 where UrunID=@id

Delete from Urunler where UrunID=2
Select*from Urunler


--After trigger: her hansi tablo uzerinde her hansi bir emeliyyatdan sonra daha bir emeliyyatin gorulmesi demekdir.
--Satis detay tablosuna urun girildiyinde o urunun sayi qeder stokdan urun cixan trigger yazaq.
go

alter trigger trgStokAzalt
on SatisDetay
after
insert
as
declare @id int, @eded int
Select @id=UrunID,@eded=Adet from inserted
Update Urunler set Stok-=@eded where UrunID=@id

go

Insert into SatisDetay(SatisID,UrunID,Fiyat,Adet,Indirim)Values(10251,4,14,5,0)

Select * from SatisDetay
Select * from Urunler where UrunID=4

--StisDetay tablosundan urun silindiyinde(vazvirat)Silinen urun qeder urunler tablosundaki stoku artiran trigger yazin.
go
Create trigger trg_StokArtir
on SatisDetay
after
Delete
as
declare @id int,@eded int
Select @id=UrunID,@eded=Adet from deleted
Update Urunler set Stok+=@eded where UrunID=@id

Delete from SatisDetay where UrunID=1 and SatisID=10248

Select * from SatisDetay where UrunID=1 and SatisID=10248
Select * from Urunler


