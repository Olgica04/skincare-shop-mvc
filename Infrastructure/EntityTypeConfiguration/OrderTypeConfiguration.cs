using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntityTypeConfiguration
{
    public class OrderTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(p => p.Address)
                   .HasMaxLength(512)
                   .IsRequired();

            builder.Property(p => p.ItemsInOrder)
                   .IsRequired();

            builder.Property(p => p.OrderDate)
                   .HasMaxLength(128)
                   .IsRequired();

            builder.Property(p => p.FirstName)
                   .HasMaxLength(64)
                   .IsRequired();

            builder.Property(p => p.LastName)
                   .HasMaxLength(64)
                   .IsRequired();

            builder.Property(p => p.TotalPrice)
                   .HasMaxLength(64)
                   .IsRequired();
        }
    }
}