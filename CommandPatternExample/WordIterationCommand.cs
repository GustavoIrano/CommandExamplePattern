using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternExample
{
    public class WordIterationCommand : Commander
    {
        private string _newWord;
        private readonly WordIterator _wordIterator;

        public WordIterationCommand(WordIterator wordIterator, string newWord)
        {
            _wordIterator = wordIterator;
            _newWord = newWord;
        }

        public override void Iterate()
        {
            _wordIterator.Iteration(_newWord);
        }

        public override void ExecuteAllCommands()
        {
            _wordIterator.Iteration(_newWord);
        }
    }
}
