using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Television))]
    [XmlInclude(typeof(Monitor))]
    public class Fabrica <P> where P : Producto
    {
        
        #region Atributos
        private int capacidad;
        public List<Producto> productos;
        #endregion

        /// <summary>
        /// La capacidad de Fabricacion(cupo limitado)
        /// </summary>
        #region Propiedades
        public int Capacidad 
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor publico que crea una lista de productos
        /// </summary>
        public Fabrica()
        {
            this.productos = new List<Producto>();
        }
        /// <summary>
        /// Constructor publico que asigna capacidad y llama al constructor publico
        /// </summary>
        /// <param name="capacidad">Le asigna capacidad a la fabrica</param>
        public Fabrica(int capacidad)
            : this()
        {
            this.Capacidad = capacidad;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que muestra todos los productos agregado en caso de ser posible
        /// </summary>
        /// <returns>Retorna el taller con el producto agregado en caso de ser posible</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendLine("*********************************************");            
            sb.AppendFormat($"Capacidad: {this.Capacidad}\n");
            sb.AppendLine("Lista de Productos");
            sb.AppendLine("*********************************************");
            foreach (Producto item in this.productos)
            {
                sb.AppendFormat($"{item.ToString()}\n");
            }

            return sb.ToString();
        }

        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecargo el metodo fabrica para la capacidad
        /// </summary>
        /// <param name="capacidad">Retorna la capacidad de todas las capacidades</param>
        public static implicit operator Fabrica <P>(int capacidad)
        {
            return new Fabrica<P>(capacidad);
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Sobrecarga del operador igual entre dos productos
        /// </summary>
        /// <param name="d">Fabrica,al cual se le añade el producto</param>
        /// <param name="p">Producto,al cual se le añade el fabrica</param>
        /// <returns></returns>
        public static bool operator ==(Fabrica<P> d, Producto p) 
        {
            bool retorno = false;
        try
        {
            foreach (Producto item in d.productos)
            {

                    if (item is Monitor && p is Monitor)
                    {
                        if ((Monitor)item == (Monitor)p)
                        {
                            return true;
                        }
                    }
                    if (item is Television && p is Television)
                    {
                        if ((Television)item == (Television)p)
                        {
                            return true;
                        }
                    }
            }    
        }
        catch(Exception ex){}

            return retorno;
        }
        
        
        /// <summary>
        /// Sobrecarga del operador distinto entre dos productos
        /// </summary>
        /// <param name="d">Fabrica,al cual se le añade el producto</param>
        /// <param name="p">Producto,al cual se le añade el fabrica</param>
        /// <returns></returns>
        public static bool operator !=(Fabrica<P> d, Producto p)
        {
            return !(d == p);
        }
        
        
        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="d">Fabrica,al cual se le añade el producto</param>
        /// <param name="p">Producto,al cual se le añade el fabrica</param>
        /// <returns></returns>
        public static Fabrica<P> operator +(Fabrica<P> d, Producto p)
        {
            try
            {
                if (d.Capacidad > d.productos.Count)
                {
                    if (d != p)
                        d.productos.Add(p);
                    else
                        Console.WriteLine("El producto ya esta en la Fabrica.\n");
                }
                else
                    throw new Exception();
            }
            catch(Exception ex)
            {
                ex.InformarProductos();  
            }
            return d;
        }
        
        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="d">Fabrica,al cual se le añade el producto</param>
        /// <param name="p">Producto,al cual se le añade el fabrica</param>
        /// <returns></returns>
        public static Fabrica<P> operator -(Fabrica<P> d, Producto p)
        {
            try
            {
                if (d == p)
                    d.productos.Remove(p);
                else
                    Console.WriteLine("El Producto ya esta Fabricado.\n");
            }
            catch(Exception ex) { }
                return d;
            }
        #endregion

        
    }
}
