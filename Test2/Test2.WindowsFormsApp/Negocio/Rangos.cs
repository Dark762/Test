using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.WindowsFormsApp.Negocio
{
    public class Rangos
    {
        public List<int> CompletarRango(List<int> param)
        {

            var Menor = param.Min();
            var MAyor = param.Max();

            List<int> ListaCompleta = new List<int>();

            for (int i = Menor; i <= MAyor; i++)
            {
                ListaCompleta.Add(i);
            }


            return ListaCompleta;
        }
    }
}
