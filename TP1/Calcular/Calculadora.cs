using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public static double Operar(Operando numero1, Operando numero2, char operador)
        {
            double retorno=0;

            operador = ValidarOperador(operador);

            switch (operador)
            {
                case '+':
                    retorno = (numero1 + numero2);
                    break;
                case '-':
                    retorno = (numero1 - numero2);
                    break;
                case '*':
                    retorno = (numero1 * numero2);
                    break;
                case '/':
                    retorno = (numero1 / numero2);
                    break;

            }

            return retorno;
        }
        private static char ValidarOperador(char operando)
        {
            char retorno = ' ';
            switch (operando)
            {
                case '+':
                    retorno = operando;
                    break;
                case '-':
                    retorno = operando;
                    break;
                case '*':
                    retorno = operando;
                    break;
                case '/':
                    retorno = operando;
                    break;
                default:
                    retorno = '+';
                    break;
            }
            return (retorno);
        }
        //private static bool ValidarOperador(double numero)
        //{
        //    bool retorno=false;
        //    if(numero != 0) retorno=true;
        //    return retorno;
        //}
    }
}
