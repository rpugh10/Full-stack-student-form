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
    public partial class Form4 : Form
    {
        String input = "";
        String name = "";
        Record record = new Record();
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(Record record)
        {
            InitializeComponent();
            this.record = record;
            this.name = record.getChairName();
            this.input = record.getChairInput();
            richTextBox1.Text = record.getChairInput();
            textBox1.Text = record.getChairName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            record.setChairName(name);
            record.setChairInput(input);
            record.setStageNum(4);
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            input = richTextBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if(record.getStageNum() >= 4)
            {
                SetReadOnly(this);
            }
        }

        private void label3_Click(object sender, EventArgs e)
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
                else if (control.HasChildren)
                {
                    SetReadOnly(control);
                }
            }
        }
    }
}
