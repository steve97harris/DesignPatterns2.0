using System;
using System.Collections.Generic;

namespace DesignPatterns._03_Behavioral._07_Observer.JobPost
{
    public class Program
    {
        static void MainOLD()
        {
            var johnDoe = new JobSeeker("John Doe");
            var janeDoe = new JobSeeker("Jane Doe");
            
            // Create publisher and attach subscribers
            var jobPostings = new JobPostings();
            jobPostings.Subscribe(johnDoe);
            jobPostings.Subscribe(janeDoe);
            
            // Add a new job and see if subscribers get notified 
            jobPostings.AddJob(new JobPost("Engineer"));

            // Figure out unsubscriber function
            // var x = new Unsubscriber<JobPost>(new List<IObserver<JobPost>>(), johnDoe);
            // x.Dispose();

            Console.ReadLine();
        }
    }
}