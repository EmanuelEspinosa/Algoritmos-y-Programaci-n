using System;

namespace Ejercicio_6
{
	class Persona
    {
        public int age, dni;
        public string name;

        public Persona()
        {

        }
        public Persona(string nomb, int edd, int ident)
        {
            name = nomb;
            age = edd;
            dni = ident;
        }
        public void imprimir()
        {
            Console.WriteLine(name + " " + "("+age+")" + " " + " " + dni);
        }
        public void esMayorQue(Persona[] p)
        {
            Persona per_aux = new Persona();
            int max=int.MinValue;
            string nombre="";

            for(int i=0; i < p.Length; i++)
            {
                per_aux = (Persona)p[i];
                if(per_aux.age > max)
                {
                    max = per_aux.age;
                    nombre = per_aux.name;    
                }
            }
            Console.WriteLine("\nLa persona de mayor edad es: {0} con {1} años", nombre, max);   
        }
    }
}
