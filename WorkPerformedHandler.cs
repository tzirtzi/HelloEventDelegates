using System;

namespace HelloEventDelegates
{


    // Custom delegate
    public delegate void WorkPerformedHandler(int work, WorkType workType);

    // Custom delegate with return type - not standard for events, can be used though as shown in demo
    public delegate int WorkPerformedWithReturnValueHandler(int work, WorkType workType);

    // this is the standard delegate for raising events with custom args
    public delegate int WorkPerfomedStandardHandler(object sender, WorkPerformedEventArgs e);

    // custom EventArgs Class, need to inherit EventArgs in order to be used with events
    public class WorkPerformedEventArgs: EventArgs
    {
        public int Hours {get; set;}
        public WorkType WorkType{ get; set;}

        public WorkPerformedEventArgs(int hours, WorkType workType)
        {
            Hours = hours;
            WorkType = workType;
        }
    }
}