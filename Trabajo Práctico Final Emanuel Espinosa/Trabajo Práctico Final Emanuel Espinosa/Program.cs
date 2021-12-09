using System;
using System.Collections;
using System.IO;

namespace Trabajo_Práctico_Final_Emanuel_Espinosa
{
	class Program
	{
		public static void Main(string[] args)
		{
			Empresa empresaInternet = new Empresa(06,08,"PROMOCION",1100,2,"INTERNET 100 MB");
			menuInicio(empresaInternet);
            bool sigueIni;
            do
            {
                try
                {
                    sigueIni = false;
                    int opcionInicio;     
                    opcionInicio = Convert.ToInt32(Console.ReadLine());
                    while(opcionInicio != 2)
                    {
                        switch(opcionInicio)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("\t<<< SELECCIONO MODIFICAR DATOS DE PROMOCION >>>\n");
                                Console.Write("Ingrese nombre de la promocion a ofrecer: ");
                                empresaInternet.nomPromocion = Console.ReadLine().ToUpper();                            
                                Console.Write("Ingrese mes de inicio de promocion: ");
                                empresaInternet.mesInicio = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Ingrese mes de finalización de la promocion: ");
                                empresaInternet.mesFin = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Ingrese costo mensual de la promoción: ");
                                empresaInternet.PrecioPromo = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Ingrese descripcion de la promoción: ");
                                empresaInternet.Descripcion = Console.ReadLine();                            
                                Console.Write("Ingrese cupo disponible de la promocion: ");
                                empresaInternet.CupoDisponible = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("--------------------------------------------------------------------");
                                Console.WriteLine("INGRESO UNA OPCIÓN INCORRECTA. <<< INTENTELO NUEVAMENTE >>>");
                                Console.WriteLine("--------------------------------------------------------------------\n");
                                break;
                        }
                        menuInicio(empresaInternet);
                        opcionInicio = Convert.ToInt32(Console.ReadLine());
                    }
                    Plan planPromo = new Plan(empresaInternet.nomPromocion,empresaInternet.PrecioPromo,empresaInternet.Descripcion);
                    empresaInternet.agregarPlan(planPromo);
                    Console.Clear();
                }
                catch(FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine("\t<<< SE DETECTO UN ERROR EN EL DATO INGRESADO >>>\n");
                    Console.WriteLine("Debe ingresar obligatoriamente un número entero");
                    Console.WriteLine("--------------------------------------------------------------------\n");
                    menuInicio(empresaInternet);
                    sigueIni = true;
                }
            }
            while(sigueIni);
            int opcion = 0;
            bool siguePrincipal;
            do
            {
                try
                {
                    siguePrincipal = false;
                    menuPrincipal();
                    opcion = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                catch(FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine("\t<<< SE DETECTO UN ERROR EN EL DATO INGRESADO >>>\n");
                    Console.WriteLine("Debe ingresar obligatoriamente un número entero");
                    Console.WriteLine("--------------------------------------------------------------------\n");
                    siguePrincipal = true;
                }
            }
            while(siguePrincipal);
            while(opcion != 0)
            {
            	switch (opcion) 
            	{
            		case 1:
            			int opcionClient = 0;
                        bool sigueCli;
                        do
                        {
                            try
                            {
                                sigueCli = false;
                                menuCliente();
                                opcionClient= Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                            }
                            catch(FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("--------------------------------------------------------------------");
                                Console.WriteLine("\t<<< ERROR EN EL VALOR DE OPCIÓN INGRESADA >>>\n");
                                Console.WriteLine("MOTIVO: Se detectaron digitos incompatibles");
                                Console.WriteLine("NOTA: Debe ingresar obligatoriamente un número entero");
                                Console.WriteLine("--------------------------------------------------------------------\n");
                                sigueCli = true;
                            }
                        }
                        while(sigueCli);
                        while(opcionClient != 0)
                        {
                            switch(opcionClient)
                            {
                                case 1:
			                        Console.WriteLine("SELECCIONO <<< AGREGAR CLIENTE >>>");
                                    int dni=0,año=0,dia=0,mes=0;
                                    bool continua,continua2;
                                    Console.Write("\nIngrese nombre: ");
                                    string nombre = Console.ReadLine().ToUpper();
                                    Console.Write("Ingrese apellido: ");
                                    string apellido = Console.ReadLine().ToUpper();
                                    do
                                    {
                                        try
                                        {
                                            continua = false;
                                            Console.Write("Ingrese dni: ");
                                            dni = Convert.ToInt32(Console.ReadLine());
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("\n<<< SE DETECTO UN ERROR EN EL DATO INGRESADO >>>\n");
                                            Console.WriteLine("Para Dni debe ingresar obligatoriamente un número entero");
                                            continua = true;
                                        }
                                    }
                                    while (continua);
                                    Console.Write("Ingrese localidad: ");
                                    string localidad = Console.ReadLine().ToUpper();
                                    Console.Write("Ingrese nombre del plan: ");
                                    string nombrePlan = Console.ReadLine().ToUpper();
                                    Console.Write("Ingresar la forma de pago: ");
                                    string forma = Console.ReadLine().ToUpper();
                                    do
                                    {
                                        try
                                        {
                                            continua2 = false;
                                            Console.WriteLine("Ingrese fecha de alta del servicio");
                                            Console.Write("Día: ");
                                            dia = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Mes: ");
                                            mes = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Año: ");
                                            año = Convert.ToInt32(Console.ReadLine());
                                        }
                                        catch(FormatException)
                                        {
                                            Console.WriteLine("\n<<< SE DETECTO UN ERROR EN EL DATO INGRESADO >>>\n");
                                            Console.WriteLine("\nPara día,mes y año debe ingresar obligatoriamente un número entero.");
                                            continua2 = true;
                                        }
                                    }
                                    while(continua2);
                                    string CodigoID = GenerarClaveClient(nombre,apellido,dni);
                                    Console.Clear();                       
                                    cargarCliente(empresaInternet,nombre,apellido,dni,localidad,nombrePlan, forma, CodigoID,dia,mes,año);  
                                    break;
                                case 2: 
                                    try
                                    {   
                                        Console.WriteLine("SELECCIONO <<< GESTIONAR BAJA A CLIENTE >>>\n");
                                        Console.Write("Ingrese código ID del cliente que desea dar de baja: ");
                                        string cod = Console.ReadLine().ToUpper();
                                        Console.WriteLine("Ingrese fecha de baja del servicio");
                                        Console.Write("Día: ");
                                        dia = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Mes: ");
                                        mes = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Año: ");
                                        año = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Ingrese motivo de baja: ");
                                        string motiB = Console.ReadLine().ToUpper();
                                        bajaCliente(empresaInternet,dia,mes,año,cod,motiB);                                      
                                    }
                                    catch(FormatException)
                                    {
                                        Console.WriteLine("--------------------------------------------------------------------");
                                        Console.WriteLine("\t<<< ERROR AL GESTIONAR LA BAJA DE UN CLIENTE >>>\n");
                                        Console.WriteLine("MOTIVO: Al ingresar la fecha se detectaron digitos incompatibles");
                                        Console.WriteLine("NOTA: Debe ingresar obligatoriamente un número entero en cada uno de los items de la fecha");    
                                    }
                                    catch(ArgumentOutOfRangeException)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("--------------------------------------------------------------------");
                                        Console.WriteLine("\t <<< NO SE PUDO COMPLETAR LA BAJA DEL CLIENTE >>>\n");
                                        Console.WriteLine("MOTIVO: La fecha ingresada es invalida");
                                        Console.WriteLine("NOTA: Realizar nuevamente la carga de los datos");                
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("SELECCIONO <<< VER LISTA DE CLIENTES >>>\n");
                                    verListaClientes(empresaInternet);
                                    break;
                                case 4:
                                    Console.WriteLine("SELECCIONO <<< VER LISTA DE BAJAS DE CLIENTES >>>\n");
                                    verListaDeBajas(empresaInternet);
                                    break;
                                case 5:
                                    try
                                    {    
                                        Console.WriteLine("SELECCIONO <<< VER CLIENTE SEGUN SU POSICION EN LA LISTA >>>\n");
                                        Console.Write("Ingrese numero posición del cliente: ");
                                        int verCli = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        verPosicionCli(empresaInternet,verCli);                   
                                    }
                                    catch(ArgumentOutOfRangeException)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("--------------------------------------------------------------------");
                                        Console.WriteLine("\t<<< ERROR AL MOSTRAR CLIENTE >>>\n");
                                        Console.WriteLine("MOTIVO: Ingreso un valor de posición incorrecto");
                                    }
                                    catch(FormatException)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("--------------------------------------------------------------------");
                                        Console.WriteLine("\t<<< ERROR AL MOSTRAR DATOS DE CLIENTE >>>\n");
                                        Console.WriteLine("MOTIVO: Al ingresar el N° de posición del cliente se detectaron digitos incompatibles");
                                        Console.WriteLine("NOTA: Debe ingresar obligatoriamente un número entero");
                                    }
                                    break;
                                case 6:
                                    try
                                    {
                                        Console.WriteLine("SELECCIONO <<< BUSCAR CLIENTE POR SU NUMERO DE DNI >>>\n");
                                        Console.Write("Ingrese el n° Dni del cliente que desea encontrar: ");
                                        dni = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();                                        
                                        buscoXDni(empresaInternet,dni);                                        
                                    }
                                    catch(FormatException)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("--------------------------------------------------------------------");
                                        Console.WriteLine("\t<<< ERROR AL BUSCAR UN CLIENTE POR SU N° DE DNI >>>\n");
                                        Console.WriteLine("MOTIVO: Al ingresar el N° DNI del cliente se detectaron digitos incompatibles");
                                        Console.WriteLine("NOTA: Debe ingresar obligatoriamente un número entero");                                       
                                    }
                                    break;
                                case 7:
                                    int total = empresaInternet.totalClientes();
                                    Console.WriteLine("SELECCIONO <<< MOSTRAR EL TOTAL DE CLIENTES >>>\n");
                                    Console.WriteLine("El total de clientes adheridos es: {0}", total);
                                    break;
                                case 8:                                       
                                    Console.WriteLine("SELECCIONO <<< VERIFICAR EXISTENCIA DE CLIENTE >>>\n");
                                    Console.Write("Ingrese el código ID de cliente: ");
                                    string codCliente = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    existeCliente(empresaInternet,codCliente);                                       
                                    break;
                                default:
                                    Console.WriteLine("--------------------------------------------------------------------");
                                    Console.WriteLine("INGRESO UNA OPCIÓN INCORRECTA. <<< INTENTELO NUEVAMENTE >>>");
                                    break;
                            }
                            do
                            {
                                try
                                {
                                    sigueCli = false;
                                    Console.WriteLine("--------------------------------------------------------------------\n");    
                                    menuCliente();
                                    opcionClient= Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                }
                                catch(FormatException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("--------------------------------------------------------------------");
                                    Console.WriteLine("\t<<< ERROR EN EL VALOR DE OPCIÓN INGRESADA >>>\n");
                                    Console.WriteLine("MOTIVO: Se detectaron digitos incompatibles");
                                    Console.WriteLine("NOTA: Debe ingresar obligatoriamente un número entero");
                                    sigueCli = true;
                                }
                            }
                            while(sigueCli);    
                        }
                        Console.Clear();
                        menuPrincipal();
            			break;
            		case 2:
            			int opcionTec = 0;
                        bool sigueTec;
                        do
                        {
                            try
                            {
                                sigueTec = false;
                                menuTecnico();
                                opcionTec = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                            }
                            catch(FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("--------------------------------------------------------------------");
                                Console.WriteLine("\t<<< ERROR EN EL VALOR DE OPCIÓN INGRESADA >>>\n");
                                Console.WriteLine("MOTIVO: Se detectaron digitos incompatibles");
                                Console.WriteLine("NOTA: Debe ingresar obligatoriamente un número entero");
                                Console.WriteLine("--------------------------------------------------------------------\n");
                                sigueTec = true;
                            }
                        }
                        while(sigueTec);                        
                        while(opcionTec != 0)
                        {
                            switch(opcionTec)
                            {
                                case 1:
                                    Console.WriteLine("SELECCIONO <<< GESTIONAR ALTA A UN TECNICO >>>\n");
                                    int dni=0;
                                    Console.Write("Ingrese nombre del tecnico: ");
                                    string nombre = Console.ReadLine().ToUpper();
                                    Console.Write("Ingrese apellido del tecnico: ");
                                    string apellido = Console.ReadLine().ToUpper();
                                    bool sigue;
                                    do
                                    {
                                        try
                                        {
                                            sigue = false;
                                            Console.Write("Ingrese dni del tecnico: ");
                                            dni = Convert.ToInt32(Console.ReadLine());
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("\n<<< SE DETECTO UN ERROR EL EL DATO INGRESADO >>>\n");
                                            Console.WriteLine("Debe ingresar obligatoriamente un número entero");
                                            sigue = true;
                                        }
                                    }
                                    while(sigue);
                                    Console.Write("Ingrese la zona a la que pertenece el tecnico: ");
                                    string area = Console.ReadLine().ToUpper();
                                    string codIDTec = GenerarClaveTecnico(nombre,apellido,dni);
                                    agregarTecnico(empresaInternet,nombre,apellido,dni,codIDTec,area);
                                    break;
                                case 2:                                    
                                    Console.WriteLine("SELECCIONO <<< GESTIONAR LA BAJA DE UN TECNICO >>>\n");                                                                           
                                    Console.Write("Ingrese código ID del tecnico sin guiones ni espacios: ");
                                    string codID = Console.ReadLine().ToUpper();
                                    bajaTecnico(empresaInternet,codID);                                                                                                            
                                    break;
                                case 3:
                                    Console.WriteLine("SELECCIONO <<< VER LISTA DE TECNICOS >>>\n");
                                    imprimirListaTec(empresaInternet);
                                    break;
                                case 4:
                                    Console.WriteLine("SELECCIONO <<< MOSTRAR TOTAL DE TECNICOS CONTRATADOS >>>\n");
                                    int totalTec = empresaInternet.cantidadTec();
                                    Console.WriteLine("El total de tecnicos contratados es: {0}", totalTec);
                                    break;
                                case 5:
                                    try
                                    {
                                        Tecnico TecAux2 = new Tecnico();
                                        Console.WriteLine("SELECCIONO <<< VER TECNICO >>>\n");
                                        Console.Write("Ingrese numero posición del tecnico: ");
                                        int verTecnico = Convert.ToInt32(Console.ReadLine());
                                        TecAux2 = empresaInternet.verTec(verTecnico);
                                        Console.Clear();
                                        Console.WriteLine("SELECCIONO <<< VER TECNICO >>>\n");
                                        TecAux2.imprimir();
                                    }
                                    catch(ArgumentOutOfRangeException)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("--------------------------------------------------------------------");
                                        Console.WriteLine("\t<<< ERROR AL MOSTRAR TECNICO >>>\n");
                                        Console.WriteLine("MOTIVO: Ingreso un valor de posición incorrecto");
                                    }
                                    catch(FormatException)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("--------------------------------------------------------------------");
                                        Console.WriteLine("\t<<< ERROR AL MOSTRAR DATOS DE TECNICO >>>\n");
                                        Console.WriteLine("MOTIVO: Al ingresar el N° de posición del tecnico se detectaron digitos incompatibles");
                                        Console.WriteLine("NOTA: Debe ingresar obligatoriamente un número entero");
                                    }
                                    break;
                                case 6:
                                    Console.WriteLine("SELECCIONO <<< MOSTRAR LISTA DE TECNICOS DE UN AREA DETERMINADA >>>\n");
                                    Console.Write("Ingrese zona o localidad para ver los tecnicos correspondiete de la misma: ");
                                    string locd = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    Console.WriteLine("SELECCIONO <<< MOSTRAR LISTA DE TECNICOS DE UN AREA DETERMINADA >>>\n");
                                    verTecnicosArea(empresaInternet,locd);
                                    break;
                                default:
                                    Console.WriteLine("--------------------------------------------------------------------");
                                    Console.WriteLine("INGRESO UNA OPCIÓN INCORRECTA. <<< INTENTELO NUEVAMENTE >>>");
                                    break;
                            }
                            do
                            {
                                try
                                {
                                    sigueTec = false;
                                    Console.WriteLine("--------------------------------------------------------------------\n");
                                    menuTecnico();
                                    opcionTec = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                }
                                catch(FormatException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("--------------------------------------------------------------------");
                                    Console.WriteLine("\t<<< ERROR EN EL VALOR DE OPCIÓN INGRESADA >>>\n");
                                    Console.WriteLine("MOTIVO: Se detectaron digitos incompatibles");
                                    Console.WriteLine("NOTA: Debe ingresar obligatoriamente un número entero");                                    
                                    sigueTec = true;
                                }
                            }
                            while(sigueTec);    
                        }
                        Console.Clear();
                        menuPrincipal();
                        break;
                    case 3:
                        int opcAdmi = 0;
                        bool sigueAdmi;
                        do
                        {
                            try
                            {
                                sigueAdmi = false;
                                menuPlanes();
                                opcAdmi = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                            }
                            catch(FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("--------------------------------------------------------------------");
                                Console.WriteLine("\t<<< ERROR EN EL VALOR DE OPCIÓN INGRESADA >>>\n");
                                Console.WriteLine("MOTIVO: Se detectaron digitos incompatibles");
                                Console.WriteLine("NOTA: Debe ingresar obligatoriamente un número entero");
                                Console.WriteLine("--------------------------------------------------------------------\n");                                
                                sigueAdmi = true; 
                            }
                        }
                        while(sigueAdmi); 
                        while(opcAdmi != 0)
                        {
                            switch(opcAdmi)
                            {
                                case 1:
                                    try
                                    {
                                        
                                        Console.WriteLine("SELECCIONO <<< AGREGAR PLAN >>>\n");
                                        Console.Write("Ingrese nombre del plan: ");
                                        string nombreP = Console.ReadLine().ToUpper();
                                        Console.Write("Ingresar costo mensual del plan:");
                                        double precioP = Convert.ToDouble(Console.ReadLine());
                                        Console.Write("Ingrese descripción del plan: ");
                                        string descrip = Console.ReadLine().ToUpper();
                                        Console.Clear();
                                        Plan planE = new Plan(nombreP, precioP,descrip);
                                        empresaInternet.agregarPlan(planE);
                                        Console.WriteLine("--------------------------------------------------------------------");
                                        Console.WriteLine("\t<<< PLAN AGREGADO CON ÉXITO >>>");
                                    }
                                    catch(FormatException)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("--------------------------------------------------------------------");
                                        Console.WriteLine("\t<<< ERROR AL GESTIONAR ALTA DEL PLAN >>>\n");
                                        Console.WriteLine("MOTIVO: Al ingresar el costo mensual del plan se detectaron digitos incompatibles");
                                        Console.WriteLine("NOTA: Debe ingresar obligatoriamente un número entero");
                                    } 
                                    break;
                                case 2:
                                    Console.WriteLine("SELECCIONO <<< ELIMINAR PLAN >>>\n");
                                    Console.Write("Ingrese el nombre del plan que desea eliminar: ");
                                    string namePlan = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                    elimPlan(empresaInternet, namePlan);
                                    break;
                                case 3:
                                    Console.WriteLine("SELECCIONO <<< VER LISTA DE PLANES >>>\n");
                                    imprimirListPlanes(empresaInternet);
                                    break;
                                case 4:
                                    Console.WriteLine("SELECCIONO <<< MODIFICAR DETALLES DE PLAN >>>\n");
                                    Console.Write("Ingrese el nombre del plan que desea modificar: ");
                                    string nameP = Console.ReadLine().ToUpper();
                                    modificoPlan(empresaInternet,nameP);
                                    break;
                                case 5:                                    
                                    Console.WriteLine("SELECCIONO <<< MODIFICAR PLAN CONTRATADO POR CLIENTE >>>\n");
                                    Console.Write("Ingrese Codigo ID del cliente: ");
                                    string codigo = Console.ReadLine().ToUpper();
                                    Console.Write("Ingrese el nombre del plan elegido pro el cliente: ");
                                    string nombPlan = Console.ReadLine().ToUpper();
                                    Console.Write("Ingrese la forma de pago elegida: ");
                                    string forma = Console.ReadLine().ToUpper();
                                    modificoPlanClient(empresaInternet,codigo,nombPlan,forma); 
                                    break;
                                case 6:
                                    Console.WriteLine("SELECCIONO <<< VER PROMOCIONES VIGENTES >>>\n");
                                    imprimirPromo(empresaInternet);
                                    break;
                                default:
                                    Console.WriteLine("--------------------------------------------------------------------");
                                    Console.WriteLine("INGRESO UNA OPCIÓN INCORRECTA. <<< INTENTELO NUEVAMENTE >>>");
                                    break;
                            }
                            do
                            {
                                try
                                {
                                    sigueAdmi = false;
                                    Console.WriteLine("--------------------------------------------------------------------\n");
                                    menuPlanes();
                                    opcAdmi = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                }
                                catch(FormatException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("--------------------------------------------------------------------");
                                    Console.WriteLine("\t<<< ERROR EN EL VALOR DE OPCIÓN INGRESADA >>>\n");
                                    Console.WriteLine("MOTIVO: Se detectaron digitos incompatibles");
                                    Console.WriteLine("NOTA: Debe ingresar obligatoriamente un número entero");
                                    sigueAdmi = true;
                                }
                            }
                            while(sigueAdmi);    
                        }
                        Console.Clear();
                        menuPrincipal();
                        break;
                    case 4:
                        int opcAyuda = 0;
                        bool sigueAyu;
                        do
                        {
                            try
                            {
                                sigueAyu = false;
                                menuAyuda();
                                opcAyuda = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                            }
                            catch(FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("--------------------------------------------------------------------");
                                Console.WriteLine("\t<<< ERROR EN EL VALOR DE OPCIÓN INGRESADA >>>\n");
                                Console.WriteLine("MOTIVO: Se detectaron digitos incompatibles");
                                Console.WriteLine("NOTA: Debe ingresar obligatoriamente un número entero");
                                Console.WriteLine("--------------------------------------------------------------------\n");                                
                                sigueAyu = true; 
                            }
                        }
                        while(sigueAyu);
                        while(opcAyuda != 0)
                        {
                            switch(opcAyuda)
                            {
                                case 1:
                                    try
                                    {
                                        StreamReader reader = new StreamReader("AyudaCliente.txt");
			                            string line;
			                            while ((line = reader.ReadLine()) != null) 
			                            {
			                                Console.WriteLine(line);
			                            }
                                    }
                                    catch(FileNotFoundException)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("--------------------------------------------------------------------");
                                        Console.WriteLine("\t<<< ERROR LA MOSTRAR AYUDA - \"AREA CLIENTE\" >>>\n");
                                        Console.WriteLine("MOTIVO: No se encunetra el archivo correspondiente a la ayuda requerida");                               
                                    }                                    
                                    break;
                                case 2:
                                    try
                                    {
                                        StreamReader reader = new StreamReader("AyudaTecnico.txt");
			                            string line;
			                            while ((line = reader.ReadLine()) != null) 
			                            {
			                                Console.WriteLine(line);
			                            }
                                    }
                                    catch(FileNotFoundException)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("--------------------------------------------------------------------");
                                        Console.WriteLine("\t<<< ERROR LA MOSTRAR AYUDA - \"AREA TECNICOS\" >>>\n");
                                        Console.WriteLine("MOTIVO: No se encunetra el archivo correspondiente a la ayuda requerida");                               
                                    }
                                    break;
                                default:
                                    Console.WriteLine("--------------------------------------------------------------------");
                        			Console.WriteLine("INGRESO UNA OPCIÓN INCORRECTA. <<< INTENTELO NUEVAMENTE >>>");                        						
                        			break;
                            }
                            do
                            {
                                try
                                {
                                    sigueAyu = false;
                                    Console.WriteLine("--------------------------------------------------------------------\n");
                                    menuAyuda();
                                    opcAyuda = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                }
                                catch(FormatException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("--------------------------------------------------------------------");
                                    Console.WriteLine("\t<<< ERROR EN EL VALOR DE OPCIÓN INGRESADA >>>\n");
                                    Console.WriteLine("MOTIVO: Se detectaron digitos incompatibles");
                                    Console.WriteLine("NOTA: Debe ingresar obligatoriamente un número entero");
                                    sigueAyu = true;
                                }
                            }
                            while(sigueAyu);
                        }
                        Console.Clear();
                        menuPrincipal();
                        break;
            		default:
            			Console.WriteLine("--------------------------------------------------------------------");
                        Console.WriteLine("INGRESO UNA OPCIÓN INCORRECTA. <<< INTENTELO NUEVAMENTE >>>");
                        Console.WriteLine("--------------------------------------------------------------------\n");
                        menuPrincipal();
            			break;
            	}
            	do
                {
                    try
                    {
                        siguePrincipal = false;
                        opcion = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }
                    catch(FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.WriteLine("\t<<< ERROR EN EL VALOR DE OPCIÓN INGRESADA >>>\n");
                        Console.WriteLine("MOTIVO: Se detectaron digitos incompatibles");
                        Console.WriteLine("NOTA: Debe ingresar obligatoriamente un número entero");
                        Console.WriteLine("--------------------------------------------------------------------\n");
                        menuPrincipal();
                        siguePrincipal = true;
                    }
                }
                while(siguePrincipal);
            }
            Console.WriteLine("PROGRAMA FINALIZADO");  
            Console.ReadKey();
		}
		public static string GenerarClaveClient(string name, string apell, int doc)
        {
            string claveCli = name.Substring(0,2) + doc.ToString() + apell.Substring(apell.Length-2,2);
            return claveCli;
        }
		public static string GenerarClaveTecnico(string name, string apell, int doc)
        {
            string clavetec = doc.ToString() +  name.Substring(0,2) +  apell.Substring(0,2);
            return clavetec; 
        }
		public static void cargarCliente(Empresa empresa, string nomb, string apell, int doc, string locdad, string nombPlan, string formaPagar, string clienteCodigo, int dia, int mes, int año)
		{
			try
			{
				DateTime fecha = new DateTime(año,mes,dia);
                Cliente unCli = new Cliente(nomb,apell,doc,locdad,nombPlan,formaPagar, clienteCodigo,fecha);
                ArrayList listTec = empresa.listaTecnicos();
                ArrayList listplanes = empresa.listaPlanes();
                if(listTec.Count != 0)
                {
                    unCli.nombreTecnico = unCli.asignarTecnico(listTec);
                }
                if(listTec.Count == 0)
                {
                    string motivo = "\t\t<<< ERROR EN GESTIÓN DE ALTA DE CLIENTE >>>\t\t\n\n MOTIVO: No hay tecnicos cargados en el sistema";
                    throw new sinTecnicoException(motivo);
                }
                unCli.Precio = unCli.asignarPrecio(listplanes);
                int mesAlta = unCli.fechaAlta.Month;

                if(empresa.nomPromocion == unCli.tipoDePlan)
                {
                	if((mesAlta >= empresa.mesInicio) & (mesAlta <= empresa.mesFin))
                	{
                		if(empresa.CupoDisponible > 0)
                		{
                			unCli.nombreTecnico = unCli.asignarTecnico(listTec);
                            empresa.altaCliente(unCli);
                            Console.WriteLine("--------------------------------------------------------------------");
                            Console.WriteLine("\t<<< CLIENTE AGREGADO CON ÉXITO >>>");
                		}
                		if(empresa.CupoDisponible <= 0)
                		{
                            string motivo = "\t\t<<< ERROR EN GESTIÓN DE ALTA DE CLIENTE >>>\t\t\n\n MOTIVO: CUPO INSUFICIENTE PARA LA PROMOCION DISPONIBLE\nNOTA: Ofrecer otro plan y/o verificar posibles promociones vigentes";
                            throw new sinCupoException(motivo);
                		}
                		empresa.CupoDisponible--;
                	}
                	else
                    {
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.WriteLine("\t <<< NO SE PUDO COMPLETA EL ALTA DEL CLIENTE >>>\n");
                        Console.WriteLine("MOTIVO: La promocion no esta disponible para el mes ingresado");
                        Console.WriteLine("NOTA: Ofrecer otro plan y/o verificar posibles promociones vigentes");
                    }
                }
                else
                {
                    
                    unCli.nombreTecnico = unCli.asignarTecnico(listTec);
                    empresa.altaCliente(unCli);
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine("\t<<< CLIENTE AGREGADO CON ÉXITO >>>");
                    
                }
			}
			catch(sinCupoException e)
            {
                Console.WriteLine(e.motivo);
            }
            catch(sinTecnicoException e)
            {
                Console.WriteLine(e.motivo);
            }
			catch(ArgumentOutOfRangeException)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("\t <<< NO SE PUDO COMPLETA EL ALTA DEL CLIENTE >>>\n");
                Console.WriteLine("MOTIVO: La fecha ingresada es invalida");
                Console.WriteLine("NOTA: Realizar nuevamente la carga de los datos");                
            }
		}
		public static void bajaCliente(Empresa empresa, int dia, int mes, int año, string codigo,string motiv)
        {
            DateTime feBaja = new DateTime(año,mes,dia);
            bool bajaCliente = empresa.bajaCliente(codigo,motiv,feBaja);             
            Console.Clear();
            if(bajaCliente == true)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("\t<<< CLIENTE ELIMINADO CON ÉXITO >>>");
            }
            else
            {
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("\t\t<<<  ERROR EN GESTIÓN DE BAJA DE CLIENTE  >>>\n");
                Console.WriteLine("MOTIVO: El código ID ingresado no pertence a ningun cliente de la empresa");
                
            }
        }
		public static void verListaClientes(Empresa empresa)
        {
            ArrayList listaDeClientes = empresa.listaClientes();
            Cliente clienteAux = new Cliente();
            if(listaDeClientes.Count == 0)
            {
                Console.WriteLine("NO HAY CLIENTES CARGADOS EN EL SISTEMA");
            }
            if(listaDeClientes.Count != 0)
            {
                Console.WriteLine("  |    CÓDIGO ID   |    NOMBRE   |   APELLIDO  |   DNI  |    LOCALIDAD     |    PLAN  | COSTO | F.PAGO |   TÉCNICO ASIG.   |FECHA ALTA|");
                Console.WriteLine("  |----------------|-------------|-------------|--------|------------------|----------|-------|--------|-------------------|----------|");
                for(int h = 0; h < listaDeClientes.Count; h++)
                {
                    clienteAux = (Cliente)listaDeClientes[h];                
                    Console.Write(h + ")| ");
                    clienteAux.imprimir();
                }
            }    
        }
		public static void verListaDeBajas(Empresa empresa)
        {
            ArrayList listaDeClientesElim = empresa.listaBajas();
            Cliente clienteAux = new Cliente();
            if(listaDeClientesElim.Count == 0)
            {
                Console.WriteLine("NINGUN CLIENTE HA SOLICITADO LA BAJA DEL SERVICIO");
            }
            if(listaDeClientesElim.Count != 0)
            {
              Console.WriteLine("  |    CÓDIGO ID   |    NOMBRE   |   APELLIDO  |   DNI  |FECHA BAJA|                  MOTIVO                 |");
                Console.WriteLine("  |----------------|-------------|-------------|--------|----------|-----------------------------------------|");
                for(int h = 0; h < listaDeClientesElim.Count; h++)
                {
                    clienteAux = (Cliente)listaDeClientesElim[h];
                    Console.Write(h + ")| ");
                    clienteAux.imprimir2();
                }  
            }
        }
		public static void verPosicionCli(Empresa empresa, int nroPos)
        {
            Cliente cliAux2 = new Cliente();
            cliAux2 = empresa.verCliente(nroPos);
            Console.WriteLine("SELECCIONO <<< VER CLIENTE SEGUN SU POSICION EN LA LISTA >>>\n");
            Console.WriteLine("   CÓDIGO ID   |    NOMBRE   |   APELLIDO  |   DNI  |    LOCALIDAD     |   PLAN   | COSTO | F.PAGO |   TÉCNICO ASIG.   |FECHA ALTA|");
            Console.WriteLine("---------------|-------------|-------------|--------|------------------|----------|-------|--------|-------------------|----------|");
            cliAux2.imprimir();
        }
		public static void buscoXDni(Empresa empresa, int nro)
        {
            ArrayList listCli = empresa.listaClientes();
            bool encontre = false;
            Cliente unCli = new Cliente();
            for (int i = 0; i < listCli.Count; i++)
            {
                unCli = (Cliente)listCli[i];
                if(nro == unCli.Dni)
                {
                    encontre = true;
                    Console.WriteLine("  |    CÓDIGO ID   |    NOMBRE   |   APELLIDO  |   DNI  |    LOCALIDAD     |    PLAN  |COSTO| F.PAGO |   TÉCNICO ASIG.   |FECHA ALTA|");
                    Console.WriteLine("  |----------------|-------------|-------------|--------|------------------|----------|-----|--------|-------------------|----------|");
                    Console.Write(i + ")| ");
                    unCli.imprimir();
                }
            }
            if(!encontre)
            {
                Console.WriteLine("--------------------------------------------------------------------");
               Console.WriteLine("\t<<< ERROR AL BUSCAR UN CLIENTE POR SU N° DE DNI >>>\n");
                Console.WriteLine("MOTIVO: El N° Dni ingresado no pertence a ningun cliente de la empresa");

            }
        }
		public static void existeCliente(Empresa empresa, string codigo)
        {
            bool esta = empresa.esCliente(codigo);
            Console.WriteLine("SELECCIONO <<< VERIFICAR EXISTENCIA DE CLIENTE >>>\n");
            if(esta == true)
            {
                Console.WriteLine("El código ingresado <<< PERTENECE >>> a un cliente de la empresa");
                
            }
            if(esta == false)
            {
                Console.WriteLine("El código ingresado <<< NO PERTENCE >>> a un cliente de la empresa");
            }
        }
		public static void agregarTecnico(Empresa empresa, string nomb, string apelli,int doc, string code,string area)
        { 
            Tecnico unTecnico = new Tecnico(nomb,apelli,doc,code,area);
            ArrayList lisCli = empresa.listaClientes();
            empresa.agregarTec(unTecnico);
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("\t<<< TECNICO AGREGADO CON ÉXITO >>>");
            foreach (Cliente item in lisCli)
            {
                if(item.nombreTecnico == "NO TEC ASIG ZONA")
                {
                    if(item.Localidad == unTecnico.zonaAsignada)
                    {
                        item.nombreTecnico = unTecnico.Nombre + " " + unTecnico.Apellido;
                    }
                }
            }
        }
		public static void bajaTecnico(Empresa empresa , string code)
        {
            ArrayList cli = empresa.listaClientes();
            bool bajaTecnico = empresa.eliminarTec(code);
            Console.Clear();
            if(bajaTecnico == true)
            {
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("\t\t<<< TECNICO ELIMINADO CON ÉXITO >>>");
            }
            else
            {
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("\t\t<<<  ERROR EN GESTION DE BAJA DE TECNICO  >>>\n");
                Console.WriteLine("MOTIVO: El código ID no corresponde a ningun tecnico de la empresa");
            }

        }
		public static void imprimirListaTec(Empresa empresa)
        {
            ArrayList listaT = empresa.listaTecnicos();
            Tecnico TecAux = new Tecnico();
            if(listaT.Count == 0)
            {
                Console.WriteLine("NO HAY TECNICOS CARGADOS EN EL SISTEMA");
            }
            if(listaT.Count != 0)
            {
                Console.WriteLine("  |    CÓDIGO ID   |      NOMBRE     |     APELLIDO    |   DNI  |    LOCALIDAD     |");
                Console.WriteLine("  |----------------|-----------------|-----------------|--------|------------------|");
                for(int m = 0; m < listaT.Count; m++)
                {
                    TecAux = (Tecnico)listaT[m];
                    Console.Write(m + ")| ");
                    TecAux.imprimir();
                }
            }
        }
		public static void verTecnicosArea(Empresa empresa, string localidad)
        {
            ArrayList listaTec = empresa.verTecArea(localidad);
            if(listaTec.Count != 0)
            {
               Console.WriteLine("   CÓDIGO ID   |      NOMBRE     |     APELLIDO    |   DNI  |    LOCALIDAD     |");
               Console.WriteLine("---------------|-----------------|-----------------|--------|------------------|");
               foreach(Tecnico tec in listaTec)
               {
                   tec.imprimir();
               }
            }
            else
            {
                Console.WriteLine("NO HAY TÉCNICOS ASIGNADOS PARA LA ZONA INGRESADA");
            }
        }
		public static void elimPlan(Empresa empresa, string namePlan)
        {
            bool encontreP = empresa.eliminarPlan(namePlan);
            if(encontreP == true)
            {
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("\t<<< PLAN ELIMINADO CON ÉXITO >>>");
            }
            if(encontreP == false)
            {
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("\t<<< ERROR AL ELIMINAR PLAN >>>");
                Console.WriteLine("MOTIVO: No se encontro el plan con el nombre ingresado");
            }
        }
		public static void imprimirListPlanes(Empresa empresa)
        {
            ArrayList listPs = empresa.listaPlanes();
            if(listPs.Count == 0)
            {
                Console.WriteLine("NO HAY PLANES CARGADOS EN EL SISTEMA");
            }
            else
            {
                imprimirEfectivo();
                foreach (Plan item in listPs)
                {
                    item.imprimirPlanEfectivo();
                }
                imprimirDebito();
                foreach (Plan item2 in listPs)
                {
                    item2.imprimirPlanTarjeta();
                }
            }            
        }
		public static void modificoPlan(Empresa empresa, string nombrePl)
        {
            try
            {
                ArrayList listaPl = empresa.listaPlanes();
                ArrayList listC = empresa.listaClientes();
                foreach (Plan item in listaPl)
                {
                    if(nombrePl == item.nombrePlan)
                    {
                        Console.WriteLine("DETALLE DEL PLAN A MODIFICAR\n");
                        imprimirEfectivo();
                        item.imprimirPlanEfectivo();
                        imprimirDebito();
                        item.imprimirPlanTarjeta();
                        Console.Write("\nIngrese nuevo nombre del plan: ");
                        item.nombrePlan = Console.ReadLine().ToUpper();
                        Console.Write("Ingrese nuevo precio del plan: ");
                        item.precioPlan = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.WriteLine("\t<<< PLAN MODIFICADO CON ÉXITO >>>");
                        Console.WriteLine("\nDETALLE DEL PLAN MODIFICADO\n");
                        imprimirEfectivo();
                        item.imprimirPlanEfectivo();
                        imprimirDebito();
                        item.imprimirPlanTarjeta();
                        foreach (Cliente item2 in listC)
                        {
                            if(nombrePl == item2.tipoDePlan)
                            {
                                if(item2.formaPago == "EFECTIVO")
                                {
                                    item2.tipoDePlan = item.nombrePlan;
                                    item2.Precio = item.precioPlan;
                                }
                                if(item2.formaPago == "DEBITO")
                                {
                                    item2.tipoDePlan = item.nombrePlan;
                                    item2.Precio = item.precioPlan * 0.85;
                                }    
                            }
                        }
                    }
                }
            }
            catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("\t<<< ERROR AL GESTIONAR ALTA DEL PLAN >>>\n");
                Console.WriteLine("MOTIVO: Al ingresar el costo mensual del plan se detectaron digitos incompatibles");
                Console.WriteLine("NOTA: Debe ingresar obligatoriamente un número entero");
            }
        }
		public static void modificoPlanClient(Empresa empresa, string code, string nombrePlan, string formaPago)
        {
            bool estaPl = false, estaCli = false;
            ArrayList lisPlanes = empresa.listaPlanes();
            ArrayList lisCli = empresa.listaClientes();
            foreach (Cliente item in lisCli)
            {
                if(code == item.CodigoCliente)
                {
                    if(formaPago == "EFECTIVO")
                    {
                        estaCli = true;
                        foreach (Plan item2 in lisPlanes)
                        {
                            if(nombrePlan == item2.nombrePlan)
                            {
                                estaPl = true;
                                item.tipoDePlan = nombrePlan;
                                item.Precio = item2.precioPlan;
                                item.formaPago = formaPago;
                                Console.Clear();
                                Console.WriteLine("\n--------------------------------------------------------------------");
                                Console.WriteLine("\t<<< PLAN MODIFICADO CON ÉXITO >>>");
                            }

                        }
                    }
                    if(formaPago == "DEBITO")
                    {
                        estaCli = true;
                        foreach (Plan item2 in lisPlanes)
                        {
                            if(nombrePlan == item2.nombrePlan)
                            {
                                estaPl = true;
                                item.tipoDePlan = nombrePlan;
                                item.Precio = item2.precioPlan * 0.85;
                                item.formaPago = formaPago;
                                Console.Clear();
                                Console.WriteLine("\n--------------------------------------------------------------------");
                                Console.WriteLine("\t<<< PLAN MODIFICADO CON ÉXITO >>>");
                            }
                        }
                    }
                    if(estaPl == false)
                    {
                        Console.Clear();
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.WriteLine("\t <<< ERROR AL REALIZAR CAMBIO DE PLAN >>>\n");
                        Console.WriteLine("MOTIVO: No existe el plan ingresado");
                    }
                }
            }
            if(estaCli == false)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("\t <<< ERROR AL REALIZAR CAMBIO DE PLAN >>>\n");
                Console.WriteLine("MOTIVO: El codigo ID ingresado, no pertence a ningun cliente");
            }
        }
		public static void imprimirPromo(Empresa empresa)
        {
            ArrayList lPlan = empresa.listaPlanes();
            foreach (Plan item in lPlan)
            {
                if(empresa.nomPromocion == item.nombrePlan)
                {
                    
                    Console.WriteLine(" |***************** PAGO EN EFECTIVO ***************|");
                    Console.WriteLine(" |   NOMBRE   | PRECIO |   DESDE   |   HASTA   |CUPO|");
                    Console.WriteLine(" |------------|--------|-----------|-----------|----|");
                    Console.WriteLine(" |{0}|${1}|{2}|{3}|{4}|",empresa.nomPromocion.PadRight(12,' '),item.precioPlan.ToString().PadRight(7,' '),imprimoMesInicio(empresa).PadRight(11,' '),imprimoMesFin(empresa).PadRight(11,' '),empresa.CupoDisponible.ToString().PadRight(4,' '));
                    Console.WriteLine("\n |****************** PAGO CON DÉBITO ***************|");
                    Console.WriteLine(" |   NOMBRE   | PRECIO |   DESDE   |   HASTA   |CUPO|");
                    Console.WriteLine(" |------------|--------|-----------|-----------|----|");
                    Console.WriteLine(" |{0}|${1}|{2}|{3}|{4}|",empresa.nomPromocion.PadRight(12,' '),(item.precioPlan * 0.85).ToString().PadRight(7,' '),imprimoMesInicio(empresa).PadRight(11,' '),imprimoMesFin(empresa).PadRight(11,' '),empresa.CupoDisponible.ToString().PadRight(4,' '));
                }
            }
        }
		public static string imprimoMesInicio(Empresa empresa)
        {
            string mes = null;
            if(empresa.mesInicio==1){mes="ENERO";}if(empresa.mesInicio==2){mes="FEBRERO";}if(empresa.mesInicio==3){mes="MARZO";}if(empresa.mesInicio==4){mes="ABRIL";} if(empresa.mesInicio==5){mes="MAYO";}if(empresa.mesInicio==6){mes="JUNIO";}
            if(empresa.mesInicio==7){mes="JULIO";}if(empresa.mesInicio==8){mes="AGOSTO";}if(empresa.mesInicio==9){mes="SEPTIEMBRE";}if(empresa.mesInicio==10){mes="OCTUBRE";}if(empresa.mesInicio==11){mes="NOVIEMBRE";}if(empresa.mesInicio==12){mes="DICIEMBRE";} 
            return mes;
        }
		public static string imprimoMesFin(Empresa empresa)
        {
            string mes = null;
            if(empresa.mesFin==1){mes="ENERO";}if(empresa.mesFin==2){mes="FEBRERO";}if(empresa.mesFin==3){mes="MARZO";}if(empresa.mesFin==4){mes="ABRIL";} if(empresa.mesFin==5){mes="MAYO";}if(empresa.mesFin==6){mes="JUNIO";}
            if(empresa.mesFin==7){mes="JULIO";}if(empresa.mesFin==8){mes="AGOSTO";}if(empresa.mesFin==9){mes="SEPTIEMBRE";}if(empresa.mesFin==10){mes="OCTUBRE";}if(empresa.mesFin==11){mes="NOVIEMBRE";}if(empresa.mesFin==12){mes="DICIEMBRE";}
            return mes;
        }
		public static void imprimirEfectivo()
        {
            Console.WriteLine(" |******************************* PAGO EN EFECTIVO ******************************|");
            Console.WriteLine(" |-------------------------------------------------------------------------------|");
            Console.WriteLine(" |   PLAN  | COSTO |                         DESCRIPCIÓN                         |");
            Console.WriteLine(" |---------|-------|-------------------------------------------------------------|");
        }
		public static void imprimirDebito()
        {
            Console.WriteLine("\n |******************************* PAGO CON DÉBITO *******************************|");
            Console.WriteLine(" |-------------------------------------------------------------------------------|");
            Console.WriteLine(" |   PLAN  | COSTO |                         DESCRIPCIÓN                         |");
            Console.WriteLine(" |---------|-------|-------------------------------------------------------------|");
        }
		public static void menuInicio(Empresa empresa)
        {
            Console.WriteLine("\t          ---------- INTERNET SUR S.A----------");
            Console.WriteLine("\t        --- SISTEMA DE VENTAS Y ADMINISTRACIÓN ---\n");
            Console.WriteLine("PARA INICIAR LA APLICACION PRIMERO DEBE CONFIRMAR O MODIFICAR LOS DATOS DE PROMOCIÓN");
            Console.WriteLine("LOS DATOS ACTUALES CARGADOS SON: \n");
            Console.WriteLine(" |***************** PAGO EN EFECTIVO ***************|");
            Console.WriteLine(" |   NOMBRE   | PRECIO |   DESDE   |   HASTA   |CUPO|");
            Console.WriteLine(" |------------|--------|-----------|-----------|----|");
            Console.WriteLine(" |{0}|${1}|{2}|{3}|{4}|\n",empresa.nomPromocion.PadRight(12,' '),empresa.PrecioPromo.ToString().PadRight(7,' '),imprimoMesInicio(empresa).PadRight(11,' '),imprimoMesFin(empresa).PadRight(11,' '),empresa.CupoDisponible.ToString().PadRight(4,' '));
            Console.WriteLine("\n\n1.  SI. MODIFICAR DATOS DE PROMOCION DE LA EMPRESA");
            Console.WriteLine("2.  NO. ACCEDER AL MENU PRINCIPAL ");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Ingrese una opción del menu: ");
        }
		public static void menuPrincipal()
        {
            Console.WriteLine("\t          ---------- INTERNET SUR S.A----------");
            Console.WriteLine("\t        --- SISTEMA DE VENTAS Y ADMINISTRACIÓN ---");
            Console.WriteLine("\n1.  AREA CLIENTES");
            Console.WriteLine("2.  AREA TECNICOS ");
            Console.WriteLine("3.  AREA  SERVICIOS Y PLANES");
            Console.WriteLine("4.  AYUDA");
            Console.WriteLine("0.  FINALIZAR PROGRAMA");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Ingrese una opción del menu: ");
        }
		public static void menuCliente()
        {
            Console.WriteLine("\t          ---------- INTERNET SUR S.A----------");
            Console.WriteLine("\t        --- SISTEMA DE VENTAS Y ADMINISTRACIÓN ---");
            Console.WriteLine("\n1. GESTIONAR ALTA DE UN CLIENTE");
            Console.WriteLine("2. GESTIONAR BAJA DE UN CLIENTE");
            Console.WriteLine("3. VER LISTA DE CLIENTES");
            Console.WriteLine("4. VER LISTA DE CLIENTES QUE SOLICITARON LA BAJA DEL SERVICIO");
            Console.WriteLine("5. VER CLIENTE SEGUN SU POSICION EN LA LISTA");
            Console.WriteLine("6. BUSCAR CLIENTE POR SU NUMERO DE DNI");
            Console.WriteLine("7. MOSTRAR EL TOTAL DE CLIENTES");
            Console.WriteLine("8. VERIFICAR EXISTENCIA DE CLIENTE");
            Console.WriteLine("0. VOLVER AL MENU PRINCIPAL");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Ingrese una opción del menu: ");
        }
		public static void menuTecnico()
        {
            Console.WriteLine("\t          ---------- INTERNET SUR S.A----------");
            Console.WriteLine("\t        --- SISTEMA DE VENTAS Y ADMINISTRACIÓN ---");
            Console.WriteLine("\n1. GESTIONAR ALTA DE UN TECNICO");
            Console.WriteLine("2. GESTIONAR LA BAJA DE UN TECNICO");
            Console.WriteLine("3. MOSTRAR LA LISTA DE TECNICOS");
            Console.WriteLine("4. MOSTRAR EL TOTAL DE TECNICOS CONTRATADOS");
            Console.WriteLine("5. VER TECNICO");
            Console.WriteLine("6. MOSTRAR LISTA DE TECNICOS DE UN AREA DETERMINADA");
            Console.WriteLine("0. VOLVER AL MENU PRINCIPAL");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.Write("Ingrese una opción del menu: ");
        }
		public static void menuPlanes()
        {
            Console.WriteLine("\t          ---------- INTERNET SUR S.A----------");
            Console.WriteLine("\t        --- SISTEMA DE VENTAS Y ADMINISTRACIÓN ---");
            Console.WriteLine("\n1. AGREGAR PLAN");
            Console.WriteLine("2. ELIMINAR PLAN");
            Console.WriteLine("3. VER LISTA DE PLANES");
            Console.WriteLine("4. MODIFICAR DETALLES DE PLAN");
            Console.WriteLine("5. MODIFICAR PLAN CONTRATADO POR CLIENTE");
            Console.WriteLine("6. VER PROMOCIONES VIGENTES");
            Console.WriteLine("0. VOLVER AL MENÚ ANTERIOR");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.Write("Ingrese una opción del menu: ");
        }
		public static void menuAyuda()
        {
            Console.WriteLine("\t          ---------- INTERNET SUR S.A----------");
            Console.WriteLine("\t        --- SISTEMA DE VENTAS Y ADMINISTRACIÓN ---");
            Console.WriteLine("\n1. AYUDA - \"AREA CLIENTES\"");
            Console.WriteLine("2. AYUDA - \"AREA TECNICOS\"");
            Console.WriteLine("0. VOLVER AL MENÚ ANTERIOR");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.Write("Ingrese una opción del menu: ");
        }	
	}
}