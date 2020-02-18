using System;

namespace DesignPatterns._03_Behavioral._07_Observer.JobPost
{
    public class JobSeeker : IObserver<JobPost>
    {
        public string Name { get; private set; }
        
        // Constructor for JobSeeker
        public JobSeeker(string name)
        {
            Name = name;
        }

        public void OnNext(JobPost value)        // On Next job posting 
        {
            Console.WriteLine($"Hi {Name} ! A new job has been posted: {value.Title}");        // Write message to list of observers
        }

        // Methods not being called by JobPost class.
        public void OnError(Exception error)
        {
            
        }

        public void OnCompleted()
        {
            
        }
    }
}