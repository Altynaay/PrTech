using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcluator_app2
{
    public class Calculator
    {
        public enum Operation
        {
            NONE,
            NUMBER,
            PLUS,
            MINUS,
            EQUAL,
            MULTIPLY,
            POW,
            PROCENT,
            DIVIDE
        };
        public Operation operation;
        public double firstNumber, secondNumber;

        public Calculator()
        {
            operation = Operation.NONE;
            firstNumber = 0;
            secondNumber = 0;
        }

        public void saveFirstNumber(string s)
        {
            firstNumber = double.Parse(s);
        }

        public void saveSecondNumber(string s)
        {
            secondNumber = double.Parse(s);
        }

        public double getResultPlus()
        {
            return firstNumber + secondNumber;
        }
        public double getResultMinus()
        {
            return firstNumber - secondNumber;
        }
        public double getResultMultiply()
        {
            return firstNumber * secondNumber;
        }
        public double getResultDivide()
        {
            return firstNumber / secondNumber;
        }
        public double getResultProcent()
        {
            return firstNumber * secondNumber/100;
        }
        public string deleteLast(string s)
        {
            string x = "";
            char[] arr = s.ToCharArray();
            for (int i = 0; i < s.Length - 1; i++)
                x = x + s[i];
            return x;
        }


    }
}
