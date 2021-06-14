using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;


namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Television))]
    [XmlInclude(typeof(Monitor))]
    public abstract class Producto : Interfaces
    {
        #region Atributos
        private int pulgadas;
        private ECalidad calidad;
        #endregion
        #region Propiedades
        public ECalidad Calidad { get => calidad; set => calidad=value; }
        public int Pulgadas { get => pulgadas ; set => pulgadas=value ; }
        #endregion
        #region Constructor
        /// <summary>
        /// Unico constructor publico que asigna inicializa Producto
        /// </summary>
        public Producto()
        {
            

        }
        /// <summary>
        /// Constructor que le asigna pulgadas y calidad
        /// </summary>
        /// <param name="pulgadas">Le asigna una pulgadas al atributo pulgadas de producto</param>
        /// <param name="calidad">Le asigna una calidad al atributo calidad de producto</param>
        public Producto(int pulgadas, ECalidad calidad)
        {
            this.Pulgadas = pulgadas;
            this.Calidad = calidad;
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Sobrecarga del operador string
        /// </summary>
        /// <returns>Los datos del producto</returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"PULGADAS: {this.Pulgadas}\n");
            sb.AppendFormat($"CALIDAD: {this.Calidad}\n");

            return sb.ToString();
        
        
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga del operador igual entre dos productos
        /// </summary>
        /// <param name="p1">Primer producto</param>
        /// <param name="p2">Segundo producto a ser comparado con el primero</param>
        /// <returns>Retorna si los productos son iguales</returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.Calidad == p2.Calidad && p1.Pulgadas  == p2.Pulgadas );
        }
        /// <summary>
        /// Sobrecarga del operador distinto entre dos productos
        /// </summary>
        /// <param name="p1">Primer producto</param>
        /// <param name="p2">Segundo producto a ser comparado con el primero</param>
        /// <returns></returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        #endregion

    }
}
