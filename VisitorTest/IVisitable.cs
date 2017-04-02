using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTest
{
    public interface IVisitable
    {
        void accept(MyVisitor visitor);
    }
}
