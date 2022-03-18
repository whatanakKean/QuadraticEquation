using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadraticEquationWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, delta;
            double result1, result2;
            

            if(!int.TryParse(inputA.Text, out a)) {
                MessageBox.Show("Wrong first input!", "Input A");
                inputA.Clear();
                inputA.Focus();
                return;
            }
            a = int.Parse(inputA.Text);
            
            if (!int.TryParse(inputB.Text, out b))
            {
                MessageBox.Show("Wrong first input!", "Input B");
                inputB.Clear();
                inputB.Focus();
                return;
            }
            b = int.Parse(inputB.Text);

            if (!int.TryParse(inputC.Text, out c))
            {
                MessageBox.Show("Wrong first input!", "Input C");
                inputC.Clear();
                inputC.Focus();
                return;
            }
            c = int.Parse(inputC.Text);

            delta = (b * b) - (4 * a * c);

            if (delta > 0)
            {
                result1 = (double)((-b) + Math.Sqrt(delta)) / (2 * a);
                result2 = (double)((-b) - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Result = " + result1 + ", " + result2);

                this.result1.Text = result1.ToString();
                this.result2.Text = result2.ToString();
            }
            else if (delta < 0)
            {
                double realNumberPart = (double)(-b) / (2 * a);
                double imaginaryPart = (double)Math.Sqrt(-1 * delta) / (2 * a);

                this.result1.Text = realNumberPart + " + " + imaginaryPart + "i ";
                this.result2.Text = realNumberPart + " - " + imaginaryPart + "i ";
            }
            else if (delta == 0)
            {
                result1 = (double)(-1 * b) / (2 * a);
                Console.WriteLine("Result = " + result1);

                this.result1.Text = result1.ToString();
            }

            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputA_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            inputA.Clear();
            inputB.Clear();
            inputC.Clear();
            result1.Clear();
            result2.Clear();
        }

        private void inputC_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
