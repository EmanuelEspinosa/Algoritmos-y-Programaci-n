using System;
using System.Collections;


namespace EXAMEN
{
	public class Constructora
	{
		private string nombre;
        private ArrayList  obreros;
        private ArrayList  obras;

        public Constructora()
        {

        }
        public Constructora(string name)
        {
            nombre = name;
            obreros = new ArrayList();
            obras = new ArrayList();
        }
        public string Nombre
        {
            set{nombre = value;}
            get{return nombre;}
        }
        public void asignarJefe(int numeroObra, Obrero Jefe)
        {
            Obrero unObrero = new Obrero();
            Obra unaObra = new Obra();
            for (int i = 0; i < obras.Count; i++)
            {
                unaObra = (Obra)obras[i];
                if(unaObra.Codigo == numeroObra)
                {
                    for (int k = 0; k < obreros.Count; k++)
                    {
                        unObrero = (Obrero)obreros[k];
                        if(unObrero.Cargo == "Capataz")
                        {
                            unaObra.JefeObra = Jefe;
                        }
                    }
                }    
            }
        }
        public void agregarObrero(Obrero unOb)
        {
            obreros.Add(unOb);
        }
        public void agregarObra(Obra unaOb)
        {
            obras.Add(unaOb);
        }
        public ArrayList verObras()
        {
            return obras;
        }
        public ArrayList verObreros()
        {
            return obreros;
        }
	}
}
