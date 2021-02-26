using System;
using System.Threading;

namespace TutorialCSharpAsyncProgramming
{
    /// <summary>
    /// Video URL: https://www.bilibili.com/video/BV1Zf4y117fs?from=search&seid=12324511733364413761
    /// Time:  02:32 ~ 
    /// </summary>
    class Example0TypicalThread
    {
        public void Demo()
        {
            Thread t = new Thread(WriteY); // to start a new Thread
            t.Name = "Y Thread ...";
            t.Start();

            // to do other/some work in the meanwhile
            for (int i = 0; i < 1000; ++i)
                Console.Write("x");
        }

        void WriteY()
        {
            for (int i = 0; i < 1000; ++i)
                Console.Write("y");
        }
    }
}