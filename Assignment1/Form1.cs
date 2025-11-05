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
    public partial class Form1 : Form
    {
        String input = "";
        String studentName = "";
        String studentEmail = "";
        String studentID = "";
        String studentPhoneNumber = "";
        String courseNumber = "";
        String profName = "";
        String courseName = "";
        Boolean fall = false;
        Boolean winter = false;
        Boolean summer = false;
        String year = "";
        String openLearnin = "";
        Record record = new Record();

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Record record)
        {
            InitializeComponent();
            this.record = record;
            this.input = record.getAppeal();
            this.studentName = record.getStudentName();
            this.studentID = record.getStudentId();
            this.studentEmail = record.getStudentEmail();
            this.studentPhoneNumber = record.getStudentPhoneNum();
            this.courseNumber = record.getCourseAcronNum();
            this.profName = record.getInstructorName();
            this.courseName = record.getCourseTitle();
            this.fall = record.getRadButton1();
            this.summer = record.getRadButton2();
            this.winter = record.getRadButton3();
            this.year = record.getYear();
            this.openLearnin = record.getOpenLearningStart();

            richTextBox1.Text = input;
            textBox18.Text = studentName;
            textBox17.Text = studentID;
            textBox12.Text = courseNumber;
            textBox13.Text = courseName;
            textBox16.Text = studentEmail;
            textBox14.Text = studentPhoneNumber;
            textBox11.Text = profName;
            textBox13.Text = courseName;
            radioButton1.Checked = fall;
            radioButton2.Checked = winter;
            radioButton3.Checked = summer;
            textBox15.Text = year;
            textBox10.Text = openLearnin;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (record.submitted)
            {
                SetReadOnly();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            input = richTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            record.setAppeal(input);
            record.setStudentName(studentName);
            record.setCourseAcronNum(courseNumber);
            record.setStudentId(studentID);
            record.setStudentPhoneNum(studentPhoneNumber);
            record.setInstructorName(profName);
            record.setRadButton1(fall);
            record.setRadButton2(winter);
            record.setRadButton3(summer);
            record.setYear(year);
            record.setOpenLearningStart(openLearnin);
            record.setCourseTitle(courseName);
            record.setStudentEmail(studentEmail);
            record.setStageNum(1);
            record.submitted = true;
            this.Close();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            studentName = textBox18.Text;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            studentEmail = textBox16.Text;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            studentID = textBox17.Text;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            studentPhoneNumber = textBox14.Text;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            courseNumber = textBox12.Text;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            profName = textBox11.Text;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            courseName = textBox13.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                fall = true;
            }
            else
            {
                fall = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                winter = true;
            }
            else
            {
                winter = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                summer = true;
            }
            else
            {
                summer = false;
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            year = textBox15.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            openLearnin = textBox10.Text;
        }

        private void SetReadOnly()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox tb)
                {
                    tb.ReadOnly = true;
                }
                else if(control is RadioButton radioButton)
                {
                    radioButton.Enabled = false;
                }
                else if(control is RichTextBox richtxt)
                {
                    richtxt.ReadOnly = true;
                }
            }
        }
    }
}
