using System.Collections.Generic;

namespace CSharpIntermediate
{
    public interface IWorkflow
    {
        public IEnumerable<ITask> GetActivities();
    }
}