using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Test_de_Consola
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Creacion de Televsion y de Monitor en la Fabrica
            Fabrica<Television> f1 = new Fabrica<Television>(4);
            Fabrica<Monitor> f2 = new Fabrica<Monitor>(2);
            //Creacion de 4 Televisores
            Television t1 = new Television(1, 32, ECalidad._4K, EMarcaTel.Philips);
            Television t2 = new Television(2, 42, ECalidad.FullHD, EMarcaTel.LG);
            Television t3 = new Television(3, 32, ECalidad._8K, EMarcaTel.LG);
            Television t4 = new Television(4, 52, ECalidad._8K, EMarcaTel.Sony);          
            //Creacion de 2 Monitores
            Monitor c1 = new Monitor(1, 20, ECalidad.FullHD, EMarcaMoni.ViewSonic);
            Monitor c2 = new Monitor(2, 18, ECalidad._8K, EMarcaMoni.Zowie);
            //YA INGRESADO
            //f1 += c1;
            f1 += t1;
            f1 += t2;
            f1 += t3;
            f2 += c2;

            //YA INGRESADO
            f1 += t4;
            f2 += c1;
            //SIN LUGAR
            f1 += t4;

            Console.WriteLine(f1.Mostrar());
            Console.WriteLine(f2.Mostrar());


            /*using (XmlTextWriter writer = new XmlTextWriter("DatosTelevisores.xml", Encoding.UTF8))
            {
                //Creo un objeto que 'sabe' como serializar a XML
                //Le tengo que indicar que tipo de objeto se va a serializar
                XmlSerializer ser = new XmlSerializer(typeof(Fabrica<Television>));

                //Utilizo el método Serialize, pasándole el 'escritor' de XML
                //y el objeto a serializar
                ser.Serialize(writer, f1);
            }


            using (XmlTextWriter writer = new XmlTextWriter("DatosMonitores.xml", Encoding.UTF8))
            {
                //Creo un objeto que 'sabe' como serializar a XML
                //Le tengo que indicar que tipo de objeto se va a serializar
                XmlSerializer ser = new XmlSerializer(typeof(Fabrica<Monitor>));

                //Utilizo el método Serialize, pasándole el 'escritor' de XML
                //y el objeto a serializar
                ser.Serialize(writer, f2);
            }
            */
            Console.ReadLine();
        }
    }
}
