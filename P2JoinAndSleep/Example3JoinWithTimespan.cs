using System;
using System.Threading;

namespace TutorialCSharpAsyncProgramming
{
    /// <summary>
    /// Video URL: https://www.bilibili.com/video/BV1Zf4y117fs?p=2 
    /// </summary>
    public class Example3JoinWithTimespan
    {
        private TimeSpan waitTime = new TimeSpan(0, 0, 1);
        public void StartDemo()
        {
            Thread newThread = new Thread(Work);
            newThread.Start();
            if (newThread.Join(waitTime + waitTime))
                Console.WriteLine("The new thread has been terminated");
            else
                Console.WriteLine("Join timed out");
        }

        private void Work()
        {
            Thread.Sleep(waitTime);
        }
    }
}