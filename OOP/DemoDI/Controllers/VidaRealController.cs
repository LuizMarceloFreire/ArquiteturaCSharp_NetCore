using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class VidaRealController : Controller
    {
        private readonly IClienteService _clienteService;

        public VidaRealController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public void Index()
        {
            _clienteService.AdicionarCliente(new Cliente());
        }
    }
}