using System;
using System.Collections;

namespace Ejercicio_8
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList apellidoList = new ArrayList();
            int ind = 0;
            string last_name;
            Console.WriteLine("La carga de los datos finaliza con 'espacio vacio' + intro");
            Console.WriteLine("Cargue apellidos a la lista: ");
            last_name = Console.ReadLine();
            while(last_name != " ")
            {
                apellidoList.Add(last_name);
                Console.WriteLine("Ingrese otro apellido");
                last_name = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Ingrese un apellido para buscarlo en la lista: ");
            string apellido = Console.ReadLine();
            if(existeApellido(apellidoList, ind, apellido))
            {
                Console.WriteLine("El apellido << {0} >> EXISTE en la lista", apellido);
            }
            else
            {
                Console.WriteLine("El apellido << {0} >> NO EXISTE en la lista", apellido);
            }
            Console.ReadKey();
		}
		public static bool existeApellido(ArrayList lastName, int indice, string apellido)
        {
            if(indice != lastName.Count)
            {
                if((string)lastName[indice] == apellido)
                {
                    return true;
                }
                else
                {
                    return existeApellido(lastName, indice + 1, apellido);
                }
            }
            return false;
        }
	}
}