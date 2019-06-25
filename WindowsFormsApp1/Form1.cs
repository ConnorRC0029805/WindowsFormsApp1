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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        // calculates 2 resistors in series
            try
            {
                double R1, R2, resistance;
                R1 = Convert.ToDouble(textBox1.Text);
                R2 = Convert.ToDouble(textBox2.Text);
                resistance = R1 + R2;
                label7.Text = "resistance = " + resistance;
            }
            catch
            {
                MessageBox.Show("Type in correct values");
            }


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        // calculates 3 resistors in series
            try
            {
                double R1, R2, R3, resistance;
                R1 = Convert.ToDouble(textBox5.Text);
                R2 = Convert.ToDouble(textBox6.Text);
                R3 = Convert.ToDouble(textBox7.Text);
                resistance = R1 + R2 + R3;
                label11.Text = "resistance = " + resistance;
            }
            catch
            {
                MessageBox.Show("Type in correct values");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
                    // calculates 4 resistors in series
            {
                double R1, R2, R3, R4, resistance;
                R1 = Convert.ToDouble(textBox8.Text);
                R2 = Convert.ToDouble(textBox9.Text);
                R3 = Convert.ToDouble(textBox10.Text);
                R4 = Convert.ToDouble(textBox11.Text);
                resistance = R1 + R2 + R3 + R4;
                label16.Text = "resistance = " + resistance;
            }
            catch
            {
                MessageBox.Show("Type in correct values");
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
                    // calculates 5 resistors in series
            {
                double R1, R2, R3, R4, R5, resistance;
                R1 = Convert.ToDouble(textBox12.Text);
                R2 = Convert.ToDouble(textBox13.Text);
                R3 = Convert.ToDouble(textBox14.Text);
                R4 = Convert.ToDouble(textBox15.Text);
                R5 = Convert.ToDouble(textBox16.Text);
                resistance = R1 + R2 + R3 + R4 + R5;
                label22.Text = "resistance = " + resistance;
            }
            catch
            {
                MessageBox.Show("Type in correct values");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            //calculates 2 resistors in parallel
            {
                double R1, R2, resistance;
                R1 = Convert.ToDouble(textBox3.Text);
                R2 = Convert.ToDouble(textBox3.Text);
                resistance = 1 / (1 / R1) + (1 / R2);
                label23.Text = "resistance = " + resistance;
            }
            catch
            {
                MessageBox.Show("Type in correct values");
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            try
             //calculates 3 resistors in parallel
            {
                double R1, R2, R3, resistance;
                R1 = Convert.ToDouble(textBox17.Text);
                R2 = Convert.ToDouble(textBox18.Text);
                R3 = Convert.ToDouble(textBox19.Text);
                resistance = 1 / (1 / R1) + (1 / R2) + (1 / R3);
                label27.Text = "resistance = " + resistance;
            }
            catch
            {
                MessageBox.Show("Type in correct values");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
             //calculates 4 resistors in parallel
            {
                double R1, R2, R3, R4, resistance;
                R1 = Convert.ToDouble(textBox20.Text);
                R2 = Convert.ToDouble(textBox21.Text);
                R3 = Convert.ToDouble(textBox22.Text);
                R4 = Convert.ToDouble(textBox23.Text);
                resistance = 1 / (1 / R1) + (1 / R2) + (1 / R3) + (1/R4);
                label32.Text = "resistance = " + resistance;
            }
            catch
            {
                MessageBox.Show("Type in correct values");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
             //calculates 5 resistors in parallel
            {
                double R1, R2, R3, R4, R5, resistance;
                R1 = Convert.ToDouble(textBox24.Text);
                R2 = Convert.ToDouble(textBox25.Text);
                R3 = Convert.ToDouble(textBox26.Text);
                R4 = Convert.ToDouble(textBox27.Text);
                R5 = Convert.ToDouble(textBox28.Text);
                resistance = 1 / (1 / R1) + (1 / R2) + (1 / R3) + (1 / R4) + (1 / R5);
                label38.Text = "resistance = " + resistance;
            }
            catch
            {
                MessageBox.Show("Type in correct values");
            }
        }
    }
}
            
        
