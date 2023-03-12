namespace SmartHome.Expenses.Domain.Entities;

public sealed class Expense
{
    public Expense()
    {
        CreateAt = DateTime.UtcNow;
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public decimal Amount { get; private set; }
    public DateTime? DueDate { get; private set; }
    public DateTime? PayDate { get; private set; }
    public Guid CreateBy { get; private set; }
    public DateTime CreateAt { get; private set; }
    public Guid CategoryId { get; private set; }

    public Category? Category { get; private set; }
    public User? CreateByUser { get; private set; }
}