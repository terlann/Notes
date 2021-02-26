Select * from Urunler
Select * from Urunler where UrunAdi in('Ikura','Tofu')
Select * from Urunler where Fiyat between 50 and 100 and UrunID between 18 and 51
Select top 5 * from Urunler where Fiyat > 10
Select * from Urunler order by UrunAdi desc
select * from Urunler where UrunID not in(1,2,3,4,5)
Select * from Urunler where TedarikciID is not null
Select COUNT(TedarikciID) from Urunler
Select SUM(Fiyat) from Urunler
Select AVG(Stok) from Urunler
Select MAX(Stok) from Urunler
Select Top 1 * from Urunler order by Fiyat desc