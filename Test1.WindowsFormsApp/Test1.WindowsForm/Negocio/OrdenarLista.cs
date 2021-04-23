using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.WindowsForm.Modelo;

namespace Test1.WindowsForm.Negocio
{
    public class OrdenarLista
    {
        public List<Usuario> OrdenarPorNombre(List<Usuario> param)
        {

            var result = param.OrderBy(item => item.Nombre).ToList();

            return result;
        }

        public List<Usuario> OrdenarPorNombreApellido(List<Usuario> param)
        {
            var result = (from s in param
                          orderby s.Nombre, s.Apellido
                          select new Usuario { Nombre = s.Nombre, Apellido = s.Apellido }).ToList();

            return result;
        }
    }
}
