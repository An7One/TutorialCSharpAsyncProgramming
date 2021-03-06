using System;
using System.Threading;

namespace TutorialCSharpAsyncProgramming
{
    /// <summary>
    /// Video URL: https://www.bilibili.com/video/BV1Zf4y117fs?p=2
    /// </summary>
    public class Example1Join
    {
        private Thread thread1, thread2;
        private const string NameThread1 = "Thread1";
        private const string NameThread2 = "Thread2";

        public Example1Join()
        {
            this.thread1 = new Thread(ThreadProc);
            this.thread1.Name = NameThread1;

            this.thread2 = new Thread(ThreadProc);
            this.thread2.Name = NameThread2;
        }

        public void StartDemo()
        {
            this.thread1.Start();
            this.thread2.Start();
        }

        private void ThreadProc()
        {
            Console.WriteLine("\nCurrent Thread: {0}", Thread.CurrentThread.Name);
            if (Thread.CurrentThread.Name == NameThread1 && thread2.ThreadState != ThreadState.Unstarted)
                thread2.Join();

            Thread.Sleep(2000);
            Console.WriteLine("\nCurrent thread: {0}", Thread.CurrentThread.Name);
            Console.WriteLine("Thread2: {0}", thread1.ThreadState);
            Console.WriteLine("Thread2: {0}\n", thread2.ThreadState);
        }
    }
}