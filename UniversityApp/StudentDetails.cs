using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Services.Interfaces;

namespace University
{
    public partial class StudentDetails : Form
    {
        private readonly IStudentService _studentService;
        public StudentDetails(IStudentService studentService)
        {
            _studentService = studentService;
            InitializeComponent();
        }

        private void StudenDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        public void AddStudent(int Index)
        {
            var student = _studentService.Get(Index);
            ageLbl.Text = student.Age.ToString();
            firstNameLbl.Text = student.FirstName;
            lastNameLbl.Text = student.LastName;
            idLbl.Text = student.Id.ToString();
        }

       
    }
}
