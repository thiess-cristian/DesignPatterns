using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class Employee
    {
        public Employee Supervisor { get; set; }

        public void ApplyVacation(VacationRequest request)
        {
            int numberOfDays = request.GetNumberOfDays();

            if (numberOfDays > 15) {
                Console.WriteLine("invoke HR");
                return;
            }

            if (numberOfDays < Supervisor.GetMaxVacationDaysCanAprove()) {
                Supervisor.ApproveVacation(request);
            } else {
                Supervisor.ApplyVacation(request);
            }
        }

        public virtual int GetMaxVacationDaysCanAprove()
        {
            return 0;
        }

        protected bool ApproveVacation(VacationRequest request)
        {
            Console.WriteLine("Approved by"+this+" id:"+request.RequestNumber);
            return true;
        }

    }
}
