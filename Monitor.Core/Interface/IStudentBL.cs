using Monitor.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Monitor.Core.Interface
{
  public interface IStudentBL
  {   
       string AddStudent(Student StudentObj);
       List<Student> GetAllStudent();
       string AddStudents(List<Student> Students);
      //List<Student> GetAllStudent();
       Student GetStudent(int Id);
       //string DeleteStudent(int Id);
       //string UpdateStudent(Student StudentObj);
  }
}
