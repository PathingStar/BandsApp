using BandsApp.Web.Models;
using BandsApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace BandsApp.Web.Controllers
{
    public class BandsController : Controller
    {
        BandService bandService = new BandService();

        [Route("")]
        public ActionResult Index()
        {
            var model = bandService.GetAllBands();
            return View(model);
        }

        [Route("details/{id}")]
        public ActionResult Details(int id)
        {
            var model = bandService.GetBandById(id);
            return View(model);
        }
    }
}
