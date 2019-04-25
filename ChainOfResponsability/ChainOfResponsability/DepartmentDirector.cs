using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class DepartmentDirector : Employee
    {
        public override int GetMaxVacationDaysCanAprove()
        {
            return 15;
        }
    }
}
