using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDI.Controllers
{
    public class ServiceLocatorController : Controller
    {
        private readonly IServiceProvider _serviceProvider;

        public ServiceLocatorController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Index()
        {
            // retorn null se não estiver registrado
            _serviceProvider.GetRequiredService<IClienteService>().AdicionarCliente(new Cliente());
        }
    }
}