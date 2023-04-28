
using ProyectoFinal.Models;
using ProyectoFinal.DAO;

Crudfloristeria CrudFloristeria = new Crudfloristeria();
Producto producto = new Producto();
Cliente cliente = new Cliente();
Venta venta = new Venta();
Detallesventum Detallesventa = new Detallesventum();

Console.WriteLine("bienvenidos a la floristeria Petalo ");
Console.WriteLine("si uested es un trabajador de la empresa ingrese 1 y si es un cliente ingrese 2 ");

var Menu = Convert.ToInt32(Console.ReadLine());

switch (Menu)
{

    case 1:
        int bucle = 1;
        while (bucle == 1)
        {
            Console.WriteLine("ingresa el nombre del producto ");
            producto.NombreProducto = Console.ReadLine();
            Console.WriteLine("ingrese el precio del producto ");
            producto.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("ingrese la Descripcion del producto: ");
            producto.Descripcion = Console.ReadLine();
            CrudFloristeria.AgregarProducto(producto);
            Console.WriteLine("el producto se ingreso correctamente ");
            Console.WriteLine("pulsa 1 para ingresar otro producto");
            Console.WriteLine("pulsa 0 para salir");
            bucle = Convert.ToInt32(Console.ReadLine());
        }
        break;

    case 2:
        int seguir = 1;

        {
            Console.WriteLine("usted es un cliente por favor ingrese sus tados para continuar: ");
            Console.WriteLine("ingrese su Nombre: ");
            cliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("ingrese el su telefono ");
            cliente.Telefono = Console.ReadLine();
            Console.WriteLine("ingrese su correo electronico ");
            cliente.Email = Console.ReadLine();
            Console.WriteLine("ingrese su direccion: ");
            cliente.Direccion = Console.ReadLine();
            CrudFloristeria.AgregarCliente(cliente);
            Console.WriteLine("el cliente se registro correctamente ");
            Console.WriteLine("Desea realizar una compra: presione 1 para si");
            var compra = Convert.ToInt32(Console.ReadLine());
            if (compra == 1)
            {
                bool continuar = true;
                while (continuar)

                    Console.WriteLine("Usted está realizando una compra:");
                Console.WriteLine("Lista de productos");

                var productos = CrudFloristeria.ListarProductos();

                foreach (var iteracionProducto in productos)
                {
                    Console.WriteLine($"ID ID: {iteracionProducto.IdProducto}:, Nombre: {iteracionProducto.NombreProducto.PadRight(25)}, Precio: ${iteracionProducto.Precio.ToString("0.00").PadRight(10)},  descripcion: {iteracionProducto.Descripcion}");
                }
                Console.WriteLine("ingrese el ID del producto: ");
                Detallesventa.IdProducto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese la cantidad: ");
                Detallesventa.Cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese la fecha");
                venta.FechaPedido = Console.ReadLine();
                
                Console.WriteLine($"su total es {Detallesventa.TotalDetalle}");


                Crudfloristeria.CalcularTotal(Detallesventa);


                Console.WriteLine("pulsa S para realizar otra compra:  ");
                Console.WriteLine("pulsa 0 para salir");
                Console.WriteLine("desea continuar? /n presione S para si y N para No");
                var cont = Console.ReadLine();
                if (cont.Equals("N"))
                {
                    continuar = false;
                }
            }
        }
        break;
}



