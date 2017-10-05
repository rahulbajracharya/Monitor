using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monitor.Core.Model;
using Monitor.Core.Interface;
namespace Monitor.Core.Business
{
 public class StudentBL: IStudentBL
  {
    public string AddStudent(Student student)
    {
      Console.WriteLine("Saved Successfully");
      return "success";
    }
    public List<Student> GetAllStudent()
    {
      List<Student> students = new List<Student>();
      for(int i  = 0; i<5;i++)
      {
        Student student = new Student();
        student.FatherName = string.Concat("Father_", i);
        student.MotherName = string.Concat("Mother_", i);
        student.StudentAddress = string.Concat("Address_", i);
        student.StudentGrade = string.Concat("Grade_", i);
        student.StudentId = i;
        student.StudentName = string.Concat("Name_", i);
        students.Add(student);
      }
      return students;
    }
    public Student GetStudent(int Id)
    {
      List<Student> students = new List<Student>();
      for (int i = 0; i < 5; i++)
      {
        Student student = new Student();
        student.FatherName = string.Concat("Father_", i);
        student.MotherName = string.Concat("Mother_", i);
        student.StudentAddress = string.Concat("Address_", i);
        student.StudentGrade = string.Concat("Grade_", i);
        student.StudentId = i;
        student.StudentName = string.Concat("Name_", i);
        students.Add(student);
      }
      Student singleitem = students.Where(x => x.StudentId == Id).SingleOrDefault();
      return singleitem;
    }

    public string AddStudents(List<Student> Students)
    {

      return "success";
    }

  }
}
