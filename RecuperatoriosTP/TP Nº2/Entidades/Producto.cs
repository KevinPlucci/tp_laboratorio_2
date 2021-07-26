using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        #region Atributos
        protected Fabricante fabricante;
        protected static Random generadorDePreciosRandom;
        protected string modelo;
        protected double precio;
        #endregion

        #region Propiedades
        public double Precio
        {
            get
            {
                if (this.precio == 0)
                {
                    this.precio = Producto.generadorDePreciosRandom.Next(8500, 150000);
                }
                return this.precio;
            }
        }
        #endregion
        #region Constructores
        static Producto()
        {
            Producto.generadorDePreciosRandom = new Random();
        }

        public Producto(string modelo, Fabricante fabricante)
        {
            this.precio = this.Precio;
            this.modelo = modelo;
            this.fabricante = fabricante;
        }

        public Producto(string modelo, string marca, EPais pais) : this(modelo, new Fabricante(marca, pais))
        {


        }
        #endregion
        #region Metodos
        private static string Mostrar(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{(string)p.fabricante}\n");
            sb.AppendFormat($"MODELO: {p.modelo}\n");
            sb.AppendFormat($"PRECIO: {p.precio}\n");

            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.modelo == p2.modelo && p1.fabricante == p2.fabricante);
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static explicit operator string(Producto p)
        {
            return Producto.Mostrar(p);
        }
        #endregion

    }
}
