using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDDD.Domain.Entities;

namespace Web.Models
{
    public class ClienteViewModel
    {
        public List<RegistrarClienteViewModel> ListaClientes { get; set; }
    }
}
