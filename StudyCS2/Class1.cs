using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCS2
{
    class Parent
    {
        public string Some() => "parent some";
        public virtual string Other() => "parent other";
        public virtual string Another() => "parent another";
    }

    class Child : Parent
    {
        public string Some() => "child some";

        // [Error] 'override' 키워드는 virtual이나 abstract 메소드에만 사용할 수 있다.
        //public override string Some() => "child some";

        public string Other() => "child other";
        public override string Another() => "child another";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Child();

            Console.WriteLine(p.Some());    // parent some
            Console.WriteLine(p.Other());   // parent other
            Console.WriteLine(p.Another()); // child another
        }
    }
}
