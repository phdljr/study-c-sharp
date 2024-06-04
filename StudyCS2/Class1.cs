//#define Test

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCS2
{

    class Point
    {
        public int x = 1;
        public int y = 2;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string? ToString()
        {
            return $"{x}, {y}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p = new(1, 2);
            var list = new List<Point>();
            var bList = new BindingList<Point>();
            list.Add(p);
            bList.Add(p);

            Console.WriteLine(string.Join("", list));
            Console.WriteLine(string.Join("", bList));

            p.x = 2;

            Console.WriteLine(string.Join("", list));
            Console.WriteLine(string.Join("", bList));
        }

        [Conditional("Test")]
        static void Test(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}
