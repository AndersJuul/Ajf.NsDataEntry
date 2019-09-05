using System.Web.Mvc;
using Ajf.NsDataEntry.Web.Models;

namespace Ajf.NsDataEntry.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new IndexModel());
        }

        [HttpPost]
        public ActionResult Index(IndexModel model)
        {
            return View();
        }
    }
}