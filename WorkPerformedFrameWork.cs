using System;

namespace HelloEventDelegates
{

    public static class WorkPerformedFrameWork
    {

        public static void DynamicWorkPerformed1(Action<int, WorkType> del, int hours, WorkType workType)
        {
            del(hours, workType);
        }
        public static bool DynamicWorkPerformed1(Func<int, WorkType, bool> del, int hours, WorkType workType)
        {
            return del(hours, workType);
        }

        public static void WorkPerformed1(int hours, WorkType workType)
        {
            System.Console.WriteLine($"Work Performed 1 fired with data: {hours} {workType}");
        }
        public static void WorkPerformed1( object sender, WorkPerformedEventArgs e) 
        {
            System.Console.WriteLine($"Work Performed 1 fired with WorkPerformedEventArgs data: {e.Hours} {e.WorkType}");
        }


        public static void WorkPerformed2(int hours, WorkType workType)
        {
            System.Console.WriteLine($"Work Performed 2 fired with data: {hours} {workType}");
        }
        public static void WorkPerformed2( object sender, WorkPerformedEventArgs e) 
        {
            System.Console.WriteLine($"Work Performed 2 fired with WorkPerformedEventArgs data: {e.Hours} {e.WorkType}");
        }


        public static void WorkPerformed3(int hours, WorkType workType)
        {
            System.Console.WriteLine($"Work Performed 3 fired with data: {hours} {workType}");
        }
        public static void WorkPerformed3( object sender, WorkPerformedEventArgs e) 
        {
            System.Console.WriteLine($"Work Performed 3 fired with WorkPerformedEventArgs data: {e.Hours} {e.WorkType}");
        }


        public static int WorkPerformed4(int hours, WorkType workType)
        {
            System.Console.WriteLine($"Work Performed 4 fired with data: {hours} {workType}");
            return hours;
        }
        public static int WorkPerformed4( object sender, WorkPerformedEventArgs e) 
        {
            System.Console.WriteLine($"Work Performed 4 fired with WorkPerformedEventArgs data: {e.Hours} {e.WorkType}");
            return 4;
        }


        public static int WorkPerformed5(int hours, WorkType workType)
        {
            System.Console.WriteLine($"Work Performed 5 fired with data: {hours} {workType}");
            return 5;
        }
        public static int WorkPerformed5( object sender, WorkPerformedEventArgs e) 
        {
            System.Console.WriteLine($"Work Performed 5 fired with WorkPerformedEventArgs data: {e.Hours} {e.WorkType}");
            return 5;
        }
    }

}