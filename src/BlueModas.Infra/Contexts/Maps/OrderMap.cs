using BlueModas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueModas.Infra.Contexts.Maps
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Date)
              .IsRequired()
              .HasColumnType("datetime");

            builder.Property(x => x.Amount)
              .IsRequired()
              .HasColumnType("money");
            
            builder.Property(x => x.ClientId)
            .IsRequired()
            .HasColumnType("uniqueidentifier");

            builder
                .HasOne(x => x.Client);
        }
    }
}

