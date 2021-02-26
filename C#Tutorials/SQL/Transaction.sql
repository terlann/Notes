--Transaction: Birden cox emeliyyati bir kicik emeliyyat veziyyetine getirib bu emeliyyatin her hansi bir yerinde nese xeta olarsa butun emeliyyati legv edib geri qaytarilmasini temin edir.

Select * from Kategoriler

begin tran
Delete from Kategoriler where KategoriID=11
rollback tran