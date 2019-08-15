using System;

namespace RecursiveExample
{
    public class RecursiveHelper
    {
        private const string Val = "{0} ";

        private readonly sbyte[] _values;

        private static readonly Random Random = new Random();

        private readonly IWriter _writer;

        public RecursiveHelper(int count, sbyte min, sbyte max, IWriter writer)
        {
            _writer = writer;
            _values = new sbyte[count];

            for (int i = 0; i < _values.Length; i++)
            {
                _values[i] = (sbyte)Random.Next(min, max);
            }
        }

        public void Print(Predicate<sbyte> predicate, int i = 0)
        {
            if (i >= _values.Length) return;

            if (predicate(_values[i]))
            {
                _writer.Write(string.Format(Val, _values[i]));
            }

            Print(predicate, i + 1);

            if (!predicate(_values[i]))
            {
                _writer.Write(string.Format(Val, _values[i]));
            }
        }
    }
}
