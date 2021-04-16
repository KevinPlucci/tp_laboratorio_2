using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

        /// <summary>
        /// Realiza el calculo de dos numeros.
        /// </summary>
        /// <param name="num1">Primer argumento de la operacion</param>
        /// <param name="num2">Segundo argumento de la operacion</param>
        /// <param name="operador">Indica la operacion entre los numeros</param>
        /// <returns>Resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            char operadorChar = new char();

            if (!string.IsNullOrEmpty(operador))
            {
                operadorChar = Convert.ToChar(operador);
            }

            operador = ValidarOperador(operadorChar);
            double retorno = 0;

            switch (operador)
            {
                case "+":
                    retorno = num1 + num2;
                    break;

                case "-":
                    retorno = num1 - num2;
                    break;

                case "/":
                    retorno = num1 / num2;
                    break;

                case "*":
                    retorno = num1 * num2;
                    break;

                default:
                    return 0;
            }

            return retorno;
        }


        /// <summary>
        /// Valida que el operador sea +, -, / o * 
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns>Operador validado, si no es valido devuelve + </returns>
        private static string ValidarOperador(char operador)
        {
            string retorno = "+";

            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                retorno = operador.ToString();
            }

            return retorno;

        }


    }
}
