using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

using OracleBpm.Features.Contract;
using OracleBpm.Features.Domain.Entities;
using OracleBpm.Features.UI.Models;

namespace Treino.Pro.Feature.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IFeatureRole _featureRole;

        public HomeController(ILogger<HomeController> logger , IFeatureRole featureRole)
        {
            _logger = logger;
            _featureRole = featureRole;
        }

        public IActionResult Index()
        {
            EntityRole entityRole = new EntityRole { CodigoRole = 1, DescricaoRole = "Desc Teste", DataCadastroRole = DateTime.Now };
           _featureRole.UpdateFeature(entityRole);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
