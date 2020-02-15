namespace DesignPatterns._01_Creational._02_Factory.Interviewer
{
    abstract class HiringManager
    {
        // Factory Method
        abstract protected IInterviewer MakeInterviewer();

        public void TakeInterview()
        {
            var interviewer = this.MakeInterviewer();
            interviewer.AskQuestions();
        }
    }
}