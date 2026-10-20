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
    public class ClienteService
    {
        //Metodo para traer todos los clientes que coincidan con el filtro
        public List<Cliente> Listar(string filtro = "")
        {
            using var ctx = new MiTiendaPOSContext();
            IQueryable<Cliente> consulta = ctx.Clientes.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(filtro))
                consulta = consulta.Where(c => c.Nombre.Contains(filtro.Trim()));
            return consulta.OrderBy(c => c.Nombre).ToList();
        }
        //READ
        public Cliente? ObtenerPorId(int id)
        {
            using var ctx = new MiTiendaPOSContext();
            return ctx.Clientes.Find(id);
        }
        //CREATE
        public void Crear(Cliente cliente)
        {
            using var ctx = new MiTiendaPOSContext();
            Validar(ctx, cliente);
            ctx.Clientes.Add(cliente);
            ctx.SaveChanges();
        }
        //UPDATE
        public void Actualizar(Cliente cliente)
        {
            using var ctx = new MiTiendaPOSContext();
            Cliente existente = ctx.Clientes.Find(cliente.Id)
                ?? throw new InvalidOperationException("El cliente ya no existe");
            Validar(ctx, cliente);
            existente.Nombre = cliente.Nombre;
            existente.Correo = cliente.Correo;
            existente.Telefono = cliente.Telefono;
            ctx.SaveChanges();
        }
        //DELETE
        public void Eliminar(int id)
        {
            using var ctx = new MiTiendaPOSContext();
            Cliente cliente = ctx.Clientes.Find(id)
                ?? throw new InvalidOperationException("El cliente ya no existe");

            ctx.Clientes.Remove(cliente);
            ctx.SaveChanges();
        }
        //Reglas del negocio 
        private static void Validar(MiTiendaPOSContext ctx, Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
                throw new ArgumentException("El nombre es obligatorio.");
            cliente.Nombre = cliente.Nombre.Trim();

            bool duplicado = ctx.Clientes.Any(c => c.Correo == cliente.Correo
            && c.Id == cliente.Id);

            if (duplicado)
                throw new InvalidOperationException("Ya existe un cliente con" +
                    "ese correo electrónico.");

            bool duplicado2 = ctx.Clientes.Any(c => c.Telefono == cliente.Telefono
            && c.Id == cliente.Id);

            if (duplicado2)
                throw new InvalidOperationException("Ya existe un cliente con" +
                    "ese número de teléfono.");
        }
    }
}
