using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Monitor : Producto
    {
        #region Atributos
        private EMarcaMoni marcaMoni;
        private int id;
        #endregion
        /// <summary>
        /// Get obiene la marca y set carga la marca.
        /// </summary>
        #region Propiedades
        public EMarcaMoni MarcaMoni
        {
            get { return marcaMoni; }
            set { marcaMoni = value; }
        }


        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de Monitor que  asigna por defecto el valor "marcaMoni" y lo iguala con la propiedad "MarcaMoni"
        /// </summary>
        /// <param name="pulgadas">Le asigna unas pulgadas al atributo pulgadas de Monitor</param>
        /// <param name="calidad">Le asigna una calidad al atributo calidad de Monitor</param>
        /// <param name="marcaMoni">Le asigna una marca al atributo marca de Monitor</param>
        ///<param name="id">Le asigna un id al atributo marca de Monitor</param>
        public Monitor(int id,int pulgadas,ECalidad calidad, EMarcaMoni marcaMoni) : base(id,pulgadas,calidad)
        {
            this.MarcaMoni = marcaMoni;
        }
        /// <summary>
        /// Constructor sin parametros.
        /// </summary>
        public Monitor()
        {

        }

        #endregion

        #region Sobrecargas de Operadores
        
        /// <summary>
        /// Sobrecarga del operador igual entre dos monitores
        /// </summary>
        /// <param name="m1">Primer monitor</param>
        /// <param name="m2">Segundo monitor a ser comparado con el monitor</param>
        /// <returns>retorna si los monitores de los productos son iguales</returns>
        public static bool operator ==(Monitor m1, Monitor m2)
        {
            bool rta = false;
            m1 = new Monitor();
            m2 = new Monitor();
            try
            {
                if (!((Producto)m1 == (Producto)m2 && m1.MarcaMoni == m2.MarcaMoni))
                {
                    rta = true;
                }
            }
            catch(Exception ex) { }
            return rta;
        }
        
        /// <summary>
        /// Sobrecarga del operador distinto entre dos monitores
        /// </summary>
        /// <param name="m1">Primer monitor</param>
        /// <param name="m2">Segundo monitor a ser comparado con el primero</param>
        /// <returns></returns>
        public static bool operator !=(Monitor m1, Monitor m2)
        {
            return !(m1 == m2);
        }
       
        /// <summary>
        /// Determina si dos instancias de objeto son iguales.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Retorna la igualdad</returns>
        public override bool Equals(object obj)
        {
            return (Monitor)obj == this;
        }
        #endregion

        #region Metodo
        /// <summary>
        /// Sobrecargo el metodo ToString para listar todos los monitores
        /// </summary>
        /// <returns>Retorna el listado de todos los monitores</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"{base.Mostrar()}");
            sb.AppendFormat($"Marca del Monitor: {this.MarcaMoni}\n");

            return sb.ToString();
        }
        #endregion

    }
}