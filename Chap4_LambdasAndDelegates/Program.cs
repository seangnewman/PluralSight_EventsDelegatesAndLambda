using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap4_LambdasAndDelegates
{

    public delegate int BizRulesDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {

            var custs = new List<Customer>
            {
                new Customer {City = "Phoenix", FirstName = "John", LastName = "Doe", ID = 1},
                new Customer {City = "Phoenix", FirstName = "Jane", LastName = "Rae", ID = 500},
                new Customer {City = "Seattle", FirstName = "Suki", LastName = "Pizzora", ID = 3},
                new Customer {City = "New York City", FirstName = "Michelle", LastName = "Smith", ID = 17}
            };
            // Select customer from custs where customer.city = "phoenix"
            var phxCustomer = custs
                .Where((customer) => customer.City == "Phoenix" && customer.ID < 500)
                .OrderBy((customer) => customer.LastName);
            var indexCustomer = custs.Where((customer) => customer.ID <= 500);

            foreach (var customer in phxCustomer)
            {
                Console.WriteLine("LastName = {0},  FirstName = {2}, City = {1}", customer.LastName, customer.City, customer.FirstName);
            }
            foreach (var customer in indexCustomer)
            {
                Console.WriteLine("LastName = {0},  FirstName = {2}, City = {1}", customer.LastName, customer.City, customer.FirstName);
            }


            //BizRulesDelegate addDel = (x, y) => x + y;
            //BizRulesDelegate multiplyDel = (x, y) => x * y;


            //var data = new ProcessData();
            //data.Process(2, 3, addDel);
            //data.Process(2, 3, multiplyDel);

            //Action<int, int> myAddAction = (x, y) => Console.WriteLine(x + y);
            //Action<int, int> myMultiplyAction = (x, y) => Console.WriteLine(x * y);


            //Func<int, int, int> funcAddDel = (x, y) => x + y;
            //Func<int, int, int> funcMultiplyDel = (x, y) => x * y;
            //data.ProcessFunc(5, 10, funcAddDel);
            //data.ProcessFunc(5, 10, funcMultiplyDel);

            //Console.WriteLine();
            //data.ProcessAction(4, 5, myAddAction);
            //data.ProcessAction(4, 5, myMultiplyAction);
            //Worker worker = new Worker();

            //worker.WorkPerformed += (sender, e) => 
            //{
            //    Console.WriteLine("Hours Worked " + e.Hours + "  " + e.WorkType);
            //};
            //worker.WorkCompleted += (semder, e) =>
            //{
            //    Console.WriteLine("Done!");
            //};

            //worker.DoWork(8, Worktype.GenerateReports);

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
