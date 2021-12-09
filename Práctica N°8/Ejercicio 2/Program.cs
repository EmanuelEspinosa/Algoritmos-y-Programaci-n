using System;

namespace Ejercicio_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int t,r;
            Console.WriteLine("Ingrese un número: ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("La secuencia Fibonacci hasta el número {0} es: ", t);

            for(int i = 0; i <= t; i++)
            {
                r = fibonacci(i);
                Console.Write(r + ",");
            }
            Console.ReadKey();
		}
		public static int fibonacci (int n) 
        { 
            int r = 0;
            if (n <= 1)
            {
                r = 1;
            }   
            if(n > 1)
            {
                r = fibonacci(n-1) + fibonacci(n-2);
            }
            return r;             
        }
	}
}