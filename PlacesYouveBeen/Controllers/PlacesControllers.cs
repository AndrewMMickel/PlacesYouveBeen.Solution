using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouveBeen.Controllers
{
    public class PlacesController : Controller
    {
        [HttpGet("/places")]
        public ActionResult Index()
        {
            List<Place> allPlaces = Place.GetAll();
            return View(allPlaces);
        }

        [HttpGet("/places/new")]
        public ActionResult New() { return View(); }

        [HttpPost("/places")]
        public ActionResult Create(string cityName, int stayLength, string journalEntry)
        {
            Place myPlace = new Place(cityName, stayLength, journalEntry);
            return RedirectToAction("Index");
        }

        [HttpGet("/places/{id}")]
        public ActionResult Show(int id)
        {
            Place foundPlace = Place.Find(id);
            return View(foundPlace);
        }
    }
}