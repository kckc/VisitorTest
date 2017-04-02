using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTest
{
    public interface IVisitor
    {
        void PrintConstructor(MyDate date);

        void PrintConstructor(MyPoint point);
    }
}
