using System;
using Calculadora;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            string numeroTexto;
            bool resultado;
            int cuadrado = 0;
            int cubo = 0;

            do
            {
                Console.WriteLine("Ingrese un numero:");
                numeroTexto = Console.ReadLine();
                resultado = double.TryParse(numeroTexto, out numero1);

            } while (!resultado);

        }
    }
}
