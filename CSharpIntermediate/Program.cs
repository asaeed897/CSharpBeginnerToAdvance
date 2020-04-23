using System.Net.Mail;

namespace CSharpIntermediate
{
    class Program
    { 
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.AddActivity(new Upload());
            workflow.AddActivity(new VideoEncoder());
            workflow.AddActivity(new MailService());
            workflow.AddActivity(new StatusChanger());
            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
            // 38 and 39  Summary and Exercise 
        }
    }
}
