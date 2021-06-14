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
        string Mostrar();
        #endregion

        #region Propiedades
        ECalidad Calidad { get; set; }
        int Pulgadas{get; set;}
        #endregion


    }
}
