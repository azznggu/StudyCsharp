using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventTest.TestAction
{
    public class TestWriteAction
    {
        private Action<string> writeText;
        public Thread testThread;
        public TestWriteAction(Action<string> action)
        {
            this.writeText = action;

            testThread = new Thread(Run);
            testThread.Start();
        }

        public void Run()
        {
            bool continueFlag = true;
            Random random = new Random();
            string[] arr = { "first", "second", "third", "fourth", "fifth" };
            using (System.Timers.Timer timer = new System.Timers.Timer(3000))
            {
                timer.Elapsed += (sender, e) =>
                {
                    timer.Stop();
                    continueFlag = false;
                };
                timer.Start();
                while (continueFlag)
                {
                    writeText("it's " + arr[random.Next(0, arr.Length)]);
                    Thread.Sleep(100);
                }
            }
        }

        public void Stop()
        {
            testThread.Abort();
        }
    }
}
