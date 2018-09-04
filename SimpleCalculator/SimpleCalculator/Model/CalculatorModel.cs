using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Model
{
    class CalculatorModel
    {
        double num1;
        double num2;
        double result;

        public double Num1
        {
            get
            {
                return num1;
            }

            set
            {
                num1 = value;
            }
        }

        public double Num2
        {
            get
            {
                return num2;
            }

            set
            {
                num2 = value;
            }
        }

        public double Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }

        public double Additon()
        {
            Result = Num1 + Num2;
            return Result;
        }
        public double Substraction()
        {
            Result = Num1 - Num2;
            return Result;
        }
        public double Division()
        {
            Result = Num1 / Num2;
            return Result;
        }
        public double Multiplication()
        {
            Result = Num1 * Num2;
            return Result;
        }
      
    }
}

