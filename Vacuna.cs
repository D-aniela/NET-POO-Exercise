using System;
using System.Collections.Generic;
using System.Text;

namespace DPRN2_U2_EA_LAEI
{
    public class Vacuna
    {
        public virtual void EfectoSecundario()
        {
            Console.WriteLine("Efecto secundario");
        }
        public virtual void InformacionGeneral()
        {
            Console.WriteLine("Informacion general");
        }
        public virtual void PasosVacuna()
        {
            Console.WriteLine("---- Pasos de vacuna ----");
            Console.WriteLine("\n1. Estire el brazo");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("2. No se mueva");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("3. Espere unos segundos\n");

            Console.WriteLine("1");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("2");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("3");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("4");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("5");
            System.Threading.Thread.Sleep(1000);

            Console.Clear();
            Console.WriteLine("4. Se ha finalizado el proceso de vacunación");
        }

        public virtual void FechaActual()
        {
            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            Console.WriteLine("\nFecha de vacunación: {0}", date);
            Console.WriteLine("\nDEBE REGRESAR EN DOS SEMANAS PARA APLICACIÓN DE SEGUNDA DOSIS A PARTIR DE ESTA FECHA");
            System.Threading.Thread.Sleep(5000);

        }
    }
}
