using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrariesNetwork
{
    public class Visitor
    {
        public Visitor()
        {
            VisitorId = Guid.NewGuid();
        }

        public Guid VisitorId { get; set; }
    }
}
