﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSale.Model
{
    public class Car
    {
        public int Id { get; set; }

        public string Brand { get; set; }
        public string Type { get; set; }

        public string License { get; set; }

        public int Date { get; set; }
    }
}
