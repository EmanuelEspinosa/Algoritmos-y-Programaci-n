using System;
using System.Collections;

namespace Ejercicio_7
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList lista = new ArrayList();
            
            double num1, num2;
            string operacion;
            Console.Write("INGRESE '+' PARA SUMAR\nINGRESE '-' PARA RESTAR\nINGRESE '*' PARA MULTIPLICAR\nINGRESE '/' PARA DIVIDIR");
            Console.Write("\nINGRESE '=' PARA FINALIZAR\n");
            Console.Write("\nIngrese la operacion a realizar: ");
            operacion=Console.ReadLine();
            while(operacion != "=")
            {
                Console.Write("Ingrese primer número: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Operacion oper = new Operacion(num1, num2, operacion);
                lista.Add(oper);
                Console.Write("Ingrese la operacion a realizar: ");
                operacion=Console.ReadLine();
            }
            Console.Clear();
            Operacion oper_aux = new Operacion();
            oper_aux.evaluar(lista);
            Console.ReadKey();
		}
	}
}