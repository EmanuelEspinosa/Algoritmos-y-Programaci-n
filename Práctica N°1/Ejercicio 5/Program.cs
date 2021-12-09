using System;

namespace Ejercicio_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			float numero, maximo =-99999, minimo =99999, suma = 0, contador = 0, promedio;
            string respuesta;
            Console.WriteLine("Hay números para ingresar: ");
            respuesta = Console.ReadLine();
            respuesta = respuesta.ToUpper();
            while (respuesta == "SI")
            {
                Console.Write("Ingrese un numero: ");
                numero = float.Parse(Console.ReadLine());
                contador++;
                suma+=numero;
                if (numero > maximo)
                {
                    maximo=numero;
                }
                if (numero < minimo)
                {
                    minimo=numero;
                }
                Console.WriteLine("Hay números para ingresar: ");
                respuesta = Console.ReadLine();
                respuesta=respuesta.ToUpper();
            }
            if (contador != 0)
            {
                promedio = suma / contador;
                Console.WriteLine("El valor maximo es: " + maximo);
                Console.WriteLine("El valor minimo es: " + minimo);
                Console.WriteLine("El promedio es: " + promedio);
            }
            else Console.WriteLine("No se leyeron números");
            Console.ReadKey();
		}
	}
}