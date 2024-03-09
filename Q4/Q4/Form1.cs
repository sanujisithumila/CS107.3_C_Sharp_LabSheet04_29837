﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
    public partial class Form1 : Form
    {
        public int num1;
        public int num2;
        public int answer;
        public string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void DigitClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            txtResult.Text += button.Text;
        }

        private void OperatorClicked(object sender, EventArgs e)
        {
            Button operatorClicked = (Button)sender;

            num1 = Convert.ToInt32(txtResult.Text);

            txtResult.Text = "";

            operation = operatorClicked.Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(txtResult.Text);

            switch (operation)
            {
                case "+":
                    answer = num1 + num2;
                    break;
                case "-":
                    answer = num1 - num2;
                    break;
                case "*":
                    answer = num1 * num2;
                    break;
                case "/":
                    answer = num1 / num2;
                    break;
            }

            txtResult.Text = answer.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            txtResult.Text = "";
            operation = "";
        }
    }
}
