using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;

namespace University.Services.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
        Student Get(int index);
        void Add(Student student);
    }
}
