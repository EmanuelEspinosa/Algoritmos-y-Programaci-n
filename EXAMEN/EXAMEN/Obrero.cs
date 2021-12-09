using System;

namespace EXAMEN
{
	public class Obrero
	{
		private string  apellido;
        private int legajo;
        private string cargo;

        public Obrero()
        {

        }
        public Obrero(string lastName , int leg, string cargo)
        {
            apellido = lastName;
            legajo = leg;
            this.cargo = cargo;
        }
        public string Apellido
        {
            set{apellido = value;}
            get{return apellido;}
        }
        public int Legajo
        {
            set{legajo = value;}
            get{return legajo;}
        }
        public string Cargo
        {
            set{cargo = value;}
            get{return cargo;}
        }
	}
}
