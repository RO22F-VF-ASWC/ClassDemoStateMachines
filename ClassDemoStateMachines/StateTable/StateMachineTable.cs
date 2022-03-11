using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoStateMachines.StateTable
{
    public class StateMachineTable:IStateMachine<char>
    {
        private int currentState = 0;
        private StateMachineEntry[,] _sm;

        public StateMachineTable()
        {
            _sm = new StateMachineEntry[4,4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    _sm[i,j] = new StateMachineEntry(){NextState = 3, Accepted = false};
                }
            }

            _sm[0, 0] = new StateMachineEntry() { NextState = 1, Accepted = true }; // state 0 input a (=0)
            //_sm[2, 0] = new StateMachineEntry() { NextState = 1, Accepted = true }; // state 0 input a (=0)
            _sm[1, 1] = new StateMachineEntry() { NextState = 2, Accepted = true }; // state 1 input b (=1)
            _sm[2, 2] = new StateMachineEntry() { NextState = 0, Accepted = true }; // state 2 input c (=2)
        }


        public bool NextInput(char input)
        {
            StateMachineEntry entry = _sm[ConvertInput(input), currentState];
            currentState = entry.NextState;
            return entry.Accepted;
        }


        private int ConvertInput(char c)
        {
            //switch (c)
            //{
            //    case 'a': return 0;
            //    case 'b': return 1;
            //    case 'c': return 2;
            //    default: return 3;
            //}
            if (c == 'a' || c == 'b' || c == 'c')
            {
                return (int)c - (int)'a';
            }
            
            return 3;
            

        }
    }

    struct StateMachineEntry
    {
        public int NextState;
        public bool Accepted;
    }
}
