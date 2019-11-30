using Microsoft.EntityFrameworkCore;

namespace data.data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<domain.Models.Conta> Conta { get; set; }
        public DbSet<domain.Models.Imovel> imovel { get; set; }
    
        
    }
}