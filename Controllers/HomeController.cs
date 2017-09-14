using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ftec.Cadastro.Site.Controllers
{
   public class HomeController : Controller
   {
      [Route("")]
      [Route("Home")]
      [Route("Home/Index")]
      [Route("Home/Index2")]
      public IActionResult Index()
      {
         return View();
      }
      [Route("home")]
      public IActionResult IHome()
      {
         return View();
      }
      [Route("Home/About")]
      public IActionResult About()
      {
         return View();
      }
      [Route("Home/Contact")]
      public IActionResult Contact()
      {
         return View();
      }
   }
}
