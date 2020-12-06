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
    public partial class GroupEditorForm : Form
    {
        private int groupId;

        public StudentGroup ChangedData
        {
            get
            {
                var group = specialtyComboBox.SelectedItem as Specialty;
                return new StudentGroup
                {
                    Id = groupId,
                    Name = nameTextBox.Text,
                    Specialty = group,
                    YearCreation = int.Parse(yearTextBox.Text),
                    SpecialtyId = group.Id
                };
            }
        }
        public GroupEditorForm()
        {
            InitializeComponent();
            AcceptButton.DialogResult = DialogResult.OK;
            CancelButton.DialogResult = DialogResult.Cancel;
        }
        public DialogResult ShowDialog(StudentGroup data, List<Specialty> specialties) 
        {

            if (data == null)
                data = new StudentGroup();

            nameTextBox.Text = data.Name;
            yearTextBox.Text = $"{data.YearCreation}";

            specialtyComboBox.DataSource = specialties;

            

            return ShowDialog();

        }
    }
}
