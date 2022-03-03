using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_num_dot(object sender, EventArgs e)
        {
            if ((displaybox.Text == "0") || (enter_value))
                displaybox.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!displaybox.Text.Contains("."))
                    displaybox.Text = displaybox.Text + num.Text;
            }
            else
                displaybox.Text = displaybox.Text + num.Text;
        }

        private void clear_entry_Click(object sender, EventArgs e)
        {
            displaybox.Text = "0";
            lblShowOperation.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            displaybox.Text = "0";
            lblShowOperation.Text = "";
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            if (displaybox.Text.Length > 0)
            {
                displaybox.Text = displaybox.Text.Remove(displaybox.Text.Length -1, 1);
            }
            if (displaybox.Text == "")
            {
                displaybox.Text = "0";
            }
        }
        private void Arithmetic_exp_mod(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (results != 0)
            {
                equal_sym.PerformClick();
                operation = num.Text;
                displaybox.Text = "";
                lblShowOperation.Text = System.Convert.ToString(results) + " " + operation;
            }
            else
            {
                operation = num.Text;
                results = Double.Parse(displaybox.Text);
                displaybox.Text = "";
                lblShowOperation.Text = System.Convert.ToString(results) + " " + operation;
            }
        }

        private void equal_sym_Click(object sender, EventArgs e)
        {
            lblShowOperation.Text = "";
            switch (operation)
            {
                case "+":
                    displaybox.Text = (results + Double.Parse(displaybox.Text)).ToString();
                    break;
                case "-":
                    displaybox.Text = (results - Double.Parse(displaybox.Text)).ToString();
                    break;
                case "*":
                    displaybox.Text = (results * Double.Parse(displaybox.Text)).ToString();
                    break;
                case "/":
                    displaybox.Text = (results / Double.Parse(displaybox.Text)).ToString();
                    break;
                case "Mod":
                    displaybox.Text = (results % Double.Parse(displaybox.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(displaybox.Text);
                    double j;
                    j = (results);
                    displaybox.Text = Math.Exp(i * Math.Log(j * 10)).ToString();
                    break;
            }
            results = Double.Parse(displaybox.Text);
            lblShowOperation.Text = "";
        }
    }
}
