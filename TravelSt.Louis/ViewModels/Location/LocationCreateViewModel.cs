using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelStLouis.Data;
using TravelStLouis.Models;
using Microsoft.AspNetCore.Mvc;
using TravelSt.Louis.Data.Repositories;

namespace TravelStLouis.ViewModels.Location
{
    public class LocationCreateViewModel
    {
        private RepositoryFactory repositoryFactory;

        public string Name { get; set; }
        public string Description { get; set; }

        public LocationCreateViewModel() { }

        public LocationCreateViewModel(RepositoryFactory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory;
        }

        public void Persist(RepositoryFactory repositoryFactory)
        {
            Models.Location location = new Models.Location
            {
                Name = this.Name,
                Description = this.Description
            };
            repositoryFactory.GetLocationRepository().Save(location);
        }

    }
}
