using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Speciality
    {
        public string Name;
        public int Number;

        public Speciality()
        {
            Name = "N/D";
            Number = 0;
        }

        public Speciality(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public override string ToString()
        {
            return "Speciality: " + Name + " Number: " + Number;
        }
    }
}
