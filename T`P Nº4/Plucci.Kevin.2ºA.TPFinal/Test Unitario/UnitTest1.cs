using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace Test_Unitario
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test Unitario de Sobrecarga del operador == productos
        /// </summary>
        [TestMethod]
        public void VerificarIgualdad()
        {
            int fabrica_ = 4;
            int pulgadasMonitor_ = 1;
            int pulgadasTelevisor_ = 1;
            int idMonitor = 1;
            int idTelevisor = 1;
            ECalidad unitario = ECalidad._4K;
            ECalidad secundario = ECalidad.FullHD;
            EMarcaTel marcaT = EMarcaTel.Philips;
            EMarcaMoni marcaM = EMarcaMoni.ViewSonic;


            Fabrica<Television> f1 = new Fabrica<Television>(fabrica_);
            Fabrica<Monitor> f2 = new Fabrica<Monitor>(fabrica_);
            Television t1 = new Television(idTelevisor, pulgadasTelevisor_, unitario, marcaT);
            Monitor m1 = new Monitor(idMonitor, pulgadasMonitor_, secundario, marcaM);

            //YA INGRESADO
            //f1 += c1;
            f1 += t1;

            //YA INGRESADO
            f2 += m1;

            Assert.AreEqual(t1.Id, idTelevisor);
            Assert.AreEqual(m1.Id, idMonitor);
            Assert.AreEqual(t1.Pulgadas, pulgadasTelevisor_);
            Assert.AreEqual(m1.Pulgadas, pulgadasMonitor_);
            Assert.AreEqual(t1.Calidad, unitario);
            Assert.AreEqual(m1.Calidad, secundario);
            Assert.AreEqual(t1.MarcaTel, marcaT);
            Assert.AreEqual(m1.MarcaMoni, marcaM);

            Assert.IsTrue(f1 == t1 && f2 == m1);
        }

        /// <summary>
        /// Test Unitario de Sobrecarga del operador != productos
        /// </summary>
        [TestMethod]
        public void VerificarDistinto()
        {
            int fabrica_ = 4;
            int idMonitor = 1;
            int idTelevisor = 1;
            int pulgadasMonitor_ = 1;
            int pulgadasTelevisor_ = 1;
            ECalidad unitario = ECalidad._4K;
            ECalidad secundario = ECalidad.FullHD;
            EMarcaTel marcaT = EMarcaTel.Philips;
            EMarcaMoni marcaM = EMarcaMoni.ViewSonic;

            Fabrica<Television> f1 = new Fabrica<Television>(fabrica_);
            Fabrica<Monitor> f2 = new Fabrica<Monitor>(fabrica_);
            Television t1 = new Television(idTelevisor,pulgadasTelevisor_, unitario, marcaT);
            Monitor m1 = new Monitor(idMonitor, pulgadasMonitor_, secundario, marcaM);

            //YA INGRESADO
            //f1 += c1;
            f1 += t1;

            //YA INGRESADO
            f2 += m1;

            Assert.AreEqual(t1.Id, idTelevisor);
            Assert.AreEqual(m1.Id, idMonitor);
            Assert.AreEqual(t1.Pulgadas, pulgadasTelevisor_);
            Assert.AreEqual(m1.Pulgadas, pulgadasMonitor_);
            Assert.AreEqual(t1.Calidad, unitario);
            Assert.AreEqual(m1.Calidad, secundario);
            Assert.AreEqual(t1.MarcaTel, marcaT);
            Assert.AreEqual(m1.MarcaMoni, marcaM);

            Assert.IsTrue(f1 != m1 && f2 != t1);
        }
    }
}
