using System;



namespace HelloEventDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("88888888888888888888888888888888888888888888888888888888888888888888888");
            System.Console.WriteLine("Starting delegates demo");
            // Handler functionality demo here
            DelegateDemo.demo();

            System.Console.WriteLine("88888888888888888888888888888888888888888888888888888888888888888888888");
            System.Console.WriteLine("Starting Events demo");
            //Event functionality demo here
            WorkerDemo.demo();
        }



    }
}
