using System;

namespace CSharpIntermediate
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            if (workflow == null)
            {
                throw new ArgumentNullException("_workflow");
            }

            foreach (var activity in workflow.GetActivities())
            {
                try
                {
                    activity.Execute();
                }
                catch (Exception e)
                {
                    //Logging 
                    //Terminate and persist the state
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}