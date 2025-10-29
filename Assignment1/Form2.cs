using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form2 : Form
    {
        String input = "";
        Boolean box1 = false;
        Boolean box2 = false;
        Boolean box3 = false;
        Boolean box4 = false;
        String sign = "";
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(String input)
        {
            InitializeComponent();
            richTextBox1.Text = input;

            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                box1 = true;
            }
            else
            {
                box1 = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            input = richTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\T00692297\\OneDrive - Thompson Rivers University\\Output\\Form2.txt");
            writer.WriteLine(input);
            writer.WriteLine(box1);
            writer.WriteLine(box2);
            writer.WriteLine(box3);
            writer.WriteLine(box4);
            writer.WriteLine(sign);
            writer.Close();
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                box2 = true;
            }
            else
            {
                box2 = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                box3 = true;
            }
            else
            {
                box3 = false; 
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked)
            {
                box4 = true;
            }
            else
            {
                box4 = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sign = textBox1.Text;
        }
    }
}
