using System;
using System.Threading;

namespace TutorialCSharpAsyncProgramming
{
    public class Example0ThreadState
    {
        public void StartDemo()
        {
            var state = ThreadState.Unstarted | ThreadState.Stopped | ThreadState.WaitSleepJoin;

            Console.WriteLine($"{Convert.ToString((int)state, 2)}");
        }
    }
}