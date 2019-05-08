﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface IVisitor
    {
        void Visit(Product product);
        void Visit(Order order);
        void Visit(Customer customer);

    }
}
