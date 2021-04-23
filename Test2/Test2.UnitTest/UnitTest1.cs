using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Test2.WindowsFormsApp.Negocio;

namespace Test2.UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        private int CantidadElemento = 0;
        private bool EsCompleto = false;


        [TestMethod]
        public void CompletarRango_Caso1_TestMethod()
        {
            var obj = new Rangos();

            var result = obj.CompletarRango(Data_Caso1());

            CantidadElemento = (result.Max() - result.Min()) + 1;

            if (CantidadElemento == result.Count)
            {
                EsCompleto = true;
            }


            Assert.IsTrue(EsCompleto);
        }

        [TestMethod]
        public void CompletarRango_Caso2_TestMethod()
        {
            var obj = new Rangos();

            var result = obj.CompletarRango(Data_Caso2());

            CantidadElemento = (result.Max() - result.Min()) + 1;

            if (CantidadElemento == result.Count)
            {
                EsCompleto = true;
            }

            Assert.IsTrue(EsCompleto);
        }


        [TestMethod]
        public void CompletarRango_Caso3_TestMethod()
        {
            var obj = new Rangos();

            var result = obj.CompletarRango(Data_Caso3());

            CantidadElemento = (result.Max() - result.Min()) + 1;

            if (CantidadElemento == result.Count)
            {
                EsCompleto = true;
            }


      

            Assert.IsTrue(EsCompleto);
        }



        private List<int> Data_Caso1()
        {
            List<int> Lista = new List<int>();

            Lista.Add(2);
            Lista.Add(1);
            Lista.Add(4);
            Lista.Add(5);


            return Lista;
        }

        private List<int> Data_Caso2()
        {
            List<int> Lista = new List<int>();

            Lista.Add(100);
            Lista.Add(96);
            Lista.Add(101);
            Lista.Add(102);
            Lista.Add(105);


            return Lista;
        }

        private List<int> Data_Caso3()
        {
            List<int> Lista = new List<int>();

            Lista.Add(22);
            Lista.Add(25);

            return Lista;
        }
    }
}
