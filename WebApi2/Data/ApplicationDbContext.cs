using Microsoft.EntityFrameworkCore;
using WebApi2.Model.Entities;

namespace WebApi2.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //Create at tables in the DB.
        public DbSet<Product> Products { get; set; }
    }
}
