--View yaratmaq ucun create komandasindan istifade olunur
Create view MehsulRapor
as
Select UrunAdi,KategoriAdi,SirketAdi from Urunler u
left join Kategoriler k
on u.KategoriID=u.KategoriID
left join Tedarikciler t
on t.TedarikciID=u.UrunID
group by UrunAdi,KategoriAdi,SirketAdi

Select * from MehsulRapor

--View'nu deyisdirmek ucun ise alter komandasindan istifade etmeliyik
alter view MehsulRapor
as
Select UrunAdi from Urunler u
left join Kategoriler k
on u.KategoriID=u.KategoriID
left join Tedarikciler t
on t.TedarikciID=u.UrunID
group by UrunAdi


--Hansi personal hansi mehsuldan toplam ne qeder satis yapti ucun view yaz
Create view PersonalSatisi
as
Select p.Adi,UrunAdi,SUM(sd.Adet*sd.Fiyat*(1-sd.Indirim))'Toplam Satis Miqdari' from SatisDetay sd
left join Satislar s
on sd.SatisID=s.SatisID
left join Personeller p
on p.PersonelID=s.PersonelID
left join Urunler u
on u.UrunID=sd.UrunID
group by p.Adi,UrunAdi

Select * from PersonalSatisi