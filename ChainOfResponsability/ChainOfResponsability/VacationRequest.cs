using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class VacationRequest
    {
        private static int lastRequestNumber;
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public int RequestNumber { get; set; }

        public VacationRequest(DateTime startDay, DateTime endDay)
        {
            StartDay = startDay;
            EndDay = endDay;
            RequestNumber = lastRequestNumber;
            lastRequestNumber++;
        }

        public int GetNumberOfDays()
        {
            return  (int)(EndDay - StartDay).TotalDays;
        }
    }
}
