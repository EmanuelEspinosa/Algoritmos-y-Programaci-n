using System;

namespace Ejercicio_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] words = new string[]{"computadora","biblioteca","libro","monitor"};
            int pos = 0; 
            double promedio = 0, suma = 0;
            arrayString(words, pos, suma, ref promedio);
            Console.WriteLine("La longitud promedio del arreglo de strings es: {0}",promedio);
            Console.ReadKey();
		}
		public static void arrayString(string[] palabras, int indice, double sumatoria, ref double prom)
        {
            if(indice == palabras.Length)
            {
                prom = sumatoria / palabras.Length;
            }
            else
            {
                sumatoria += palabras[indice].Length;
                arrayString(palabras, indice + 1, sumatoria, ref prom);
            }
        }
	}
}