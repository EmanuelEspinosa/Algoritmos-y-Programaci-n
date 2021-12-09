using System;

namespace Ejercicio_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			menu(); 
			Console.ReadKey();
		}
		public static void suma(double a, double b)
		{
			double sum = a + b; 
			Console.WriteLine("El resultado de la suma es: {0}", sum);
		}
		public static void resta(double a, double b)
		{
			double res = a - b; 
			Console.WriteLine("El resultado de la resta es: {0}", res);
		}
		public static void multiplicacion(double a, double b)
		{
			double mult = a * b; 
			Console.WriteLine("El resultado de la multiplicación es: {0}", mult);
		}
		public static void division(double a, double b)
		{
			double div = a / b; 
			Console.WriteLine("El resultado de la división es: {0}", div);
		}
		public static void menu()
		{
			int opcion, num1, num2; 
			Console.WriteLine("         CALCULADORA "); 
			Console.WriteLine("SELECCIONE LA OPERACIÓN ARITMETICA QUE DESEA REALIZAR"); 
			Console.WriteLine("         SUMA = OPCION 1 "); 
			Console.WriteLine("         RESTA = OPCION 2 "); 
			Console.WriteLine("      MULTIPLICACION = OPCION 3 " ); 
			Console.WriteLine("        DIVISION = OPCION 4 "); 
			Console.WriteLine("    FINALIZAR PROGRAMA = OPCION 5 "); 
			opcion = Convert.ToInt32(Console.ReadLine());
			
			while(opcion != 5)
			{
				if(opcion == 1)
				{
					Console.Write("Ingrese el primer número: "); 
					num1 = Convert.ToInt32(Console.ReadLine()); 
					Console.Write("Ingrese segundo número: "); 
					num2= Convert.ToInt32(Console.ReadLine()); 
					suma(num1, num2);
				}
				else if(opcion == 2)
				{
					Console.Write("Ingrese el primer número: "); 
					num1 = Convert.ToInt32(Console.ReadLine()); 
					Console.Write("Ingrese segundo número: "); 
					num2= Convert.ToInt32(Console.ReadLine()); 
					resta(num1, num2);
				}
				else if(opcion == 3)
				{
					Console.Write("Ingrese el primer número: "); 
					num1 = Convert.ToInt32(Console.ReadLine()); 
					Console.Write("Ingrese segundo número: "); 
					num2= Convert.ToInt32(Console.ReadLine()); 
					multiplicacion(num1, num2);
				}
				else if(opcion == 4)
				{
					Console.Write("Ingrese el primer número: "); 
					num1 = Convert.ToInt32(Console.ReadLine()); 
					Console.Write("Ingrese segundo número: "); 
					num2= Convert.ToInt32(Console.ReadLine()); 
					division(num1, num2);
				}
				else
				{
					Console.WriteLine("!!! INGRESO UNA OPCIÓN INVALIDA ¡¡¡");
				}
				Console.WriteLine("Ingrese una opción : "); 
				opcion = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("PROGRAMA FINALIZADO");
		}
	}
}