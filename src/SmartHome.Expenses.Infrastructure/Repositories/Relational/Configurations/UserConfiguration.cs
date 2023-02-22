using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHome.Expenses.Domain.Entities;

namespace SmartHome.Expenses.Infrastructure.Repositories.Relational.Configurations;

public sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("user");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Name).HasColumnName("name");
        builder.Property(e => e.Phone).HasColumnName("phone");
        builder.Property(e => e.Surname).HasColumnName("surname");
        builder.Property(e => e.Email).HasColumnName("email");
    }
}