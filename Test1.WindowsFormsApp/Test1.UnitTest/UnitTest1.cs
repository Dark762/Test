using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Test1.WindowsForm.Modelo;
using Test1.WindowsForm.Negocio;

namespace Test1.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OrdenarPorNombre_TestMethod()
        {

            var obj = new OrdenarLista();

            var result = obj.OrdenarPorNombreApellido(DataDesordenada());

            var DataOrdenada = DataEsperada().OrderBy(item => item.Nombre).ToList();

            Assert.IsTrue(ListaIguales(result, DataOrdenada));
        }

        [TestMethod]
        public void OrdenarPorNombreApellido_TestMethod()
        {

            var obj = new OrdenarLista();

            var result = obj.OrdenarPorNombreApellido(DataDesordenada());


            var DataOrdenada = (from s in DataEsperada()
                                orderby s.Nombre, s.Apellido
                                select new Usuario { Nombre = s.Nombre, Apellido = s.Apellido }).ToList();

            Assert.IsTrue(ListaIguales(result, DataOrdenada));

        }

        private List<Usuario> DataDesordenada()
        {
            List<Usuario> list = new List<Usuario>();

            list.Add(new Usuario() { Nombre = "Carlos", Apellido = "Alcantara" });
            list.Add(new Usuario() { Nombre = "Luis", Apellido = "Reyes" });
            list.Add(new Usuario() { Nombre = "Marcos", Apellido = "Pinillos" });
            list.Add(new Usuario() { Nombre = "Marcos", Apellido = "Buis" });
            list.Add(new Usuario() { Nombre = "Alberto", Apellido = "Coronel" });


            return list;
        }

        private List<Usuario> DataEsperada()
        {
            List<Usuario> list = new List<Usuario>();

            list.Add(new Usuario() { Nombre = "Alberto", Apellido = "Coronel" });
            list.Add(new Usuario() { Nombre = "Carlos", Apellido = "Alcantara" });
            list.Add(new Usuario() { Nombre = "Luis", Apellido = "Reyes" });
            list.Add(new Usuario() { Nombre = "Marcos", Apellido = "Buis" });
            list.Add(new Usuario() { Nombre = "Marcos", Apellido = "Pinillos" });

            return list;
        }

        private bool ListaIguales(List<Usuario> param1, List<Usuario> param2)
        {
            try
            {
                if (JsonConvert.SerializeObject(param1).Equals(JsonConvert.SerializeObject(param2)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
