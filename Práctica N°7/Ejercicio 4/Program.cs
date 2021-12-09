using System;

namespace Ejercicio_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			int a = 3;
           Console.WriteLine("Entrando");
           try
           {
               Console.WriteLine("Hola");
               A(a);
               Console.WriteLine("Chau");
           }
           catch(UnErrorException)
           {
               Console.WriteLine("oh oh");
           }
           catch(Exception)
           {
               Console.WriteLine("Pucha");
           }
           finally
           {
               Console.WriteLine("Saliendo");
           }
           Console.ReadKey();
		}
		public static void A(int n)
        {
            try
            {
                if(n == 1)
                {
                    throw new UnErrorException();
                }
                B(n);
            }
            catch(OtroErrorException)
            {
                Console.WriteLine("Vaya!");
            }
            finally
            {
                Console.WriteLine("OK");
            }
        }
		public static void B(int n)
        {
            if(n == 2)
            {
                throw new OtroErrorException();
            }
            throw new OverflowException();
        }
	}
	class UnErrorException : Exception
	{
		
	}
	class OtroErrorException : Exception
	{
		
	}
}
/*Cuando a = 1 se obtiene: Entrando Hola OK Oh Oh Saliendo*/
/*Cuando a = 2 se obtiene: Entrando Hola Vaya! OK Chau Saliendo*/
/*Cuando a = 3 se obtiene: Entrando Hola OK Pucha Saliendo*/
