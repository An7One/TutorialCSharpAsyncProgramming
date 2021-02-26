using System;
using System.Threading;

namespace TutorialCSharpAsyncProgramming
{
    /// <summary>
    /// Video URL: https://www.bilibili.com/video/BV1Zf4y117fs?from=search&seid=12324511733364413761
    /// Time: 06:00 ~ 
    /// </summary>
    class ExampleP1CurrentThread
    {
        public void Demo()
        {
            Thread.CurrentThread.Name = "Main Thread...";
            Thread t = new Thread(WriteY);
            t.Name = "Y Thread ...";
            t.Start();

            Console.WriteLine(Thread.CurrentThread.Name);
            for (int i = 0; i < 1000; ++i)
                Console.Write("x");
        }

        void WriteY()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            for (int i = 0; i < 1000; ++i)
                Console.Write("y");
        }
    }
}