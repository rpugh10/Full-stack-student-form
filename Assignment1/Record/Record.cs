using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //All the variables for the forms 
    public class Record
    {
        private int stageNum = 0;
        private String name = "";
        private String description = "";

        private String chairName = "";
        private String chairInput = "";

        private String instructorInput = "";

        private String resolutionInput = "";
        private Boolean checkBox1 = false;
        private Boolean checkBox2 = false;
        private Boolean checkBox3 = false;
        private Boolean checkBox4 = false;
        private String signature = "";
        private String date = "";

        private String appeal = "";
        private String studentName = "";
        private String studentID = "";
        private String studentEmail = "";
        private String studentPhoneNum = "";
        private String courseAcronNum = "";
        private String instructorName = "";
        private String courseTitle = "";
        private Boolean radButton1 = false;
        private Boolean radButton2 = false;
        private Boolean radButton3 = false;
        private String year = "";
        private String openLearningStart = "";

        public Boolean submitted = false;

        private String filePath = "";

        //Getters and setters 
        public Record(int stageNum)
        {
            this.stageNum = stageNum;
        }

        public Record()
        {

        }

        public Record(String name, String description)
        {
            this.name = name;
            this.description = description;
        }

        public void setFilePath(String filePath)
        {
            this.filePath = filePath;
        }

        public String getFilePath()
        {
            return filePath;
        }

        //Writing all the forms onto one file. Passsing this file to the search function 
        public void createFile(String filePath)
        {
            StreamWriter writer = new StreamWriter(filePath);
            writer.WriteLine("Form 1");
            writer.WriteLine(studentName);
            writer.WriteLine(studentID);
            writer.WriteLine(studentEmail);
            writer.WriteLine(studentPhoneNum);
            writer.WriteLine(courseAcronNum);
            writer.WriteLine(instructorName);
            writer.WriteLine(courseTitle);
            writer.WriteLine(radButton1);
            writer.WriteLine(radButton2);
            writer.WriteLine(radButton3);
            writer.WriteLine(year);
            writer.WriteLine(openLearningStart);
            writer.WriteLine(appeal);

            writer.WriteLine("Form 2");
            writer.WriteLine(resolutionInput);
            writer.WriteLine(checkBox1);
            writer.WriteLine(checkBox2);
            writer.WriteLine(checkBox3);
            writer.WriteLine(checkBox4);
            writer.WriteLine(signature);
            writer.WriteLine(date);

            writer.WriteLine("Form 3");
            writer.WriteLine(instructorInput);

            writer.WriteLine("Form 4");
            writer.WriteLine(chairName);
            writer.WriteLine(chairInput);

            writer.WriteLine("Form 5");
            writer.WriteLine(name);
            writer.WriteLine(description);

            writer.Close();
        }

        public void setOpenLearningStart(String openLearningStart)
        {
            this.openLearningStart = openLearningStart;
        }

        public String getOpenLearningStart()
        {
            return openLearningStart;
        }

        public void setYear(String year)
        {
            this.year = year;
        }

        public String getYear()
        {
            return year;
        }


        public void setRadButton3(Boolean radButton3)
        {
            this.radButton3 = radButton3;
        }

        public Boolean getRadButton3()
        {
            return radButton3;
        }
        public void setRadButton2(Boolean radButton2)
        {
            this.radButton2 = radButton2;
        }

        public Boolean getRadButton2()
        {
            return radButton2;
        }

        public void setRadButton1(Boolean radButton1)
        {
            this.radButton1 = radButton1;
        }

        public Boolean getRadButton1()
        {
            return radButton1;
        }

        public void setCourseTitle(String courseTitle)
        {
            this.courseTitle = courseTitle;
        }

        public String getCourseTitle()
        {
            return courseTitle;
        }

        public void setInstructorName(String instructorName)
        {
            this.instructorName = instructorName;
        }

        public String getInstructorName()
        {
            return instructorName;
        }

        public void setCourseAcronNum(String courseAcronNum)
        {
            this.courseAcronNum = courseAcronNum;
        }

        public String getCourseAcronNum()
        {
            return courseAcronNum;
        }

        public void setStudentPhoneNum(String studentPhoneNum)
        {
            this.studentPhoneNum = studentPhoneNum;
        }

        public String getStudentPhoneNum()
        {
            return studentPhoneNum;
        }

        public void setStudentEmail(String studentEmail)
        {
            this.studentEmail = studentEmail;
        }

        public String getStudentEmail()
        {
            return studentEmail;
        }

        public void setStudentId(String studentID)
        {
            this.studentID = studentID;
        }

        public String getStudentId()
        {
            return studentID;
        }

        public void setStudentName(String studentName)
        {
            this.studentName = studentName;
        }

        public String getStudentName()
        {
            return studentName;
        }

        public void setAppeal(String appeal)
        {
            this.appeal = appeal;
        }

        public String getAppeal()
        {
            return appeal;
        }

        public String getName()
        {
            return name;
        }

        public String getDescription()
        {
            return description;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setDescription(String description)
        {
            this.description = description;
        }

        public int getStageNum()
        {
            return stageNum;
        }

        public void setStageNum(int sageNum)
        {
            this.stageNum = sageNum;
        }

        public void setChairName(String chairName)
        {
            this.chairName = chairName;
        }

        public String getChairName()
        {
            return chairName;
        }

        public void setChairInput(String chairInput)
        {
            this.chairInput = chairInput;
        }

        public String getChairInput()
        {
            return chairInput;
        }

        public String getInstructorInput()
        {
            return instructorInput;
        }

        public void setInstructorInput(String instructorInput)
        {
            this.instructorInput = instructorInput;
        }

        public void setResolution(String resolution)
        {
            this.resolutionInput = resolution;
        }

        public String getResolution()
        {
            return resolutionInput;
        }

        public Boolean getCheckBox1()
        {
            return checkBox1;
        }

        public Boolean getCheckBox2()
        {
            return checkBox2;
        }

        public Boolean getCheckBox3()
        {
            return checkBox3;
        }

        public Boolean getCheckBox4()
        {
            return checkBox4;
        }

        public void setCheckBox1(Boolean value)
        {
            this.checkBox1 = value;
        }

        public void setCheckBox2(Boolean value)
        {
            this.checkBox2 = value;
        }

        public void setCheckBox3(Boolean value)
        {
            this.checkBox3 = value;
        }

        public void setCheckBox4(Boolean value)
        {
            this.checkBox4 = value;
        }

        public void setSignature(String signature)
        {
            this.signature = signature;
        }

        public String getSignature()
        {
            return signature;
        }

        public void setDate(String date)
        {
            this.date = date;
        }

        public String getDate()
        {
            return date;
        }
    }
}
