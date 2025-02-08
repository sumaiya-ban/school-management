using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collegemanegement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student_teacher[] Student_teachers = new Student_teacher[]
           {
 new Student_teacher(1,"sumaiya","phycis"),
                 new Student_teacher(2,"rabeya","phycis"),
                  new Student_teacher(3,"khadiza","phycis")
           };
            Console.WriteLine("enter students id:");
            int searchID = int.Parse(Console.ReadLine());
            DisplayStudentByID(Student_teachers, searchID);
        }
    }
}
