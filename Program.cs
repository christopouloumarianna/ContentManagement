using System;

namespace ContentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var sen = new SimpleText();
            Console.WriteLine(sen.CountWords());
        }
    }
}