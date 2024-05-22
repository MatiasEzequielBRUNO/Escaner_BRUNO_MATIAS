using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class IngresoDatos
    {
        public static string String(string mensaje)
        {
            string? dato;
            do
            {
                Console.WriteLine(mensaje);
                dato = Console.ReadLine();
                if (string.IsNullOrEmpty(dato))
                {
                    Console.WriteLine("Por favor, ingrese un dato válido.");
                }
            } while (string.IsNullOrEmpty(dato));
            return dato;
        }

        public static int Int(string mensaje)
        {
            int dato;
            do
            {
                Console.WriteLine(mensaje);
                if (int.TryParse(Console.ReadLine(), out dato))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
            } while (true);
            return dato;
        }

        public static float Float(string mensaje)
        {
            int dato;
            do
            {
                Console.WriteLine(mensaje);
                if (int.TryParse(Console.ReadLine(), out dato))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
            } while (true);
            return dato;
        }
    }

}
