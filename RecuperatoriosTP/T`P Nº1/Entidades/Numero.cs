
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
        private string SetNumero//propiedad.
        {
            set
            {
                this.numero = ValidarNumero(value);
                //value representa el valor que asignamos a la propiedad.
            }
        }


        #region Constructores

        /// <summary>
        /// Constructor por defecto que asigna valor 0 al atributo numero
        /// </summary>
        public Numero()
        {
            this.numero = default(double);//le asigno 0.
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
        public static string BinarioDecimal(string numBinario)
        {
            Numero numB = new Numero(numBinario);
            double numBConvertD = numB.numero;//guardo el atribuo double en numBConvertD
            //string retornoStr = string.Empty;
            int retorno = default(int);
            string errorMsg = "Error inválido";
            int residuo = 0;
            int exponente = 0;

            if (numBConvertD > 0)
            {
                do
                {
                    residuo = (int)numBConvertD % 10;//el residuo del número ingresado entre 10.
                    numBConvertD = numBConvertD / 10;
                    numBConvertD = Math.Floor(numBConvertD);//aca se podria poner el /10 y ahorro una línea.
                    retorno += (int)(residuo * Math.Pow(2, exponente));// 2 ^ nº cantidad (2^0, 2^1, 2^2...)
                    exponente++;//0, 1, 2, n cantidad de veces como tantos ciclos realice el bucle do while.
                } while (numBConvertD != 0);
            }
            else
            {
                return errorMsg;
            }

            return retorno.ToString();
        }


        /// <summary>
        /// Convierte de Decimal a Binario
        /// </summary>
        /// <param name="numero">Numero decimal a convertir</param>
        /// <returns>Numero binario en forma de string</returns>
        public static string DecimalBinario(string numBin)
        {
            Numero numD = new Numero(numBin);
            double numDecimal = Math.Floor(numD.numero);
            string retornoDeciBinario = string.Empty;
            string errorMsg = "Error inválido";

            if (numDecimal > 0)
            {
                while (numDecimal != 0)
                {
                    ////los num pares van a dar siempre residuos en 0 - impares residuo 1
                    if (numDecimal % 2 == 0)
                    {
                        retornoDeciBinario = "0" + retornoDeciBinario;
                    }
                    else
                    {
                        retornoDeciBinario = "1" + retornoDeciBinario;
                    }
                    numDecimal /= 2;
                    numDecimal = Math.Floor(numDecimal);
                }
            }
            else
            {
                retornoDeciBinario = errorMsg;
            }

            return retornoDeciBinario;
        }


        /// <summary>
        /// Convierte el numero de Decimal a Binario
        /// </summary>
        /// <param name="numero">Numero decimal a convertir</param>
        /// <returns>String convertido a binario</returns>
        public static string DecimalBinario(double numDouble)
        {
            //Retorna solo la parte entera.
            //Y reutilizo código.
            return DecimalBinario(numDouble.ToString());//convierto el numeroDouble para poder usar la sobrecarga.
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
            double retornoDb = default(double);

            if (num2.numero == 0)
            {
                retornoDb = double.MinValue;
            }
            else
            {
                retornoDb = num1.numero / num2.numero;
            }
            return retornoDb;
        }

        #endregion


        /// <summary>
        /// Valida que el valor ingresado sea un numero
        /// </summary>
        /// <param name="strNumero">Numero en tipo string sobre el que se realiza la validacion</param>
        /// <returns>El numero validado</returns>
        public double ValidarNumero(string strNumero)
        {
            double retornoDbl = default(double);
            if (double.TryParse(strNumero, out retornoDbl))
            {
                return retornoDbl;
            }
            else
            {
                return 0;
            }
        }



        #endregion
    }
}