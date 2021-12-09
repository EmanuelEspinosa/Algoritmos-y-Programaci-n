using System;

namespace Ejercicio_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int x = 0;
            try
            {
                Console.WriteLine(1.0 / x);
                Console.WriteLine("Si es un numero real, hace la división por cero");
                Console.WriteLine(1/x);
                Console.WriteLine("Ok");
            }
            catch(Exception)
            {
                Console.WriteLine("No puede dividir por cero un numero entero");
            }
            Console.ReadKey();
		}
	}
}