using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            CatalogList<Student> studentCatalogList = new CatalogList<Student>();
            Student s1 = new Student(1);
            Student s2 = new Student(2);
            Student s3 = new Student(3);

            //s1.Id = 1;
            studentCatalogList.Add(s1);
            studentCatalogList.Add(s2);
            studentCatalogList.Add(s3);

            Console.WriteLine();

            studentCatalogList.Find(1);
            studentCatalogList.Find(2);
            studentCatalogList.Find(3);

            Console.WriteLine();

            Console.WriteLine("Counting...");
            Console.WriteLine(studentCatalogList.Count().ToString());
            Console.WriteLine();
            Console.WriteLine("Get all...");
            foreach (Student s in studentCatalogList.GetAll())
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("Get all Ended\n");
            Console.WriteLine("ToString...");
            string everything = studentCatalogList.ToString();
            Console.WriteLine(everything);

            CatalogSet<Student, Student> studentCatalogSet = new CatalogSet<Student, Student>();
            //Opgaven siger at Set skal modtage flere parametre, men det giver ingen mening?

            Console.Read();
        }
    }
}
