using System;

namespace Trabajo_Práctico_Final_Emanuel_Espinosa
{
	public class Persona
	{
		/*VARIABLES DE INSTANCIA*/
		protected string name, lastName;
        protected int documentNumber;
        
        /*CONSTRUCTORES*/
		public Persona()
		{
			
		}
		public Persona(string name, string lastName, int documentNumber)
        {
            this.name = name;
            this.lastName = lastName;
            this.documentNumber = documentNumber;
        }
        
        /*PROPIEDADES*/
        public string Nombre
        {
            set{name = value;}
            get{return name;}
        }
        public string Apellido
        {
            set{lastName = value;}
            get{return lastName;}
        }
        public int Dni
        {
            set{documentNumber = value;}
            get{return documentNumber;}
        }
	}
}
