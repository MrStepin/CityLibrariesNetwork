using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrariesNetwork
{
    public class City
    {
        public City()
        {
            CityId = Guid.NewGuid();
        }

        public Guid CityId { get; set; }
        public string Name { get; set; }
    }
}
