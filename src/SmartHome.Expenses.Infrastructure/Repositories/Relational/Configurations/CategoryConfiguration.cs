using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHome.Expenses.Domain.Entities;

namespace SmartHome.Expenses.Infrastructure.Repositories.Relational.Configurations;

public sealed class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("category");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Name).HasColumnName("name");
        builder.Property(e => e.Code).HasColumnName("code");
        builder.Property(e => e.Description).HasColumnName("description");
        builder.Property(e => e.CanRepeatMonth).HasColumnName("can_repeat_month");
    }
}