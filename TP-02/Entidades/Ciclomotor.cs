using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {

        #region "Constructor"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="marca">Le asigna marca al atributo vehiculo</param>
        /// <param name="chasis">Le asigna un chasis al atributo vehiculo</param>
        /// <param name="color">Le asigna un color al atributo vehiculo</param>

        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Sobrecarga la propiedad tipo Enum
        /// </summary>
        /// 
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion

        #region "Metodos"

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}\n", this.Tamanio);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
