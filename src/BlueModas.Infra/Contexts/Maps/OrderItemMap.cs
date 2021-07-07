using BlueModas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueModas.Infra.Contexts.Maps
{
    public class OrderItemMap : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItem");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Quantity)
              .IsRequired()
              .HasColumnType("int");

            builder.Property(x => x.UnitPrice)
             .IsRequired()
             .HasColumnType("money");

            builder.Property(x => x.Amount)
              .IsRequired()
              .HasColumnType("money");

            builder.Property(x => x.OrderId)
            .IsRequired()
            .HasColumnType("uniqueidentifier");

            builder.Property(x => x.ProductId)
            .IsRequired()
            .HasColumnType("uniqueidentifier");

            builder
                .HasOne(x => x.Product);

            builder.HasOne(x => x.Order);
        }
    }
}
