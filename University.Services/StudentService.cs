using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;
using University.Services.Interfaces;

namespace University.Services.Implementation
{
    public  class StudentService : IStudentService
    {
        private readonly List<Student> _students = new List<Student>();

        public void Add(Student student) => _students.Add(student);

        public Student Get(int index) => _students[index];

        public IEnumerable<Student> GetAll() => _students;
    }
}
