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
        public Form3()
        {
            InitializeComponent();
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
            StreamWriter write = new StreamWriter("C:\\Users\\T00692297\\OneDrive - Thompson Rivers University\\Output\\Form3.txt");
            write.WriteLine(input);
            write.Close();
            this.Close();
        }
       
        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
