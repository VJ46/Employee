using Employee.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employee.Web.Data
{
    public class ApplicationDbContext: DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Employe> Employes { get; set; }
    }
}
