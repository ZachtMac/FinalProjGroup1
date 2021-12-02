/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjGroup1.Models;

namespace FinalProjGroup1
{
    public class StudentFoodDatabase
    {

        private StudentInfoContext _context;
        public StudentFoodDatabase(StudentInfoContext context)
        {
            _context = context;
        }
        public void AddStudent(StudentFood addedStudent)
        {
            _context.StudentFood.Add(addedStudent);
        }

        public IEnumerable<StudentFood> GetStudentFoodById(int? id)
        {
            if (id == null || id == 0)
            {
                return _context.StudentFood.Take(5);
            }
            else
            {
                return _context.StudentFood.Where(x => x.Id == id);
            }
        }

        public IEnumerable<StudentFood> GetStudentFoodByFullName(string? name)
        {
            if (name == null)
            {
                throw new ArgumentException(
                    $"No name provided, showing top result");
                return _context.StudentFood.Take(1);
            }
            else
            {
                return _context.StudentFood.Where(x => x.FullName == name);
            }
        }

        public IEnumerable<StudentFood> GetAllStudentFoods()
        {
            return _context.StudentFood.ToList();
        }

        public void AddNewStudentFood(StudentFood person)
        {
            try
            {
                _context.StudentFood.Add(person);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public StudentFood DeleteStudentFood(int? id)
        {
            var deletePersonId = _context.StudentFood.FirstOrDefault(x => x.Id == id);
            if (deletePersonId != null)
            {
                _context.Remove(deletePersonId);
                _context.SaveChanges();
            }
            return deletePersonId;
        }

        public StudentFood UpdateStudentFood(StudentFood student)
        {

            var updatedPerson = _context.StudentFood.FirstOrDefault(x => x.Id == student.Id);
            if (updatedPerson != null)
            {
                
                    updatedPerson.FullName = student.FullName;
                    updatedPerson.Id = student.Id;
                    updatedPerson.Breakfast = student.Breakfast;
                    updatedPerson.Lunch = student.Lunch;
                    updatedPerson.Dinner = student.Dinner;
                _context.SaveChanges();
                
                
            }
            return updatedPerson;
        }



        


    }
}
*/