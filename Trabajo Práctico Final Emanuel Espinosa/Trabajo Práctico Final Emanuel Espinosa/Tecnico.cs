using System;

namespace Trabajo_Práctico_Final_Emanuel_Espinosa
{
	public class Tecnico : Persona
	{
		/*VARIABLES DE INSTANCIA*/
        private string zone, technicianCode;
        
        /*CONSTRUCTORES*/
        public Tecnico()
        {

        }
        public Tecnico(string name, string lastName, int doc, string code, string area) : base (name, lastName, doc)
        {
            technicianCode = code;
            zone = area;
        }
        
        /*PROPIEDADES*/
        public string codigoTecnico
        {
            set{technicianCode = value;}
            get{return technicianCode;}
        }
        public string zonaAsignada
        {
            set{zone = value;}
            get{return zone;}
        }
        
        /*METODO*/
        public void imprimir()
        {
            string CodTec = documentNumber.ToString() + "-" + name.Substring(0,2) + "-" + lastName.Substring(0,2);
            Console.WriteLine("{0} | {1}| {2}|{3}| {4} |",CodTec,name.PadRight(16,' '),lastName.PadRight(16,' '),documentNumber,zone.PadRight(16,' '));
        }
	}
}
