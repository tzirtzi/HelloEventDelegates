using System;

namespace HelloEventDelegates
{

    public static class WorkerDemo
    {
        public static void demo()
        {

            System.Console.WriteLine("Initializing class that will do work....");
            Worker workerDemo = new Worker();

            System.Console.WriteLine("Registering listeners....");

            workerDemo.WorkPerformed += new WorkPerformedWithReturnValueHandler(WorkPerformedFrameWork.WorkPerformed4);
            workerDemo.WorkPerformed += /*new WorkPerformedWithReturnValueHandler*/(WorkPerformedFrameWork.WorkPerformed5);
            
            workerDemo.WorkPerformed2 += new EventHandler<WorkPerformedEventArgs>(WorkPerformedFrameWork.WorkPerformed1);
            workerDemo.WorkPerformed2 += /*new EventHandler<WorkPerformedEventArgs>*/(WorkPerformedFrameWork.WorkPerformed2); // This also works, C# compiler will infer the corret delegate


            System.Console.WriteLine("Initializing works....");
            workerDemo.DoWork(12, WorkType.GenerateReports);
            workerDemo.DoWork(2, WorkType.Golf);

            System.Console.WriteLine("Going swimming... work finished!!");
        }
    }
}