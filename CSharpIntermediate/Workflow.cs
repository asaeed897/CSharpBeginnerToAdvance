using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Workflow : IWorkflow
    {
        private readonly IList<ITask> _tasks;

        public Workflow()
        {
            _tasks = new List<ITask>();
        }

        public void AddActivity(ITask activity)
        {
            _tasks.Add(activity);
        }
        public void RemoveActivity(ITask activity)
        {
            _tasks.Remove(activity);
        }

        public IEnumerable<ITask> GetActivities()
        {
            return _tasks;
        }
    }
}