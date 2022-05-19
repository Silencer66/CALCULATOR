using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProj;
namespace CALCULATOR
{
    public partial class FormCalculator : Form
    {
        private string D; //в этой переменной сохраняется действие
        private string N1; // число перед нажатием операции
        private bool flag = false; //после активации действия, начали набирать второе число 

        public FormCalculator() //конструктор по умолчанию 
        {
            InitializeComponent();
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text += B.Text;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text; //сохраняем число в данный момент
            flag = true;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double d1, d2, result = 0;
            d1 = Convert.ToDouble(N1);
            d2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
                result = MathFunction.Summa(d1, d2);

            if (D == "-")
                result = MathFunction.Substract(d1,d2);

            if (D == "ˣ")
                result = MathFunction.Multiply(d1, d2);

            if (D == "/")
                result = MathFunction.Divide(d1,d2);
            D = "=";
            flag = true; // чтобы при следующем наборе начиналось с '0'
            textBox1.Text = result.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);//удаляем последний символ из поля ввода
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            double result = 0, d;
            if (B.Text == "√")
            {
                d = Convert.ToDouble(textBox1.Text);
                result = Math.Sqrt(d);
                textBox1.Text = result.ToString();
            }
            if (B.Text == "ₓ⁮²")
            {
                d = Convert.ToDouble(textBox1.Text);
                result = Math.Pow(d, 2);
                textBox1.Text = result.ToString();
            }
            if (B.Text == "±")
            {
                d = Convert.ToDouble(textBox1.Text);
                result = -d;
                textBox1.Text = result.ToString();
            }
            if (B.Text == "1/x")
            {
                d = Convert.ToDouble(textBox1.Text);
                result =MathFunction.Fruction(d); //собственная библиотека
                textBox1.Text = result.ToString();
            }
            if (B.Text == "%")
            {
                double d1 = Convert.ToDouble(N1);
                d = Convert.ToDouble(textBox1.Text);
                if (D == "+")
                {
                    result = MathFunction.Percent(d1, d, D); //d - второе число
                }
                if (D == "-")
                {
                    result = MathFunction.Percent(d1, d, D);
                }
                if (D == "ˣ")
                {
                    result = MathFunction.Percent(d1, d, D);
                }
                if (D == "/")
                {
                    result = MathFunction.Percent(d1, d, D);
                }
                textBox1.Text = result.ToString();
            }
            if(B.Text == ".")
            {
                if(!textBox1.Text.Contains(","))
                    textBox1.Text += ",";
            }
        }
    }
}
