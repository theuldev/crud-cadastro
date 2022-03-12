using crud_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_mvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base(options)
        {


        }
        public DbSet<Client> _Client{ get; set; }
    }
}
