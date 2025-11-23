using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class AdimForm : Form
    {
        Record record = new Record();
        Form1 form1 = new Form1();
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        Form4 form4 = new Form4();
        Form5 form5 = new Form5();
        String filePath = "";
        public AdimForm()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(record);
            form.ShowDialog();
            AdimForm_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(record);
            form.ShowDialog();
            AdimForm_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(record);
            form.ShowDialog();
            AdimForm_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(record);
            form.ShowDialog();
            AdimForm_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
           Form5 form = new Form5(record);
            form.ShowDialog();
            AdimForm_Load(sender, e);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void AdimForm_Load(object sender, EventArgs e)
        {
            int stageNum = record.getStageNum();
            if(stageNum == 0)
            {
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
            else if(stageNum == 1)
            {
                button1.Enabled =true;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
            else if (stageNum == 2)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = false;
                button5.Enabled = false;
            }
            else if(stageNum == 3)
            {
                button1.Enabled =true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String filePath = "C:\\Users\\T00692297\\OneDrive - Thompson Rivers University\\Output";
            openFileExplorer(filePath);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            String filePath = "C:\\Users\\T00692297\\OneDrive - Thompson Rivers University\\Output\\Form6.txt";
            SaveFileDialog saveToFile = new SaveFileDialog();
            saveToFile.Filter = "txt files (*.txt)| *.txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                record.createFile(filePath);
                record.setFilePath(filePath);
            }
        }

        private static void openFileExplorer(String filePath)
        {
            Process.Start(filePath);
        }
    }
}
