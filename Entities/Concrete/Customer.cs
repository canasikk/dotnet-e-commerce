﻿
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer : IEntitiy
    {
        public string CustomerId { get; set; }
        public string ContanctName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
    }
}
