using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            int Min;
            if (number1 < number2)
                Min = number1;
            else Min = number2;
            return Min;
        }

        public int FindMinimum(int number1,int number2, float number3)
        {
            int Min;
            int x = (int)number3;
            if (number1 < number2 && number1 < x)
                Min = number1;
            else if (x < number1 && x < number2)
                Min = x;
            else
                Min = number2;
            return Min;
        }

        public int FindMaximum(int number1, int number2)
        {
            int Max;
            if (number1 > number2)
                Max = number1;
            else Max = number2;
            return Max;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            int Max;
            int y = (int)number3;
            if (number1 > number2 && number1 > y)
                Max = number1;
            else if (number2 > number1 && number2 > y)
                Max = number2;
            else
                Max = y;
            return Max;
        }
    }
}
