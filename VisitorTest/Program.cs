using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new MyDate(31, 12, 2016);
            var p = new MyPoint(5.5, 10);

            d.PrintConstructor();
            p.PrintConstructor();

            var visitor = new MyVisitor();

            d.accept(visitor);
            p.accept(visitor);

            Console.Read();
        }
    }
}
