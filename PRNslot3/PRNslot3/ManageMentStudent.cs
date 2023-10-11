using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRNslot3
{
    public partial class ManageMentStudent : Form
    {
        public List<Student> listStudent = new List<Student>();
        public ManageMentStudent()
        {
            InitializeComponent();

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtStudentName.Text;
            var phone = txtStudentPhone.Text;
            Student student = new Student();
            student.Name = name;
            student.Phone = phone;

            listStudent.Add(student);

            BindingSource source = new BindingSource();

            source.DataSource = listStudent;
            dgvViewStudent.DataSource = source;
        }

        private void dgvViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvViewStudent.Rows[e.RowIndex];
            var name = row.Cells[0].Value.ToString();
            var phone = row.Cells[1].Value.ToString();
            txtStudentName.Text = name;
            txtStudentPhone.Text = phone;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
