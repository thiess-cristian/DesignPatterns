﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class TeamLeader : Employee
    {
        public override int GetMaxVacationDaysCanAprove()
        {
            return 5;
        }
    }
}
