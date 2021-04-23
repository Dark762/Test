using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDDD.Domain.Entities;

namespace TestDDD.Application.Main.Interfaces
{
    public interface IClienteAppService : IBaseAppService<Clientes>
    {
        StatusResponse getByEmail(string id);
    }
}
