--begin tran
--Update Urunler set Fiyat=20
--rollback tran

Select * from Urunler
begin tran
Update Urunler set Stok=Stok+5 where KategoriID=2
rollback tran
Select * from Urunler