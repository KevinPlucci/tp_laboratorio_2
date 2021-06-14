using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Television : Producto
    {
        #region Atributos
        private EMarcaTel marcaTel;

        #endregion

        #region Propiedades
        public EMarcaTel MarcaTel
        {
            get { return marcaTel; }
            set { marcaTel = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de Television que asigna por defecto el valor "marcaTel" 
        /// </summary>
        /// <param name="pulgadas">Le asigna una pulgadas al atributo pulgadas de productp</param>
        /// <param name="calidad">Le asigna una calidad al atributo calidad de producto</param>
        /// <param name="marcaTel">Le asigna una calidad al atributo calidad de producto</param>
        public Television(int pulgadas, ECalidad calidad, EMarcaTel marcaTel) : base(pulgadas, calidad)
        {
            this.MarcaTel = marcaTel;
        }

        public Television()
        {

        }

        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="t1">Primer televisor</param>
        /// <param name="t2">Segundo televisor</param>
        /// <returns></returns>
        public static bool operator ==(Television t1, Television t2)
        {
            return (Producto)t1 == (Producto)t2 && t1.MarcaTel == t2.MarcaTel;
        }

        /// <summary>
        /// Sobrecarga del !=
        /// </summary>
        /// <param name="t1">Primer televisor</param>
        /// <param name="t2">Segundo televisor</param>
        /// <returns></returns>
        public static bool operator !=(Television t1, Television t2)
        {
            return !(t1 == t2);
        }

        /// <summary>
        /// Determina si dos instancias de objeto son iguales.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Retorna la igualdad</returns>
        public override bool Equals(object obj)
        {
            return ((Television)obj) == this;
        }
        #endregion

        #region Metodo
        /// <summary>
        /// Metodo que sobrescribe al de la clase base mostrando la informacion de Producto y Television
        /// </summary>
        /// <returns>Retorna la informacion de Television y Producto en formato string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"{base.Mostrar()}");
            sb.AppendFormat($"Marca del Televisor: {this.MarcaTel}\n");

            return sb.ToString();
        }
        #endregion


    }
}