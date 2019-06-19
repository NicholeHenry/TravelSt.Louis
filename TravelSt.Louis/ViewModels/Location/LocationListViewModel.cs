using TravelStLouis.Models;
using TravelStLouis.Data;
using System; 
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelSt.Louis.Data.Repositories;

namespace TravelStLouis.ViewModels.Location
{
    public class LocationListViewModel
    {
        public static List<LocationListViewModel> GetLocations(RepositoryFactory repositoryFactory)
        {
            return repositoryFactory.GetLocationRepository()
                .GetModels()
                .Select(m => new LocationListViewModel())
                .ToList();
        }
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        public string Name { get; set; }
        public int Description { get; set; }

    }
}
