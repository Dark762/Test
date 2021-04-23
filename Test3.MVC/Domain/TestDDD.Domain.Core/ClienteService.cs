using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDDD.Domain.Entities;
using TestDDD.Domain.Interfaces.Repositories;
using TestDDD.Domain.Interfaces.Services;

namespace TestDDD.Domain.Core
{
    /**
     * <summary>Clase que contiene los métodos de la entidad permiso, se encarga de realizar la conexión entre los servicios y los repositorios.</summary>
     */
    public class ClienteService : BaseService<Clientes>, IClienteService
    {
        //Declaración de variables globales
        private readonly IClienteRepository ClienteRepository;

        /**
         * <summary>Método constructor</summary>
         * <param name="ClienteRepository">Corresponde al tipo de interfaz de tipo IPermissionRepository</param>
         */
        public ClienteService(IClienteRepository ClienteRepository) : base(ClienteRepository)
        {
            this.ClienteRepository = ClienteRepository;
        }//Fin del método

        public StatusResponse getByEmail(string id)
        {
            return this.ClienteRepository.getByEmail(id);
        }
    }//Fin de la Interface IBaseRepository
}
