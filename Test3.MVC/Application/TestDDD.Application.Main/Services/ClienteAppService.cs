using TestDDD.Domain.Entities;
using TestDDD.Domain.Interfaces.Services;
using TestDDD.Application.Main.Interfaces;



namespace TestDDD.Application.Main.Services
{
    public class ClienteAppService : BaseAppService<Clientes>, IClienteAppService
    {

        private readonly IClienteService clienteService;


        public ClienteAppService(IClienteService clienteService) : base(clienteService)
        {
            this.clienteService = clienteService;
        }

        public StatusResponse getByEmail(string id)
        {
            return this.clienteService.getByEmail(id);
        }
    }
}
