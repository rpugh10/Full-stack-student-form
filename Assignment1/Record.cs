using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Record
    {
        private int stageNum = 0;
        private String name = "";
        private String description = "";

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

        public void setSageNum(int sageNum)
        {
            this.stageNum = sageNum;
        }
    }
}