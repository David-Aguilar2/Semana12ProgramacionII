using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiTiendaPOS.Data;
using MiTiendaPOS.Models;


namespace MiTiendaPOS.Services
{
    public class ProductoService
    {
        // Catálogo para el ComboBox de la FK (tabla de la que depende Producto)
        public List<Categoria> ListarCategorias()
        {
            using var ctx = new MiTiendaPOSContext();
            return ctx.Categorias.AsNoTracking().OrderBy(c => c.Nombre).ToList();
        }

        // READ con filtros opcionales. Include = JOIN con Categorias
        // texto vacío = sin filtro de nombre; categoriaId = 0 = todas
        public List<Producto> Listar(string texto = "", int categoriaId = 0)
        {
            using var ctx = new MiTiendaPOSContext();

            IQueryable<Producto> consulta = ctx.Productos.AsNoTracking()
                                               .Include(p => p.Categoria);

            if (!string.IsNullOrWhiteSpace(texto))
                consulta = consulta.Where(p => p.Nombre.Contains(texto));

            if (categoriaId > 0)
                consulta = consulta.Where(p => p.CategoriaId == categoriaId);

            return consulta.OrderBy(p => p.Nombre).ToList();  // aquí se ejecuta el SQL
        }

        public Producto? ObtenerPorId(int id)
        {
            using var ctx = new MiTiendaPOSContext();
            return ctx.Productos.AsNoTracking().FirstOrDefault(p => p.Id == id);
        }

        // CREATE / UPDATE en un solo método: Id = 0 significa producto nuevo
        public void Guardar(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new InvalidOperationException("El nombre es obligatorio.");
            if (producto.PrecioUnitario <= 0)
                throw new InvalidOperationException("El precio debe ser mayor que cero.");
            if (producto.Stock < 0)
                throw new InvalidOperationException("El stock no puede ser negativo.");

            using var ctx = new MiTiendaPOSContext();

            // Integridad referencial: la FK debe apuntar a una categoría existente
            if (!ctx.Categorias.Any(c => c.Id == producto.CategoriaId))
                throw new InvalidOperationException("La categoría no existe.");

            // Evita duplicados (excluye al mismo producto cuando se está editando)
            bool duplicado = ctx.Productos
                .Any(p => p.Nombre == producto.Nombre && p.Id != producto.Id);
            if (duplicado)
                throw new InvalidOperationException(
                    $"Ya existe un producto '{producto.Nombre}'.");

            if (producto.Id == 0)
                ctx.Productos.Add(producto);      // INSERT
            else
                ctx.Productos.Update(producto);   // UPDATE de todas sus columnas

            ctx.SaveChanges();
        }

        // DELETE físico o baja lógica, según el producto tenga ventas o no
        public string Eliminar(int id)
        {
            using var ctx = new MiTiendaPOSContext();
            Producto producto = ctx.Productos.Find(id)
                ?? throw new InvalidOperationException("El producto ya no existe.");
            // Restrict: SQL Server rechazaría el DELETE si hay detalles que lo usan
            if (ctx.DetallesVenta.Any(d => d.ProductoId == id))
            {
                producto.Activo = false;          // baja lógica: UPDATE, no DELETE
                ctx.SaveChanges();
                return "El producto tiene ventas registradas, por lo que se desactivó.";
            }

            ctx.Productos.Remove(producto);
            ctx.SaveChanges();
            return "Producto eliminado.";
        }

    }
}
