using BlueModas.Domain.Entities;
using BlueModas.Domain.Shared;
using BlueModas.Infra.Contexts.Maps;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;

namespace BlueModas.Infra.Contexts
{
     public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Settings.ConnectionString);
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Ignore<Notification>();

            builder.ApplyConfiguration(new ProductMap());
            builder.ApplyConfiguration(new ClientMap());
        }
    }
}
