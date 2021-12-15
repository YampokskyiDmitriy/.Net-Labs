using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Faculty
    {
        public string Name;
        public string University;
        public Faculty()
        {
            Name = "N/D";
            University = "N/D";
        }

        public Faculty(string name, string university)
        {
            Name = name;
            University = university;
        }
        public override string ToString()
        {
            return "Faculty: " + Name + " University: " + University;
        }
    }
}
