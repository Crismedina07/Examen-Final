using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inicio:
            try
            {
                int acumulado = 0;
                string decision;

                Console.Write("Ingrese el acumulado del primer parcial: ");
                acumulado = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el acumulado del segundo parcial: ");
                acumulado = acumulado + int.Parse(Console.ReadLine());
                Console.Write("Ingrese el acumulado del examen final: ");
                acumulado = acumulado + int.Parse(Console.ReadLine());

                switch (acumulado)
                {
                    case int n when (n == 0 && n <= 59):
                        Console.WriteLine($"La calificacion es: {n} y la calificación alfabetica es F");
                        break;
                    case int n when (n >= 60 && n <= 69):
                        Console.WriteLine($"La calificacion es: {n} y la calificación alfabetica es D");
                        break;
                    case int n when (n >= 70 && n <= 79):
                        Console.WriteLine($"La calificacion es: {n} y la calificación alfabetica es C");
                        break;
                    case int n when (n >= 80 && n <= 89):
                        Console.WriteLine($"La calificacion es: {n} y la calificación alfabetica es B");
                        break;
                    case int n when (n >= 90 && n <= 100):
                        Console.WriteLine($"La calificacion es: {n} y la calificación alfabetica es A");
                        break;
                }
                Console.Write("Desea procesar otro la calificación de otro estudiante? ");
                decision = Console.ReadLine();
                switch (decision)
                {
                    case "s":
                        goto inicio;
                        break;
                    case "n":
                        Environment.Exit(0);
                        break;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Ha ocurrido un error inesperado: " + ex);
                goto inicio;
            }
        }
    }
}
