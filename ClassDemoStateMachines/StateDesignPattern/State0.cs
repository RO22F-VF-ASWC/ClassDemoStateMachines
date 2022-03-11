using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoStateMachines.StateDesignPattern
{
    public class State0:IState<char, bool>
    {
        public IState<char, bool> NextStateFunction(char input)
        {
            switch (input)
            {
                case 'a': return new State1();
                default: return new State3();

            }
        }

        public bool OutputFunction(char input)
        {
            switch (input)
            {
                case 'a': return true;
                default: return false;

            }
        }
    }
    
}
