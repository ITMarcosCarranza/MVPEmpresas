using Microsoft.EntityFrameworkCore;

namespace MVPEmpresas.Models
{
    public class EmpresasDbContext:DbContext
    {
        public EmpresasDbContext(DbContextOptions<EmpresasDbContext> options)
            : base( options) { }
        public DbSet<Company> Companies { get; set; }
    }
}
