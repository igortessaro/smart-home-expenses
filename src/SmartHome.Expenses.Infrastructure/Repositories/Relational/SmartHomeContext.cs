using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using SmartHome.Expenses.Domain.Entities;

namespace SmartHome.Expenses.Infrastructure.Repositories.Relational;

public sealed class SmartHomeContext : DbContext
{
    public SmartHomeContext()
    {
    }

    public SmartHomeContext(DbContextOptions<SmartHomeContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(message => Debug.WriteLine(message));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Configurations.UserConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ExpenseConfiguration());
    }
}