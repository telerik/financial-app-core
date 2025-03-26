using Financial_App_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Financial_App_Core.Data
{
    public class FinancialDbContext : DbContext
    {
        public FinancialDbContext(DbContextOptions<FinancialDbContext> options)
        : base(options)
        {
        }

        public DbSet<CashflowModel> Cashflows { get; set; }
        public DbSet<StockDataPoint> StockData { get; set; }
        public DbSet<TransactionModel> Transactions { get; set; }
    }
}
