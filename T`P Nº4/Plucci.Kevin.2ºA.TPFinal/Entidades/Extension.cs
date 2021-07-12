using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        public static string InformarProductos(this Exception productoLleno)
        {
            return "Los productos esta lleno" + productoLleno.Message;
        }
    }
}
