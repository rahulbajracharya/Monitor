using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monitor.Data.Model;
using Monitor.Core.Interface;
using Monitor.Core.Model;
using Monitor.Core.Business;
using Monitor.Core.Logger;
using Xunit;


namespace Monitor.Test
{
 public class LogAddTest
  {
   
    [Fact]
    public void AddLogTest()
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
      IStudentBL bl = new StudentBL();
      
      var logAddStudents = new Monitor.Core.Logger.Perf<string, List<Student>>();
      string start = logAddStudents.ExecuteLog(bl.AddStudents, students);
    
     
    }
  }
}
