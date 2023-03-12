namespace SmartHome.Expenses.Domain.Queries;

public sealed class CategorySummaryDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public bool CanRepeatMonth { get; set; }
}