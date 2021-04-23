using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDDD.Domain.Entities;

namespace TestDDD.Domain.Interfaces.Repositories
{
    /**
    * <summary>Interfaz que contiene los métodos para la entidad de permisos, e implementa la interfaz IBaseRepository.</summary>
    */
    public interface IClienteRepository : IBaseRepository<Clientes>
    {
        StatusResponse getByEmail(string id);
    }
}
