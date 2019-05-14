using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace metodos1
{
    class Program
    {
        static void Imprimir(int[] numeros)
        {
            foreach(int n in numeros)
            {
                Console.WriteLine("{0} ", n);
            }
        }
        static int[] GenerarTabla(int numInicial)
        {
            
            int[] numerosTabla = new int[10];
            int res = numInicial;
            for (int i = 0; i < numerosTabla.Length; i++)
            {
                numerosTabla[i] = res;
                res += numInicial;
            }
            return numerosTabla;
        }
        static void Main(string[] args)
        {
            int numerador = 2, denominador = 1;
            Racional fraccion = new Racional(denominador, numerador);
            Console.WriteLine(fraccion.ToString());
            fraccion.numerador = int.Parse(Console.ReadLine());
            Console.WriteLine(fraccion.ToString());
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] numeros = GenerarTabla(int.Parse(Console.ReadLine()));
            foreach(int n in numeros)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("{0} es par",n);
                }
                else
                {
                    Console.WriteLine("{0} es impar",n);
                }
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}