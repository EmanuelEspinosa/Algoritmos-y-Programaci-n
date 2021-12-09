using System;
using System.Collections;

namespace Ejercicio_3___Ejercicio_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList lista_personas = new ArrayList();
            string nombre;
            Console.Write("Ingrese nombre de la persona a registrar: ");
            nombre = Console.ReadLine();
            while (nombre!=" ") 
            {
            	Persona people = new Persona();
            	people.nombre = nombre;
            	Console.Write("Ingrese edad: ");
                people.edad = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese DNI: ");
                people.dni = Convert.ToInt32(Console.ReadLine());
                lista_personas.Add(people);
                Console.Write("Ingrese nombre de la persona a registrar: ");
                nombre = Console.ReadLine();
               }
            Console.Clear();
            Persona people1 = new Persona();
            for (int i=0; i < lista_personas.Count; i++)
            {
                people1 = (Persona)lista_personas[i];
                Console.Write(i+1 + ")");
                people1.imprimir();
            }
            Console.ReadKey();
		}
	}
}