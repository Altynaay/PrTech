using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcluator_app2
{
    public partial class Form1 : Form
    {
        public static Calculator calculator;
        private int cnt = 0;
        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (calculator.operation == Calculator.Operation.NONE ||
                calculator.operation == Calculator.Operation.NUMBER)
            {
                if (display.Text == "0")
                {
                    display.Text = " ";
                    display.Text += btn.Text;
                }
                else
                display.Text += btn.Text;
            }
            else if (calculator.operation == Calculator.Operation.PLUS)
            {
                cnt = 1;
                calculator.saveFirstNumber(display.Text);
                display.Text = btn.Text;
            }
            else if (calculator.operation == Calculator.Operation.MINUS)
            {
                cnt = 2;
                calculator.saveFirstNumber(display.Text);
                display.Text = btn.Text;
            }
            else if (calculator.operation == Calculator.Operation.MULTIPLY)
            {
                cnt = 3;
                calculator.saveFirstNumber(display.Text);
                display.Text = btn.Text;
            }
            else if (calculator.operation == Calculator.Operation.DIVIDE)
            {
                cnt = 4;
                calculator.saveFirstNumber(display.Text);
                display.Text = btn.Text;
            }
            else if (calculator.operation == Calculator.Operation.POW)
            {
                cnt = 5;
                calculator.saveFirstNumber(display.Text);
              //  display.Text = btn.Text;
            }

            calculator.operation = Calculator.Operation.NUMBER;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
           /*display.Text = " ";
            calculator.saveFirstNumber(display.Text);
            display.Text = calculator.getResultPlus().ToString();
            calculator.firstNumber = calculator.getResultPlus();*/
            calculator.operation = Calculator.Operation.PLUS;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            calculator.operation = Calculator.Operation.MINUS;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            calculator.operation = Calculator.Operation.MULTIPLY;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            calculator.operation = Calculator.Operation.DIVIDE;
        }
        
        private void button19_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }
        private void button24_Click(object sender, EventArgs e)
        {
            calculator.saveSecondNumber(display.Text);
            display.Text = calculator.getResultProcent().ToString();
            //calculator.operation = Calculator.Operation.PROCENT;
        }
        private void button22_Click(object sender, EventArgs e)
        {
            // quadratic
            display.Text =(double.Parse(display.Text) * double.Parse(display.Text)).ToString();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            calculator.saveSecondNumber(display.Text);
            if (cnt == 1)
            {
                display.Text = calculator.getResultPlus().ToString();
            }
            if (cnt == 2)
            {
                display.Text = calculator.getResultMinus().ToString();
            }
            if (cnt == 3)
            {
                display.Text = calculator.getResultMultiply().ToString();
            }
            if (cnt == 4)
            {
                display.Text = calculator.getResultDivide().ToString();
            }
        }

        

        private void button20_Click(object sender, EventArgs e)
        {
            //delete the latest number
            display.Text = calculator.deleteLast(display.Text);
            if (display.Text == "")
                display.Text = "0";
        }

        

        private void button23_Click(object sender, EventArgs e)
        {
            //  sqrt(number)
            display.Text = (Math.Sqrt(double.Parse(display.Text))).ToString();
            //display.Text = (1 / double.Parse(display.Text)).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display.Text += ",";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //     1/number
            //display.Text = (Math.Sqrt(double.Parse(display.Text))).ToString();
            display.Text = (1 / double.Parse(display.Text)).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            display.Text = ((-1) * double.Parse(display.Text)).ToString();
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            // CE CE CE
            //Button btn = sender as Button;
            /*calculator.saveSecondNumber("0");
            display.Text = "0";
            calculator.saveSecondNumber(display.Text);*/
        }

        private void button27_Click(object sender, EventArgs e)
        {

        }
        public double M;
        private void button25_Click(object sender, EventArgs e)
        {
            //MS
            M = double.Parse(display.Text);
            display.Text = "0";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            // M-
            M = double.Parse(display.Text) - M;  
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            display.Text = M.ToString();
            calculator.saveSecondNumber(M.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // M+
            M = double.Parse(display.Text) + M;   
        }
    }
}
