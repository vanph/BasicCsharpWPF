using MyCountry.DataAccess.Model;

namespace MyCountry.DataAccess.Persistence
{
    using System.Data.Entity;

    public partial class MyCountryEntities : DbContext
    {
        public MyCountryEntities()
            : base("name=MyCountryEntities")
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<District> Districts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
