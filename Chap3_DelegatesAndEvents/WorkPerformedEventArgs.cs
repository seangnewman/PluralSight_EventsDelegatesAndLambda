using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_DelegatesAndEvents
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public int Hours { get; set; }
        public Worktype WorkType { get; set; }

        public WorkPerformedEventArgs(int hours, Worktype workType)
        {
            Hours = hours;
            WorkType = workType;
        }
    }
 

}
