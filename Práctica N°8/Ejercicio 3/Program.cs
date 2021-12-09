using System;
using System.Collections;

namespace Ejercicio_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList listFibonacci = new ArrayList();
            int t,r;
            Console.WriteLine("Ingrese un número: ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for(int i = 0; i <= t; i++)
            {
                r = fibonacci(i);
                listFibonacci.Add(r);
            }
            Console.Write("La serie Fibonacci del número {0} es: ", t);
            foreach(var element in listFibonacci)
            {
                Console.Write(element + " ");
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