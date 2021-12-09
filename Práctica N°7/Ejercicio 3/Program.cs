using System;

namespace Ejercicio_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			try
            {
                metodo1();
            }
            catch(Exception)
            {
                Console.WriteLine("Método 1 propago una excepción");
            }
            Console.ReadKey();
		}
		public static void metodo1()
        {
            byte b = 255;
            try
            {
                b++;
            }
            finally
            {
                Console.WriteLine("bloque finally");
            }
		} /*Este programa imprime: bloque finally \n Método 1 propago una excepción*/
	}    /*El bloque finally se ejecuta siempre, haya o no una excepción*/
}       /*Tener en cuenta que el rango de valores del tipo de datos byte es de 0 a 255*/
       /*Como en metodo1() se le suma 1 a la variable b, quiere decir que se sobrepasa el rango permitido para el tipo*/
      /*de datos byte, a causa de ello se dispara la excepción con el mensaje "Método 1 propago una excepción"*/