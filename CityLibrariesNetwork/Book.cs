using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrariesNetwork
{
    public class Book
    {

        public Book()
        {
            Id = Guid.NewGuid();
        }

        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public Guid Id { get; set; }
    }
}
