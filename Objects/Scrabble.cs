using System;
using System.Collections.Generic;

namespace Counter.Objects
{
    public class RepeatCounter
    {
        private string[] _sentenceInput;
        private string _wordInput;

        public RepeatCounter(string sentence, string word)
        {
            _sentenceInput = sentence.Split(' ');
            _wordInput = word.ToLower();
        }

        public int CountRepeats()
        {
            int counter = 0;
            for (int i = 0; i <= _sentenceInput.Length - 1; i++)
            {
                if (_sentenceInput[i] == _wordInput)
                {
                    counter += 1;
                }
            }
            return counter;
        }

        // public string[] GetSentenceInput()
        // {
        //     return _sentenceInput;
        // }
        // public string GetWordInput()
        // {
        //     return _wordInput;
        // }
    }
}
