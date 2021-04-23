using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDDD.Application.Main.Interfaces;
using Web.Models;

namespace Web.Controllers
{
    public class ClienteController : Controller
    {

        private readonly IClienteAppService _clienteAppService;


        public ClienteController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }

        public IActionResult Index()
        {
            var Lista = _clienteAppService.getAll();

            ClienteViewModel model = new ClienteViewModel();

            if (Lista != null)
            {
                model.ListaClientes = new List<RegistrarClienteViewModel>();

                Lista.ToList().ForEach(item =>
                {
                    RegistrarClienteViewModel obj = new RegistrarClienteViewModel()
                    {
                        Id = item.Id,
                        Nombres = item.Nombres,
                        Apellidos = item.Apellidos,
                        Correo = item.Correo,
                        FechaNacimiento = item.FechaNacimiento,
                        Direccion = item.Direccion,
                        Activo = item.Activo,
                        FechaRegistro = item.FechaRegistro
                    };

                    model.ListaClientes.Add(obj);
                });
            }

            return View(model);
        }

        public IActionResult Registrar()
        {

            return View();
        }


       
        [HttpPost]
        [Produces("application/json")]
        [AllowAnonymous]
        public IActionResult Registrar(RegistrarClienteViewModel request)
        {

            var existeCorreo = _clienteAppService.getByEmail(request.Correo);

            StatusResponseViewModel result = new StatusResponseViewModel();

            if (existeCorreo.Success && !(bool)existeCorreo.Value)
            {
                var obj = _clienteAppService.add(new TestDDD.Domain.Entities.Clientes()
                {
                    Nombres = request.Nombres,
                    Apellidos = request.Apellidos,
                    Correo = request.Correo,
                    FechaNacimiento = request.FechaNacimiento,
                    Direccion = request.Direccion,
                    Activo = request.Activo,
                    FechaRegistro = DateTime.Now
                });

                result.Value = obj.Value;
                result.Success = obj.Success;
                result.Message = obj.Message;
            }
            else {

                result.Success = true;
                result.Value = false;
                result.Message = "El correo existe de ese cliente";
            }

            return Json(result);
        }
    }
}
