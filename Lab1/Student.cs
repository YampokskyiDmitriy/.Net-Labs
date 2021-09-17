using System;

namespace Lab1
{
    class Student
    {
        private string _name;
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
                    Console.WriteLine("Name passed validation");
                }
                else
                {
                    _name = "N/D";
                    Console.WriteLine("Name did not pass validation!");
                }
            }
        }
        private string _suname;
        public string Surame
        {
            get
            {
                return _suname;
            }

            set
            {

                if (value.Length > 1)
                {
                    _suname = value;
                    Console.WriteLine("Surname passed validation");
                }
                else
                {
                    _suname = "N/D";
                    Console.WriteLine("Surname did not pass validation!");
                }
            }
        }
        private string _patronymic;
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
                    Console.WriteLine("Patronymic passed validation");
                }
                else
                {
                    _patronymic = "N/D";
                    Console.WriteLine("Patronymic did not pass validation!");
                }
            }
        }
        private DateTime _birthday;
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
                    Console.WriteLine("Birthday passed validation");
                }
                else
                {
                    _birthday = new DateTime();
                    Console.WriteLine("Birthday did not pass validation!");
                }
            }
        }
        private DateTime _receiptDate;
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
                    Console.WriteLine("Receipt date passed validation");
                }
                else
                {
                    _receiptDate = new DateTime();
                    Console.WriteLine("Receipt date did not pass validation!");
                }
            }
        }
        private string _faculty;
        public string Faculty
        {
            get
            {
                return _faculty;
            }

            set
            {

                if (value.Length > 1)
                {
                    _faculty = value;
                    Console.WriteLine("Faculty passed validation");
                }
                else
                {
                    _faculty = "N/D";
                    Console.WriteLine("Faculty did not pass validation!");
                }
            }
        }
        private string _speciality;
        public string Speciality
        {
            get
            {
                return _speciality;
            }

            set
            {

                if (value.Length > 1)
                {
                    _speciality = value;
                    Console.WriteLine("Speciality passed validation");
                }
                else
                {
                    _speciality = "N/D";
                    Console.WriteLine("Speciality did not pass validation!");
                }
            }
        }
        private float _academicPerformance;
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
                    Console.WriteLine("Speciality passed validation");
                }
                else
                {
                    _academicPerformance = 0;
                    Console.WriteLine("Speciality did not pass validation!");
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}\nSurname: {Surame}\nPatronymic: {Patronymic}\nBirthday: {Birthday.ToShortDateString()}\nReciep date: {ReceiptDate.ToShortDateString()}\nFaculty: {Faculty}\nSpeciality: {Speciality}\nAcademic performance: {AcademicPerformance}\n";
        }
    }
}
