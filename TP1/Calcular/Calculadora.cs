using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza la operacion matematica asignada en el parametro "operador" entre el "numero1" y "numero2
        /// </summary>
        /// <param name="numero1">Primer operando</param>
        /// <param name="numero2">Segundo operando</param>
        /// <param name="operador">Operacion a realizar</param>
        /// <returns>Resultado de la operacion (double)</returns>
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
        /// <summary>
        /// Valida que sea correcta la operacion matematica requerida
        /// </summary>
        /// <param name="operando">Caracter de la operacion matematica a realizar</param>
        /// <returns>El caracter ingresado en caso de ser valiro. '+' En caso de ser incorrecto el caracter</returns>
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
