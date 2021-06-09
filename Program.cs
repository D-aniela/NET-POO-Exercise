using System;

namespace DPRN2_U2_EA_LAEI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos objeto de vacuna
            Vacuna vacuna = new Vacuna();

            //Creamos objeto de los tipos de vacuna
            VacunaPfizer vacunaPfizer = new VacunaPfizer();
            VacunaAztra vacunaAztra = new VacunaAztra();
            VacunaSputnik vacunaSputnik = new VacunaSputnik();


            //Establecemos un menu de Vacunas a elegir
            while (true)
            {
                Console.WriteLine("\n---- Menu Vacunas ---- \nEscoga su vacuna" +
                                    "\n a. Pfizer" +
                                    "\n b. Aztrazeneca" +
                                    "\n c. Sputnik V" +
                                    "\n d. Aplicar segunda vacuna" +
                                    "\n x. Salir"); ;
                try
                {
                    var opcion = Console.ReadKey();

                    switch (opcion.KeyChar)
                    {
                        case 'a':
                            vacunaPfizer.InformacionGeneral();
                            vacunaPfizer.EfectoSecundario();
                            //Establecemos un menu de Aceptar términos
                            while (true)
                            {
                                Console.WriteLine("\n Menu.\n a. Aceptar Términos \n b. Regresar al menú \n x.- Salir. \n");
                                try
                                {
                                    var opcion2 = Console.ReadKey();
                                    switch (opcion2.KeyChar)
                                    {
                                        case 'a':
                                            //Establecemos menu para iniciar con el proceso de vacunacion
                                            while (true)
                                            {
                                                Console.WriteLine("\n a. Iniciar proceso \n x. Salir");
                                                try
                                                {
                                                    var opcion3 = Console.ReadKey();
                                                    switch (opcion3.KeyChar)
                                                    {
                                                        case 'a':
                                                            vacuna.PasosVacuna();
                                                            vacuna.FechaActual();
                                                            System.Environment.Exit(0);
                                                            break;
                                                        case 'x':
                                                            System.Environment.Exit(0);
                                                            break;
                                                    }
                                                    Console.WriteLine("\nPresione una tecla para continuar...");
                                                    Console.ReadKey();
                                                }
                                                catch (Exception)
                                                {
                                                    Console.WriteLine("Opcion no valida");
                                                }
                                            }

                                            break;
                                    }
                                    Console.WriteLine("Presione una tecla para continuar...");
                                    Console.ReadKey();
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Opcion no valida");
                                }
                            }
                            break;
                        case 'b':
                            vacunaAztra.InformacionGeneral();
                            vacunaAztra.EfectoSecundario();
                            //Establecemos el menu para aceptar terminos
                            while (true)
                            {
                                Console.WriteLine("\n Menu.\n a. Aceptar Términos \n b. Regresar al menú \n x.- Salir. \n");
                                try
                                {
                                    var opcion2 = Console.ReadKey();
                                    switch (opcion2.KeyChar)
                                    {
                                        case 'a':
                                            vacuna.PasosVacuna();
                                            vacuna.FechaActual();
                                            System.Environment.Exit(0);
                                            break;
                                        case 'x':
                                            System.Environment.Exit(0);
                                            break;
                                    }
                                    Console.WriteLine("\nPresione una tecla para continuar...");
                                    Console.ReadKey();
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Opcion no valida");
                                }
                            }
                            break;
                        case 'c':
                            vacunaSputnik.InformacionGeneral();
                            vacunaSputnik.EfectoSecundario();
                            //Establecemos menu para aceptar terminos y condiciones
                            while (true)
                            {
                                Console.WriteLine("\n Menu.\n a. Aceptar Términos \n b. Regresar al menú \n x.- Salir. \n");

                                try
                                {
                                    var opcion2 = Console.ReadKey();
                                    switch (opcion2.KeyChar)
                                    {
                                        case 'a':
                                            vacuna.PasosVacuna();
                                            vacuna.FechaActual();
                                            System.Environment.Exit(0);
                                            break;
                                        case 'x':
                                            System.Environment.Exit(0);
                                            break;
                                    }
                                    Console.WriteLine("\nPresione una tecla para continuar...");
                                    Console.ReadKey();
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Opcion no valida");
                                }
                            }
          
                            break;
                        case 'd':
                            vacuna.PasosVacuna();   
                            Console.WriteLine("Vacunación finalizada puede SALIR");
                            break;
                        case 'x':
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("\nEsta opcion no es valida!");
                            break;
                    }
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Opcion no valida");
                }
            }
        }
    }
}
