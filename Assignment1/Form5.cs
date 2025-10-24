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
        String input = "";
        String name = "";
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sWrite = new StreamWriter("C:\\Users\\T00692297\\OneDrive - Thompson Rivers University\\Output\\Form5.txt");
            sWrite.WriteLine(name);
            sWrite.WriteLine(input);
            sWrite.Close();
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
    }
}
