using System.Threading.Tasks;
using UnityEngine;

namespace Codethulu
{
    public class WaitForTask : CustomYieldInstruction
    {
        private Task task;

        public override bool keepWaiting {
            get {
                return !task.IsCompleted;
            }
        }

        public WaitForTask(Task task) {
            this.task = task;
        }
    }
}
