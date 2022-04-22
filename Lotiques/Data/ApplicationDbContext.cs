using Lotiques.Models;
using Microsoft.EntityFrameworkCore;
namespace Lotiques.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<AntiqueOrder> AntiqueOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
