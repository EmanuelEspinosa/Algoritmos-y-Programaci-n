using System;

namespace Ejercicio_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			int [] arr = new int[]{5,4,7,9,1};
           int ubic, t;
           Console.Write("Ingrese un número para buscar su posición dentro del arreglo: ");
           t = Convert.ToInt32(Console.ReadLine());
           try
           {
               ubic = posicion(arr, t);
               if(ubic == 0)
               {
                   throw new NoSeEncuentraNumero();
               }
               Console.WriteLine("\nEl número ingresado se encuentra en la posición << {0} >> del arreglo",ubic);
           }
           catch(NoSeEncuentraNumero)
           {
               Console.WriteLine("\nEl número ingresado NO se encuentra en el arreglo");
           }           
           Console.ReadKey();
		}
		public static int posicion(int[]a, int v)
        {
            int pos=0;
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] == v)
                {
                    pos = i;
                }
            }
            return pos;
        }
	}
	class NoSeEncuentraNumero : Exception
	{
		
	}
}