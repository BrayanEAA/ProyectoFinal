
using ProyectoFinal.Models;
using ProyectoFinal.DAO;

Crudfloristeria CrudFloristeria = new Crudfloristeria();
Producto producto = new Producto();
Cliente cliente = new Cliente();
Venta venta = new Venta();
Detallesventum Detallesventa = new Detallesventum();

Console.WriteLine("bienvenidos a la floristeria Petalo ");
Console.WriteLine("si uested es un trabajador de la empresa ingrese 1");
Console.WriteLine("si usted es un cliente presione 2");

var Menu = Convert.ToInt32(Console.ReadLine());

switch (Menu)
{

    case 1:
        Console.WriteLine("bienvenido a la interfaz para modificar y agregar productos ");
        Console.WriteLine("si desea agregar un producto presione 1");
        Console.WriteLine("si desea actualizar un producto presione 2");

        var menu1 = Convert.ToInt32(Console.ReadLine());

        if (menu1 == 1)
        {
            int bucle = 1;
            while (bucle == 1)
            {
                Console.WriteLine("usted esta agregando un producto");
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
        }
        else
        {
            Console.WriteLine("Actualizar Productos");
            Console.WriteLine("Ingresa el ID del producto a actualizar");
            var ProductoIndividualU = CrudFloristeria.productoIndividual(Convert.ToInt32(Console.ReadLine()));
            if (ProductoIndividualU == null)
            {
                Console.WriteLine("El Producto no existe no existe");
            }
            else
            {
                Console.WriteLine($"Nombre {ProductoIndividualU.NombreProducto} , Precio {ProductoIndividualU.Precio}");


                Console.WriteLine("Para actulizar nombre coloca el # 1");

                Console.WriteLine("Para actulizar el precio coloca el # 2");

                var Lector = Convert.ToInt32(Console.ReadLine());
                if (Lector == 1)
                {
                    Console.WriteLine("Ingrese el nombre");
                    ProductoIndividualU.NombreProducto = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Ingrese el precio");
                    ProductoIndividualU.Precio =  Convert.ToInt32(Console.ReadLine());
                }
                CrudFloristeria.ActualizarProducto(ProductoIndividualU, Lector);
                Console.WriteLine("Actualizacion correcta");
            }
        }
        break;

    case 2:
        Console.WriteLine("bienvenidos a la Floristeria ///////PETALO//////// ");
        Console.WriteLine("si usted ya es cliente presione 1 si es un cliente nuevo presione 2 ");
        var client = Convert.ToInt32(Console.ReadLine());

        if (client == 1)
        {
            Console.WriteLine("usted es un cliente existente por favor acceda");
            Console.WriteLine("Lista de productos");

            var lclientes = CrudFloristeria.ListarClientes();

            foreach (var iteracionCliente in lclientes)
            {
                Console.WriteLine($"ID ID: {iteracionCliente.IdCliente}:, Nombre: {iteracionCliente.NombreCliente} ");
            }
            Console.WriteLine("Ingrese su ID ");
            cliente.IdCliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su Nombre ");
            cliente.NombreCliente = Console.ReadLine();

            bool Resultado = CrudFloristeria.Acceso(cliente);
            if (Resultado == true)
            {
                Console.WriteLine("si existe");
            }
        }
        if (client == 2)
        {
            
            Console.WriteLine("usted es un nuevo cliente por favor registrese");
            Console.WriteLine("Por favor ingrese sus tados para continuar: ");
            Console.WriteLine("ingrese su Nombre: ");
            cliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("ingrese el su telefono ");
            cliente.Telefono = Console.ReadLine();
            Console.WriteLine("ingrese su correo electronico ");
            cliente.Email = Console.ReadLine();
            Console.WriteLine("ingrese su direccion: ");
            cliente.Direccion = Console.ReadLine();
            CrudFloristeria.AgregarCliente(cliente);
            Console.WriteLine("sus datos se registraron correctamente: ");
            Console.WriteLine($"su id es: {cliente.IdCliente} ");
        }
          
   
        break;
}



