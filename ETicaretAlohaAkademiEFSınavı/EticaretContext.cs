using ETicaretAlohaAkademiEFSınavı.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAlohaAkademiEFSınavı
{
    public class EticaretContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = LAPTOP-3AOA7VRF\\SQLEXPRESS; Database = ETicaretAlohaAcademy; trusted_connection = true; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupplierProduct>().HasKey(sp => new {sp.SuplierId, sp.ProductId});
        }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Costumer> Costumers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SupplierProduct> SupplierProducts { get; set; }
       
    }
}
