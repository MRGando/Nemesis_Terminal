using System;
using System.Diagnostics;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Nemesis - 1.0v";
            Redirector.menu();
            Console.Read();
        }
    }
}
