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
    public class RoleController : Controller
    {  

        private readonly IFeatureRole _featureRole;

        public RoleController(IFeatureRole featureRole)
        {           
            _featureRole = featureRole;
        }

        public IActionResult Index(int pagina=1)
        {
            var listFeatures = _featureRole.ListFeature().ToPagedList(pagina, 7);
            return View(listFeatures);
        }

    }
}
