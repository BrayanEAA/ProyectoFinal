
using ProyectoFinal.Models;
using ProyectoFinal.DAO;

Crudfloristeria CrudFloristeria = new Crudfloristeria();
Producto producto = new Producto();
Cliente cliente = new Cliente();

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

                Console.WriteLine("usted esta realizando una compra : ");
                Console.WriteLine("Lista de productos");
                var ListarProductos = CrudFloristeria.ListarProductos();
                foreach (var iteracionproducto in ListarProductos)
                {
                    Console.WriteLine($"ID {iteracionproducto.IdProducto},Nombre del producto {iteracionproducto.NombreProducto},precio del producto {iteracionproducto.Precio}, descripcion del producto {iteracionproducto.Descripcion}");
                }


                Console.WriteLine("pulsa 1 para realizar una compra: ");
                Console.WriteLine("pulsa 0 para salir");

            }
        }
        break;
}

