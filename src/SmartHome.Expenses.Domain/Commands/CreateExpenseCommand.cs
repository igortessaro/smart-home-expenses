namespace SmartHome.Expenses.Domain.Commands;

public sealed class CreateExpenseCommand
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime? DueDate { get; set; }
    public DateTime? PayDate { get; set; }
    public Guid CreateBy { get; set; }
    public string CategoryCode { get; set; } = string.Empty;
    public Guid CategoryId { get; set; }
}