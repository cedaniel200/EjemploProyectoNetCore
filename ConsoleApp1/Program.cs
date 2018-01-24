using System;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Calculadora!");
            while (true)
            {
                Console.WriteLine("Ingresa los numero que quieras sumar separados por espacio");
                string numeros = Console.ReadLine();
                var numerosSumar = ObtenerArregloNumeros(numeros);
                var resultado = Sumar(numerosSumar);
                Console.WriteLine("El resultado de la suma es: {0}", resultado);
            }            
        }

        private static long[] ObtenerArregloNumeros(string numeros)
        {
            long[] arregloNumeros;
            try
            {
                arregloNumeros = IntentarObtenerArregloNumeros(numeros);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                arregloNumeros = new long[0];
            }
            return arregloNumeros;
        }

        private static long[] IntentarObtenerArregloNumeros(string numeros)
        {
            string[] arreglo = numeros.Split(" ");
            var resultado = new long[arreglo.Length];
            for (int i = 0; i < arreglo.Length; i++)
            {
                long num;
                long.TryParse(arreglo[i], out num);
                resultado[i] = num;
            }

            return resultado;
        }

        public static long Sumar(long[] numeros)
        {
            long resultado = 0;
            foreach (long numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }
    }
}
