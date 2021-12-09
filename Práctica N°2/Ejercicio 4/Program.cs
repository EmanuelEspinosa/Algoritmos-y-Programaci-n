using System;

namespace Ejercicio_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			string palabra;
            
            Console.WriteLine("Ingrese palabra: ");
            palabra = Console.ReadLine();
            if (palabra != " ")
            {
                int con_porcentaje = 0;
                int suma_caracteres = 0;
                int cantidad_palabras = 0;

                while(palabra != " ")
                {
                    int longitud = palabra.Length;
                    Console.WriteLine("Longitus de palabra {0}: {1}", palabra, longitud);
                    if (palabra[0] == 's')
                    {
                        con_porcentaje++;
                    }
                    suma_caracteres += longitud;
                    cantidad_palabras++;
                    Console.WriteLine("Ingrese palabra: ");
                    palabra = Console.ReadLine();

                }
                float promedio_ca = (float)suma_caracteres / cantidad_palabras;
                float porcentaje = (float)(con_porcentaje * 100) / cantidad_palabras;
                Console.WriteLine("Porcentaje de palabras que empiezan con 's': {0}%\nPromedio de caracteres por palabra: {1}",porcentaje,promedio_ca);
            }
            else
            {
                Console.WriteLine("No se ingreso nada. ");
            }
            Console.ReadKey();
		}
	}
}