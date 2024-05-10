using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            StudentCRUD crud = new StudentCRUD();
            do
            {
                Console.WriteLine("1.Student List");
                Console.WriteLine("2.Get Student By Id");
                Console.WriteLine("3.Add Student");
                Console.WriteLine("4.Update Student");
                Console.WriteLine("5.Delete Student");
                Console.WriteLine("Select Your Option");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        List<Student> list = crud.GetStudent();
                        Console.WriteLine("Id \t Name \t Mobile Number \t College Name");
                        foreach (Student student in list)
                        {
                            Console.WriteLine($"{student.Id}\t{student.Name}\t{student.Mobile_Number}\t{student.College_Name}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter The Student id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Student s = crud.GetStudentById(id);
                        Console.WriteLine("Id \t Name \t Mobile Number \t College Name");
                        Console.WriteLine($"{s.Id}\t{s.Name}\t{s.Mobile_Number}\t{s.College_Name}");
                        break;

                    case 3:
                        Student s1 = new Student();
                        Console.WriteLine("Enter Student id");
                        s1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter The Name");
                        s1.Name = Console.ReadLine();
                        Console.WriteLine("Enter The Mobile Number");
                        s1.Mobile_Number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter The College Name");
                        s1.College_Name = Console.ReadLine();
                        crud.AddStudent(s1);
                        Console.WriteLine("Product Saved");
                        break;
                    case 4:
                        Student s2 = new Student();
                        Console.WriteLine("Enter Student id");
                        s2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter The Name");
                        s2.Name = Console.ReadLine();
                        Console.WriteLine("Enter The Mobile Number");
                        s2.Mobile_Number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter The College Name");
                        s2.College_Name= Console.ReadLine();
                        crud.UpadateStudent(s2);
                        Console.WriteLine("Student Updated");
                        break;
                    case 5:
                        Console.WriteLine("Enter The Student Id");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteStudent(id2);
                        Console.WriteLine($"{id2} Student deleted..");
                        break;
                }
                Console.WriteLine("Press 1 for Continue");
                no = Convert.ToInt32(Console.ReadLine());
            }
            while (no != 0);
        }
    }
}
