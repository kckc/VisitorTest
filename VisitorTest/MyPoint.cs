using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTest
{
    public class MyPoint: IVisitable
    {
        private double _x, _y;

        public MyPoint(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public void accept(MyVisitor visitor)
        {
            visitor.PrintConstructor(this);
        }

        public void PrintConstructor()
        {
            Console.WriteLine(String.Format("new MyPoint({0}, {1})", _x, _y));
        }
    }
}
