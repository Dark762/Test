using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDDD.Domain.Entities;

namespace TestDDD.Domain.Interfaces.Services
{
    public interface IClienteService : IBaseService<Clientes>
    {
        StatusResponse getByEmail(string id);
    }
}
