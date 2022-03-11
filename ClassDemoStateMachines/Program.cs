using System;

namespace ClassDemoStateMachines
{
    class Program
    {
        static void Main(string[] args)
        {
            StateWorker worker = new StateWorker();
            worker.Start();


            //Console.ReadLine();
        }
    }
}
