using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Workflow
    {
        private readonly IList<IWorkflow> _workflow;

        public Workflow()
        {
            _workflow = new List<IWorkflow>();
        }

        public void AddActivity(IWorkflow activity)
        {
            _workflow.Add(activity);
        }

        public IList<IWorkflow> GetActivities()
        {
            return _workflow;
        }
    }
}