using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHome.Expenses.Domain.Entities;

namespace SmartHome.Expenses.Infrastructure.Repositories.Relational.Configurations;

public sealed class ExpenseConfiguration: IEntityTypeConfiguration<Expense>
{
    public void Configure(EntityTypeBuilder<Expense> builder)
    {
        builder.ToTable("expense");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Name).HasColumnName("name");
        builder.Property(e => e.Description).HasColumnName("description");
        builder.Property(e => e.Amount).HasColumnName("amount");
        builder.Property(e => e.CategoryId).HasColumnName("category_id");
        builder.Property(e => e.CreateAt).HasColumnName("create_at");
        builder.Property(e => e.CreateBy).HasColumnName("create_by");
        builder.Property(e => e.DueDate).HasColumnName("due_date");
        builder.Property(e => e.PayDate).HasColumnName("pay_date");

        builder.HasOne(d => d.Category)
            .WithMany(p => p.Expenses)
            .HasForeignKey(d => d.CategoryId)
            .OnDelete(DeleteBehavior.ClientSetNull);
        builder.HasOne(d => d.CreateByUser)
            .WithMany(p => p.Expenses)
            .HasForeignKey(d => d.CreateBy)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}