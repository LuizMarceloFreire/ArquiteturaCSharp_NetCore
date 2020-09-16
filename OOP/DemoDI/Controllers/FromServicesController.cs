using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class FromServicesController : Controller
    {
        public void Index([FromServices] IClienteService clienteService)
        {
            clienteService.AdicionarCliente(new Cliente());
        }
    }
}