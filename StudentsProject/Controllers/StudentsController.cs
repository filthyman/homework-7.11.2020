using StudentsProject.Models;
using StudentsProject.Services;
using StudentsProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsProject.Controllers
{
    class StudentsController
    {
        private StorageContext _context;
        private StudentsForm _view; 
        public StudentsController(StorageContext context, StudentsForm view)
        {
            _context = context;
            _view = view;
            _view.LoadData += LoadDataHandler;
            _view.ChangeData += ChangeDataHandler;
            _view.RefreshData += RefreshDataHendler;
        }
        
        private void LoadDataHandler()
        {
            RefreshDataHendler();
        }

        public void RefreshDataHendler()
        {
            try
            {
                var students = _context.Students.GetAllWichGroups();
                _view.ShowData(students);
            }
            catch 
            {

                MessageBox.Show("Произошла ошибка при чтении данных");
            }

        }
        private void ChangeDataHandler(Student data)
        {
            var editor = new StudentsEditorForm();
            var students = _context.Groups.GetAllWithSpecialties();

            var result = editor.ShowDialog(data, students);

            if (result != DialogResult.OK)
                return;

            var changedStudentsData = editor.ChangedData;

            _context.Students.Update(data.Id, changedStudentsData);

            RefreshDataHendler();
        }
    }
}
