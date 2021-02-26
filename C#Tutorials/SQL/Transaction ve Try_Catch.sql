Create proc TransferEt
@Gonderen nvarchar(50),
@QebulEden nvarchar(50),
@Mebleg money
as
Begin try
Begin tran kocurme --Transaction'u baslatiriq
Update Accounts set Bakiye-=@Mebleg where HesabAdi=@Gonderen
--declare @err int=8/0
Update Accounts set Bakiye+=@Mebleg where HesabAdi=@QebulEden
commit tran kocurme --Transactionu tesdiqleyirik
print 'Emeliyyat ugurla basa catdi'
Select * from Accounts
end try
Begin catch
rollback tran kocurme--Emeliyyat geri qaytaririq
print 'Emeliyyat ugursuz oldu'
end catch

exec TransferEt 'Terlan Qurbanov','Isa Qurbanov',100

Select * from Accounts

--@@TranCount bize aciq olan(Commit ile baglanmayan) Transactionlarin sayini veririr
Select @@TRANCOUNT