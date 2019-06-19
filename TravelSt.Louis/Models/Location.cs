using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelStLouis.Models
{
    public class Location :IModel
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
