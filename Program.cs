using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   public class student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        
       public student(int id,string name,string course)
        { ID= id; Name = name; Course = course; }
        
        public static void DisplayStudentByID(student[] students,int searchID)
        {
            foreach(student student in students)
            {
                if(student.ID==searchID)
                {
                    Console.WriteLine($"ID:{student.ID},Name:{student.Name},Course:{student.Course}");
                    return;
                }
            }
            Console.WriteLine("student not found.");
        }

        public static void Main(string[] args)
        {
            student[] students = new student[]
            {
 new student(1,"sumaiya","phycis"),
                 new student(2,"rabeya","phycis"),
                  new student(3,"khadiza","phycis")
            };
            Console.WriteLine("enter students id:");
            int searchID = int.Parse(Console.ReadLine());
            DisplayStudentByID(students, searchID);
            
        }
    }
}
