using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base (options) 
        {
            
        }

        DbSet<Transaction> Transactions {  get; set; }
        DbSet<Category> Categories { get; set; }


    }
}
