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
                return _context.Student.Where(x => x.Id == id);
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

        public void AddNewPerson(StudentInfo person)
        {
            try
            {
                _context.Student.Add(person);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public StudentInfo DeletePerson(int? id)
        {
            var deletePersonId = _context.Student.FirstOrDefault(x => x.Id == id);
            if (deletePersonId != null)
            {
                _context.Remove(deletePersonId);
                _context.SaveChanges();
            }
            return deletePersonId;
        }

        public StudentInfo UpdateStudent(StudentInfo student)
        {
            var updatedPerson = _context.Student.FirstOrDefault(x => x.Id == student.Id);
            if (updatedPerson != null)
            {

                updatedPerson.BirthDate = student.BirthDate;
                updatedPerson.FullName = student.FullName;
                updatedPerson.Id = student.Id;
                updatedPerson.Program = student.Program;
                updatedPerson.ProgramYear = student.ProgramYear;
                _context.SaveChanges();


            }
            return updatedPerson;
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

        public void AddNewStudentFood(StudentFood studentFood)
        {
            try
            {
                _context.StudentFood.Add(studentFood);
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

        public StudentFood UpdateStudentFood(StudentFood studentFood)
        {

            var updatedPerson = _context.StudentFood.FirstOrDefault(x => x.Id == studentFood.Id);
            if (updatedPerson != null)
            {

                updatedPerson.FullName = studentFood.FullName;
                updatedPerson.Id = studentFood.Id;
                updatedPerson.Breakfast = studentFood.Breakfast;
                updatedPerson.Lunch = studentFood.Lunch;
                updatedPerson.Dinner = studentFood.Dinner;
                _context.SaveChanges();


            }
            return updatedPerson;
        }

        public void AddStudent(StudentGame addedStudent)
        {
            _context.StudentGame.Add(addedStudent);
        }

        public IEnumerable<StudentGame> GetStudentGameById(int? id)
        {
            if (id == null || id == 0)
            {
                return _context.StudentGame.Take(5);
            }
            else
            {
                return _context.StudentGame.Where(x => x.Id == id);
            }
        }

        public IEnumerable<StudentGame> GetStudentGameByCreatorName(string? name)
        {
            if (name == null)
            {
                throw new ArgumentException(
                    $"No name provided, showing top result");
                return _context.StudentGame.Take(1);
            }
            else
            {
                return _context.StudentGame.Where(x => x.CreatorName == name);
            }
        }

        public IEnumerable<StudentGame> GetAllStudentGames()
        {
            return _context.StudentGame.ToList();
        }

        public void AddNewStudentGame(StudentGame studentGame)
        {
            try
            {
                _context.StudentGame.Add(studentGame);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public StudentGame DeleteStudentGame(int? id)
        {
            var deletePersonId = _context.StudentGame.FirstOrDefault(x => x.Id == id);
            if (deletePersonId != null)
            {
                _context.Remove(deletePersonId);
                _context.SaveChanges();
            }
            return deletePersonId;
        }

        public StudentGame UpdateStudentGame(StudentGame studentGame)
        {

            var updatedPerson = _context.StudentGame.FirstOrDefault(x => x.Id == studentGame.Id);
            if (updatedPerson != null)
            {

                updatedPerson.CreatorName = studentGame.CreatorName;
                updatedPerson.Id = studentGame.Id;
                updatedPerson.Version = studentGame.Version;
                updatedPerson.Title = studentGame.Title;
                updatedPerson.Genre = studentGame.Genre;
                _context.SaveChanges();


            }
            return updatedPerson;
        }






    }
}


