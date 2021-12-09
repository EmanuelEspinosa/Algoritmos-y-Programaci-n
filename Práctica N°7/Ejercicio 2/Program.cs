using System;

namespace Ejercicio_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*Las excepciones creadas por el usuario deben ser levantadas por el propio usuario cuando sea necesario*/
            /*En este caso la excepción no es atrapada porque falta el comando throw que es el encargado de disparar*/ 
            /*la excepción. Como la condición del if dice que la excepción se levanta cuando jefe es false, en este caso*/
            /*la excepción no se disparara ya que jefe = true y por consecuencia se pasara a ejecutar el*/
            /*Console.WriteLine("Bienvenido jefe");. Ocurriría lo contrario si jefe = false, en ese caso la condición del if*/
            /*resultaría verdadera y se dispararía la excepción con el mensaje "No está autorizado"*/
            
            /*bool jefe = true;
            try
            {
                if(!jefe)                        
                {                               
                    new NoEsElJefeException(); 
                }                            
                Console.WriteLine("Bienvenido jefe");
            }
            catch(NoEsElJefeException)
            {
                Console.WriteLine("No está autorizado");
            }*/
            
            /*Para que la excepción sea capturada y pueda dispararse con el mensaje "No está autorizado"*/
            /*el código debe escribirse de la siguiente manera*/
            
            bool jefe = false;
            try
            {
                if(!jefe)
                {
                    throw new NoEsElJefeException();
                }
                Console.WriteLine("Bienvenido jefe");
            }
            catch(NoEsElJefeException)
            {
                Console.WriteLine("No esta autorizado");
            }
            Console.ReadKey();
		}
		public class NoEsElJefeException : Exception
    	{

    	}

	}
}