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

        public TestWriteAction(Action<string> action)
        {
            this.writeText = action;

            Thread testThread = new Thread(Run);
            testThread.Start();
        }

        public void Run()
        {
            while (true)
            {
                writeText("write!!!!!");
                Thread.Sleep(100);
            }
        }
    }
}
