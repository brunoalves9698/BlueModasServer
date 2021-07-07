using BlueModas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueModas.Infra.Contexts.Maps
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
              .IsRequired()
              .HasMaxLength(100)
              .HasColumnType("varchar(100)");

            builder.Property(x => x.Email)
              .IsRequired()
              .HasMaxLength(100)
              .HasColumnType("varchar(100)");

            builder.Property(x => x.Phone)
              .IsRequired()
              .HasMaxLength(100)
              .HasColumnType("varchar(15)");

            builder.Property(x => x.ZipCode)
              .IsRequired()
              .HasMaxLength(100)
              .HasColumnType("varchar(9)");

            builder.Property(x => x.Address)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnType("varchar(100)");

            builder.Property(x => x.AddressNumber)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnType("varchar(10)");

            builder.Property(x => x.Neighborhood)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnType("varchar(100)");

            builder.Property(x => x.StateId)
            .IsRequired()
            .HasColumnType("varchar(15)");

            builder.Property(x => x.CityId)
            .IsRequired()
            .HasColumnType("varchar(15)");
        }
    }
}
