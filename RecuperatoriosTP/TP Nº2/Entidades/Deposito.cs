using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito
    {
        #region Atributos
        private int capacidad;
        private List<Producto> productos;
        #endregion

        #region Propiedades
        public double PrecioDeTablets
        {
            get
            {
                return this.ObtenerPrecio(EProducto.PrecioDeTablets);
            }
        }

        public double PrecioDeCelulares
        {
            get
            {
                return this.ObtenerPrecio(EProducto.PrecioDeCelulares);
            }
        }

        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(EProducto.PrecioTotal);
            }
        }
        #endregion

        #region Constructores
        private Deposito()
        {
            this.productos = new List<Producto>();
        }

        private Deposito(int capacidad)
            : this()
        {
            this.capacidad = capacidad;
        }
        #endregion

        #region Metodos
        public static string Mostrar(Deposito d)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"Capacidad: {d.capacidad}\n");
            sb.AppendFormat($"Total por tablets: {d.PrecioDeTablets}\n");
            sb.AppendFormat($"Total por celulares: {d.PrecioDeCelulares}\n");
            sb.AppendFormat($"Total: {d.PrecioTotal}\n");
            sb.AppendLine("*********************************************");
            sb.AppendLine("Lista de productos");
            sb.AppendLine("*********************************************");
            foreach (Producto item in d.productos)
            {
                sb.AppendFormat($"{item.ToString()}\n");
            }

            return sb.ToString();
        }

        private double ObtenerPrecio(EProducto tipoProducto)
        {
            double acumulador = 0;
            foreach (Producto item in this.productos)
            {
                switch (tipoProducto)
                {
                    case EProducto.PrecioDeTablets:
                        if (item is Tablet)
                            acumulador += (double)(Tablet)item;
                        break;

                    case EProducto.PrecioDeCelulares:
                        if (item is Celular)
                            acumulador += (double)(Celular)item;
                        break;

                    case EProducto.PrecioTotal:
                        if (item is Tablet)
                            acumulador += (double)(Tablet)item;
                        if (item is Celular)
                            acumulador += (Celular)item;
                        break;
                }
            }
            return acumulador;
        }
        #endregion

        #region Sobrecargas
        public static implicit operator Deposito(int capacidad)
        {
            return new Deposito(capacidad);
        }

        public static bool operator ==(Deposito d, Producto p)
        {
            bool retorno = false;

            foreach (Producto item in d.productos)
            {
                if (item is Celular && p is Celular)
                {
                    if ((Celular)item == (Celular)p)
                    {
                        return true;
                    }
                }
                if (item is Tablet && p is Tablet)
                {
                    if ((Tablet)item == (Tablet)p)
                    {
                        return true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Deposito d, Producto p)
        {
            return !(d == p);
        }

        public static Deposito operator +(Deposito d, Producto p)
        {
            if (d.capacidad > d.productos.Count)
            {
                if (d != p)
                    d.productos.Add(p);
                else
                    Console.WriteLine("El producto ya esta en el deposito.\n");
            }
            else
                Console.WriteLine("No hay mas lugar en el deposito.\n");

            return d;
        }
        public static Deposito operator -(Deposito d, Producto p)
        {
            if (d == p)
                d.productos.Remove(p);
            else
                Console.WriteLine("El producto ya esta en la concesionaria.\n");
            return d;
        }
        #endregion
    }
}
