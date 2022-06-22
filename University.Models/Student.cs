using System;
using System.ComponentModel;
using System.Linq;

namespace University.Models
{
    public partial class Student
    {
        public Student()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        [Browsable(false)]
        public string FirstName { get; set; }
        [Browsable(false)]
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    public partial class Student
    {
        public string FullName { get => $"{FirstName} {LastName}"; }
    }
}
