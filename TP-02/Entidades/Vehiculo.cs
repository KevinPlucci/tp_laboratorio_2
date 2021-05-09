using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        #region "Atributos"
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Retornará el tamaño Enum
        /// </summary>
        protected abstract ETamanio Tamanio { get; }
        #endregion

        public enum EMarca
        {
            Chevrolet, 
            Ford, 
            Renault, 
            Toyota, 
            BMW, 
            Honda, 
            HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, 
            Mediano, 
            Grande
        }
        
        #region "Constructores"
        /// <summary>
        /// Constructor unico de vehiculo
        /// </summary>
        /// <param name="chasis">Le asigna un atributo </param>
        /// <param name="marca">Le asigna un atributo </param>
        /// <param name="color">Le asigna un atributo </param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo que se sobrescribe en las clases que heredan de vehiculo
        /// </summary>
        /// <returns>La informacion del vehiculo utilizando el explicit string</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.Append("---------------------\n");

            return sb.ToString();
        }
        #endregion

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;

            if (((object)v1) == null && ((object)v2) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)v1) != null && ((object)v2) != null)
                {
                    if (v1.chasis == v2.chasis)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
