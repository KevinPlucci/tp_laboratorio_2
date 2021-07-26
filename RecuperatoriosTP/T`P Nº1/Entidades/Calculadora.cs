
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
            double retornoDouble = default(double);
            switch (ValidarOperador(operador))
            {
                case "+":
                    retornoDouble = num1 + num2;
                    break;

                case "-":
                    retornoDouble = num1 - num2;
                    break;

                case "/":
                    retornoDouble = num1 / num2;
                    break;

                case "*":
                    retornoDouble = num1 * num2;
                    break;
            }
            return retornoDouble;
        }


        /// <summary>
        /// Valida que el operador sea +, -, / o * 
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns>Operador validado, si no es valido devuelve + </returns>
        private static string ValidarOperador(string operador)
        {
            switch (operador)
            {
                case "+":
                    break;

                case "-":
                    break;

                case "/":
                    break;

                case "*":
                    break;

                default:
                    return "+";
            }
            return operador;
        }


    }
}