using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_numbers_overload
{
    internal class Class1
    {
        public static int sum(int a, int b, int c, int d) // сумма значений
        {

            return a + b + c + d;
        }
        public static int sum(int a, int b, int c)
        {


            return a + b + c;
        }
        public static int sum(int a, int b)
        {


            return a + b;
        }
        public static int sum(int a)
        {


            return a;
        }
    }
}
