using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDDD.Domain.Entities;
using TestDDD.Domain.Interfaces.Repositories;

namespace TestDDD.Infraestructure.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Clientes>, IClienteRepository
    {
        public StatusResponse getByEmail(string correo)
        {
            try
            {
                using (var context = new ContextData())
                {
                    var result = context.Cliente.Where(item => item.Correo.ToUpper().Trim().Equals(correo.ToUpper().Trim()) && item.Activo);



                    return new StatusResponse()
                    {
                        Success = true,
                        Value = result.ToList().Count > 0 ? true : false
                    };

                }
            }//Fin del try
            catch (Exception ex)
            {
                return new StatusResponse()
                {
                    Success = false,
                    Value = true
                };
            }
        }
    }
}
