using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CountSomethingInterfaceDemo
{
    class FileStringSource : IStringsSource
    {
        private string[] _lines;
        private int _index = 0;

        public FileStringSource(string path)
        {
            _lines = File.ReadAllLines(path);
        }

        public string Get()
        {
            var line = _lines[_index];
            _index++;
            return line;
        }

        public bool IsFinished()
        {
            return _index >= _lines.Length;
        }
    }
}
