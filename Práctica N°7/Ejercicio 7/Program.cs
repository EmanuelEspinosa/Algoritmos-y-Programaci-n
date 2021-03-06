using System;
using System.Collections;

namespace Ejercicio_7
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList lista1 = new ArrayList();
            ArrayList lista2 = new ArrayList();
            int numA, contA = 0, numB, es, contAciertos = 0, contIntentos = 0;
            Console.WriteLine("***************ADIVINANZA*****************\n");
            Console.WriteLine("           <<< JUGADOR 1 >>>\n");
            Console.WriteLine("Ingrese 0 para comenzar la carga de los números");
            numA = Convert.ToInt32(Console.ReadLine());
            lista1.Add(numA);
            Console.WriteLine("Elija 5 números comprendidos entre 1 y 10, sin repetir ninguno.");
            do
            {
                try
                {
                    Console.Write("Ingrese un numero: ");
                    numA = Convert.ToInt32(Console.ReadLine());
                    if((numA < 1)|(numA > 10))
                    {
                        string motivo = "\nEl número ingresado no esta en el rango solicitado. Ingrese el número nuevamente\n";
                        throw new NumInvalidoException(motivo);
                    }
                    if(!lista1.Contains(numA))
                    {
                        lista1.Add(numA);
                        contA++;
                    }
                    else
                    {
                        Console.WriteLine("\a\n\"Usted ya ingreso ese número. Ingrese otro\"\n");
                    }
                }
                catch(NumInvalidoException e)
                {
                    Console.WriteLine(e.motivo);
                }    
            }while(contA != 5);
            Console.Clear();            
            Console.WriteLine("           <<< JUGADOR 2 >>>\n");
            Console.WriteLine("       ADIVINE LOS NÚMEROS DEL JUGADOR 1");
            Console.WriteLine("Ingrese 5 números comprendidos entre 1 y 10, sin repetir ninguno.\n");
            do
            {                
                try
                {
                    Console.Write("Ingrese un numero: ");
                    numB = Convert.ToInt32(Console.ReadLine());
                    if((numB < 1)|(numB > 10))
                    {
                        string motivo = "\nEl número ingresado no esta en el rango solicitado. Ingrese el número nuevamente\n";
                        throw new NumInvalidoException(motivo);
                    }
                    es = posicion(lista1, numB);
                    if(es != 0)
                    {
                        if(!lista2.Contains(numB))
                        {
                            lista2.Add(numB);
                            contAciertos++;
                        }
                        else
                        {
                           Console.WriteLine("\a\n\"Usted ya ingreso ese número. Ingrese otro\"\n");
                           contIntentos++; 
                        }
                    }
                    if(es == 0)
                    {
                        Console.WriteLine("\nINTENTO FALLIDO. Este número no se encuentra dentro de los elegidos por el JUGADOR 1\n");
                        contIntentos++;
                    }

                }
                catch(NumInvalidoException e)
                {
                    Console.WriteLine(e.motivo);
                    contIntentos++;
                }    
            }while(contAciertos != 5);
            Console.Clear();
            
            Console.WriteLine("\n**********FELICITACIONES !!!  ADIVINO TODOS LOS NÚMEROS**********\n");
            Console.WriteLine("Usted necesito {0} intento para adivinar los numeros",contIntentos);
            Console.WriteLine("\n\nNOTA: Solo se contabilizan los intentos cuando se ingresa un numero incorrecto o repetido");
            Console.WriteLine("JUEGO FINALIZADO");
            
            
            Console.ReadKey(true);
		}
		public static int posicion(ArrayList a, int v)
        {
            int pos=0;
            for(int i = 0; i < a.Count; i++)
            {
                if((int)a[i] == v)
                {
                    pos = i;
                }
            }
            return pos;
        }
	}
	class NumInvalidoException : Exception
    {
        public string motivo;

        public NumInvalidoException(string motivo)
        {
            this.motivo = motivo;
        }
    }
}