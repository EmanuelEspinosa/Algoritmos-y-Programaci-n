using System;
using System.Collections;

namespace EXAMEN
{
	class Program
	{
		public static void Main(string[] args)
		{
			Constructora unaConstruc = new Constructora("TU CASA YA");
            int opcion;
            menu();
            Console.WriteLine("Ingrese una opcion");
            opcion = int.Parse(Console.ReadLine());
            while(opcion != 0)
            {
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("ingresar apellido del obrero: ");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Ingresar N° de legajo del obrero: ");
                        int legajo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingresar el cargo que ocupa: ");
                        string cargo = Console.ReadLine();
                        Obrero unObrero = new Obrero(apellido, legajo, cargo);
                        unaConstruc.agregarObrero(unObrero); 
                        break;
                    case 2:
                        Console.WriteLine("Ingrese codigo de la obra: ");
                        int cod = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese ubicacion de la obra: ");
                        string ubic = Console.ReadLine();
                        Console.WriteLine("Ingrese tipo de obra: ");
                        string tipo = Console.ReadLine();
                        Console.WriteLine("Ingrese fecha de la obra: ");
                        Console.WriteLine("Ingrese el dia: ");
                        int dia = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el mes: ");
                        int mes = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el año: ");
                        int año = Convert.ToInt32(Console.ReadLine());
                        DateTime fecha = new DateTime(año, mes, dia);
                        Obra unaObra = new Obra(cod,ubic,tipo,fecha);
                        unaConstruc.agregarObra(unaObra); 
                        break;
                    case 3:
                        ArrayList listObras = unaConstruc.verObras();
                        ArrayList listObreros = unaConstruc.verObreros();
                        try
                        {
                            Console.WriteLine("Ingrese codigo de obrero: ");
                            int codObrero = Convert.ToInt32(Console.ReadLine());
                            foreach (Obrero item in listObreros)
                            {
                                if(item.Legajo == codObrero)
                                {
                                    Console.WriteLine("Ingrese código de la obra: ");
                                    int codigoObra = Convert.ToInt32(Console.ReadLine());
                                    unaConstruc.asignarJefe(codigoObra,item);
                                }
                                if(item.Legajo != codObrero)
                                {
                                    string motivo = "NO EXISTE EL CÓDIGO DE OBRERO INGRESADO";
                                    throw new ObreroInexistenteException(motivo);
                                }
                            }

                        }
                        catch(ObreroInexistenteException e)
                        {
                            Console.WriteLine(e.motivo);
                        }
                        break;
                    case 4:
                        ArrayList listaDeObras = unaConstruc.verObras();
                        int cantObras = listaDeObras.Count;
                        Console.WriteLine("La cantidad de obras contratadas es: {0}", cantObras);
                        break;
                    case 5:
                        ArrayList listaObras = unaConstruc.verObras();
                        if(listaObras.Count == 0)
                        {
                            Console.WriteLine("No hay obras cargadas en el sistema");
                        }
                        if(listaObras.Count != 0)
                        {
                            Obra ObraAux = new Obra();
                            for (int i = 0; i < listaObras.Count; i++)
                            {
                                ObraAux = (Obra)listaObras[i];
                                if(ObraAux.Tipo == "Edificio")
                                {
                                    ObraAux.imprimir();
                                }
                                
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Ingreso una opcion incorrecta");
                        break;
                }
                menu();
                Console.WriteLine("Ingrese una opcion");
                opcion = int.Parse(Console.ReadLine());
            } 
            Console.ReadKey();
		}
		public static void menu()
        {
            Console.WriteLine("1. CARGAR OBREROS");
            Console.WriteLine("2. CARGAR OBRAS");
            Console.WriteLine("3. ASIGNAR JEFE DE OBRA");
            Console.WriteLine("4. VER CANTIDAD DE OBRAS CONTRATADAS");
            Console.WriteLine("5. VER LISTA DE LAS OBRAS TIPO EDIFICIOS CON SUS RESPECTIVOS JEFES");
        }
	}
}