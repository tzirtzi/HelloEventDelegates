using System;

namespace HelloEventDelegates
{
    public class Worker
    {

        public event WorkPerformedWithReturnValueHandler WorkPerformed;  // Event definition 
        public event EventHandler WorkCompleted;    //Default arguments is (raiser object, EventArgs[])

        protected virtual void OnWorkPerformed(int hours, WorkType workType)    // It is common to define the event in a wrapper function, here virtual if anyone wants to subclass and override
        {
            if (WorkPerformed != null) // Check if anyone listening, this will raise an error if no one is subscribed
            {
                System.Console.WriteLine("Worker Class :: -> raising event Work Perfomed...");
                WorkPerformed(hours, workType);
            }
        }

        protected virtual void OnWorkCompleted()    // It is common to define the event in a wrapper function, here virtual if anyone wants to subclass and override
        {
            if (WorkCompleted != null) // Check if anyone listening, this will raise an error if no one is subscribed
            {
                System.Console.WriteLine("Worker Class :: -> raising event Work Completed...");
                WorkCompleted(this, EventArgs.Empty);
            }
        }

        public void DoWork(int hours, WorkType workType)
        {
            
            for (int i=0; i < hours; i++ )
            {
                System.Console.WriteLine($"Worker Class :: Doing job tasks for hour {i}");
                //raise event for job done in this hour
                OnWorkPerformed( i+1, workType );
            }
            // raise event work completed
            OnWorkCompleted();

        }
    }

}