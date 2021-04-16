using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class Numero
    {
        #region Atributos

        /// <summary>
        /// Guarda el numero de la entidad 
        /// </summary>
        private double numero;

        #endregion


        /// <summary>
        /// Setea el numero, lo valida antes de setearlo
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(Convert.ToString(value));
            }
        }


        #region Constructores

        /// <summary>
        /// Constructor por defecto que asigna valor 0 al atributo numero
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }


        /// <summary>
        /// Contructor que guarda el numero en la variable
        /// </summary>
        /// <param name="numero">Numero a guardar</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }


        /// <summary>
        /// Constructor que guarda el numero validado
        /// </summary>
        /// <param name="strNumero">Numero a guardar de tipo string</param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        #endregion


        #region Métodos

        /// <summary>
        /// Convierte de Binario a Decimal
        /// </summary>
        /// <param name="binario">Numero binario a convertir</param>
        /// <returns>Numero decimal convertido en tipo string, o Error si no puede hacer la conversion</returns>
        public string BinarioDecimal(string binario)
        {
            bool retorno;

            retorno = EsBinario(binario);

            if (retorno)
            {

                char[] arrayBinario = binario.ToCharArray();

                Array.Reverse(arrayBinario);

                double numero = 0;

                for (int i = 0; i < arrayBinario.Length; i++)
                {
                    if (arrayBinario[i] == '1')
                    {
                        if (i == 0)
                        {
                            numero += 1;
                        }
                        else
                        {
                            numero += (int)Math.Pow(2, i);
                        }
                    }
                }

                return numero.ToString();
            }
            else
            {
                return "ERROR! Valor no binario";
            }
        }


        /// <summary>
        /// Convierte de Decimal a Binario
        /// </summary>
        /// <param name="numero">Numero decimal a convertir</param>
        /// <returns>Numero binario en forma de string</returns>
        public string DecimalBinario(double numero)
        {
            string binario = "";
            int num = (int)numero;

            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    binario = "0" + binario;
                }
                else
                {
                    binario = "1" + binario;
                }

                num = num / 2;
            }

            binario = '1' + binario;

            return binario;
        }


        /// <summary>
        /// Convierte el numero de Decimal a Binario
        /// </summary>
        /// <param name="numero">Numero decimal a convertir</param>
        /// <returns>String convertido a binario</returns>
        public string DecimalBinario(string numero)
        {
            string retorno;
            double num;

            if (double.TryParse(numero, out num))
            {
                retorno = DecimalBinario(num);
            }
            else
            {
                retorno = "Valor invalido";
            }

            return retorno;
        }


        /// <summary>
        /// Valida que la cadena ingresada este compuesta solo por 0 o 1
        /// </summary>
        /// <param name="binario">Cadena a validar</param>
        /// <returns>True o False</returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = true;

            foreach (char a in binario)
            {
                if (Regex.IsMatch(binario, "[^01]"))
                {
                    retorno = false;
                }
            }

            return retorno;
        }


        #region Operaciones

        /// <summary>
        /// Suma dos numeros
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <returns>Resultado de la suma</returns>
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }


        /// <summary>
        /// Resta dos numeros
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <returns>Resultado de la resta</returns>
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }


        /// <summary>
        /// Multiplica dos numeros
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <returns>Resultado de la multiplicacion</returns>
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }


        /// <summary>
        /// Divide dos numeros
        /// </summary>
        /// <param name="num1">Dividendo</param>
        /// <param name="num2">Divisor</param>
        /// <returns>Resultado de la division</returns>
        public static double operator /(Numero num1, Numero num2)
        {
            if (num2.numero == 0)
            {
                return double.MinValue;
            }
            return num1.numero / num2.numero;
        }

        #endregion


        /// <summary>
        /// Valida que el valor ingresado sea un numero
        /// </summary>
        /// <param name="strNumero">Numero en tipo string sobre el que se realiza la validacion</param>
        /// <returns>El numero validado</returns>
        private double ValidarNumero(string strNumero)
        {
            double aux = 0;

            double.TryParse(strNumero, out aux);

            return aux;
        }



        #endregion
    }
}
