namespace SmartHome.Expenses.Domain.Entities;

public sealed class User
{
    protected User()
    {
    }
    
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Surname { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string Phone { get; private set; } = string.Empty;

    public IReadOnlyCollection<Expense> Expenses { get; private set; }
}