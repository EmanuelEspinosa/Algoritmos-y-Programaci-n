using System;

namespace Ejercicio_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num;
			Console.WriteLine("******** FACTORIAL DE UN NÚMERO ********\n");
			Console.Write("Introduzca un número entero: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Su factorial es: {0}", Factorial(num));
            Console.ReadKey();
		}
		public static int Factorial (int n)
        {
            if(n == 1)
            {
                return 1;
            }
            return n * Factorial(n-1);
        }
	}
}