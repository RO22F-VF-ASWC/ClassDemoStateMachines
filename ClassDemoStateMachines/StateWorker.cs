using System;
using ClassDemoStateMachines.StateDesignPattern;
using ClassDemoStateMachines.StateTable;

namespace ClassDemoStateMachines
{
    public class StateWorker
    {

        public void Start()
        {
            Console.Write("Type in a textline ");
            string str = Console.ReadLine();

            bool success = true;
            IStateMachine<char> sm = new StateMachineDesignPattern();


            foreach (char c in str)
            {
                if (!sm.NextInput(c))
                {
                    Console.WriteLine("Error - The string do not confirm to (abc)* - input was " + str);
                    success = false;
                    break;
                }
            }

            if (success)
            {
                Console.WriteLine($"Congratulations the string {str} did confirm to (abc)* ");
            }
        }
    }

}