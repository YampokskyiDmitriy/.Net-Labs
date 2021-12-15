using System;
using System.Runtime.Serialization;

namespace Lab8
{
    public class Student
    {
        private string _name;

        [DataMember]
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {

                if (value.Length > 1)
                {
                    _name = value;
                }
                else
                {
                    _name = "N/D";
                    Console.WriteLine("Name did not pass validation!");
                }
            }
        }

        private string _surname;

        [DataMember]
        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {

                if (value.Length > 1)
                {
                    _surname = value;
                }
                else
                {
                    _surname = "N/D";
                    Console.WriteLine("Surname did not pass validation!");
                }
            }
        }

        private string _patronymic;

        [DataMember]
        public string Patronymic
        {
            get
            {
                return _patronymic;
            }

            set
            {

                if (value.Length > 1)
                {
                    _patronymic = value;
                }
                else
                {
                    _patronymic = "N/D";
                    Console.WriteLine("Patronymic did not pass validation!");
                }
            }
        }

        private DateTime _birthday;

        [DataMember]
        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }

            set
            {

                if (value < DateTime.Now)
                {
                    _birthday = value;
                }
                else
                {
                    _birthday = DateTime.UtcNow;
                    Console.WriteLine("Birthday did not pass validation!");
                }
            }
        }

        private DateTime _receiptDate;

        [DataMember]
        public DateTime ReceiptDate
        {
            get
            {
                return _receiptDate;
            }

            set
            {

                if (value < DateTime.Now)
                {
                    _receiptDate = value;
                }
                else
                {
                    _receiptDate = DateTime.UtcNow;
                    Console.WriteLine("Receipt date did not pass validation!");
                }
            }
        }

        private Faculty _faculty;

        [DataMember]
        public Faculty Faculty
        {
            get
            {
                return _faculty;
            }

            set
            {

                if (value.Name.Length > 1)
                {
                    _faculty = value;
                }
                else
                {
                    _faculty = new Faculty();
                    Console.WriteLine("Faculty did not pass validation!");
                }
            }
        }

        private Speciality _speciality;

        [DataMember]
        public Speciality Speciality
        {
            get
            {
                return _speciality;
            }

            set
            {

                if (value.Name.Length > 1)
                {
                    _speciality = value;
                }
                else
                {
                    _speciality = new Speciality();
                    Console.WriteLine("Speciality did not pass validation!");
                }
            }
        }

        private char _groupIndex;

        [DataMember]
        public char GroupIndex
        {
            get
            {
                return _groupIndex;
            }

            set
            {

                if (char.IsLetter(value))
                {
                    _groupIndex = value;
                }
                else
                {
                    _groupIndex = '-';
                }
            }
        }

        private float _academicPerformance;

        [DataMember]
        public float AcademicPerformance
        {
            get
            {
                return _academicPerformance;
            }

            set
            {

                if (value > -1 && value < 101)
                {
                    _academicPerformance = value;
                }
                else
                {
                    _academicPerformance = 0;
                    Console.WriteLine("Speciality did not pass validation!");
                }
            }
        }

        public Student(string name, string surname, string patronymic, Faculty faculty, Speciality speciality, float academicPerformance, char groupIndex)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Faculty = faculty;
            Speciality = speciality;
            AcademicPerformance = academicPerformance;
            GroupIndex = groupIndex;
            Birthday = DateTime.UtcNow;
            ReceiptDate = DateTime.UtcNow;
        }

        public Student(string name, string surname, string patronymic, Faculty faculty, Speciality speciality, float academicPerformance, char groupIndex, DateTime birthday, DateTime receiptDate)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Birthday = birthday;
            ReceiptDate = receiptDate;
            Faculty = faculty;
            Speciality = speciality;
            AcademicPerformance = academicPerformance;
            GroupIndex = groupIndex;
        }

        public Student()
        {
        }

        public override string ToString()
        {
            return $"Name: {Name}\nSurname: {Surname}\nPatronymic: {Patronymic}\nBirthday: {Birthday.ToShortDateString()}\nReciep date: {ReceiptDate.ToShortDateString()}\nFaculty: {Faculty.Name }\nSpeciality: {Speciality.Name }\nAcademic performance: {AcademicPerformance}\nGroup index: {GroupIndex}\n\n";
        }
    }
}
