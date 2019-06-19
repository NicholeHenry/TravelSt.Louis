using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelSt.Louis.Data.Repositories;
using TravelStLouis.ViewModels.Location;

namespace TravelStLouis.Controllers
{
    public class LocationController : Controller
    {
        private RepositoryFactory repositoryFactory;

        public LocationController(RepositoryFactory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory;
        }
        public IActionResult Index()
        {
            List<LocationListViewModel> locations = LocationListViewModel.GetLocations(repositoryFactory);
            return View(locations);
        }
        [HttpGet]
        public IActionResult Create()
        {
            LocationCreateViewModel model = new LocationCreateViewModel(repositoryFactory);
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(LocationCreateViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            model.Persist(repositoryFactory);
            return RedirectToAction(actionName: nameof(Index));
        }
        
    }
}