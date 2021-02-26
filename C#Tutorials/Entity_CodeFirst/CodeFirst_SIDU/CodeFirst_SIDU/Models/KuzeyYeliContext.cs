using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CodeFirst_SIDU.Models.Mapping;

namespace CodeFirst_SIDU.Models
{
    public partial class KuzeyYeliContext : DbContext
    {
        static KuzeyYeliContext()
        {
            Database.SetInitializer<KuzeyYeliContext>(null);
        }

        public KuzeyYeliContext()
            : base("Name=KuzeyYeliContext")
        {
        }

        public DbSet<Bolge> Bolges { get; set; }
        public DbSet<Bolgeler> Bolgelers { get; set; }
        public DbSet<Kategoriler> Kategorilers { get; set; }
        public DbSet<MusteriDemographic> MusteriDemographics { get; set; }
        public DbSet<Musteriler> Musterilers { get; set; }
        public DbSet<Nakliyeciler> Nakliyecilers { get; set; }
        public DbSet<Personeller> Personellers { get; set; }
        public DbSet<SatisDetay> SatisDetays { get; set; }
        public DbSet<Satislar> Satislars { get; set; }
        public DbSet<Tedarikciler> Tedarikcilers { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<UrunlerTest> UrunlerTests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BolgeMap());
            modelBuilder.Configurations.Add(new BolgelerMap());
            modelBuilder.Configurations.Add(new KategorilerMap());
            modelBuilder.Configurations.Add(new MusteriDemographicMap());
            modelBuilder.Configurations.Add(new MusterilerMap());
            modelBuilder.Configurations.Add(new NakliyecilerMap());
            modelBuilder.Configurations.Add(new PersonellerMap());
            modelBuilder.Configurations.Add(new SatisDetayMap());
            modelBuilder.Configurations.Add(new SatislarMap());
            modelBuilder.Configurations.Add(new TedarikcilerMap());
            modelBuilder.Configurations.Add(new UrunlerMap());
            modelBuilder.Configurations.Add(new UrunlerTestMap());
        }
    }
}
