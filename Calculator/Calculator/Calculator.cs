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

    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        void FirstNumber;
        private void n0_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "0";
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "1";
            }

            else
            {
                output.Text = output.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "2";
            }

            else
            {
                output.Text = output.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "3";
            }

            else
            {
                output.Text = output.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "4";
            }

            else
            {
                output.Text = output.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "5";
            }

            else
            {
                output.Text = output.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "6";
            }

            else
            {
                output.Text = output.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "7";
            }

            else
            {
                output.Text = output.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "8";
            }

            else
            {
                output.Text = output.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "9";
            }

            else
            {
                output.Text = output.Text + "9";
            }
        }



        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Calculator_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        Point lastPoint;

        private void Calculator_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void breset_Click(object sender, EventArgs e)
        {

        }

        private void bdot_Click(object sender, EventArgs e)
        {

        }

        private void badd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(output.Text);
            output.Text = "0";
            Operation = "+";
        }

        private void bsub_Click(object sender, EventArgs e)
        {

        }

        private void bmult_Click(object sender, EventArgs e)
        {

        }

        private void bdiv_Click(object sender, EventArgs e)
        {

        }

        private void bequal_Click(object sender, EventArgs e)
        {

        }
    }
}
