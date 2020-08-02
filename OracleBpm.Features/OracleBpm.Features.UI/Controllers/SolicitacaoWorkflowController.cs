using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OracleBpm.Features.UI.Controllers
{
    public class SolicitacaoWorkflowController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}   