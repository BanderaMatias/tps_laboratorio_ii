using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public string Numero
        {
            set { 
                this.numero = ValidarOperando(value);
                }
        }
        /// <summary>
        /// Convierte de binario a decimal en caso de ser posible
        /// </summary>
        /// <param name="binario">Valor a convertir</param>
        /// <returns>
        /// 1)Si puede ser convertido. Decimal convertido 
        /// 2)No puede ser convertido. "Valor invalido"
        /// </returns>
        public static string BinarioDecimal(string binario)
        {
            string retorno = "";
            if (EsBinario(binario))
            {
                retorno = Convert.ToInt32(binario, 2).ToString();
            }
            else
            {
                retorno = "Valor Invalido";
            }

            return retorno;
        }
        /// <summary>
        /// Convierte de decimal a binario 
        /// </summary>
        /// <param name="numero">Valor a convertir</param>
        /// <returns>
        /// Binario convertido 
        /// </returns>
        public static string DecimalBinario(double numero)
        {
            int resto;
            string binario = "";
            while (numero > 0)
            {
                resto = (int)numero % 2;
                numero = (int)numero / 2;
                binario =resto.ToString()+binario;
            }
            return binario;
        }

        /// <summary>
        /// Convierte de decimal a binario 
        /// </summary>
        /// <param name="numero">Valor a convertir</param>
        /// <returns>
        /// Binario convertido 
        /// </returns>
        public static string DecimalBinario(string numero)
        {
            double auxNumero;
            if(!double.TryParse(numero, out auxNumero))
            {
                return "Valor Invalido";
            }
            else
            {
                return DecimalBinario(auxNumero);
            }

        }
        /// <summary>
        /// Comprueba si el string pasado como parametro es un binario
        /// </summary>
        /// <param name="binario">string a comprobar</param>
        /// <returns>
        /// true: si es binario
        /// false: si no es binario
        /// </returns>
        public static bool EsBinario(string binario)
        {
            char [] arrayBinario = binario.ToCharArray();

            foreach (char caracter in arrayBinario)
            {
                if(caracter != '1' && caracter != '0')
                {
                    return false;
                }
            }
            return true;
        }
        public Operando()
        {
            this.numero = 0;
        }
        public Operando(double numero):this(numero.ToString())
        {

        }
        public Operando(string strNumero)
        {
            Numero = strNumero;
        }
        /// <summary>
        /// Comprueba si el string pasado como parametro se puede convertir a double
        /// </summary>
        /// <param name="strNumero">string a comprobar</param>
        /// <returns>
        /// 1)Valor convertio
        /// 2)0 En caso de no poder convertir el string
        /// </returns>
        private double ValidarOperando(string strNumero)
        {
            double retorno=0;
            if (!double.TryParse(strNumero, out retorno)) retorno = 0;
            return retorno;
        }

        public static double operator -(Operando n1, Operando n2) 
        {
           return n1.numero - n2.numero;
        }
        public static double operator +(Operando n1, Operando n2) 
        {
            return n1.numero + n2.numero;
        }
        public static double operator *(Operando n1, Operando n2) 
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Operando n1, Operando n2) 
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }
    }
}
