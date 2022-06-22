using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Models;
using University.Services.Interfaces;

namespace University
{

    internal interface IUniversity
    {
    }
    public partial class Univercity : Form,IUniversity
    {
        private readonly IStudentService _studentService;
        private readonly StudentDetails _studentDetails;

        public Univercity(IStudentService studentService, StudentDetails studentDetails)
        {
            _studentService = studentService;
            _studentDetails = studentDetails;
            InitializeComponent();
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.Age = int.Parse(ageBox.Text);
            student.FirstName = firstNameBox.Text;
            student.LastName = lastNameBox.Text;

            _studentService.Add(student);
            studentGv.DataSource = null;
            studentGv.DataSource = _studentService.GetAll();
        }

        private void studentGv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _studentDetails.AddStudent(e.RowIndex);
            _studentDetails.Show();
        }

    }
}
