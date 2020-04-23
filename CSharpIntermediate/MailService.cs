using System;

namespace CSharpIntermediate
{
    public class MailService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email... ");
            ;
        }
    }
}