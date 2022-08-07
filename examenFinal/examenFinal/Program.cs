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
                int pEvP = 0;
                int sEvP = 0;
                int EF = 0;
                int acumulado = 0;
                string decision;

                pp:
                Console.Write("Ingrese el acumulado de la primera evaluación parcial: ");
                pEvP = int.Parse(Console.ReadLine());
                if (pEvP > 35)
                {
                    Console.WriteLine("El acumulado de la primera evaluación parcial no puede ser mayor a 35");
                    pEvP = 0;
                    goto pp;
                }
                sp:
                Console.Write("Ingrese el acumulado de la segunda evaluación parcial: ");
                sEvP = int.Parse(Console.ReadLine());
                if (sEvP > 35)
                {
                    Console.WriteLine("El acumulado de la segunda evaluación parcial no puede ser mayor a 35");
                    sEvP = 0;
                    goto sp;
                }
                f:
                Console.Write("Ingrese el acumulado del examen final: ");
                EF = int.Parse(Console.ReadLine());
                if (EF > 30)
                {
                    Console.WriteLine("El acumulado del examen final no puede ser mayor a 30");
                    EF = 0;
                    goto f;
                }

                acumulado = pEvP + sEvP + EF;

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
                    case int n when (n > 100):
                        Console.WriteLine("La suma de las calificaciones no puede se mayor a 100 verifique los valores ingresados" +
                            " y trate de nuevo");
                        goto inicio;
                        break;
                }
                Console.Write("Desea procesar otro la calificación de otro estudiante? (s = Si n = No): ");
                decision = Console.ReadLine();
                if (decision == "S" || decision == "s")
                {
                    goto inicio;
                    
                }
                else
                {
                    Environment.Exit(0);    
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Ha ocurrido un error inesperado, verifique si el valor ingresado" +
                    " es un número entero valido");
                goto inicio;
            }
        }
    }
}
