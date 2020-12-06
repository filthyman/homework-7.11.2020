using StudentsProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsProject.Views
{
    public partial class GroupsForm : Form
    {
        public event Action NeedShowStudentsForm;
        public event Action<StudentGroup> ChangeData;
        public event Action RefreshData;

        public GroupsForm()
        {
            InitializeComponent();
            groupsView.AutoGenerateColumns = false;

        }
        public void ShowData(List<StudentGroup> data)
        {
            groupsView.DataSource = data;
        }



        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            var row = groupsView.SelectedRows[0];
            var group = row.DataBoundItem as StudentGroup;
            ChangeData(group);
        }

        private void showStudentsButton_Click(object sender, EventArgs e)
        {
            NeedShowStudentsForm();
        }

        private void groupsView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
