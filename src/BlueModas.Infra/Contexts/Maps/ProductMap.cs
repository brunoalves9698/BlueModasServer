using BlueModas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueModas.Infra.Contexts.Maps
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
              .IsRequired()
              .HasMaxLength(100)
              .HasColumnType("varchar(100)");

            builder.Property(x => x.Description)
              .IsRequired()
              .HasMaxLength(100)
              .HasColumnType("varchar(100)");

            builder.Property(x => x.Price)
             .IsRequired()
             .HasColumnType("money");

            builder.Property(x => x.Image)
              .IsRequired()
              .HasMaxLength(100)
              .HasColumnType("varchar(150)");
        }
    }
}