using ExpenseTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Infrastructure.Data;

public class ExpenseTrackerDbContext : DbContext
{
    public ExpenseTrackerDbContext(
        DbContextOptions<ExpenseTrackerDbContext> options)
        : base(options)
    {
    }

    public DbSet<Expense> Expenses => Set<Expense>();
}