using System;

namespace Ejercicio_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			int mes;
            Console.Write("Ingrese número de mes: ");
            mes = int.Parse(Console.ReadLine());
            switch (mes)
            {
                case 1:
                    Console.WriteLine("El número " + mes + " corresponde al mes de Enero");
                    break;
                case 2:
                    Console.WriteLine("El número " + mes + " corresponde al mes de Febrero");
                    break;
                case 3:
                    Console.WriteLine("El número " + mes + " corresponde al mes de Marzo");
                    break;
                case 4:
                    Console.WriteLine("El número " + mes + " corresponde al mes de Abril");
                    break;
                case 5:
                    Console.WriteLine("El número " + mes + " corresponde al mes de Mayo");
                    break;
                case 6:
                    Console.WriteLine("El número " + mes + " corresponde al mes de Junio");
                    break;
                case 7:
                    Console.WriteLine("El número " + mes + " corresponde al mes de Julio");
                    break;
                case 8:
                    Console.WriteLine("El número " + mes + " corresponde al mes de Agosto");
                    break;
                case 9:
                    Console.WriteLine("El número " + mes + " corresponde al mes de Septimebre");
                    break;
                case 10:
                    Console.WriteLine("El número " + mes + " corresponde al mes de Octubre");
                    break;
                case 11:
                    Console.WriteLine("El número " + mes + " corresponde al mes de Noviembre");
                    break;
                case 12:
                    Console.WriteLine("El número " + mes + " corresponde al mes de Diciembre");
                    break;
                default:
                    Console.WriteLine("Mes inválido");
                    break;
            }
            Console.ReadKey();
		}
	}
}