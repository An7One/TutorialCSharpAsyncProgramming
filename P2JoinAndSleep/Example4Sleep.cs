using System;
using System.Threading;

namespace TutorialCSharpAsyncProgramming
{
    /// <summary>
    /// Video URL: https://www.bilibili.com/video/BV1Zf4y117fs?p=2 
    /// </summary>
    public class Example4Sleep
    {
        public void StartDemo()
        {
            for (int i = 0; i < 1000; ++i)
            {
                Console.WriteLine("Sleep for 1 second");
                Thread.Sleep(1000);
            }

            Console.WriteLine("The main thread exits.");
        }
    }
}