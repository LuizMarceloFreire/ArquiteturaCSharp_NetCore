using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class MutiplasClassesController : Controller
    {
        private readonly Func<string, IService> _serviceAcessor;

        public MutiplasClassesController(Func<string, IService> serviceAcessor)
        {
            _serviceAcessor = serviceAcessor;
        }

        public string Index()
        {
            return _serviceAcessor("A").Retorno();
            //return _serviceAcessor("B").Retorno();
            //return _serviceAcessor("C").Retorno();
        }
    }
}