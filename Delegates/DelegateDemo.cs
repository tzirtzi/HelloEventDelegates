using System;

namespace HelloEventDelegates
{

    public static class DelegateDemo
    {

        public static void demo()
        {
            Console.WriteLine("FIRST USE ------- Delegator chain as a work flow");
            Console.WriteLine("Preparing delegators chain");
            Console.WriteLine("Delegators could be framework code outside our reach");
            WorkPerformedHandler del = new WorkPerformedHandler(WorkPerformedFrameWork.WorkPerformed1);
            del += new WorkPerformedHandler(WorkPerformedFrameWork.WorkPerformed2); // with this we can invoke multiple listeners
            
            Console.WriteLine("Passing actual data to delegator chain");
            Console.WriteLine("Please notice delegators fire sequentially");
            del(1, WorkType.GenerateReports );
            del(2, WorkType.Golf);

            Console.WriteLine("NOTICE -- When Custom handler returns data, ONLY THE LAST INVOKATION IN THE LIST WILL RETURN DATA");
            WorkPerformedWithReturnValueHandler del2 = new WorkPerformedWithReturnValueHandler(WorkPerformedFrameWork.WorkPerformed4);
            del2 += new WorkPerformedWithReturnValueHandler(WorkPerformedFrameWork.WorkPerformed5);
            del2( 23, WorkType.Golf);

            Console.WriteLine("SECOND USE ------- Dynamically pass delegator as function pointer");
            Console.WriteLine("In this way we can define the actions that will take place at run time, dynamically passing different delegates");
            System.Console.WriteLine("... First subcase: Use delegate defined in a framework to perform work on a local process:");
            DoTask(WorkPerformedFrameWork.WorkPerformed2, 34, WorkType.GoToMeetings );

            System.Console.WriteLine("... Second subcase: Pass a locally defined delegate to a framework process to do work");
            
            Action<int, WorkType> myAction = (hours, worktype) => {
                System.Console.WriteLine("This is work done on framework dynamic process, from a locally defined function (myAction)...");
                System.Console.WriteLine($"Processing data {hours} hours of {worktype}! ... myAction done!");
            };
            Func<int, WorkType, bool> myOtherAction = (hours, worktype) => {
                System.Console.WriteLine("This is work done on framework dynamic process, from a locally defined function (myOtherAction)...");
                System.Console.WriteLine($"Processing data {hours} hours of {worktype} ... myOtherAction done!");
                return true;
            };

            WorkPerformedFrameWork.DynamicWorkPerformed1(myAction, 12, WorkType.GoToMeetings);
            var res = WorkPerformedFrameWork.DynamicWorkPerformed1(myOtherAction, 12, WorkType.GoToMeetings);
            System.Console.WriteLine($" ---> Result from last delegate invocation {res}");
        }
        static void DoTask(WorkPerformedHandler del, int hours, WorkType workType)
        {
            del(hours, workType);
        }
    }
}