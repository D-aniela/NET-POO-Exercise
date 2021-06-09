using System;
using System.Collections.Generic;
using System.Text;

namespace DPRN2_U2_EA_LAEI
{
    public class VacunaPfizer : Vacuna
    {
        public override void EfectoSecundario()
        {
            Console.WriteLine("\n---- Efectos Secundarios Pfizer ----");
            Console.WriteLine("\n" +
                "\n 1. Dolor, enrojecimiento e hinchazón donde se recibió la vacuna" +
                "\n 2. Cansancio, dolor de cabeza y muscular" +
                "\n 3. Escalofrios, fiebre y náuseas" +
                "\n");
        }
        public override void InformacionGeneral()
        {
            Console.WriteLine("\n---- Informacion General pfizer -----");
            Console.WriteLine("\n" +
                "\n Cantidad de dosis: 2 dosis con 21 días de diferencia" +
                "\n No contiene huevo ni latex" +
                "\n - Esta vacuna protege contra enfermedades infecciosas, " +
                "\n - Enseñan a nuestras célular a producir una proteína, o incluso una porción de una proteína, que desencadena una respuesta inmunitaria dentro de nuestro organismo." +
                "\n - El beneficio de la vacuna es que las personas que se vacunan tienen protección sin correr el riesgo de sufrir consecuencias graves en el caso de infectarse por el COVID-19.");
        }
    }

    public class VacunaAztra : Vacuna
    {
        public override void EfectoSecundario()
        {
            Console.WriteLine("\n---- Efectos Secundarios Aztrazeneca ----");
            Console.WriteLine("\n" +
                "\n 1. El 22.8% de las personas presentaron dolor de cabeza." +
                "\n 2. Fátiga." +
                "\n 3. Sensibilidad." +
                "\n");
        }
        public override void InformacionGeneral()
        {
            Console.WriteLine("\n---- Informacion General aztra ----");
            Console.WriteLine("\n"+
                "\n La vacuna AZD1222 contra la COVID-19 tiene una eficacia del 63,09% contra la infección sintomática por SARS-CoV-2." +
                "\n Los intervalos más amplios entre dosis dentro del rango de 8 a 12 semanas están asociados a una mayor eficacia de la vacuna." +
                "\n Las personas con antecedentes de reacción alérgica fuerte a algún componente de la vacuna no deberían vacunarse." +
                "\n No se recomienda la vacuna para menores de 18 años, a reserva de los resultados de nuevos estudios." +
                "\n");
                    }
    }

    public class VacunaSputnik : Vacuna
    {
        public override void EfectoSecundario()
        {
            Console.WriteLine("\n---- Efectos Secundarios Sputnik ----");
            Console.WriteLine("\n" +
                "\n 1. Dolor en la zona de la inyección." +
                "\n 2. Síntomas similares a la gripe incluida fiebre." +
                "\n 3. Debilidad, fatiga y dolor de cabeza." +
                "\n");
        }
        public override void InformacionGeneral()
        {
            Console.WriteLine("\n---- Información General Sputnik ----");
            Console.WriteLine("\n" +
                "\n - La vacuna Sputnik V tiene una efectividad del 97.6% contra el Covid-19 en una evaluación del “mundo real” basada en datos de 3.8 millones de " +
                " personas, de acuerdo con el Instituto Gamaleya de Moscú y el Fondo de Inversión Directa de Rusia (RDIF), sus desarrolladores.." +
                "\n - La vacuna contra el coronavirus Sputnik V ofrece alrededor de 92% de protección contra covid-19." +
                "\n - La vida útil de la vacuna es de 3 meses a partir de la fecha de producción. Una vez descongelada" +
                "e deberá usar dentro de los primeros 120 minutos y no se puede volver a congelar.");
        }
    }
}
