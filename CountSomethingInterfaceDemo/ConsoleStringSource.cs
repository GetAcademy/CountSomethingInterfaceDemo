using System;

namespace CountSomethingInterfaceDemo
{
    class ConsoleStringSource : IStringsSource
    {
        private string _line = null;

        public string Get()
        {
            _line = Console.ReadLine();
            return _line;
        }

        public bool IsFinished()
        {
            return _line != null && _line.Length == 0;
        }
    }
}
