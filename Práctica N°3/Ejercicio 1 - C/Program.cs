using System;
using System.Collections;

namespace Ejercicio_1___C
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList palabras = new ArrayList();
            string pal;
            bool es;
            Console.WriteLine("Ingrese palabras: \nPulse zzz para finalizar la carga");
            pal=Console.ReadLine();
            while (pal != "zzz")
            {
                palabras.Add(pal);
                Console.WriteLine("Ingrese palabras: ");
                pal = Console.ReadLine();
            }
            Console.Clear();
            
            foreach(string elemento in palabras)
            {
            	pal = elemento;
                es = pal_comp(pal);
                if (es == true)
                {
                    Console.WriteLine("La palabra {0} es palindroma", pal);
                }
                else
                {
                    Console.WriteLine("La palabra {0} NO es palindroma", pal);
                }
            }
            Console.ReadKey();
		}
		public static bool pal_comp(string palabra)
		{
			string palindromo=null;
            int tam;
            tam = palabra.Length;
            for(int j = tam - 1; j >= 0; j--)
            {
                palindromo += palabra[j];
            }
            if(palindromo == palabra)
            {
                return true;
            }
            else
            {
                return false;
            }
		}
	}
}