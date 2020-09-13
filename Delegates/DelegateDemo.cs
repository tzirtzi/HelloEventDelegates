using System;

namespace HelloEventDelegates
{

    public static class DelegateDemo
    {

        public static void demo()
        {
            Console.WriteLine("FIRST USE ------- Delegator chain as a woirk flow");
            Console.WriteLine("Preparing delegators chain");
            Console.WriteLine("Delegators could be framework code outside our reach");
            WorkPerformedHandler del = new WorkPerformedHandler(WorkPerformedFrameWork.WorkPerformed1);
            del += new WorkPerformedHandler(WorkPerformedFrameWork.WorkPerformed2); // with this we can invoke multiple listeners
            
            Console.WriteLine("Passing actualing data to delegator chain");
            Console.WriteLine("Please notice delegators fire sequentially");
            del(1, WorkType.GenerateReports );
            del(2, WorkType.Golf);

            Console.WriteLine("WHEN HANDLER RETURNS DATA, ONLY THE LAST INVOKATION IN THE LIST WILL RETURN");
            WorkPerformedWithReturnValueHandler del2 = new WorkPerformedWithReturnValueHandler(WorkPerformedFrameWork.WorkPerformed4);
            del2 += new WorkPerformedWithReturnValueHandler(WorkPerformedFrameWork.WorkPerformed5);
            del2( 23, WorkType.Golf);

            Console.WriteLine("SECOND USE ------- Dynamically pass delegator as function pointer");
            DoTask(WorkPerformedFrameWork.WorkPerformed2, 34, WorkType.GoToMeetings );
        }
        static void DoTask(WorkPerformedHandler del, int hours, WorkType workType)
        {
            del(hours, workType);
        }
    }
}