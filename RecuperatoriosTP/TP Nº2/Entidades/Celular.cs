using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Celular:Producto
    {
        #region Atributos
        public EGama Gama;
        #endregion

        #region Constructores
        public Celular(string modelo, Fabricante fabricante, EGama gama) : base(modelo, fabricante)
        {
            this.Gama = gama;
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Celular c1, Celular c2)
        {
            return (Producto)c1 == (Producto)c2 && c1.Gama == c2.Gama;
        }

        public static bool operator !=(Celular c1, Celular c2)
        {
            return !(c1 == c2);
        }

        public static implicit operator double(Celular c)
        {
            return c.precio;
        }

        public override bool Equals(object obj)
        {
            return (Celular)obj == this;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Celular");
            sb.AppendFormat($"{(string)(Celular)this}");
            sb.AppendFormat($"GAMA: {this.Gama}\n");

            return sb.ToString();
        }
        #endregion
    }
}
