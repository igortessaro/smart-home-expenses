namespace SmartHome.Expenses.Domain.Queries;

public sealed class ExpenseSummaryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime? DueDate { get; set; }
    public DateTime? PayDate { get; set; }
    public string CreateBy { get; set; } = string.Empty;
    public DateTime CreateAt { get; set; }
    public string Category { get; set; } = string.Empty;
}