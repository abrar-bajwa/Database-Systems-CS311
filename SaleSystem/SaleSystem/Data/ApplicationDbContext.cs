using Microsoft.EntityFrameworkCore;
using SaleSystem.Models;

namespace SaleSystem.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //Table Creation
        public DbSet<Client> Client { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
    }
}
