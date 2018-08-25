using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();

            worker.WorkPerformed += delegate (object sender, WorkPerformedEventArgs e)
            {
                Console.WriteLine("Hours Worked " + e.Hours + "  " + e.WorkType);
            };
            worker.WorkCompleted += delegate (object sender, EventArgs e)
            {
                Console.WriteLine("Done!");
            };


            worker.DoWork(8, Worktype.GenerateReports);

        }

        //private static void Worker_WorkCompleted(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Done!");
        //}

        //private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        //{
        //    Console.WriteLine("Hours Worked " + e.Hours + "  " + e.WorkType);
        //}

      

         
    }



    public enum Worktype
    {
        GoToMeetings, Golf, GenerateReports
    }

}
