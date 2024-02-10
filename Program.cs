using Microsoft.VisualBasic;

namespace ejercicio7Fechas
{
    /// <summary>
    /// Clase principal de programa
    /// msm - 100224
    /// </summary>
    class Program
    {

        /// <summary>
        /// Metodo que contiene el procedimiento del programa
        /// msm - 100224
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            Console.WriteLine("Inserte una fecha");
            DateTime fecha = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Ahora Inserte un numero dias para sumar a la fecha");
            int dias = Convert.ToInt32(Console.ReadLine());

            //Para sumar
            DateTime fechaDiasSuma = fecha.AddDays(dias);
            Console.WriteLine(" ");
            Console.WriteLine("La fecha + numero dias");
            Console.WriteLine("-------------------------");
            Console.WriteLine(fechaDiasSuma.ToString("dd" + "/MM" + "/yyyy"));


            //Para restar
            Console.WriteLine(" ");
            Console.WriteLine("Ahora Inserte un numero dias para restar a la fecha");
            dias = Convert.ToInt32(Console.ReadLine());
            DateTime fechaDiasRestar = fechaDiasSuma.AddDays(- dias);
            Console.WriteLine(" ");
            Console.WriteLine("La fecha + numero dias");
            Console.WriteLine("-------------------------");
            Console.WriteLine(fechaDiasRestar.ToString("dd" + "/MM" + "/yyyy"));
        }
    }
}