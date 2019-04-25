using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            TeamLeader teamLeader = new TeamLeader();
            ProjectLeader projectLeader = new ProjectLeader();
            DepartmentDirector departmentDirector = new DepartmentDirector();

            employee.Supervisor = teamLeader;
            teamLeader.Supervisor = projectLeader;
            projectLeader.Supervisor = departmentDirector;

            employee.ApplyVacation(new VacationRequest(new DateTime(2019,12,1), new DateTime(2019, 12, 4)));
            employee.ApplyVacation(new VacationRequest(new DateTime(2019, 12, 1), new DateTime(2019, 12, 7)));
            employee.ApplyVacation(new VacationRequest(new DateTime(2019, 12, 1), new DateTime(2019, 12, 12)));
            employee.ApplyVacation(new VacationRequest(new DateTime(2019, 12, 1), new DateTime(2019, 12, 23)));

        }
    }
}
