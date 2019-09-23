using EventHandling.OrderExample;
using EventHandling.OrderExample.Model;
using EventHandling.WorkerExample;
using System;

namespace EventHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Order Simple Example
            Orders orders = new Orders();
            orders.OrderPlaced += OrderPlacedHandler;
            orders.ProcessOrder();
            Console.WriteLine();
            //Worker Example
            Worker worker = new Worker();
            worker.WorkPerformed += Worker_Workperformed;
            worker.WorkCompleted += Worker_WorkCompleted;
            worker.DoWork(8, WorkType.UATSupport);
        }

        private static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Work is done");
        }

        private static void Worker_Workperformed(object sender, WorkerEventArgs e)
        {
            Console.WriteLine($"Work Done --> {e.WorkType} for {e.Hours} hours.");
        }

        private static void OrderPlacedHandler(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Order Placed --> Total: {e.Total:C2}, Discounted: {e.DiscountedTotal:C2}");
        }
    }
}
