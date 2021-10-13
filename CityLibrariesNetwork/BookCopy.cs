using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrariesNetwork
{
    public class BookCopy
    {
        public BookCopy()
        {
            BookCopyId = Guid.NewGuid();
        }

        public string Binding { get; set; }
        public Book BookLink { get; set; }
        public Edition Edition { get; set; }
        public Guid BookCopyId { get; set; }
    }
}
