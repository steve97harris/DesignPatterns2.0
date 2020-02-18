using System;
using System.Collections.Generic;

namespace DesignPatterns._03_Behavioral._07_Observer.JobPost
{
    internal class Unsubscriber<JobPost> : IDisposable
    {
        private List<IObserver<JobPost>> mObservers;        // List of Unsubscriber Observers
        private IObserver<JobPost> mObserver;               // Unsubscriber observer
        internal Unsubscriber(List<IObserver<JobPost>> observers, IObserver<JobPost> observer)
        {
            this.mObservers = observers;
            this.mObserver = observer;
        }

        public void Dispose()        // Function to unsubscribe a current observer that belongs to the observers list
        {
            if (mObservers.Contains(mObserver))        // if list of observers contains current observer
            {
                mObservers.Remove(mObserver);          // remove current observer from list
            }
        }
    }
}