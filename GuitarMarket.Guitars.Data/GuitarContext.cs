using GuitarMarket.Domain.Guitars;
using Microsoft.EntityFrameworkCore;
using System;

namespace GuitarMarket.Guitars.Data
{
    public class GuitarContext: DbContext
    {
        public DbSet<GuitarBrand> GuitarBrands { get; set; }
        public DbSet<GuitarModel> GuitarModels { get; set; }
        public DbSet<GuitarType> GuitarTypes { get; set; }
        public DbSet<Guitar> Guitars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Data Source = T040829563753\SQLEXPRESS; Initial Catalog = test; Integrated Security = True
            optionsBuilder.UseSqlServer(@"Data Source=T040829563753\SQLEXPRESS;Initial Catalog=GuitarDB;Integrated Security=True");
         
        }
    }
}
