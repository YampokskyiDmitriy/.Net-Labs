using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var citFaculty = new Faculty("CIT", "KhPI");
            var csFaculty = new Faculty("CS", "KhPI");
            var compGames = new Speciality("Computer games",123);
            var students = new List<Student>()
            {
                new Student("Dima","Yampolskyi","Andreevich",citFaculty,compGames,50f,'a'),
                new Student("Dima","Menshakov","Olegovich",csFaculty,compGames,100f,'a'),
                new Student("Roma","Momot","Olegovich",citFaculty,compGames,100f,'a'),
                new Student("Vadim","Biliy","Olegovich",csFaculty,compGames,100f,'a'),
                new Student("Serhiy","Naimitenko","Olegovich",citFaculty,compGames,100f,'a'),
            };
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("заполнение коллекций объектов из нескольких источников");
            var studentsQ = Query();
            foreach (var student in studentsQ)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();
        }

        public static List<Student> Query()
        {
            var citFaculty = new Faculty("CIT", "KhPI");
            var csFaculty = new Faculty("CS", "KhPI");
            var compGames = new Speciality("Computer games", 123);
            var names = System.IO.File.ReadAllLines(@"../names.txt");
            var index = System.IO.File.ReadAllLines(@"../index.txt");
            var queryNamesScores =
            from nameLine in names
            let splitName = nameLine.Split(',')
            from indexLine in index
            let splitIndexLine = indexLine.Split(',')
            select new Student()
            {
                Name = splitName[0],
                Surname = splitName[1],
                Patronymic = "Tiltoson",
                AcademicPerformance = 100f,
                GroupIndex = Convert.ToChar(splitIndexLine[0]),
                Faculty = citFaculty,
                Speciality = compGames
            };
            return queryNamesScores.ToList();
        }
    }
}
