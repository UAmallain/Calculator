using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc2._0
{
    public partial class Form1 : Form
    {
        float runningTotal = 0.0f;
        bool operatorPressed = false;
        bool operatorSwitch = false;
        string currentOperator = "";
        public Form1()
        {
            InitializeComponent();
        }

    
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operatorPressed)
            {
                textBox1.Text = "0";
                operatorPressed = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operatorPressed)
            {
                textBox1.Text = "0";
                operatorPressed = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operatorPressed)
            {
                textBox1.Text = "0";
                operatorPressed = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operatorPressed)
            {
                textBox1.Text = "0";
                operatorPressed = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operatorPressed)
            {
                textBox1.Text = "0";
                operatorPressed = false;    
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operatorPressed)
            {
                textBox1.Text = "0";
                operatorPressed = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "6";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (operatorPressed)
            {
                textBox1.Text = "0";
                operatorPressed = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operatorPressed)
            {
                textBox1.Text = "0";
                operatorPressed = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operatorPressed)
            {
                textBox1.Text = "0";
                operatorPressed = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (operatorPressed)
            {
                textBox1.Text = "0";
                operatorPressed = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (currentOperator != "+") 
            { 
                operatorSwitch = true; 
            }
            CalcResult(runningTotal, float.Parse(textBox1.Text), "+");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (currentOperator != "-")
            {
                operatorSwitch = true;
            }
            CalcResult(runningTotal, float.Parse(textBox1.Text), "-");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (currentOperator != "*")
            {
                operatorSwitch = true;
            }   
            CalcResult(runningTotal, float.Parse(textBox1.Text), "*");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (currentOperator != "/")
            {
                operatorSwitch = true;
            }
            CalcResult(runningTotal, float.Parse(textBox1.Text), "/");
        }

        private float CalcResult(float valueOne, float valueTwo, string operatorFunction)
        {
            //string calculationOperator = operatorFunction;
            

            if (currentOperator!="" && operatorFunction != currentOperator && !operatorSwitch)
            {
                operatorFunction = currentOperator;
                operatorSwitch = true;
            }
            
            float result = 0;
            switch(operatorFunction)
            {
                case "+":
                    {
                        operatorPressed = true;
                        currentOperator = "+";
                        if (runningTotal > 0)
                        {
                            listBox1.Items.Add($"{runningTotal}+{float.Parse(textBox1.Text)} = {runningTotal + float.Parse(textBox1.Text)}");
                            runningTotal = runningTotal + float.Parse(textBox1.Text);
                            textBox1.Text = runningTotal.ToString();
                        }
                        else
                        {
                            runningTotal = float.Parse(textBox1.Text);
                            textBox1.Text = "0";
                        }
                        break;
                    }
                case "-":
                    {
                        operatorPressed = true;
                        currentOperator = "-";
                        if (runningTotal > 0)
                        {
                            listBox1.Items.Add($"{runningTotal}-{float.Parse(textBox1.Text)} = {runningTotal - float.Parse(textBox1.Text)}");
                            runningTotal = runningTotal - float.Parse(textBox1.Text);
                            textBox1.Text = runningTotal.ToString();
                        }
                        else
                        {
                            runningTotal = float.Parse(textBox1.Text);
                            textBox1.Text = "0";
                        }
                        break;
                    }
                case "*":
                    {
                        operatorPressed = true;
                        currentOperator = "*";
                        if (runningTotal > 0)
                        {
                            listBox1.Items.Add($"{runningTotal}*{float.Parse(textBox1.Text)} = {runningTotal * float.Parse(textBox1.Text)}");
                            runningTotal = runningTotal * float.Parse(textBox1.Text);
                            textBox1.Text = runningTotal.ToString();
                        }
                        else
                        {
                            runningTotal = float.Parse(textBox1.Text);
                            textBox1.Text = "0";
                        }
                        break;
                    }
                case "/":
                    {
                        operatorPressed = true;
                        currentOperator = "/";
                        if (runningTotal > 0)
                        {
                            listBox1.Items.Add($"{runningTotal}/{float.Parse(textBox1.Text)} = {runningTotal / float.Parse(textBox1.Text)}");
                            runningTotal = runningTotal / float.Parse(textBox1.Text);
                            textBox1.Text = runningTotal.ToString();
                        }
                        else
                        {
                            runningTotal = float.Parse(textBox1.Text);
                            textBox1.Text = "0";
                        }
                        break;
                    }
            }
            return result;
        }
    }
}
