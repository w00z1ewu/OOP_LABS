using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPLab01
{
    public partial class Calculator : Form
    {
        private bool EmptyInput = true;
        private const int TB_max_capacity = 10;
        private const int DataStackCapacity = 15;
        private bool aboutToSubmit = false; 
        private Stack<int> DataStack = new Stack<int>(DataStackCapacity);

        private int currentNumber = 0;
        private Operation currentOperation = Operation.EMPTY;

        private enum Operation
        {
            EMPTY = -1,
            PLUS,
            MINUS,
            MULTIPLY,
            DIVISION,
            MOD
        };
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            foreach(var item in this.Controls)
            {
                if(item is Button)
                {
                    if (Char.IsDigit(((Button)item).Text[0]))
                    {
                        ((Button)item).Click += Btn_Click;
                    }
                }
            }
        }
        //=========
        private void Btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") EmptyInput = true;
            if (((Button)sender).Text == "0")
            {
                if (EmptyInput)
                {
                    textBox1.Clear();
                }
                if (textBox1.Text.Length < TB_max_capacity)
                {
                    textBox1.Text += ((Button)sender).Text;
                }
            }
            else
            {
                if (EmptyInput)
                {
                    textBox1.Clear();
                    EmptyInput = false;
                }
                if (textBox1.Text.Length < TB_max_capacity)
                {
                    textBox1.Text += ((Button)sender).Text;
                }
            }
            try
            {
                long check = Convert.ToInt64(textBox1.Text);
                if (check >= int.MaxValue || check <= int.MinValue) throw new Exception("Overflow");
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message, "Eror occured.");
                textBox1.Clear();
                textBox1.Text = "0";
                EmptyInput = true;
                currentNumber = 0;
                currentOperation = Operation.EMPTY;
                operation_label.Text = "";
            }
        }

        //=========

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
            EmptyInput = true;
            currentNumber = 0;
            currentOperation = Operation.EMPTY;
            operation_label.Text = "";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (EmptyInput)
            {
                textBox1.Clear();
            }
            if (textBox1.Text.Length < TB_max_capacity)
            {
                textBox1.Text += "0";
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if(EmptyInput)
            {
                textBox1.Clear();
                EmptyInput = false;
            }
            if(textBox1.Text.Length<TB_max_capacity)
            {
                textBox1.Text += "1";
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (EmptyInput)
            {
                textBox1.Clear();
                EmptyInput = false;
            }
            if (textBox1.Text.Length < TB_max_capacity)
            {
                textBox1.Text += "2";
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (EmptyInput)
            {
                textBox1.Clear();
                EmptyInput = false;
            }
            if (textBox1.Text.Length < TB_max_capacity)
            {
                textBox1.Text += "3";
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (EmptyInput)
            {
                textBox1.Clear();
                EmptyInput = false;
            }
            if (textBox1.Text.Length < TB_max_capacity)
            {
                textBox1.Text += "4";
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (EmptyInput)
            {
                textBox1.Clear();
                EmptyInput = false;
            }
            if (textBox1.Text.Length < TB_max_capacity)
            {
                textBox1.Text += "5";
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (EmptyInput)
            {
                textBox1.Clear();
                EmptyInput = false;
            }
            if (textBox1.Text.Length < TB_max_capacity)
            {
                textBox1.Text += "6";
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (EmptyInput)
            {
                textBox1.Clear();
                EmptyInput = false;
            }
            if (textBox1.Text.Length < TB_max_capacity)
            {
                textBox1.Text += "7";
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (EmptyInput)
            {
                textBox1.Clear();
                EmptyInput = false;
            }
            if (textBox1.Text.Length < TB_max_capacity)
            {
                textBox1.Text += "8";
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (EmptyInput)
            {
                textBox1.Clear();
                EmptyInput = false;
            }
            if (textBox1.Text.Length < TB_max_capacity)
            {
                textBox1.Text += "9";
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            operation_label.Text = "+";
            if (currentNumber == 0)
                currentNumber = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            textBox1.Text = "0";
            EmptyInput = true;
            currentOperation = Operation.PLUS;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            operation_label.Text = "-";
            if (currentNumber == 0)
                currentNumber = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            textBox1.Text = "0";
            EmptyInput = true;
            currentOperation = Operation.MINUS;
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            operation_label.Text = "x";
            if (currentNumber == 0)
                currentNumber = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            textBox1.Text = "0";
            EmptyInput = true;
            currentOperation = Operation.MULTIPLY;
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            operation_label.Text = "/";
            if (currentNumber == 0)
                currentNumber = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            textBox1.Text = "0";
            EmptyInput = true;
            currentOperation = Operation.DIVISION;
        }

        private void button_saveResult_Click(object sender, EventArgs e)
        {
            DataStack.Push(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
        }

        private void button_getRes_Click(object sender, EventArgs e)
        {
            textBox1.Text = DataStack.Pop().ToString();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            operation_label.Text = "";
            long result = 0;
            try
            {
                switch (currentOperation)
                {
                    case Operation.PLUS:
                        result = (long)currentNumber + Convert.ToInt32(textBox1.Text);
                        break;
                    case Operation.MINUS:
                        result = (long)currentNumber - Convert.ToInt32(textBox1.Text);
                        break;
                    case Operation.MULTIPLY:
                        result = (long)currentNumber * Convert.ToInt32(textBox1.Text);
                        break;
                    case Operation.DIVISION:
                        if (Convert.ToInt32(textBox1.Text) == 0) { throw new Exception("Zero division is not allowed"); }
                        result = (long)currentNumber / Convert.ToInt32(textBox1.Text);
                        break;
                    case Operation.MOD:
                        result = (long)currentNumber % Convert.ToInt32(textBox1.Text);
                        break;
                    default: break;
                }
                if (result >= int.MaxValue || result <= int.MinValue) throw new Exception("Overflow");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Eror occured.");
                textBox1.Clear();
                textBox1.Text = "0";
                EmptyInput = true;
                currentNumber = 0;
                currentOperation = Operation.EMPTY;
                operation_label.Text = "";
                return;
            }
            currentOperation = Operation.EMPTY;
            textBox1.Text = result.ToString();
            currentNumber = 0;
            aboutToSubmit = false;
        }

        private void button_mod_Click(object sender, EventArgs e)
        {
            operation_label.Text = "mod";
            if (currentNumber == 0)
                currentNumber = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            textBox1.Text = "0";
            EmptyInput = true;
            currentOperation = Operation.MOD;
        }
    }
}
