using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoStateMachines.StateDesignPattern
{
    public class StateMachineDesignPattern:IStateMachine<char>
    {
        IState<char,bool> currentState = new State0();

        public bool NextInput(char input)
        {
            bool returValue = currentState.OutputFunction(input);
            currentState = currentState.NextStateFunction(input);
            return returValue;
        }
    }
}
