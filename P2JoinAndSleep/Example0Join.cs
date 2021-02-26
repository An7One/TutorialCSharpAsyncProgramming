using System.Threading;
using System;

namespace TutorialCSharpAsyncProgramming
{
    /// <summary>
    /// Video URL: https://www.bilibili.com/video/BV1Zf4y117fs?p=2
    /// Time: 00:35 ~ 01:05
    /// </summary>
    public class Example0Join
    {
        public void StartDemo()
        {
            Thread t = new Thread(Go);
            t.Start();
            t.Join();
            Console.WriteLine("Thread t has ended!");
        }

        private void Go()
        {
            for (int i = 0; i < 1000; ++i)
                Console.Write("y");
        }
    }
}