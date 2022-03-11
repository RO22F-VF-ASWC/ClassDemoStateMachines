using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoStateMachines.StateDesignPattern
{
    public class State3 : IState<char, bool>
    {
        public IState<char, bool> NextStateFunction(char input)
        {
            switch (input)
            {
                default: return new State3();

            }
        }

        public bool OutputFunction(char input)
        {
            switch (input)
            {
                default: return false;

            }
        }
    }
}
