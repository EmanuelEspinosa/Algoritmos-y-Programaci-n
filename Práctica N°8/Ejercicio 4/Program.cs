using System;

namespace Ejercicio_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] arr = new int[]{2,5,14,7,11,8};
            int tam = arr.Length;
            int posicion = 0;
            int contador = 0; /*variable que paso como parámetro para contar los elementos pares*/
            float porcent = 0; /*variable donde me devolverá el porcentaje*/
            
            Recorrer(arr, posicion, tam, contador, ref porcent);
            Console.WriteLine("El porcentaje de números pares es: {0}%", porcent);
            Console.ReadKey();
		}
		public static void Recorrer(int[] arreglo, int indice, int tamañoArr, int contPares, ref float porcentaje)
        {
            if(indice == tamañoArr)
            {
                porcentaje = (contPares * 100) / tamañoArr;
            }
            else
            {
                if(arreglo[indice] % 2 == 0)
                {/*Si se el elemento es par se incrementa el contador de pares y se incrementa el indice */
                 /*para apuntar al siguiente elemento del arreglo*/

                    Recorrer(arreglo, indice + 1, tamañoArr, contPares + 1, ref porcentaje);
                }   
                else
                { /*Si el elemeto no es un número par, entonces no se incrementa el contador de pares*/
                  /*pero se incrementa el indice para apuntar al siguiente elemento del arreglo*/

                    Recorrer(arreglo, indice + 1, tamañoArr, contPares, ref porcentaje);
                }
            }
        }
	}
}