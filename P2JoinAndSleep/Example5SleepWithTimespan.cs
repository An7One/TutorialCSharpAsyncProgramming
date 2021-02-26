using System;
using System.Threading;

namespace TutorialCSharpAsyncProgramming
{
    /// <summary>
    /// Video URL: https://www.bilibili.com/video/BV1Zf4y117fs?p=2 
    /// </summary>
    public class Example5SleepWithTimespan
    {
        public void StartDemo()
        {
            TimeSpan interval = new TimeSpan(0, 0, 1);

            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("Sleep for 1 second");
                Thread.Sleep(interval);
            }

            Console.WriteLine("The main thread exits");
        }
    }
}