namespace ExpenseTracker.Domain.Entities;

public class Expense
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public decimal Amount { get; set; }

    public DateTime ExpenseDate { get; set; }
}