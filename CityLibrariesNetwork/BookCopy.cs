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
            Id = Guid.NewGuid();
        }
        public Guid BookId { get; set; }
        public Guid NumberOfEdition { get; set; }
        public Guid Id { get; set; }
    }
}
