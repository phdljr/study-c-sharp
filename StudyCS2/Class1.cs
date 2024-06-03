//#define Test

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCS2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Test("test");
        }

        [Conditional("Test")]
        static void Test(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}
