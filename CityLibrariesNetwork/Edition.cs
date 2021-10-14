using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrariesNetwork
{
    public class Edition
    {
        public Edition()
        {
            NumberOfEdition = Guid.NewGuid();
        }

        public Guid NumberOfEdition { get; set; }
        public int QtyOfPages { get; set; }
        public Guid BookId {get;set;}
        public string Binding { get; set; }
    }
}
