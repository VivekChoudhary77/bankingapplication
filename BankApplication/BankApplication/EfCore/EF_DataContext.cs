using Microsoft.EntityFrameworkCore;

namespace BankApplication.Model
{
    public class EF_DataContext : DbContext
    {
        public EF_DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
    }
}
