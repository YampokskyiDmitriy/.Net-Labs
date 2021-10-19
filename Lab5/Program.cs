using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student("Dima","Yampolskyi","Andreevich","CIT","Computer games",50f,'a'),
                new Student("Dima","Menshakov","Olegovich","CS","Computer games",100f,'a'),
                new Student("Roma","Momot","Olegovich","CIT","Computer games",100f,'a'),
                new Student("Vadim","Biliy","Olegovich","CS","Computer games",100f,'a'),
                new Student("Serhiy","Naimitenko","Olegovich","CIT","Computer games",100f,'a'),
            };

            var collection = new Collection();

            foreach (var stud in students)
            {
                collection.Add(stud);
            }

            foreach (var student in collection)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("Remove all from CIT faculty-------------------------------------------------------------------------------------------------------");
            collection.RemomeCIT();

            foreach (var student in collection)
            {
                Console.WriteLine(student.ToString());
            }

            Console.ReadLine();

        }
    }
}
