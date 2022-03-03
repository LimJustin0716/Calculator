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

        private void sin_click(object sender, EventArgs e)
        {
            double sineTrigo = Double.Parse(displaybox.Text);
            lblShowOperation.Text = System.Convert.ToString("sin" + "(" + (displaybox.Text) + ")");
            sineTrigo = Math.Sin(sineTrigo * Math.PI / 180);
            displaybox.Text = System.Convert.ToString(sineTrigo);
        }

        private void cos_click(object sender, EventArgs e)
        {
            double cosineTrigo = Double.Parse(displaybox.Text);
            lblShowOperation.Text = System.Convert.ToString("cos" + "(" + (displaybox.Text) + ")");
            cosineTrigo = Math.Cos(cosineTrigo * Math.PI / 180);
            displaybox.Text = System.Convert.ToString(cosineTrigo);
        }

        private void tan_click(object sender, EventArgs e)
        {
            double tanTrigo = Double.Parse(displaybox.Text);
            lblShowOperation.Text = System.Convert.ToString("tan" + "(" + (displaybox.Text) + ")");
            tanTrigo = Math.Tan(tanTrigo * Math.PI / 180);
            displaybox.Text = System.Convert.ToString(tanTrigo);
        }

        private void sinh_click(object sender, EventArgs e)
        {
            double sinhTrigo = Double.Parse(displaybox.Text);
            lblShowOperation.Text = System.Convert.ToString("sinh" + "(" + (displaybox.Text) + ")");
            sinhTrigo = Math.Sinh(sinhTrigo * Math.PI / 180);
            displaybox.Text = System.Convert.ToString(sinhTrigo);
        }

        private void cosh_click(object sender, EventArgs e)
        {
            double coshTrigo = Double.Parse(displaybox.Text);
            lblShowOperation.Text = System.Convert.ToString("cosh" + "(" + (displaybox.Text) + ")");
            coshTrigo = Math.Tan(coshTrigo * Math.PI / 180);
            displaybox.Text = System.Convert.ToString(coshTrigo);
        }

        private void tanh_click(object sender, EventArgs e)
        {
            double tanhTrigo = Double.Parse(displaybox.Text);
            lblShowOperation.Text = System.Convert.ToString("tanh" + "(" + (displaybox.Text) + ")");
            tanhTrigo = Math.Tan(tanhTrigo * Math.PI / 180);
            displaybox.Text = System.Convert.ToString(tanhTrigo);
        }
    }
}
