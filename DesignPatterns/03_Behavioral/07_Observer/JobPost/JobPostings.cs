using System;
using System.Collections.Generic;

namespace DesignPatterns._03_Behavioral._07_Observer.JobPost
{
    public class JobPostings : IObservable<JobPost>
    {
        private List<IObserver<JobPost>> mObservers;
        private List<JobPost> mJobPostings;

        public JobPostings()
        {
            mObservers = new List<IObserver<JobPost>>();
            mJobPostings = new List<JobPost>();
        }
        
        public IDisposable Subscribe(IObserver<JobPost> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!mObservers.Contains(observer)) // if current observer is not contained in list of observers
            {
                mObservers.Add(observer);        // add current observer
            }
            return new Unsubscriber<JobPost>(mObservers, observer);        // adds to unsubscriber list
        }

        private void Notify(JobPost jobPost)        // Function to Notify observers on new job postings 
        {
            foreach (var observer in mObservers)
            {
                observer.OnNext(jobPost);           // foreach observer in list of observers write message to observer with job post
            }
        }

        public void AddJob(JobPost jobPost)        // Function to add new job post
        {
            mJobPostings.Add(jobPost);             // Add job post to list of job posts
            Notify(jobPost);                       // Call Notify function to let observers know about new job post
        }
    }
}