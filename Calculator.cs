using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2;

            if (txtCh1.Text == "")
                num1 = 0;
            else
                num1 = double.Parse(txtCh1.Text);

            if (txtCh2.Text == "")
                num2 = 0;
            else
                num2 = double.Parse(txtCh2.Text);

            switch (cmbxAct.SelectedIndex)
            {
                case 0:
                    {
                        txtRez.Text = (num1 + num2).ToString();
                        break;
                    }

                case 1:
                    {
                        txtRez.Text = (num1 - num2).ToString();
                        break;
                    }

                case 2:
                    {
                        txtRez.Text = (num1 * num2).ToString();
                        break;
                    }

                case 3:
                    {
                        txtRez.Text = (num1 / num2).ToString();
                        break;
                    }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            cmbxAct.Items.Add("+");
            cmbxAct.Items.Add("-");
            cmbxAct.Items.Add("*");
            cmbxAct.Items.Add("/");

            cmbxAct.Text = "+";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
