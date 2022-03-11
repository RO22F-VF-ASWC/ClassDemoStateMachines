using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoStateMachines.StateDesignPattern
{
    public class State1 : IState<char, bool>
    {
        public IState<char, bool> NextStateFunction(char input)
        {
            switch (input)
            {
                case 'b': return new State2();
                default: return new State3();

            }
        }

        public bool OutputFunction(char input)
        {
            switch (input)
            {
                case 'b': return true;
                default: return false;

            }
        }
    }
}

