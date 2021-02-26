using System;

namespace TutorialCSharpAsyncProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            #region P1 Example
            // var p1Example0 = new Example0TypicalThread();
            // p1Example0.Demo();

            // var p1Example1 = new Example1TypicalThread();
            // p1Example1.Demo();
            #endregion

            #region P2 Example
            // var p2Example0 = new Example0Join();
            // p2Example0.StartDemo();

            // var p2Example1 = new Example1Join();
            // p2Example1.StartDemo();

            // var p2Example2 = new Example2JoinWithTimeout();
            // p2Example2.StartDemo();

            // var p2Example3 = new Example3JoinWithTimespan();
            // p2Example3.StartDemo();

            // var p2Example4 = new Example4Sleep();
            // p2Example4.StartDemo();

            // var p2Example5 = new Example5SleepWithTimespan();
            // p2Example5.StartDemo();

            var p3Example0 = new Example0ThreadState();
            p3Example0.StartDemo();

            #endregion
        }
    }
}
