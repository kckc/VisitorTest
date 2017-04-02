using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTest
{
    public class MyDate: IVisitable
    {
        private int _day, _month, _year;

        public MyDate(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public void accept(MyVisitor visitor)
        {
            visitor.PrintConstructor(this);
        }

        public void PrintConstructor()
        {
            Console.WriteLine(String.Format("new MyDate({0}, {1}, {2})", _day, _month, _year));
        }
    }
}
