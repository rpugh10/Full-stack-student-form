using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        String wordSearch = "";
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
                else if (control is TextBox textbox && textbox.Name != textBox2.Name)
                {
                    textbox.ReadOnly = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pythonPath = @"C:\Program Files\Python37\python.exe";
            string scriptPath = @"C:\Users\T00692297\OneDrive - Thompson Rivers University\Comp2210C#\PythonSearchFuntion.py";
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            wordSearch = textBox2.Text;
        }
    }

}