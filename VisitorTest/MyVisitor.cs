using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTest
{
    public class MyVisitor: IVisitor
    {
        public void PrintConstructor(MyDate date)
        {
            date.PrintConstructor();
        }

        public void PrintConstructor(MyPoint point)
        {
            point.PrintConstructor();
        }
    }
}
