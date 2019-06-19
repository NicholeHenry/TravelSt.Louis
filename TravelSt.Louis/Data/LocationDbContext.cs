using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TravelStLouis.Models;

namespace TravelStLouis.Data
{
    public class LocationDbContext : DbContext
    {
        public DbSet<Location> Locations {get; set;}

        public LocationDbContext(DbContextOptions<LocationDbContext>options)
        : base(options) { }
    }
}
