using System;

namespace Ejercicio_7
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Introducir una palabra para ver si es palindroma:");
            string palabra = Console.ReadLine();
            if(esPalindroma(palabra))
            {
                Console.WriteLine("Es palíndroma");
            }
            else
            {
                Console.WriteLine("NO Es palíndroma");
            }
            Console.ReadKey();
		}
		public static bool esPalindroma(string palabra)
        {
            if(palabra.Length < 2)
            {
                return true;
            }
            if(palabra[0] == palabra[palabra.Length -1]) /*Si la primera letra de la palabra es igual a la ultima...*/
            {
                return esPalindroma(palabra.Substring(1, palabra.Length - 2));
            }
            return false;
        }
	}
}