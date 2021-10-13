using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrariesNetwork
{
    public class Library
    {
        public Library()
        {
            LibraryId = Guid.NewGuid();
        }

        public Guid LibraryId { get; set; }
        public string Name { get; set; }
        public Guid DistrictId { get; set; }
    }
}
