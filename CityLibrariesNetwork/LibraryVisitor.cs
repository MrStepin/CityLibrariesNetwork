using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrariesNetwork
{
    public class LibraryVisitor
    {
        public Guid VisitorId { get; set; }

        public Guid LibraryId { get; set; }

        public Guid BookCopyId { get; set; }

        public double GetTime { get; set; }

        public double ReturnTime { get; set; }
    }
}
