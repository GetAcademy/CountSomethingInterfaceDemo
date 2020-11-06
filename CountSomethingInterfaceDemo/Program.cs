using System;

namespace CountSomethingInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountLines(new ConsoleStringSource());
            CountLines(new FileStringSource("TextFile1.txt"));
        }

        private static void CountLines(IStringsSource stringsSource)
        {
            var count = 0;
            while (!stringsSource.IsFinished())
            {
                var line = stringsSource.Get();
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
