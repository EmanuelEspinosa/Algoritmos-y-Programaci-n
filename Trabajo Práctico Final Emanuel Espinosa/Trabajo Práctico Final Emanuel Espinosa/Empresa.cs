using System;
using System.Collections;

namespace Trabajo_Práctico_Final_Emanuel_Espinosa
{
	public class Empresa
	{
		/*VARIABLES DE INSTACIA*/
        private int mesIni, mesF, cupo;
        private double costo;
        private string nombrePromocion, descripcion;
        private ArrayList listTecnicos;
        private ArrayList listClientes;
        private ArrayList listClientesBaja;
        private ArrayList listPlanes;
        
        /*CONSTRUCTORES*/
        public Empresa()
        {

        }
        public Empresa(int inicio, int fin, string nombPromo, double costo, int cupo, string descripcion)
        {
            mesIni = inicio;
            mesF = fin;
            this.cupo = cupo;
            nombrePromocion = nombPromo;
            this.costo = costo;
            this.descripcion = descripcion;
            listClientes = new ArrayList();
            listTecnicos = new ArrayList();
            listPlanes = new ArrayList();
            listClientesBaja = new ArrayList();
        }
        
        /*PROPIEDADES*/
        public int mesInicio
        {
            set{mesIni = value;}
            get{return mesIni;}
        }
        public int mesFin
        {
            set{mesF = value;}
            get{return mesF;}
        }
        public string nomPromocion
        {
            set{nombrePromocion = value;}
            get{return nombrePromocion;}
        }
        public int CupoDisponible
        {
            set{cupo = value;}
            get{return cupo;}
        }
        public double PrecioPromo
        {
            set{costo = value;}
            get{return costo;}
        }
        public string Descripcion
        {
            set{descripcion = value;}
            get{return descripcion;}
        }
        
        /*METODOS*/
        public void altaCliente(Cliente unCli)
        {
            listClientes.Add(unCli);
        }
        public bool bajaCliente(string codigo, string motv, DateTime fecha)
        {
            bool operacionCorrecta = false; 
            Cliente CliAux = new Cliente();
            for(int i = 0; i < listClientes.Count; i++)
            {
                CliAux = (Cliente)listClientes[i];
                if(codigo == CliAux.CodigoCliente)
                {
                    listClientes.Remove(CliAux);
                    Cliente clienteAux = new Cliente(CliAux.Nombre,CliAux.Apellido,CliAux.Dni,CliAux.CodigoCliente,fecha,motv);
                    listClientesBaja.Add(clienteAux);
                    operacionCorrecta = true;   
                }
            }
            return operacionCorrecta;
        }
        public Cliente verCliente(int i)
        {
            return (Cliente)listClientes[i];
        }
        public int totalClientes()
        {
            return listClientes.Count;
        }
        public bool esCliente(string codigo)
        {
            bool es = false;
            Cliente uncliAux2 = new Cliente();
            for(int j = 0; j < listClientes.Count; j++)
            {
                uncliAux2 = (Cliente)listClientes[j];
                if(codigo == uncliAux2.CodigoCliente)
                {                
                    es = true;
                }
            }
            return es;
        }
        public ArrayList listaClientes()
        {
            return listClientes;
        }
        public ArrayList listaBajas()
        {
            return listClientesBaja;
        }
        public void agregarTec(Tecnico unTec)
        {
            listTecnicos.Add(unTec);
        }
        public bool eliminarTec(string codeTec)
        {
            bool eliminado = false; 
            Tecnico unTec = new Tecnico();
            for(int u = 0; u < listTecnicos.Count; u++)
            {
                unTec = (Tecnico)listTecnicos[u];
                if(codeTec == unTec.codigoTecnico)
                {
                    listTecnicos.Remove(unTec); 
                    eliminado = true;   
                }
            }
            foreach (Cliente item in listClientes)
            {
                item.nombreTecnico = item.asignarTecnico(listTecnicos);
            }
            return eliminado;  
        }
        public int cantidadTec()
        {
            return listTecnicos.Count;
        }
        public Tecnico verTec(int t)
        {
            return (Tecnico)listTecnicos[t];
        }
        public ArrayList listaTecnicos()
        {
            return listTecnicos;
        }
        public ArrayList verTecArea (string area)
        {
            ArrayList listTecArea = new ArrayList();
            foreach(Tecnico Tec in listTecnicos)
            {
                if(area == Tec.zonaAsignada)
                {
                    listTecArea.Add(Tec);
                }
            }
            return listTecArea;
        }
        public void agregarPlan(Plan unPlan)
        {
            listPlanes.Add(unPlan);
        }
        public bool eliminarPlan(string name)
        {
            bool esta = false;
            Plan planElim = new Plan();
            for (int i = 0; i < listPlanes.Count; i++)
            {
                planElim = (Plan)listPlanes[i];
                if(planElim.nombrePlan == name)
                {
                    listPlanes.Remove(planElim);
                    esta = true;
                }
            } 
            return esta;
        }
        public ArrayList listaPlanes()
        {
            return listPlanes;
        }
	}
}
