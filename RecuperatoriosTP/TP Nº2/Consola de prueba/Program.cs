using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola_de_prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposito miDeposito = 7;

            Tablet t1 = new Tablet("Galaxy", "Samsung", EPais.Corea, ETipo.Mediano);
            Tablet t2 = new Tablet("Xperia", "Sony", EPais.China, ETipo.Chico);
            Fabricante f1 = new Fabricante("Huawei", EPais.China);
            Celular c1 = new Celular("A6", f1, EGama.Media);
            Celular c2 = new Celular("A20", f1, EGama.Alta);

            miDeposito += c1;
            //YA INGRESADO

            miDeposito += t1;
            miDeposito += t2;

            miDeposito += c2;



            Console.WriteLine(Deposito.Mostrar(miDeposito));
            Console.ReadLine();
        }
    }
}
