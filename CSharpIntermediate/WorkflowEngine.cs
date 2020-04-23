using System;

namespace CSharpIntermediate
{
    public class WorkflowEngine
    {
        public void Run(Workflow _workflow)
        {
            if (_workflow == null)
            {
                throw new ArgumentNullException("_workflow");
            }
            else if (_workflow.GetActivities().Count == 0)
            {
                throw new ArgumentNullException("ActivityList","Empty Activity list not allowed");
            }
            
            foreach (var activity in _workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}