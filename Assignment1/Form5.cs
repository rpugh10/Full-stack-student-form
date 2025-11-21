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
    public partial class Form5 : Form
    {
        String description = "";
        String name = "";
        Record record = new Record();
        public Form5()
        {
            InitializeComponent();
        }

        public Form5(String description, String name)
        {
            InitializeComponent();
            textBox1.Text = name;
            richTextBox1.Text = description;
            this.name = name;
            this.description = description;
        }

        public Form5(Record record)
        {
            InitializeComponent();
            this.record = record;
            this.name = record.getName();
            this.description = record.getDescription();
            richTextBox1.Text = record.getDescription();
            textBox1.Text = record.getName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            record.setName(name);
            record.setDescription(description);
            record.setStageNum(5);
            saveToFile();
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            description = richTextBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (record.getStageNum() >= 5)
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void saveToFile()
        {
            String filePath = "C:\\Users\\T00692297\\OneDrive - Thompson Rivers University\\Output\\Form5.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Name of individual " + "\n" + name);
                writer.WriteLine("Describe the outcome of your communtication with this individual and/or attached copies of related communications " + " \n" + description);
                writer.Close();
            }
        }
    }

}