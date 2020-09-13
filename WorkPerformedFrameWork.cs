namespace HelloEventDelegates
{

    public static class WorkPerformedFrameWork
    {
        public static void WorkPerformed1(int hours, WorkType workType)
        {
            System.Console.WriteLine($"Work Performed 1 fired with data: {hours} {workType}");
        }

        public static void WorkPerformed2(int hours, WorkType workType)
        {
            System.Console.WriteLine($"Work Performed 2 fired with data: {hours} {workType}");
        }

        public static void WorkPerformed3(int hours, WorkType workType)
        {
            System.Console.WriteLine($"Work Performed 3 fired with data: {hours} {workType}");
        }

        public static int WorkPerformed4(int hours, WorkType workType)
        {
            System.Console.WriteLine($"Work Performed 4 fired with data: {hours} {workType}");
            return hours;
        }

        public static int WorkPerformed5(int hours, WorkType workType)
        {
            System.Console.WriteLine($"Work Performed 5 fired with data: {hours} {workType}");
            return 5;
        }

    }

}