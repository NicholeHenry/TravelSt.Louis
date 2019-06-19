using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TravelStLouis.Data;
using TravelStLouis.Data.Repositories;
using TravelStLouis.Models;

namespace TravelSt.Louis.Data.Repositories
{
    public class RepositoryFactory
    {
        private LocationDbContext context;

        public RepositoryFactory(LocationDbContext context)
        {
            this.context = context;
        }

       public IRepository<Location> GetLocationRepository()
        {
            return new BaseRepository<Location>(context);
        }
    }
}
