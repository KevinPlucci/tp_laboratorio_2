using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tablet:Producto
    {
        #region Atributos
        public ETipo tipo;
        #endregion

        #region Constructores
        public Tablet(string modelo, string marca, EPais pais, ETipo tipo) : base(modelo, marca, pais)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Tablet t1, Tablet t2)
        {
            return (Producto)t1 == (Producto)t2 && t1.tipo == t2.tipo;
        }

        public static bool operator !=(Tablet t1, Tablet t2)
        {
            return !(t1 == t2);
        }

        public static explicit operator double(Tablet t)
        {
            return t.precio;
        }

        public override bool Equals(object obj)
        {
            return ((Tablet)obj) == this;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tablet");
            sb.AppendFormat($"{(string)(Producto)this}");
            sb.AppendFormat($"TIPO: {this.tipo}\n");

            return sb.ToString();
        }
        #endregion
    }
}
