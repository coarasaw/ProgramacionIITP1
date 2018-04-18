using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {

        public static double Operar (Numero num1, Numero num2, string operador)
        {
            double numero = 0;

            if (ValidarOperador(operador)!="+")
            {
                switch (operador)
                {
                    case "+":
                        numero = (num1 + num2);
                        break;
                    case "-":
                        numero = (num1 - num2);
                        break;
                    case "*":
                        //
                        break;
                    case "/":
                        //
                        break;
                } 
              return numero;  
            }
            else
            {
                return 0;
            }
            

            
        }


        private static string ValidarOperador (string operador)
        {
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
                return operador;
            else
                return "+";
        }
    }
}
