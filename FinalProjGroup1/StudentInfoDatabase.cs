using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjGroup1.Models;

namespace FinalProjGroup1
{
    public class StudentInfoDatabase
    {

        private StudentInfoContext _context;
        public StudentInfoDatabase(StudentInfoContext context)
        {
            _context = context;
        }
        public void AddStudent(StudentInfo addedStudent)
        {
            _context.Student.Add(addedStudent);
        }

        public IEnumerable<StudentInfo> GetStudentById(int? id)
        {
            if (id == null || id == 0)
            {
                return _context.Student.Take(5);
            }
            else
            {
                return _context.Student.Where(x => x.StudentID == id);
            }
        }

        public IEnumerable<StudentInfo> GetStudentByFullName(string? name)
        {
            if (name == null)
            {
                throw new ArgumentException(
                    $"No name provided, showing top result");
                return _context.Student.Take(1);
            }
            else
            {
                return _context.Student.Where(x => x.FullName == name);
            }
        }

        public IEnumerable<StudentInfo> GetAllStudents()
        {
            return _context.Student.ToList();
        }



        


    }
}
