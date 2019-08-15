using System;

namespace RecursiveExample
{
    public class RecursiveHelper
    {
        private const string Val = "{0} ";

        private readonly sbyte[] _values;

        private readonly Random _random = new Random();

        private readonly IWriter _writer;

        public RecursiveHelper(int count, sbyte min, sbyte max, IWriter writer)
        {
            _writer = writer;
            _values = new sbyte[count];

            for (int i = 0; i < _values.Length; i++)
            {
                _values[i] = (sbyte)_random.Next(min, max);
            }
        }

        public void Print(Predicate<sbyte> predicate, int i = 0)
        {
            if (i < _values.Length * 2)
            {
                if (i < _values.Length)
                {
                    if (predicate(_values[i]))
                    {
                        _writer.Write(string.Format(Val, _values[i]));
                    }
                }
                else
                {
                    if (!predicate(_values[i - _values.Length]))
                    {
                        _writer.Write(string.Format(Val, _values[i - _values.Length]));
                    }
                }

                Print(predicate, ++i);
            }
        }
    }
}
