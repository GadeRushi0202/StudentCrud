using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCRUD
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Mobile_Number  { get; set; }
        public string College_Name { get; set; }
    }
    public class StudentCRUD
    {
        private List<Student> Studentlist;

        public StudentCRUD()
        {
            Studentlist = new List<Student>()
            {
                new Student() { Id=1, Name="RushiKesh", Mobile_Number=7447307393,College_Name="AVCOE"},
                new Student() { Id=2, Name="Vishal", Mobile_Number=7378764545,College_Name="New Art"},
                new Student() { Id=3, Name="Rajesh", Mobile_Number=9527256519,College_Name="Dr.Vikhe Patil"}

            };
        }
        public List<Student> GetStudent()
        {
            return Studentlist;
        }

        public Student GetStudentById(int Id)
        {
            Student student = new Student();
            foreach (Student pat in Studentlist)
            {
                if (pat.Id == Id)
                {
                    student = pat;
                }
            }
            return student;
        }
        public void AddStudent(Student p)
        {
            Studentlist.Add(p);
        }
        public void UpadateStudent(Student p)
        {
            foreach (Student stu in Studentlist)
            {
                if (stu.Id == p.Id)
                {
                    stu.Name = p.Name;
                    stu.Mobile_Number = p.Mobile_Number;
                    stu.College_Name = p.College_Name;
                    break;
                }
            }
        }
        public void DeleteStudent(int Id)
        {
            foreach (Student p in Studentlist)
            {
                if (p.Id == Id)
                {
                    Studentlist.Remove(p);
                    break;
                }
            }
        }
    }
}
