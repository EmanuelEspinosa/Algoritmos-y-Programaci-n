using System;

namespace Ejercicio_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			for (int i = 250; i <= 900; i+=2)
            {
                if (i % 5 == 0)
                Console.Write("{0}|", i);
            }
            Console.ReadKey();
		}
	}
}