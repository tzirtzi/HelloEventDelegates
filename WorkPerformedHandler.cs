using System;

namespace HelloEventDelegates
{

    public class WorkPerformedEventArgs: EventArgs
    {
        public int Hours {get; set;}
        public WorkType WorkType{ get; set;}
    }

    public delegate void WorkPerformedHandler(int work, WorkType workType);

    public delegate int WorkPerformedWithReturnValueHandler(int work, WorkType workType);

}