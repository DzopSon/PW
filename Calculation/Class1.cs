using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculation
{
    public class Calculate
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Nie mozna dzielic przez zero");
            }
            return a / b;
        }
    }
}