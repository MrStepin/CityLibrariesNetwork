using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrariesNetwork
{
    public class District
    {
        public District()
        {
            DistrictId = Guid.NewGuid();
        }

        public Guid DistrictId { get; set; }
        public string Name { get; set; }
    }
}
