using StudentsProject.Services;
using StudentsProject.Views;
using StudentsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentsProject.Controllers
{
    class GroupsController
    {
        private StorageContext _context;
        private GroupsForm _view;
        public GroupsController(GroupsForm view, StorageContext context)
        {
            _context = context;
            _view = view;
            _view.Load += LoadHandler;
            _view.NeedShowStudentsForm += ShowStudentsWindow;
            _view.ChangeData += ChangeDataHendler;
            _view.RefreshData += RefreshHandler;
        }

        public void ShowStudentsWindow() 
        {
            var window = new StudentsForm();
            var controller = new StudentsController(_context, window);

            _view.Hide();
            window.ShowDialog();
            _view.Show();
        }
        private void LoadHandler(object s, EventArgs e)
        {
            RefreshHandler();
        }

        private void RefreshHandler() 
        {
            try
            {
                List<StudentGroup> groups = _context.Groups.GetAllWithSpecialties();
                _view.ShowData(groups);
            }
            catch
            {

                MessageBox.Show("Произошла ошибка при чтении данных");
            }


        }


        private void ChangeDataHendler(StudentGroup data ) 
        {
            var editor = new GroupEditorForm();
            var specialties = _context.Specialties.GetSpecialties();

            var result = editor.ShowDialog(data, specialties);

            if (result != DialogResult.OK)
                return;

            var changedStudentsData = editor.ChangedData;

            _context.Groups.Update(data.Id, changedStudentsData);

            RefreshHandler();
        }
    }
}
