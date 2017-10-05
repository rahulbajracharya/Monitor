using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monitor.Core.Business;
using Monitor.Core.Model;
using Monitor.Core.Interface;

namespace Monitor.Core
{
  class Program
  {

    static void Main(string[] args)
    {
      Test1();
      Test2();
    }
    public static void Test1()
    {
      Student student = new Student();
      student.StudentId = 1;
      student.StudentName = "ra";
      student.StudentGrade = "aa";
      student.StudentAddress = "jh";
      student.MotherName = "hh";
      student.FatherName = "gg";
      IStudentBL studentbl = new StudentBL(); 
      //var logStudent = new Logger.Logger<string, Student>();
      //string status = logStudent.ExecuteLog(studentbl.AddStudent, student);
      var logGetStudents = new Logger.Perf<List<Student>>();
      List<Student> list = logGetStudents.ExecuteLog(studentbl.GetAllStudent);
      var logGetStudent = new Logger.Perf<Student, int>();
      int Id = 3;
      Student studn = logGetStudent.ExecuteLog(studentbl.GetStudent, Id);
     

      //var logStudentlist = new Logger.Logger<List<Student>,>();
      Console.ReadLine();
    }
    public static void Test2()
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
      IStudentBL bl = new StudentBL();
      var logAddStudents = new Logger.Perf<string, List<Student>>();
      string start = logAddStudents.ExecuteLog(bl.AddStudents, students);
      Console.ReadLine();
    }
  }
}
