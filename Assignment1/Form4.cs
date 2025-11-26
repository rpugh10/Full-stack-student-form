using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Assignment1
{
    public partial class Form4 : Form
    {
        String input = "";
        String name = "";
        String wordSearch = "";
        Record record = new Record();
        public Form4()
        {
            InitializeComponent();
        }

        //When the form is repopened, getting all the informaion from the record class
        public Form4(Record record)
        {
            InitializeComponent();
            this.record = record;
            this.name = record.getChairName();
            this.input = record.getChairInput();
            richTextBox1.Text = record.getChairInput();
            textBox1.Text = record.getChairName();
        }

        //Setting user input to record class, setting the stage number and saving to a file 
        private void button1_Click(object sender, EventArgs e)
        {
            record.setChairName(name);
            record.setChairInput(input);
            record.setStageNum(4);
            saveToFile();
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

        //Checking the stage number to see if this form needs to be set to read only
        private void Form4_Load(object sender, EventArgs e)
        {
            if (record.getStageNum() >= 4)
            {
                SetReadOnly(this);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Setting the controls in this form to read only, except the search textbox
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
                else if (control is TextBox textbox && textbox.Name != textBox2.Name)
                {
                        textbox.ReadOnly = true;
                }
                

            }
        }

        //Adding python
        private void button2_Click(object sender, EventArgs e)
        {
            //Python executable and script path will be different on different computers
            string pythonPath = @"C:\Program Files\Python37\python.exe";
            string scriptPath = @"C:\Users\T00692297\OneDrive - Thompson Rivers University\Comp2210C#\Assignment1\PythonSearchFuntion.py";
            var startInfo = new ProcessStartInfo();
            startInfo.FileName = pythonPath;
            var script = scriptPath;
            startInfo.Arguments = $"\"{script}\" \"{wordSearch}\" \"{record.getFilePath()}\"";
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;

            var error = "";
            var output = "";

            using (Process process = Process.Start(startInfo))
            {
                error = process.StandardError.ReadToEnd();
                output = process.StandardOutput.ReadToEnd();
            }

            Console.WriteLine("Errors");
            Console.WriteLine(error);
            Console.WriteLine();
            Console.WriteLine("Output");
            Console.WriteLine(output);
            Console.WriteLine();

        }

        //Saving the information on this form to a file
        private void saveToFile()
        {
            String filePath = "C:\\Users\\T00692297\\OneDrive - Thompson Rivers University\\Output\\Form4.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Name of individual " + "\n" + name);
                writer.WriteLine("Describe the outcome of your communtication with this individual and/or attached copies of related communications " + "\n" + input);
                writer.Close();
            }
        }

        //Saving the text the user enters to the wordSearch variable 
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            wordSearch = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}