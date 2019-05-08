﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface ISubscriber
    {
        string Name { get; set; }
        void Update(List<Product> products);

    }
}
