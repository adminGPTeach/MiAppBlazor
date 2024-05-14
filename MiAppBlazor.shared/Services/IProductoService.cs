using MiAppBlazor.Models;


namespace MiAppBlazor.Shared.Services
{
    public interface IProductoService
    {

        Task<IEnumerable<Producto>> ObtenerTodosLosProductosAsync();
        Task<Producto> ObtenerProductosPorIdAsync(int id);
        Task AnadirProductoAsync(Producto producto);
        Task ActualizarProductoAsync(Producto producto);
        Task EliminarProductoAsync(int id);
    }
}
