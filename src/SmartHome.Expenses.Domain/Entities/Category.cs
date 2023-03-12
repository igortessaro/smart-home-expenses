namespace SmartHome.Expenses.Domain.Entities;

public sealed class Category
{
    internal Category()
    {
        this.Expenses = new List<Expense>();
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public string Code { get; private set; } = string.Empty;
    public bool CanRepeatMonth { get; private set; }

    public IReadOnlyCollection<Expense> Expenses { get; private set; }
}