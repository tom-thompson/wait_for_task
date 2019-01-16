using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using UnityEngine.TestTools;
using Codethulu;

namespace Tests
{
    public class WaitForTaskTest
    {
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator WaitForTaskTestWithEnumeratorPasses()
        {
            int val = 0;

            Task t = new Task(() =>
            {
                Thread.Sleep(1000);
                val = 1;
            });
            t.Start();

            yield return new WaitForTask(t);

            Assert.AreEqual(1, val);
        }
    }
}
