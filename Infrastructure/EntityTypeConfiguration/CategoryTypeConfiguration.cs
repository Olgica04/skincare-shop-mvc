using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    public class CategoryTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(p => p.Name)
            .HasMaxLength(128)
            .IsRequired();

            builder.Property(p => p.Id)
                .IsRequired();

            builder.HasData(
                new Category(1, "Cleansers"),
                new Category(2, "Serums"),
                new Category(3, "Masks"),
                new Category(4, "Eye cream"),
                new Category(5, "Moisturizer"),
                new Category(6, "Facial Tools")
                );
        }
    }
}