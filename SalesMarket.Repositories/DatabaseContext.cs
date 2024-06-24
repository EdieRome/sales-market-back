using Microsoft.EntityFrameworkCore;
using SalesMarket.Common.Models;

namespace SalesMarket.Repositories
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemStore> ItemStores { get; set; }
        public DbSet<CustomerItem> CustomerItems { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemStore>()
                .HasOne(at => at.Item)
                .WithMany(a => a.ItemStores)
                .HasForeignKey(at => at.IdItem);

            modelBuilder.Entity<ItemStore>()
                .HasOne(at => at.Store)
                .WithMany(t => t.ItemStores)
                .HasForeignKey(at => at.IdStore);

            modelBuilder.Entity<CustomerItem>()
                .HasOne(ca => ca.Customer)
                .WithMany(c => c.CustomerItems)
                .HasForeignKey(ca => ca.IdCustomer);

            modelBuilder.Entity<CustomerItem>()
                .HasOne(ca => ca.Item)
                .WithMany(a => a.CustomerItems)
                .HasForeignKey(ca => ca.IdItem);
        }
    }
}
