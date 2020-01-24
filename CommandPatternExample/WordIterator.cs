using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternExample
{
    public class WordIterator
    {
        private string _word;

        public void Iteration(string word)
        {
            Console.Write(_word + " " + word);
        }
    }
}
