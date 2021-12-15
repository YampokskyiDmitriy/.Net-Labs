using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student("Vadim","Biliy","Andreevich","CIT","Computer games",50f,'a'),
                new Student("Dima","Menshakov","Olegovich","CIT","Computer games",100f,'a'),
                new Student("Dima","Menshakov","Olegovich","CN","Computer games",100f,'a'),
                new Student("Dima","Menshakov","Olegovich","CN","Computer games",100f,'a'),
            };

            var collection = new Collection();

            foreach (var stud in students)
            {
                collection.Add(stud);
            }

            collection.RemomeCIT();

            foreach (var student in collection)
            {
                Console.WriteLine(student.ToString());
            }

            Console.ReadLine();
        }
    }
}
