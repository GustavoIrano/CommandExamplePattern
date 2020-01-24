using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternExample
{
    public class User
    {
        private readonly WordIterator _wordIterator = new WordIterator();
        private readonly List<Commander> _commands = new List<Commander>();

        public void Add(string word)
        {
            Commander command = new WordIterationCommand(_wordIterator, word);
            command.Iterate();

            _commands.Add(command);
        }

        public void ExecuteAllCommands(int levels)
        {
            for(var i = 0; i < levels; i++)
            {
                _commands[i].ExecuteAllCommands();
            }
        }
    }
}
