using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sayi1 = 0;
        double sayi2 = 0;
        int b = 0;
        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button0.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button15.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            uzunluk = textBox1.TextLength;
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text + button11.Text;
            b = 4;


        }

        private void button16_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(textBox1.Text.Substring(uzunluk+1));
            if (b == 4)
            {
                textBox1.Text= Convert.ToString(sayi1/sayi2);
            }
            else if (b == 3)
            {
                textBox1.Text = Convert.ToString(sayi1 * sayi2);
            }
            else if (b == 2) 
            {
                textBox1.Text = Convert.ToString(sayi1 - sayi2);
            }
            else if(b == 1)
            {
                textBox1.Text = Convert.ToString(sayi1 + sayi2);
            }
        }
        int uzunluk = 0;
        private void button12_Click(object sender, EventArgs e)
        {
            uzunluk = textBox1.TextLength;
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text + button12.Text;
            b = 3;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            uzunluk = textBox1.TextLength;
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text + button13.Text;

            b = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            uzunluk = textBox1.TextLength;
            sayi1 = Convert.ToDouble(textBox1.Text);
           
             b = 1;
        }
    }
}
