using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chap2_DelegaatesAndEvents
{

    public delegate int WorkPerformedHandler(object sender, WorkPerformedEventArgs e);
    public class Worker
    {
        //public event WorkPerformedHandler WorkPerformed;

        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, Worktype worktype)
        {
            for (int  i = 0; i < hours; i++)
            {
                // Raise event that work is being performed
                Thread.Sleep(250);
                OnWorkPerformed(i + 1, worktype);
                Console.WriteLine("Working");
            }

            //Raise event that work has completed
            OnWorkCompleted();
            Console.WriteLine("Work Completed");
        }

        protected virtual void OnWorkPerformed(int hours, Worktype workType)
        {
            //if( WorkPerformed != null)
            //{
            //    WorkPerformed(hours, worktype);
            //}
            var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            if(del != null)
            {
                del(this,  new WorkPerformedEventArgs(hours, workType));
            }
         }

        protected virtual void OnWorkCompleted()
        {
            //if( WorkCompleted != null)
            //{
            //    WorkCompleted(this, EventArgs.Empty);
            //}
            var del = WorkCompleted as EventHandler;
            if (del != null)
            {
                del(this, EventArgs.Empty);
            }
        }

         
    }
}
