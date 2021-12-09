using System;
using System.Collections;

namespace Ejercicio_7
{
	class Operacion
    {
        public double operando1, operando2;
        public string operador;

        public Operacion()
        {

        }
        public Operacion (double oper1, double oper2, string opera)
        {
            operando1 = oper1;
            operando2 = oper2;
            operador = opera;
        }
        public void evaluar(ArrayList a)
        {
            Operacion Oper_aux = new Operacion();
            string signo = "";
            double resul;

            for(int i =0; i<a.Count; i++)
            {
                Oper_aux = (Operacion)a[i];
                if(Oper_aux.operador == "+")
                {
                    signo="<< SUMA >>";
                    resul = Oper_aux.operando1 + Oper_aux.operando2;
                    Console.WriteLine("{0} entre {1} y {2} es: {3}", signo, Oper_aux.operando1, Oper_aux.operando2, resul);  
                }
                if(Oper_aux.operador == "-")
                {
                    signo="<< RESTA >>";
                    resul = Oper_aux.operando1 - Oper_aux.operando2;
                    Console.WriteLine("{0} entre {1} y {2} es: {3}", signo, Oper_aux.operando1, Oper_aux.operando2, resul);
                }
                if(Oper_aux.operador == "*")
                {
                    signo="<< MULTIPLICACIÓN >>";
                    resul = Oper_aux.operando1 * Oper_aux.operando2;
                    Console.WriteLine("{0} entre {1} y {2} es: {3}", signo, Oper_aux.operando1, Oper_aux.operando2, resul);
                }
                if(Oper_aux.operador == "/")
                {
                    signo="<< DIVISIÓN >>";
                    resul = Oper_aux.operando1 / Oper_aux.operando2;
                    Console.WriteLine("{0} entre {1} y {2} es: {3}", signo, Oper_aux.operando1, Oper_aux.operando2, resul);
                }
            }  
        }
    }
}
