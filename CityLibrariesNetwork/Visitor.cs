﻿using System;
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
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
