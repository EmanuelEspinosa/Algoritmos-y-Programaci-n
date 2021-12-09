using System;
using System.Collections;

namespace Ejercicio_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList listaALUM=new ArrayList();
            ArrayList listaEsc=new ArrayList();
            int opcion;
            menu();
            opcion=int.Parse(Console.ReadLine());
            while(opcion != 6)
            {
                switch(opcion)
                {
                    case 1:
                        CargoDatos(listaALUM, listaEsc);
                        break;
                    case 2:
                        BorrarAlum(listaALUM);
                        break;
                    case 3:
                        Inscriptos(listaALUM);
                        break;
                    case 4:
                        TotalEscuelas(listaEsc);
                        break;
                    case 5:
                        lista_colegio(listaEsc);
                        break;
                    default:
                        System.Console.WriteLine("USTED INGRESO UNA OPCIÓN INVALIDA. \nINTENTELO NUEVAMENTE");
                        break;        
                }
                menu();
                opcion=Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("PROGRAMA FINALIZADO");
            Console.ReadKey();
		}
		public static void CargoDatos(ArrayList alumno, ArrayList escuela)
        {
            int dni;
            string institucion;
            Console.WriteLine("La carga de los datos finaliza cuando se ingresa DNI 0");
            Console.WriteLine("Ingrese DNI del alumno: ");
            dni=int.Parse(Console.ReadLine());

            while(dni != 0)
            {
                alumno.Add(dni);
                Console.WriteLine("Ingrese establecimiento educativo al que pertenece: ");
                institucion=Console.ReadLine();
                escuela.Add(institucion);
                Console.WriteLine("Ingrese DNI del alumno: ");
                dni=int.Parse(Console.ReadLine());
            }
        }
		public static void BorrarAlum(ArrayList baja_alum)
        {
            int dni1;
            Console.WriteLine("Ingrese el DNI del alumno a eliminar de la lista de inscriptos: ");
            dni1=int.Parse(Console.ReadLine());
            baja_alum.Remove(dni1);
        }
		public static void Inscriptos(ArrayList alum_insc)
        {
            Console.WriteLine("La cantidad de alumnos inscriptos es: {0}",alum_insc.Count);
        }
		public static void TotalEscuelas(ArrayList list_esc)
        {
            ArrayList Lista_Aux = new ArrayList();
            list_esc.Sort();
            for(int i = 1; i < list_esc.Count; i++)
            {
                string esc1 = (string)list_esc[i];
                string esc2 = (string)list_esc[i - 1];
                if(!Lista_Aux.Contains(esc1))
                {
                    Lista_Aux.Add(esc1);
                }
            }
            if(Lista_Aux.Count > 0)
            {
                Console.WriteLine("La cantidad de escuelas inscriptas es: {0}",Lista_Aux.Count);
            }
        }
		public static void lista_colegio(ArrayList list_esc)
        {
            ArrayList lista_aux = new ArrayList();
            list_esc.Sort();
            for(int j = 1; j < list_esc.Count; j++)
            {
                string esc1 = (string)list_esc[j];
                string esc2 = (string)list_esc[j - 1];
                if(!lista_aux.Contains(esc1))
                {
                    lista_aux.Add(esc1);
                }
            }
            if(lista_aux.Count > 0)
            {
                Console.WriteLine("Las escuelas cargadas en el sistema son: ");
                foreach(string coleg in lista_aux)
                {
                    Console.WriteLine(coleg);
                }
            }
            else
            {
                Console.WriteLine("No hay escuelas cargadas en el sistema");
            }
		}
		public static void menu()
        {
            Console.WriteLine("INSCRIPCION --- COMPETENCIA DE MATEMÁTICA---");
            Console.WriteLine("SELECCIONE LAS OPCIONES DEL MENU SEGUN LO QUE QUIERA REALIZAR: ");
            Console.WriteLine("1 -- INCRIBIR UN ALUMNO");
            Console.WriteLine("2 -- BORRAR UN ALUMNO");
            Console.WriteLine("3 -- MOSTRAR TOTAL DE ALUMNOS INSCRIPTOS");
            Console.WriteLine("4 -- MOSTRAR TOTAL DE ESCUELAS QUE PARTICIPARAN DE LA COMPETENCIA");
            Console.WriteLine("5 -- MOSTRAR EL LISTADO DE ESCUELAS QUE PARTICIPARAN DE LA COMPETENCIA");
            Console.WriteLine("6 -- FINALIZAR PROGRAMA");
        }
	}
}