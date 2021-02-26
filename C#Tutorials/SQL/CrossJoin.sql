--CrossJoin Tablodaki butun qeydleri bir birine kartezyen carpim ederek getirir.


--Hansi personal hansi mehsuldan satmamisdir?

Select p.Adi,u.UrunAdi from Personeller p
cross join Urunler u
except
Select p.Adi,UrunAdi from Satislar s
left join Personeller p
on s.PersonelID=p.PersonelID
left join SatisDetay sd
on s.SatisID=sd.SatisID
left join Urunler u
on sd.UrunID=u.UrunID
group by p.Adi,UrunAdi

--Hansi tedarikci hansi urunden tedaruk etmemisdir?

Select SirketAdi,UrunAdi from Tedarikciler t
cross join Urunler u
Except
Select SirketAdi,UrunAdi from Tedarikciler t
left join Urunler u
on t.TedarikciID=u.TedarikciID
group by SirketAdi,UrunAdi