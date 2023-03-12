namespace SmartHome.Expenses.Domain.Queries;

public sealed class UserSummaryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
}