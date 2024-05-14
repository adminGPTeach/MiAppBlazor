using MiAppBlazor.Data;
using MiAppBlazor.Models;
using Microsoft.EntityFrameworkCore;



namespace MiAppBlazor.Shared.Services
{
    public class ProductoService : IProductoService
    {
        private readonly ApplicationDbContext _context;

        public ProductoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Producto>> ObtenerTodosLosProductosAsync()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task<Producto> ObtenerProductosPorIdAsync(int id)
        {
            return await _context.Productos.FindAsync(id);
        }

        public async Task AnadirProductoAsync(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarProductoAsync(Producto producto)
        {
            _context.Productos.Update(producto);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarProductoAsync(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
        }
       
    }
}
