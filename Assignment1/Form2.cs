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
        String date = "";
        Record record = new Record();
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(String input)
        {
            InitializeComponent();
            richTextBox1.Text = input;
        }

        public Form2(Record record)
        {
            InitializeComponent();
            this.record = record;
            this.input = record.getResolution();
            this.box1 = record.getCheckBox1();
            this.box2 = record.getCheckBox2();
            this.box3 = record.getCheckBox3();
            this.box4 = record.getCheckBox4();
            this.sign = record.getSignature();
            this.date = record.getDate();
            richTextBox1.Text = record.getResolution();
            checkBox1.Checked = record.getCheckBox1();
            checkBox2.Checked = record.getCheckBox2();
            checkBox3.Checked = record.getCheckBox3();
            checkBox4.Checked = record.getCheckBox4();
            textBox1.Text = record.getSignature();
            
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
            if(record.getStageNum() >= 2)
            {
                SetReadOnly(this);
            }
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
            record.setResolution(input);
            record.setCheckBox1(box1);
            record.setCheckBox2(box2);
            record.setCheckBox3(box3);    
            record.setCheckBox4(box4);
            record.setSignature(sign);
            record.setDate(date);
            record.setStageNum(2);
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void SetReadOnly(Control parent)
        {
            foreach (Control control in parent.Controls)
            {

                if (control is CheckBox check)
                {
                    check.Enabled = false;
                }
                else if (control is RichTextBox richtxt)
                {
                    richtxt.ReadOnly = true;
                }
                else if (control is TextBox textbox)
                {
                    textbox.ReadOnly = true;
                }
            }
        }
    }
}
