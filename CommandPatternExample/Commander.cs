using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternExample
{
    public abstract class Commander
    {
        public abstract void Iterate();
        public abstract void ExecuteAllCommands();
    }
}
