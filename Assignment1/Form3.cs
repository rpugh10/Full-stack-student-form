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
            record.setStageNum(3);
            saveToFile();
            this.Close();
        }
       
        private void Form3_Load(object sender, EventArgs e)
        {
            if(record.getStageNum() >= 3)
            {
                SetReadOnly(this);
            }
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

        private void saveToFile()
        {
            String filePath = "C:\\Users\\T00692297\\OneDrive - Thompson Rivers University\\Output\\Form3.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Describe the outcome of your communtication with this individual and/or attached copies of related communications " + "\n" + input);
                writer.Close();
            }
        }
    }
}
