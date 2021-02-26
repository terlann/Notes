Create view PersonalSatisSifreli
With encryption
as
SELECT p.Adi, u.UrunAdi, SUM((sd.Adet * sd.Fiyat) * (1 - sd.Indirim)) AS [Toplam Satis Miqdari]
FROM     dbo.SatisDetay AS sd LEFT OUTER JOIN
                  dbo.Satislar AS s ON sd.SatisID = s.SatisID LEFT OUTER JOIN
                  dbo.Personeller AS p ON p.PersonelID = s.PersonelID LEFT OUTER JOIN
                  dbo.Urunler AS u ON u.UrunID = sd.UrunID
GROUP BY p.Adi, u.UrunAdi