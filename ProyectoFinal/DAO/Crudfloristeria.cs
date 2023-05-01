using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal.DAO
{
    public class Crudfloristeria
    {

        public void AgregarProducto(Producto ParametroProducto)
        {
            using (FloristeriaContext db = new FloristeriaContext())
            {
                Producto producto = new Producto();
                producto.NombreProducto = ParametroProducto.NombreProducto;
                producto.Precio = ParametroProducto.Precio;
                producto.Descripcion = ParametroProducto.Descripcion;
                db.Add(producto);
                db.SaveChanges();

            }
        }

        public void AgregarCliente(Cliente ParametroCliente)
        {
            using (FloristeriaContext db = new FloristeriaContext())
            {
                Cliente cliente = new Cliente();
                cliente.NombreCliente = ParametroCliente.NombreCliente;
                cliente.Telefono = ParametroCliente.Telefono;
                cliente.Email = ParametroCliente.Email;
                cliente.Direccion = ParametroCliente.Direccion;
                db.Add(cliente);
                db.SaveChanges();

            }
        }
        public List<Producto> ListarProductos()
        {
            using (FloristeriaContext db = new FloristeriaContext())
            { return db.Productos.ToList(); }
        }
         
        
            public void AgregarVenta(int clienteId, string fecha, decimal total)
            {
                using (var db = new FloristeriaContext())
                {
                    var venta = new Venta { IdCliente = clienteId, FechaPedido = fecha , Total = total };
                    db.Ventas.Add(venta);
                    db.SaveChanges();
                }
            }
        public List<Venta> ObtenerVentas()
        {
            using (var db = new FloristeriaContext())
            {
                return db.Ventas.ToList();
            }
        }
        public void AgregarDetalleVenta(int ventaId, int productoId, int cantidad, decimal totaldetalle)
        {
            using (var db = new FloristeriaContext())
            {
                var detalleVenta = new Detallesventum { IdVenta = ventaId, IdProducto = productoId, Cantidad = cantidad, TotalDetalle = totaldetalle };
                db.Detallesventa.Add(detalleVenta);
                db.SaveChanges();
            }
        }
        public decimal CalcularTotalVenta(int ventaId)
        {
            using (var db = new FloristeriaContext())
            {
                var detallesVenta = db.Detallesventa.Include(d => d.IdProductoNavigation).Where(d => d.IdVenta == ventaId).ToList();
                decimal total = 0;
                foreach (var detalleVenta in detallesVenta)
                {
                    total += detalleVenta.Cantidad * detalleVenta.IdProductoNavigation.Precio;
                }
                return total;
            }
        }


    }
}
