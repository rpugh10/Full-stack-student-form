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
    public partial class Form3 : Form
    {
        String input = "";
        Record record = new Record();
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Record record)
        {
            InitializeComponent();
            this.record = record;
            this.input = record.getInstructorInput();
            richTextBox1.Text = record.getInstructorInput();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            input = richTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            record.setInstructorInput(input);
            record.setSageNum(3);
            this.Close();
        }
       
        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
