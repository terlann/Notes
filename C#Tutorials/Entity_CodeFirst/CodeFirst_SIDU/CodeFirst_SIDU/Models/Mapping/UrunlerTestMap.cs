using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirst_SIDU.Models.Mapping
{
    public class UrunlerTestMap : EntityTypeConfiguration<UrunlerTest>
    {
        public UrunlerTestMap()
        {
            // Primary Key
            this.HasKey(t => t.UrunID);

            // Properties
            this.Property(t => t.UrunID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UrunAdi)
                .HasMaxLength(40);

            this.Property(t => t.BirimdekiMiktar)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("UrunlerTest");
            this.Property(t => t.UrunID).HasColumnName("UrunID");
            this.Property(t => t.UrunAdi).HasColumnName("UrunAdi");
            this.Property(t => t.TedarikciID).HasColumnName("TedarikciID");
            this.Property(t => t.KategoriID).HasColumnName("KategoriID");
            this.Property(t => t.BirimdekiMiktar).HasColumnName("BirimdekiMiktar");
            this.Property(t => t.Fiyat).HasColumnName("Fiyat");
            this.Property(t => t.Stok).HasColumnName("Stok");
            this.Property(t => t.YeniSatis).HasColumnName("YeniSatis");
            this.Property(t => t.EnAzYenidenSatisMikatari).HasColumnName("EnAzYenidenSatisMikatari");
            this.Property(t => t.Sonlandi).HasColumnName("Sonlandi");
        }
    }
}
