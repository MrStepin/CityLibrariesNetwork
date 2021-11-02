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

        public string GetTime { get; set; }

        public string ReturnTime { get; set; }
    }
}
