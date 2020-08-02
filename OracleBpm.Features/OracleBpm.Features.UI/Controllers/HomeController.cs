using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Web;
using System.Diagnostics;

using OracleBpm.Features.Contract;
using OracleBpm.Features.Domain.Entities;
using OracleBpm.Features.UI.Models;
using X.PagedList.Mvc.Core;
using X.PagedList;


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

        public IActionResult Index(int pagina=1)
        {

            var listFeatures = _featureRole.ListFeature().ToPagedList(pagina, 5);
            return View(listFeatures);
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
