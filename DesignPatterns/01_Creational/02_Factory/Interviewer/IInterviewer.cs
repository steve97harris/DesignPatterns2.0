using System;

namespace DesignPatterns._01_Creational._02_Factory.Interviewer
{
    interface IInterviewer
    {
        void AskQuestions();
    }

    class Developer : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Asking questions about design patterns");
        }
    }

    class CommunityExecutive : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Asking questions about community building");
        }
    }
}