using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouveBeen.Controllers
{
    public class PlacesYouveBeenController : Controller
    {
        [HttpGet("/placesYouveBeen")]
        public ActionResult Index()
        {
            List<Parcel> allParcels = Parcel.GetAll();
            return View(allParcels);
        }

        [HttpGet("/placesYouveBeen/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/placesYouveBeen")]
        public ActionResult Create(int width, int height, int depth)
        {
            Parcel myParcel = new Parcel(width, height, depth);
            return RedirectToAction("Index");
        }
    }
}