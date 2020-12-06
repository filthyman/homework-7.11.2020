using StudentsProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsProject.Views
{
    public partial class StudentsForm : Form
    {
        public event Action LoadData;
        public event Action<Student> ChangeData;
        public event Action RefreshData;

        public StudentsForm()
        {
            InitializeComponent();
            studentsView.AutoGenerateColumns = false;

        }

        public void ShowData(List<Student> data)
        {
            studentsView.DataSource = data;
        }  
        private void createButton_Click(object sender, EventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            var row = studentsView.SelectedRows[0];
            var student = row.DataBoundItem as Student;
            ChangeData(student);
        }

        private void studentsView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
