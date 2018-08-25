using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2_DelegaatesAndEvents
{
    
    class Program
    {
        static void Main(string[] args)
        {
           Worker worker = new Worker();

            worker.DoWork(50, Worktype.GoToMeetings);

        }
    }

    public enum Worktype
    {
        GoToMeetings, Golf, GenerateReports
    }

}
