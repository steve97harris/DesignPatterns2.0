namespace DesignPatterns._03_Behavioral._07_Observer.JobPost
{
    public class JobPost
    {
        public string Title { get; private set; }
        
        // Constructor for JobPost
        public JobPost(string title)
        {
            Title = title;
        }
    }
}