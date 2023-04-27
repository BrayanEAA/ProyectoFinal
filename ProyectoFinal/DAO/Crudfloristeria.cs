using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void RealizarVenta(Venta ParametroVenta)
        {
            using (FloristeriaContext db = new FloristeriaContext())
            {
                Venta venta = new Venta();
                venta.FechaPedido = ParametroVenta.FechaPedido;
                db.Add(venta);
                db.SaveChanges();

            }
        }

    }
}
