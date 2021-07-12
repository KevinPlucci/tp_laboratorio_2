using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Propiedades y metodos que comparten Monitor y Televisor.
    /// </summary>
    public interface Interfaces
    {
        #region Metodos
        /// <summary>
        /// Muestra datos del producto.
        /// </summary>
        /// <returns>retorna una cadena de datos</returns>
        string Mostrar();
        #endregion

        /// <summary>
        /// Comparten la misma propiedad entre ambos productos.
        /// </summary>
        #region Propiedades
        
        ECalidad Calidad { get; set; }
        int Pulgadas{get; set;}
        #endregion


    }
}
