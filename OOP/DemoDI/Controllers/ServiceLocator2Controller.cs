using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDI.Controllers
{
    public class ServiceLocator2Controller : Controller
    {
        public void Index([FromServices] IServiceProvider serviceProvider)
        {
            // retorna null se não estiver registrado
            serviceProvider.GetRequiredService<IClienteService>().AdicionarCliente(new Cliente());
        }
    }
}