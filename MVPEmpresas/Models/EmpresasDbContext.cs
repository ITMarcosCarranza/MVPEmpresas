using Microsoft.EntityFrameworkCore;
using MVPEmpresas.Models;

namespace MVPEmpresas.Models
{
    public class EmpresasDbContext:DbContext
    {
        public EmpresasDbContext(DbContextOptions<EmpresasDbContext> options)
            : base( options) { }
        public DbSet<Company> Companies { get; set; }
        public DbSet<MVPEmpresas.Models.Category> Category { get; set; } = default!;
    }
}
