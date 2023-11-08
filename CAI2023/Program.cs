using System;
using CAI2023Entidades;
using CAI2023Negocio;
using CAI2023Consola.Utilidades;
using System.Collections.Generic;

namespace CAI2023Consola
{
    class Program
    {
        private static UsuarioNegocio usuarioNegocio;
        private static ProveedorNegocio proveedorNegocio;
        private static VentaNegocio ventaNegocio;
        private static ProductoNegocio productoNegocio;
        private static ReporteNegocio reporteNegocio;

        static void Main(string[] args)
        {
            proveedorNegocio = new ProveedorNegocio();
            ventaNegocio = new VentaNegocio();
            reporteNegocio = new ReporteNegocio();
            productoNegocio = new ProductoNegocio();
            usuarioNegocio = new UsuarioNegocio();

            Console.WriteLine("Bienvenido a Cai 2023 - Gestion de Stock!\n");
            Console.ReadLine();

            MenuPrincipal();
        }

        public static void MenuPrincipal()
        {
            Console.WriteLine("1. Iniciar sesión");
            Console.WriteLine("2. Registrarse");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            int valor;
            valor = Validaciones.PedirInt("\nSeleccione una opcion:", 0, 2);
            Console.Clear();
            do
            {
                switch (valor)
                {
                    case 0:
                        Console.WriteLine("Muchas gracias por usar el sistema!!\nPresiona una tecla para salir");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    case 1:
                        Login();
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Registro();
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }

                static Usuario Registro()
                {
                        /// armar una lista con usuarios admin 

                        Guid id = Validaciones.PedirGui("Ingrese el nombre del usuario:");
                        string nombre = Validaciones.PedirStr("Ingrese un apellido para el usuario:");
                        string apellido = Validaciones.PedirStr("Ingrese un apellido para el usuario:");
                        string direccion = Validaciones.PedirStr("Ingrese una dirección para el usuario:");
                        string telefono = Validaciones.PedirStr("Ingrese un numero de teléfono para el usuario:"); ;
                        string email = Validaciones.PedirEmail("Ingrese un email para el usuario");
                        DateTime fechaAlta = Validaciones.PedirFecha("ingrese fecha");
                        DateTime fechaNacimiento = Validaciones.PedirFecha("ingrese fecha");
                        DateTime fechaBaja = Validaciones.PedirFecha("ingrese fecha");
                        int idUsuario = Validaciones.PedirInt("Ingrese el nombre del usuario:", 0, 1000000);
                        string host = Validaciones.PedirEmail("Ingrese un email para el usuario");
                        string nombreusuario = Validaciones.PedirStr("Ingrese un email para el usuario");
                        string contraseña = Validaciones.PedirStr("Ingrese una contraseña para el usuario");
                        string dni = Validaciones.PedirEmail("Ingrese un email para el usuario");
                        bool ingresar;

                        Usuario usuario = new Usuario(id, nombre, apellido, direccion, telefono, email, fechaAlta, fechaNacimiento, fechaBaja,idUsuario, host, dni);
                        Console.Clear();
                        ingresar = Validaciones.ValidarSN("Está a punto de ingresar el cliente, está de acuerdo?");
                        if (ingresar)
                        {
                            usuarioNegocio.AgregarUsuario(usuario);
                            Console.WriteLine("Cliente ingresado correctamente! Pulse una tecla para continuar");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Ha decidido no ingresar el cliente. Pulse una tecla para continuar");
                            Console.ReadKey();
                            usuario = null;
                        }
                        return usuario;
                    }

                    static void Login()
                    {

                    //valida el usuario y contraseña y dependiendo del host de usuario setea valor del menu a mostrar 
                        var usuarioDatos = new UsuarioNegocio();
                    }
            } while (valor != 0);
        }
   
    public static void MenuAdministrador()
        {
            Console.WriteLine("Esta en el menu Administrador");
            Console.WriteLine("Ingrese una opcion");
            Console.WriteLine("1 - Alta de usuario");
            Console.WriteLine("2 - Modificación de usuarios ");
            Console.WriteLine("3 - Baja de usuarios Supervisores");
            Console.WriteLine("7 - Alta de Proveedores");
            Console.WriteLine("8 - Modificación de Proveedores");
            Console.WriteLine("9 - Baja de Proveedores");
            Console.WriteLine("10 - Alta de Productos ");
            Console.WriteLine("11 - Modificación de Productos ");
            Console.WriteLine("12 - Baja de Productos");
            Console.WriteLine("13 - Reporte de stock crítico");
            Console.WriteLine("14 - Reporte de ventas por vendedor ");
            Console.WriteLine("15 - Reporte de productos más vendido por categoría");

            string opcionMenuAdmin;
            opcionMenuAdmin = Console.ReadLine();

            switch (opcionMenuAdmin)
            {
                case "1":
                    //AgregarUsuario();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    BajaDeUsuario();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "3":
                    ModificacionUsuario();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "4":
                    AltaProveedor();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "5":
                    ModificacionProveedor();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "6":
                    BajaProveedor();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "7":
                    AltaProductos();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "8":
                    ModificacionProductos();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "9":
                    BajaProductos();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "10":
                    Reportestock();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "11":
                    Reportesvtasporvendedor();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "12":
                    Reporteproductosporcat();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
           

             static void BajaDeUsuario()
            {
                Console.WriteLine("a completar");
            }

             static void ModificacionUsuario()
            {
                Console.WriteLine("a completar");
            }

            static void AltaProveedor()
            {
                Console.WriteLine("a completar");
            }

            static void BajaProveedor()
            {
                Console.WriteLine("a completar");
            }

            static void ModificacionProveedor()
            {
                Console.WriteLine("a completar");
            }

            static void Reporteproductosporcat()
            {
                Console.WriteLine("a completar");
            }

            static void AltaProductos()
            {
                Console.WriteLine("a completar");
            }

            static void ModificacionProductos()
            {
                Console.WriteLine("a completar");
            }

            static void BajaProductos()
                {
                    Console.WriteLine("a completar");
                }

                static void Reportestock()
            {
                Console.WriteLine("a completar");
            }

            static void Reportesvtasporvendedor()
             {
                Console.WriteLine("a completar");
            }
        }
    }
}
