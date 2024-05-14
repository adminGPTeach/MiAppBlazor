using Microsoft.EntityFrameworkCore;
using MiAppBlazor.Models;

namespace MiAppBlazor.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
