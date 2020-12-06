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
    public partial class StudentsEditorForm : Form
    {
        private int studentId;
        public Student ChangedData 
        {
            get 
            {
                var group = groupComboBox.SelectedItem as StudentGroup;

                return new Student
                {
                    Id = studentId,
                    Group = group,
                    GroupId = group.Id,
                    Name = nameBox.Text,
                    Surname = surnameBox.Text
                };
            }
        }
        public StudentsEditorForm()
        {
            InitializeComponent();
            acceptButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;
        }
        public DialogResult ShowDialog(Student data, List<StudentGroup> groups) 
        {
            groupComboBox.DataSource = groups;

            if (data == null)
                data = new Student();

            nameBox.Text = data.Name;
            surnameBox.Text = data.Surname;
            groupComboBox.SelectedItem = data.Group;


            return ShowDialog();
        }
    }
}
