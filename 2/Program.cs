using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass();
            c.change = "Not charged";
            MyStruct s;
            s.change = "Not changed";
            Console.WriteLine(c.change);
            Console.WriteLine(s.change);
            ClassTaker(c);
            StructTaker(ref s);
            Console.WriteLine(c.change);
            Console.WriteLine(s.change);

            Console.ReadLine();
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Changed";
        }

        static void StructTaker(ref MyStruct myStruct)
        {
            myStruct.change = "Changed";
        }

    }
}
