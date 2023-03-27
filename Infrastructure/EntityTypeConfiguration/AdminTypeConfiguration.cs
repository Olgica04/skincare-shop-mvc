using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class AdminTypeConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.Property(p => p.Username)
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(p => p.Password)
            .HasMaxLength(20)
            .IsRequired();

            builder.HasData(new Admin(1, "Admin", PasswordHasher.HashPassword("123456Aa!")));
        }
    }
}