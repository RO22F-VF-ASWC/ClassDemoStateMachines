using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoStateMachines
{
    public interface IStateMachine<T>
    {
        bool NextInput(T input);
    }
}
